﻿using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace DBD_Config_Editor
{
    public partial class MainForm : Form
    {
        static readonly decimal ver = 2.1m;
        static readonly string url = "https://raw.githubusercontent.com/rarksy/DBDConfigEditor/master/ver.ce2";
        public MainForm()
        {
            InitializeComponent();
        }

        //Move Application On Title Bar
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void TitleBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void TitleLabel_MouseDown(object sender, MouseEventArgs e)
        {
            TitleBarPanel_MouseDown(sender, e);
        }

        private void ExitButton_MouseDown(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void ExitButton_MouseHover(object sender, EventArgs e)
        {
            ExitButton.ForeColor = Color.Red;
        }

        private void ExitButton_MouseLeave(object sender, EventArgs e)
        {
            ExitButton.ForeColor = Color.Silver;
        }

        private void MinimizeButton_MouseHover(object sender, EventArgs e)
        {
            MinimizeButton.ForeColor = Color.Red;
        }

        private void MinimizeButton_MouseLeave(object sender, EventArgs e)
        {
            MinimizeButton.ForeColor = Color.Silver;
        }

        private void MinimizeButton_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = this.Width; i >= 0; i--)
            {
                this.Width -= 10;
                this.Height -= 10;
            }
            this.WindowState = FormWindowState.Minimized;
        }

        private void TitleBarPanel_MouseHover(object sender, EventArgs e)
        {
            for (int i = 0; i <= 25; i++)
            {
                InfoPanel.Height += 1;
                if (MiscPanel.Location.Y <= 63)
                {
                    MiscPanel.Location = new Point(MiscPanel.Location.X, MiscPanel.Location.Y + 1);
                    MainPanel.Location = new Point(MainPanel.Location.X, MainPanel.Location.Y + 1);
                    KeybindPanel.Location = new Point(KeybindPanel.Location.X, KeybindPanel.Location.Y + 1);
                    MiscPanel.Height -= 1;
                }
            }
        }

        private void TitleBarPanel_MouseLeave(object sender, EventArgs e)
        {
            for (int i = 25; i >= 0; i--)
            {
                InfoPanel.Height -= 1;
                if (MiscPanel.Location.Y >= 38)
                {
                    MiscPanel.Location = new Point(MiscPanel.Location.X, MiscPanel.Location.Y - 1);
                    MainPanel.Location = new Point(MainPanel.Location.X, MainPanel.Location.Y - 1);
                    KeybindPanel.Location = new Point(KeybindPanel.Location.X, KeybindPanel.Location.Y - 1);
                    MiscPanel.Height += 1;
                }
            }
        }


        private void OnFormFocus(object sender, EventArgs e)
        {
            this.Width = 1000;
            this.Height = 620;
        }

        public static string sPathToUse = String.Empty;
        static helper _helper = new helper();
        

        private void SelectConfigLocation()
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.ValidateNames = false;
                openFileDialog.CheckFileExists = false;
                openFileDialog.CheckPathExists = false;
                openFileDialog.FileName = "Folder Selection. (Do Not Change This)";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    filePath = filePath.Remove(filePath.Length - 38);
                    if (!Directory.Exists($@"C:\Users\{Environment.UserName}\Appdata\Local\DBDCE"))
                        Directory.CreateDirectory($@"C:\Users\{Environment.UserName}\Appdata\Local\DBDCE");
                    File.WriteAllText($@"C:\Users\{Environment.UserName}\Appdata\Local\DBDCE\custompath.DBDCE", filePath);
                    sPathToUse = filePath;
                    GamePathTextBox.Text = sPathToUse;
                }
            }
        }



        private void MainForm_Load(object sender, EventArgs e)
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.CachePolicy = new System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.NoCacheNoStore);
                string s = webClient.DownloadString(url);
                if (ver.ToString().Contains(s))
                {
                    UpdateLabel.Show();
                }
                else
                {
                    UpdateLabel.Hide();
                }
                Console.WriteLine(ver.ToString());
                Console.WriteLine(s);
            }
            if (Directory.Exists($@"C:\Users\{Environment.UserName}\Appdata\Local\DBDCE"))
            {
                if (File.Exists($@"C:\Users\{Environment.UserName}\Appdata\Local\DBDCE\custompath.DBDCE"))
                {
                    string cPath = File.ReadAllText($@"C:\Users\{Environment.UserName}\Appdata\Local\DBDCE\custompath.DBDCE");
                    if (cPath != String.Empty)
                    {
                        sPathToUse = cPath;
                        if (!Directory.Exists(sPathToUse))
                        {
                            Directory.Delete($@"C:\Users\{Environment.UserName}\Appdata\Local\DBDCE", true);

                            Application.Restart();
                            Application.Exit();
                        }
                        _helper.DoReadOnly(false);
                        GamePathTextBox.Text = sPathToUse;
                        UserLabel.Text += Environment.UserName;
                        InfoPanel.Height = 0;
                        TimerInit.Start();
                        return;
                    }
                }
               
            }
            if (!Directory.Exists($@"C:\Users\{Environment.UserName}\Appdata\Local\DeadByDaylight\Saved\Config\WindowsNoEditor"))
            {
                DialogResult NoDefaultDir = MessageBox.Show("Default Config Location Not Found, Please Select It Now");
                if (Directory.Exists($@"C:\Users\{Environment.UserName}\Appdata\Local\DBDCE"))
                {
                    string cPath = File.ReadAllText($@"C:\Users\{Environment.UserName}\Appdata\Local\DBDCE\custompath.DBDCE");
                    if (cPath == String.Empty)
                        SelectConfigLocation();
                    else sPathToUse = cPath;
                }
            }
            else sPathToUse = $@"C:\Users\{Environment.UserName}\Appdata\Local\DeadByDaylight\Saved\Config\WindowsNoEditor";
            if (!Directory.Exists(sPathToUse))
            {
                Directory.Delete($@"C:\Users\{Environment.UserName}\Appdata\Local\DBDCE", true);
                Application.Restart();
                Application.Exit();
            }
            _helper.DoReadOnly(false);
            GamePathTextBox.Text = sPathToUse;
            UserLabel.Text += Environment.UserName;
            InfoPanel.Height = 0;
            TimerInit.Start();
        }


        private void TimerInit_Tick(object sender, EventArgs e)
        {
            var userini = new IniFile(sPathToUse + @"\Engine.ini");

            if (userini.KeyExists("MaxSmoothedFrameRate", "/script/engine.engine"))
            {
                UnlockFPSButton.Text = "Lock FPS";
                FPSInfoLabel.ForeColor = Color.Green;
                FPSInfoLabel.Text = "FPS Unlocked";
            }
            else
            {
                FPSInfoLabel.ForeColor = Color.Red;
                FPSInfoLabel.Text = "FPS locked";
            }

            if (userini.KeyExists("r.DefaultFeature.MotionBlur", "/Script/Engine.GarbageCollectionSettings"))
            {
                if (userini.ReadString("/Script/Engine.GarbageCollectionSettings", "r.DefaultFeature.MotionBlur") == "False")
                {
                    MotionBlurButton.Text = "Enable Motion Blur";
                    MotionBlurInfoLabel.ForeColor = Color.Green;
                    MotionBlurInfoLabel.Text = "Motion Blur Disabled";
                }
                else
                {
                    MotionBlurButton.Text = "Disable Motion Blur";
                    MotionBlurInfoLabel.ForeColor = Color.Red;
                    MotionBlurInfoLabel.Text = "Motion Blur Enabled";
                }
            }
            else
            {
                MotionBlurButton.Text = "Disable Motion Blur";
                MotionBlurInfoLabel.ForeColor = Color.Red;
                MotionBlurInfoLabel.Text = "Motion Blur Enabled";
            }

            if (userini.KeyExists("r.DefaultFeature.Bloom", "/Script/Engine.GarbageCollectionSettings"))
            {
                if (userini.ReadString("/Script/Engine.GarbageCollectionSettings", "r.DefaultFeature.Bloom") == "False")
                {
                    BloomButton.Text = "Enable Bloom";
                    BloomInfoLabel.ForeColor = Color.Green;
                    BloomInfoLabel.Text = "Bloom Disabled";
                }
                else
                {
                    BloomButton.Text = "Disable Bloom";
                    BloomInfoLabel.ForeColor = Color.Red;
                    BloomInfoLabel.Text = "Bloom Enabled";
                }
            }
            else
            {
                BloomButton.Text = "Disable Bloom";
                BloomInfoLabel.ForeColor = Color.Red;
                BloomInfoLabel.Text = "Bloom Enabled";
            }

            if (userini.KeyExists("r.DefaultFeature.LensFlare", "/Script/Engine.GarbageCollectionSettings"))
            {
                if (userini.ReadString("/Script/Engine.GarbageCollectionSettings", "r.DefaultFeature.LensFlare") == "False")
                {
                    LensFlareButton.Text = "Enable Lens Flare";
                    LensFlareInfoLabel.ForeColor = Color.Green;
                    LensFlareInfoLabel.Text = "Lens Flare Disabled";
                }
                else
                {
                    LensFlareButton.Text = "Disable Lens Flare";
                    LensFlareInfoLabel.ForeColor = Color.Red;
                    LensFlareInfoLabel.Text = "Lens Flare Enabled";
                }
            }
            else
            {
                LensFlareButton.Text = "Disable Lens Flare";
                LensFlareInfoLabel.ForeColor = Color.Red;
                LensFlareInfoLabel.Text = "Lens Flare Enabled";
            }

            if (userini.KeyExists("r.DefaultFeature.AmbientOcclusion", "/Script/Engine.GarbageCollectionSettings"))
            {
                if (userini.ReadString("/Script/Engine.GarbageCollectionSettings", "r.DefaultFeature.AmbientOcclusion") == "False")
                {
                    AmbientOcclusionButton.Text = "Enable Ambient Occlusion";
                    AmbientOcclusionInfoLabel.ForeColor = Color.Green;
                    AmbientOcclusionInfoLabel.Text = "Ambient Occlusion Disabled";
                }
                else
                {
                    AmbientOcclusionButton.Text = "Disable Ambient Occlusion";
                    AmbientOcclusionInfoLabel.ForeColor = Color.Red;
                    AmbientOcclusionInfoLabel.Text = "Ambient Occlusion Enabled";
                }
            }
            else
            {
                AmbientOcclusionButton.Text = "Disable Ambient Occlusion";
                AmbientOcclusionInfoLabel.ForeColor = Color.Red;
                AmbientOcclusionInfoLabel.Text = "Ambient Occlusion Enabled";
            }

            userini = new IniFile(sPathToUse + @"\GameUserSettings.ini");

            ResQualityLabel.Text = $"Resolution Quality ({userini.ReadInt("ScalabilityGroups", "sg.ResolutionQuality") / 1000000})";
            ResScaleTrackbar.Value = userini.ReadInt("ScalabilityGroups", "sg.ResolutionQuality") / 1000000;
            if (userini.ReadString("/Script/DeadByDaylight.DBDGameUserSettings", "bUseVSync") == "False")
            {
                VSyncButton.Text = "Enable VSync";
                VSyncInfolabel.ForeColor = Color.Green;
                VSyncInfolabel.Text = "VSync Disabled";
            }
            else
            {
                VSyncInfolabel.ForeColor = Color.Red;
                VSyncInfolabel.Text = "VSync Enabled";
            }

            ViewDistanceCMB.SelectedIndex =  userini.ReadInt("ScalabilityGroups", "sg.ViewDistanceQuality");
            var eini = new IniFile(sPathToUse + @"\Engine.ini");
            if (eini.KeyExists("r.DefaultFeature.AntiAliasing", "/Script/Engine.GarbageCollectionSettings"))
                AntiAliasingCMB.SelectedIndex = 0;
            else
                AntiAliasingCMB.SelectedIndex =  userini.ReadInt("ScalabilityGroups", "sg.AntiAliasingQuality");
            ShadowCMB.SelectedIndex = userini.ReadInt("ScalabilityGroups", "sg.ShadowQuality");
            PostProcessingCMB.SelectedIndex = userini.ReadInt("ScalabilityGroups", "sg.PostProcessQuality");
            TextureCMB.SelectedIndex = userini.ReadInt("ScalabilityGroups", "sg.TextureQuality");
            EffectsCMB.SelectedIndex = userini.ReadInt("ScalabilityGroups", "sg.EffectsQuality");
            FoliageCMB.SelectedIndex = userini.ReadInt("ScalabilityGroups", "sg.FoliageQuality");
            ShadingCMB.SelectedIndex = userini.ReadInt("ScalabilityGroups", "sg.ShadingQuality");
            AnimationCMB.SelectedIndex = userini.ReadInt("ScalabilityGroups", "sg.AnimationQuality");


            TimerInit.Stop();
        }

        private void ChangeConfigPathButton_Click(object sender, EventArgs e)
        {
            SelectConfigLocation();
        }

        private void OpenConfigLocationButton_Click(object sender, EventArgs e)
        {
            Process.Start("file://" + sPathToUse);
        }


        private void CopyConfigButton_Click(object sender, EventArgs e)
        {
            byte[] PTBGUS = Encoding.UTF8.GetBytes(File.ReadAllText(sPathToUse+@"\GameUserSettings.ini"));
            byte[] PTBENGINE = Encoding.UTF8.GetBytes(File.ReadAllText(sPathToUse + @"\Engine.ini"));
            string GUSEncoded = Convert.ToBase64String(PTBGUS);
            string EngineEncoded = Convert.ToBase64String(PTBENGINE);

            string JoinedEncode = GUSEncoded + "#" + EngineEncoded;

            Clipboard.SetText(JoinedEncode);
            MessageBox.Show("Copied To Clipboard");
        }

        private void InjectConfigButton_Click(object sender, EventArgs e)
        {
            string clipTXT = Clipboard.GetText(TextDataFormat.Text);

            if (!clipTXT.Contains('#') || !_helper.IsValidBase64(clipTXT))
            {
                MessageBox.Show("Invalid Config");
                return;
            }

            string[] split = clipTXT.Split('#');

            File.WriteAllText(sPathToUse+@"\GameUserSettings.ini", _helper.Base64Decode(split[0]));
            File.WriteAllText(sPathToUse+@"\Engine.ini", _helper.Base64Decode(split[1]));

            MessageBox.Show("Successfully Injected Config, Restarting...");
            Application.Restart();
            Application.Exit();
        }

        private void ExportConfigButton_Click(object sender, EventArgs e)
        {
            string GUS = File.ReadAllText(sPathToUse + @"\GameUserSettings.ini");
            string E = File.ReadAllText(sPathToUse + @"\Engine.ini");
            Directory.CreateDirectory(sPathToUse + @"\exported");
            File.WriteAllText(sPathToUse+@"\exported\GameUserSettings.ini", GUS);
            File.WriteAllText(sPathToUse+@"\exported\Engine.ini", E);
            MessageBox.Show($@"Exported To {sPathToUse}\exported");
        }

        private void UnlockFPSButton_Click(object sender, EventArgs e)
        {

            var ini = new IniFile(sPathToUse + @"\Engine.ini");
            if (File.ReadAllText(sPathToUse + @"\Engine.ini").Contains("[/script/engine.engine]"))
            {
                ini.DeleteSection("/script/engine.engine");
                FPSInfoLabel.ForeColor = Color.Red;
                UnlockFPSButton.Text = "Unlock FPS";
                FPSInfoLabel.Text = "FPS Locked";
            }
            else
            {
                ini.Write("bSmoothFrameRate", "False", "/script/engine.engine");
                ini.Write("MinSmoothedFrameRate", "False", "/script/engine.engine");
                ini.Write("MaxSmoothedFrameRate", "120", "/script/engine.engine");
                FPSInfoLabel.ForeColor = Color.Green;
                UnlockFPSButton.Text = "Lock FPS";
                FPSInfoLabel.Text = "FPS Locked";
            }
        }

        private void TitleLabel_MouseHover(object sender, EventArgs e)
        {
            TitleBarPanel_MouseHover(sender, e);
        }

        private void VSyncButton_Click(object sender, EventArgs e)
        {
            var ini = new IniFile(sPathToUse + @"\GameUserSettings.ini");
            if (ini.ReadString("/Script/DeadByDaylight.DBDGameUserSettings", "bUseVSync") == "True")
            {
                ini.Write("bUseVSync", "False", "/Script/DeadByDaylight.DBDGameUserSettings");
                VSyncButton.Text = "Enable VSync";
                VSyncInfolabel.ForeColor = Color.Green;
                VSyncInfolabel.Text = "VSync Disabled";
            }
            else
            {
                ini.Write("bUseVSync", "True", "/Script/DeadByDaylight.DBDGameUserSettings");
                VSyncInfolabel.ForeColor = Color.Red;
                VSyncInfolabel.Text = "VSync Enabled";
                VSyncButton.Text = "Disable VSync";
            }
        }

        private void MotionBlurButton_Click(object sender, EventArgs e)
        {
            var ini = new IniFile(sPathToUse + @"\Engine.ini");
            if (ini.KeyExists("r.DefaultFeature.MotionBlur", "/Script/Engine.GarbageCollectionSettings"))
            {
                ini.DeleteKey("r.DefaultFeature.MotionBlur", "/Script/Engine.GarbageCollectionSettings");
                MotionBlurButton.Text = "Disable Motion Blur";
                MotionBlurInfoLabel.ForeColor = Color.Red;
                MotionBlurInfoLabel.Text = "Motion Blur Enabled";
            }
            else
            {
                ini.Write("r.DefaultFeature.MotionBlur", "False", "/Script/Engine.GarbageCollectionSettings");
                MotionBlurButton.Text = "Enable Motion Blur";
                MotionBlurInfoLabel.ForeColor = Color.Green;
                MotionBlurInfoLabel.Text = "Motion Blur Disabled";
            }
        }

        private void BloomButton_Click(object sender, EventArgs e)
        {
            var ini = new IniFile(sPathToUse + @"\Engine.ini");
            if (ini.KeyExists("r.DefaultFeature.Bloom", "/Script/Engine.GarbageCollectionSettings"))
            {
                ini.DeleteKey("r.DefaultFeature.Bloom", "/Script/Engine.GarbageCollectionSettings");
                BloomButton.Text = "Disable Bloom";
                BloomInfoLabel.ForeColor = Color.Red;
                BloomInfoLabel.Text = "Bloom Enabled";
            }
            else
            {
                ini.Write("r.DefaultFeature.Bloom", "False", "/Script/Engine.GarbageCollectionSettings");
                BloomButton.Text = "Enable Bloom";
                BloomInfoLabel.ForeColor = Color.Green;
                BloomInfoLabel.Text = "Bloom Disabled";
            }
        }

        private void LensFlareButton_Click(object sender, EventArgs e)
        {
            var ini = new IniFile(sPathToUse + @"\Engine.ini");
            if (ini.KeyExists("r.DefaultFeature.LensFlare", "/Script/Engine.GarbageCollectionSettings"))
            {
                ini.DeleteKey("r.DefaultFeature.LensFlare", "/Script/Engine.GarbageCollectionSettings");
                LensFlareButton.Text = "Disable Lens Flare";
                LensFlareInfoLabel.ForeColor = Color.Red;
                LensFlareInfoLabel.Text = "Lens Flare Enabled";
            }
            else
            {
                ini.Write("r.DefaultFeature.LensFlare", "False", "/Script/Engine.GarbageCollectionSettings");
                LensFlareButton.Text = "Enable Lens Flare";
                LensFlareInfoLabel.ForeColor = Color.Green;
                LensFlareInfoLabel.Text = "Lens Flare Disabled";
            }
        }

        private void AmbientOcclusionButton_Click(object sender, EventArgs e)
        {
            var ini = new IniFile(sPathToUse + @"\Engine.ini");
            if (ini.KeyExists("r.DefaultFeature.AmbientOcclusion", "/Script/Engine.GarbageCollectionSettings"))
            {
                ini.DeleteKey("r.DefaultFeature.AmbientOcclusion", "/Script/Engine.GarbageCollectionSettings");
                AmbientOcclusionButton.Text = "Disable Ambient Occlusion";
                AmbientOcclusionInfoLabel.ForeColor = Color.Red;
                AmbientOcclusionInfoLabel.Text = "Ambient Occlusion Enabled";
            }
            else
            {
                ini.Write("r.DefaultFeature.AmbientOcclusion", "False", "/Script/Engine.GarbageCollectionSettings");
                AmbientOcclusionButton.Text = "Enable Ambient Occlusion";
                AmbientOcclusionInfoLabel.ForeColor = Color.Green;
                LensFlareInfoLabel.Text = "Ambient Occlusion Disabled";
            }
        }

        private void ViewDistanceCMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ini = new IniFile(sPathToUse + @"\GameUserSettings.ini");
            ini.Write("sg.ViewDistanceQuality", ViewDistanceCMB.SelectedIndex.ToString(), "ScalabilityGroups");
        }

        private void AntiAliasingCMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ini = new IniFile(sPathToUse + @"\Engine.ini");
            if (AntiAliasingCMB.SelectedIndex == 0)
            {
                ini.Write("r.DefaultFeature.AntiAliasing", "0", "/Script/Engine.GarbageCollectionSettings");
            }
            else
            {
                if (ini.KeyExists("r.DefaultFeature.AntiAliasing", "/Script/Engine.GarbageCollectionSettings"))
                    ini.DeleteKey("r.DefaultFeature.AntiAliasing", "/Script/Engine.GarbageCollectionSettings");
                ini = new IniFile(sPathToUse + @"\GameUserSettings.ini");
                ini.Write("sg.AntiAliasingQuality", AntiAliasingCMB.SelectedIndex.ToString(), "ScalabilityGroups");
            }
        }

        private void ResScaleTrackbar_Scroll(object sender, EventArgs e)
        {
            ResQualityLabel.Text = $"Resolution Quality ({ResScaleTrackbar.Value})";
            var ini = new IniFile(sPathToUse + @"\GameUserSettings.ini");
            ini.Write("sg.ResolutionQuality", ResScaleTrackbar.Value.ToString() + ".000000", "ScalabilityGroups");
        }

        private void ShadowCMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ini = new IniFile(sPathToUse + @"\GameUserSettings.ini");
            ini.Write("sg.ShadowQuality", ShadowCMB.SelectedIndex.ToString(), "ScalabilityGroups");
        }

        private void PostProcessingCMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ini = new IniFile(sPathToUse + @"\GameUserSettings.ini");
            ini.Write("sg.PostProcessQuality", PostProcessingCMB.SelectedIndex.ToString(), "ScalabilityGroups");
        }

        private void TextureCMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ini = new IniFile(sPathToUse + @"\GameUserSettings.ini");
            ini.Write("sg.TextureQuality", TextureCMB.SelectedIndex.ToString(), "ScalabilityGroups");
        }

        private void EffectsCMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ini = new IniFile(sPathToUse + @"\GameUserSettings.ini");
            ini.Write("sg.EffectsQuality", EffectsCMB.SelectedIndex.ToString(), "ScalabilityGroups");
        }

        private void FoliageCMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ini = new IniFile(sPathToUse + @"\GameUserSettings.ini");
            ini.Write("sg.FoliageQuality", FoliageCMB.SelectedIndex.ToString(), "ScalabilityGroups");
        }

        private void ShadingCMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ini = new IniFile(sPathToUse + @"\GameUserSettings.ini");
            ini.Write("sg.ShadingQuality", ShadingCMB.SelectedIndex.ToString(), "ScalabilityGroups");
        }

        private void AnimationCMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ini = new IniFile(sPathToUse + @"\GameUserSettings.ini");
            ini.Write("sg.AnimationQuality", AnimationCMB.SelectedIndex.ToString(), "ScalabilityGroups");
        }

        private void UpdateLabel_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/rarksy/DBDConfigEditor/releases");
        }
    }
}