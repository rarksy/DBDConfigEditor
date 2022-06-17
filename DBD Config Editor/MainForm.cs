using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBD_Config_Editor
{
    public partial class MainForm : Form
    {
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
                openFileDialog.FileName = "Folder Selection.";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    filePath = filePath.Remove(filePath.Length - 17);
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
                if (userini.ReadValue("/Script/Engine.GarbageCollectionSettings", "r.DefaultFeature.MotionBlur") == "False")
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
                if (userini.ReadValue("/Script/Engine.GarbageCollectionSettings", "r.DefaultFeature.Bloom") == "False")
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
                if (userini.ReadValue("/Script/Engine.GarbageCollectionSettings", "r.DefaultFeature.LensFlare") == "False")
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
                if (userini.ReadValue("/Script/Engine.GarbageCollectionSettings", "r.DefaultFeature.AmbientOcclusion") == "False")
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
            if (userini.ReadValue("/Script/DeadByDaylight.DBDGameUserSettings", "bUseVSync") == "False")
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

            ViewDistanceCMB.SelectedIndex = Int32.Parse(string.Join(String.Empty, userini.ReadValue("ScalabilityGroups", "sg.ViewDistanceQuality").ToCharArray().Where(Char.IsDigit)));
            var eini = new IniFile(sPathToUse + @"\Engine.ini");
            if (eini.KeyExists("r.DefaultFeature.AntiAliasing", "/Script/Engine.GarbageCollectionSettings"))
                AntiAliasingCMB.SelectedIndex = 0;
            else
                AntiAliasingCMB.SelectedIndex = Int32.Parse(string.Join(String.Empty, userini.ReadValue("ScalabilityGroups", "sg.AntiAliasingQuality").ToCharArray().Where(Char.IsDigit)));
            ShadowCMB.SelectedIndex = Int32.Parse(string.Join(String.Empty, userini.ReadValue("ScalabilityGroups", "sg.ShadowQuality").ToCharArray().Where(Char.IsDigit)));
            PostProcessingCMB.SelectedIndex = Int32.Parse(string.Join(String.Empty, userini.ReadValue("ScalabilityGroups", "sg.PostProcessQuality").ToCharArray().Where(Char.IsDigit)));
            TextureCMB.SelectedIndex = Int32.Parse(string.Join(String.Empty, userini.ReadValue("ScalabilityGroups", "sg.TextureQuality").ToCharArray().Where(Char.IsDigit)));
            EffectsCMB.SelectedIndex = Int32.Parse(string.Join(String.Empty, userini.ReadValue("ScalabilityGroups", "sg.EffectsQuality").ToCharArray().Where(Char.IsDigit)));
            FoliageCMB.SelectedIndex = Int32.Parse(string.Join(String.Empty, userini.ReadValue("ScalabilityGroups", "sg.FoliageQuality").ToCharArray().Where(Char.IsDigit)));
            ShadingCMB.SelectedIndex = Int32.Parse(string.Join(String.Empty, userini.ReadValue("ScalabilityGroups", "sg.ShadingQuality").ToCharArray().Where(Char.IsDigit)));
            AnimationCMB.SelectedIndex = Int32.Parse(string.Join(String.Empty, userini.ReadValue("ScalabilityGroups", "sg.AnimationQuality").ToCharArray().Where(Char.IsDigit)));


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
            Process.Start("file://" + sPathToUse+@"\exported");
        }

        private void UnlockFPSButton_Click(object sender, EventArgs e)
        {

            var ini = new IniFile(sPathToUse + @"\Engine.ini");
            if (File.ReadAllText(sPathToUse + @"\Engine.ini").Contains("[/script/engine.engine]"))
            {
                ini.DeleteSection("/script/engine.engine");
                FPSInfoLabel.ForeColor = Color.Red;
                UnlockFPSButton.Text = "Unlock FPS";
                FPSInfoLabel.Text = "FPS Unlocked";
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
            if (ini.ReadValue("/Script/DeadByDaylight.DBDGameUserSettings", "bUseVSync") == "True")
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
    }
}