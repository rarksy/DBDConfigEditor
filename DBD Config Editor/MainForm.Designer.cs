﻿namespace DBD_Config_Editor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TitleBarPanel = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ConfigPanel = new System.Windows.Forms.Panel();
            this.ExportConfigButton = new System.Windows.Forms.Button();
            this.InjectConfigButton = new System.Windows.Forms.Button();
            this.CopyConfigButton = new System.Windows.Forms.Button();
            this.OpenConfigLocationButton = new System.Windows.Forms.Button();
            this.ChangeConfigPathButton = new System.Windows.Forms.Button();
            this.GamePathTextBox = new System.Windows.Forms.TextBox();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.UnlockFPSButton = new System.Windows.Forms.Button();
            this.VSyncButton = new System.Windows.Forms.Button();
            this.MotionBlurButton = new System.Windows.Forms.Button();
            this.BloomButton = new System.Windows.Forms.Button();
            this.LensFlareButton = new System.Windows.Forms.Button();
            this.AmbientOcclusionButton = new System.Windows.Forms.Button();
            this.MiscPanel = new System.Windows.Forms.Panel();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.AmbientOcclusionInfoLabel = new System.Windows.Forms.Label();
            this.LensFlareInfoLabel = new System.Windows.Forms.Label();
            this.BloomInfoLabel = new System.Windows.Forms.Label();
            this.MotionBlurInfoLabel = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.VSyncInfolabel = new System.Windows.Forms.Label();
            this.FPSInfoLabel = new System.Windows.Forms.Label();
            this.TimerInit = new System.Windows.Forms.Timer(this.components);
            this.MainPanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.AnimationCMB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ShadingCMB = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.FoliageCMB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EffectsCMB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TextureCMB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PostProcessingCMB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ShadowCMB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AntiAliasingCMB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ViewDistanceCMB = new System.Windows.Forms.ComboBox();
            this.TitleBarPanel.SuspendLayout();
            this.ConfigPanel.SuspendLayout();
            this.MiscPanel.SuspendLayout();
            this.InfoPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleBarPanel
            // 
            this.TitleBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TitleBarPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitleBarPanel.Controls.Add(this.MinimizeButton);
            this.TitleBarPanel.Controls.Add(this.ExitButton);
            this.TitleBarPanel.Controls.Add(this.TitleLabel);
            this.TitleBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBarPanel.Location = new System.Drawing.Point(0, 0);
            this.TitleBarPanel.Name = "TitleBarPanel";
            this.TitleBarPanel.Size = new System.Drawing.Size(1000, 32);
            this.TitleBarPanel.TabIndex = 0;
            this.TitleBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBarPanel_MouseDown);
            this.TitleBarPanel.MouseLeave += new System.EventHandler(this.TitleBarPanel_MouseLeave);
            this.TitleBarPanel.MouseHover += new System.EventHandler(this.TitleBarPanel_MouseHover);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold);
            this.MinimizeButton.ForeColor = System.Drawing.Color.Silver;
            this.MinimizeButton.Location = new System.Drawing.Point(954, 3);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(20, 23);
            this.MinimizeButton.TabIndex = 1;
            this.MinimizeButton.Text = "_";
            this.MinimizeButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MinimizeButton_MouseDown);
            this.MinimizeButton.MouseLeave += new System.EventHandler(this.MinimizeButton_MouseLeave);
            this.MinimizeButton.MouseHover += new System.EventHandler(this.MinimizeButton_MouseHover);
            // 
            // ExitButton
            // 
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.Silver;
            this.ExitButton.Location = new System.Drawing.Point(978, 7);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(18, 18);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "X";
            this.ExitButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ExitButton_MouseDown);
            this.ExitButton.MouseLeave += new System.EventHandler(this.ExitButton_MouseLeave);
            this.ExitButton.MouseHover += new System.EventHandler(this.ExitButton_MouseHover);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Fira Sans Medium", 12F);
            this.TitleLabel.ForeColor = System.Drawing.Color.Silver;
            this.TitleLabel.Location = new System.Drawing.Point(6, 5);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(317, 19);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Dead By Daylight Config Editor (By Rarksy)";
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleLabel_MouseDown);
            this.TitleLabel.MouseHover += new System.EventHandler(this.TitleLabel_MouseHover);
            // 
            // ConfigPanel
            // 
            this.ConfigPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ConfigPanel.Controls.Add(this.ExportConfigButton);
            this.ConfigPanel.Controls.Add(this.InjectConfigButton);
            this.ConfigPanel.Controls.Add(this.CopyConfigButton);
            this.ConfigPanel.Controls.Add(this.OpenConfigLocationButton);
            this.ConfigPanel.Controls.Add(this.ChangeConfigPathButton);
            this.ConfigPanel.Controls.Add(this.GamePathTextBox);
            this.ConfigPanel.Location = new System.Drawing.Point(718, 460);
            this.ConfigPanel.Name = "ConfigPanel";
            this.ConfigPanel.Size = new System.Drawing.Size(273, 154);
            this.ConfigPanel.TabIndex = 1;
            // 
            // ExportConfigButton
            // 
            this.ExportConfigButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ExportConfigButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ExportConfigButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ExportConfigButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ExportConfigButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportConfigButton.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportConfigButton.ForeColor = System.Drawing.Color.Silver;
            this.ExportConfigButton.Location = new System.Drawing.Point(3, 4);
            this.ExportConfigButton.Name = "ExportConfigButton";
            this.ExportConfigButton.Size = new System.Drawing.Size(267, 33);
            this.ExportConfigButton.TabIndex = 5;
            this.ExportConfigButton.Text = "Export Config";
            this.ToolTip.SetToolTip(this.ExportConfigButton, "Copy your config to clipboard to share with others");
            this.ExportConfigButton.UseVisualStyleBackColor = false;
            this.ExportConfigButton.Click += new System.EventHandler(this.ExportConfigButton_Click);
            // 
            // InjectConfigButton
            // 
            this.InjectConfigButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.InjectConfigButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.InjectConfigButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.InjectConfigButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.InjectConfigButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InjectConfigButton.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.InjectConfigButton.ForeColor = System.Drawing.Color.Silver;
            this.InjectConfigButton.Location = new System.Drawing.Point(140, 43);
            this.InjectConfigButton.Name = "InjectConfigButton";
            this.InjectConfigButton.Size = new System.Drawing.Size(131, 33);
            this.InjectConfigButton.TabIndex = 4;
            this.InjectConfigButton.Text = "Inject Config";
            this.ToolTip.SetToolTip(this.InjectConfigButton, "Inject Config Settings From Clipboard");
            this.InjectConfigButton.UseVisualStyleBackColor = false;
            this.InjectConfigButton.Click += new System.EventHandler(this.InjectConfigButton_Click);
            // 
            // CopyConfigButton
            // 
            this.CopyConfigButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CopyConfigButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CopyConfigButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CopyConfigButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CopyConfigButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopyConfigButton.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.CopyConfigButton.ForeColor = System.Drawing.Color.Silver;
            this.CopyConfigButton.Location = new System.Drawing.Point(3, 43);
            this.CopyConfigButton.Name = "CopyConfigButton";
            this.CopyConfigButton.Size = new System.Drawing.Size(131, 33);
            this.CopyConfigButton.TabIndex = 3;
            this.CopyConfigButton.Text = "Copy Config";
            this.ToolTip.SetToolTip(this.CopyConfigButton, "Copy your config to clipboard to share with others");
            this.CopyConfigButton.UseVisualStyleBackColor = false;
            this.CopyConfigButton.Click += new System.EventHandler(this.CopyConfigButton_Click);
            // 
            // OpenConfigLocationButton
            // 
            this.OpenConfigLocationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.OpenConfigLocationButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.OpenConfigLocationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.OpenConfigLocationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.OpenConfigLocationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenConfigLocationButton.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.OpenConfigLocationButton.ForeColor = System.Drawing.Color.Silver;
            this.OpenConfigLocationButton.Location = new System.Drawing.Point(3, 82);
            this.OpenConfigLocationButton.Name = "OpenConfigLocationButton";
            this.OpenConfigLocationButton.Size = new System.Drawing.Size(267, 33);
            this.OpenConfigLocationButton.TabIndex = 2;
            this.OpenConfigLocationButton.Text = "Open Config Location";
            this.OpenConfigLocationButton.UseVisualStyleBackColor = false;
            this.OpenConfigLocationButton.Click += new System.EventHandler(this.OpenConfigLocationButton_Click);
            // 
            // ChangeConfigPathButton
            // 
            this.ChangeConfigPathButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ChangeConfigPathButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ChangeConfigPathButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ChangeConfigPathButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ChangeConfigPathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeConfigPathButton.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.ChangeConfigPathButton.ForeColor = System.Drawing.Color.Silver;
            this.ChangeConfigPathButton.Location = new System.Drawing.Point(140, 121);
            this.ChangeConfigPathButton.Name = "ChangeConfigPathButton";
            this.ChangeConfigPathButton.Size = new System.Drawing.Size(130, 27);
            this.ChangeConfigPathButton.TabIndex = 1;
            this.ChangeConfigPathButton.Text = "Change Config Path";
            this.ChangeConfigPathButton.UseVisualStyleBackColor = false;
            this.ChangeConfigPathButton.Click += new System.EventHandler(this.ChangeConfigPathButton_Click);
            // 
            // GamePathTextBox
            // 
            this.GamePathTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.GamePathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GamePathTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.GamePathTextBox.Enabled = false;
            this.GamePathTextBox.ForeColor = System.Drawing.Color.Silver;
            this.GamePathTextBox.Location = new System.Drawing.Point(3, 121);
            this.GamePathTextBox.Multiline = true;
            this.GamePathTextBox.Name = "GamePathTextBox";
            this.GamePathTextBox.ReadOnly = true;
            this.GamePathTextBox.Size = new System.Drawing.Size(131, 27);
            this.GamePathTextBox.TabIndex = 0;
            // 
            // UnlockFPSButton
            // 
            this.UnlockFPSButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UnlockFPSButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UnlockFPSButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UnlockFPSButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UnlockFPSButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnlockFPSButton.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.UnlockFPSButton.ForeColor = System.Drawing.Color.Silver;
            this.UnlockFPSButton.Location = new System.Drawing.Point(3, 3);
            this.UnlockFPSButton.Name = "UnlockFPSButton";
            this.UnlockFPSButton.Size = new System.Drawing.Size(267, 33);
            this.UnlockFPSButton.TabIndex = 6;
            this.UnlockFPSButton.Text = "Unlock FPS";
            this.ToolTip.SetToolTip(this.UnlockFPSButton, "Copy your config to clipboard to share with others");
            this.UnlockFPSButton.UseVisualStyleBackColor = false;
            this.UnlockFPSButton.Click += new System.EventHandler(this.UnlockFPSButton_Click);
            // 
            // VSyncButton
            // 
            this.VSyncButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.VSyncButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.VSyncButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.VSyncButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.VSyncButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VSyncButton.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.VSyncButton.ForeColor = System.Drawing.Color.Silver;
            this.VSyncButton.Location = new System.Drawing.Point(3, 42);
            this.VSyncButton.Name = "VSyncButton";
            this.VSyncButton.Size = new System.Drawing.Size(267, 33);
            this.VSyncButton.TabIndex = 7;
            this.VSyncButton.Text = "Disable VSync";
            this.ToolTip.SetToolTip(this.VSyncButton, "Copy your config to clipboard to share with others");
            this.VSyncButton.UseVisualStyleBackColor = false;
            this.VSyncButton.Click += new System.EventHandler(this.VSyncButton_Click);
            // 
            // MotionBlurButton
            // 
            this.MotionBlurButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MotionBlurButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MotionBlurButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MotionBlurButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MotionBlurButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MotionBlurButton.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.MotionBlurButton.ForeColor = System.Drawing.Color.Silver;
            this.MotionBlurButton.Location = new System.Drawing.Point(3, 81);
            this.MotionBlurButton.Name = "MotionBlurButton";
            this.MotionBlurButton.Size = new System.Drawing.Size(267, 33);
            this.MotionBlurButton.TabIndex = 8;
            this.MotionBlurButton.Text = "Disable Motion Blur";
            this.ToolTip.SetToolTip(this.MotionBlurButton, "Copy your config to clipboard to share with others");
            this.MotionBlurButton.UseVisualStyleBackColor = false;
            this.MotionBlurButton.Click += new System.EventHandler(this.MotionBlurButton_Click);
            // 
            // BloomButton
            // 
            this.BloomButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BloomButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BloomButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BloomButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BloomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BloomButton.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.BloomButton.ForeColor = System.Drawing.Color.Silver;
            this.BloomButton.Location = new System.Drawing.Point(3, 120);
            this.BloomButton.Name = "BloomButton";
            this.BloomButton.Size = new System.Drawing.Size(267, 33);
            this.BloomButton.TabIndex = 9;
            this.BloomButton.Text = "Disable Bloom";
            this.ToolTip.SetToolTip(this.BloomButton, "Copy your config to clipboard to share with others");
            this.BloomButton.UseVisualStyleBackColor = false;
            this.BloomButton.Click += new System.EventHandler(this.BloomButton_Click);
            // 
            // LensFlareButton
            // 
            this.LensFlareButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LensFlareButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LensFlareButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LensFlareButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LensFlareButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LensFlareButton.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.LensFlareButton.ForeColor = System.Drawing.Color.Silver;
            this.LensFlareButton.Location = new System.Drawing.Point(3, 159);
            this.LensFlareButton.Name = "LensFlareButton";
            this.LensFlareButton.Size = new System.Drawing.Size(267, 33);
            this.LensFlareButton.TabIndex = 10;
            this.LensFlareButton.Text = "Disable Lens Flare";
            this.ToolTip.SetToolTip(this.LensFlareButton, "Copy your config to clipboard to share with others");
            this.LensFlareButton.UseVisualStyleBackColor = false;
            this.LensFlareButton.Click += new System.EventHandler(this.LensFlareButton_Click);
            // 
            // AmbientOcclusionButton
            // 
            this.AmbientOcclusionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AmbientOcclusionButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AmbientOcclusionButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AmbientOcclusionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AmbientOcclusionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AmbientOcclusionButton.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.AmbientOcclusionButton.ForeColor = System.Drawing.Color.Silver;
            this.AmbientOcclusionButton.Location = new System.Drawing.Point(3, 198);
            this.AmbientOcclusionButton.Name = "AmbientOcclusionButton";
            this.AmbientOcclusionButton.Size = new System.Drawing.Size(267, 33);
            this.AmbientOcclusionButton.TabIndex = 11;
            this.AmbientOcclusionButton.Text = "Disable Ambient Occlusion";
            this.ToolTip.SetToolTip(this.AmbientOcclusionButton, "Copy your config to clipboard to share with others");
            this.AmbientOcclusionButton.UseVisualStyleBackColor = false;
            this.AmbientOcclusionButton.Click += new System.EventHandler(this.AmbientOcclusionButton_Click);
            // 
            // MiscPanel
            // 
            this.MiscPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MiscPanel.Controls.Add(this.AmbientOcclusionButton);
            this.MiscPanel.Controls.Add(this.LensFlareButton);
            this.MiscPanel.Controls.Add(this.BloomButton);
            this.MiscPanel.Controls.Add(this.MotionBlurButton);
            this.MiscPanel.Controls.Add(this.VSyncButton);
            this.MiscPanel.Controls.Add(this.UnlockFPSButton);
            this.MiscPanel.Location = new System.Drawing.Point(718, 38);
            this.MiscPanel.Name = "MiscPanel";
            this.MiscPanel.Size = new System.Drawing.Size(273, 416);
            this.MiscPanel.TabIndex = 2;
            // 
            // InfoPanel
            // 
            this.InfoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.InfoPanel.Controls.Add(this.AmbientOcclusionInfoLabel);
            this.InfoPanel.Controls.Add(this.LensFlareInfoLabel);
            this.InfoPanel.Controls.Add(this.BloomInfoLabel);
            this.InfoPanel.Controls.Add(this.MotionBlurInfoLabel);
            this.InfoPanel.Controls.Add(this.UserLabel);
            this.InfoPanel.Controls.Add(this.VSyncInfolabel);
            this.InfoPanel.Controls.Add(this.FPSInfoLabel);
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoPanel.Location = new System.Drawing.Point(0, 32);
            this.InfoPanel.MaximumSize = new System.Drawing.Size(1000, 25);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(1000, 25);
            this.InfoPanel.TabIndex = 3;
            // 
            // AmbientOcclusionInfoLabel
            // 
            this.AmbientOcclusionInfoLabel.AutoSize = true;
            this.AmbientOcclusionInfoLabel.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.AmbientOcclusionInfoLabel.ForeColor = System.Drawing.Color.Silver;
            this.AmbientOcclusionInfoLabel.Location = new System.Drawing.Point(776, 6);
            this.AmbientOcclusionInfoLabel.Name = "AmbientOcclusionInfoLabel";
            this.AmbientOcclusionInfoLabel.Size = new System.Drawing.Size(161, 15);
            this.AmbientOcclusionInfoLabel.TabIndex = 9;
            this.AmbientOcclusionInfoLabel.Text = "Ambient Occlusion Disabled";
            // 
            // LensFlareInfoLabel
            // 
            this.LensFlareInfoLabel.AutoSize = true;
            this.LensFlareInfoLabel.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.LensFlareInfoLabel.ForeColor = System.Drawing.Color.Silver;
            this.LensFlareInfoLabel.Location = new System.Drawing.Point(640, 6);
            this.LensFlareInfoLabel.Name = "LensFlareInfoLabel";
            this.LensFlareInfoLabel.Size = new System.Drawing.Size(112, 15);
            this.LensFlareInfoLabel.TabIndex = 8;
            this.LensFlareInfoLabel.Text = "Lens Flare Disabled";
            // 
            // BloomInfoLabel
            // 
            this.BloomInfoLabel.AutoSize = true;
            this.BloomInfoLabel.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.BloomInfoLabel.ForeColor = System.Drawing.Color.Silver;
            this.BloomInfoLabel.Location = new System.Drawing.Point(525, 6);
            this.BloomInfoLabel.Name = "BloomInfoLabel";
            this.BloomInfoLabel.Size = new System.Drawing.Size(93, 15);
            this.BloomInfoLabel.TabIndex = 7;
            this.BloomInfoLabel.Text = "Bloom Disabled";
            // 
            // MotionBlurInfoLabel
            // 
            this.MotionBlurInfoLabel.AutoSize = true;
            this.MotionBlurInfoLabel.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.MotionBlurInfoLabel.ForeColor = System.Drawing.Color.Silver;
            this.MotionBlurInfoLabel.Location = new System.Drawing.Point(381, 6);
            this.MotionBlurInfoLabel.Name = "MotionBlurInfoLabel";
            this.MotionBlurInfoLabel.Size = new System.Drawing.Size(123, 15);
            this.MotionBlurInfoLabel.TabIndex = 6;
            this.MotionBlurInfoLabel.Text = "Motion Blur Disabled";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.UserLabel.ForeColor = System.Drawing.Color.Silver;
            this.UserLabel.Location = new System.Drawing.Point(8, 6);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(66, 15);
            this.UserLabel.TabIndex = 5;
            this.UserLabel.Text = "Welcome, ";
            // 
            // VSyncInfolabel
            // 
            this.VSyncInfolabel.AutoSize = true;
            this.VSyncInfolabel.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.VSyncInfolabel.ForeColor = System.Drawing.Color.Silver;
            this.VSyncInfolabel.Location = new System.Drawing.Point(270, 6);
            this.VSyncInfolabel.Name = "VSyncInfolabel";
            this.VSyncInfolabel.Size = new System.Drawing.Size(91, 15);
            this.VSyncInfolabel.TabIndex = 4;
            this.VSyncInfolabel.Text = "VSync Disabled";
            // 
            // FPSInfoLabel
            // 
            this.FPSInfoLabel.AutoSize = true;
            this.FPSInfoLabel.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.FPSInfoLabel.ForeColor = System.Drawing.Color.Silver;
            this.FPSInfoLabel.Location = new System.Drawing.Point(171, 6);
            this.FPSInfoLabel.Name = "FPSInfoLabel";
            this.FPSInfoLabel.Size = new System.Drawing.Size(83, 15);
            this.FPSInfoLabel.TabIndex = 2;
            this.FPSInfoLabel.Text = "FPS Unlocked";
            // 
            // TimerInit
            // 
            this.TimerInit.Tick += new System.EventHandler(this.TimerInit_Tick);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MainPanel.Controls.Add(this.label9);
            this.MainPanel.Controls.Add(this.AnimationCMB);
            this.MainPanel.Controls.Add(this.label7);
            this.MainPanel.Controls.Add(this.ShadingCMB);
            this.MainPanel.Controls.Add(this.label8);
            this.MainPanel.Controls.Add(this.FoliageCMB);
            this.MainPanel.Controls.Add(this.label5);
            this.MainPanel.Controls.Add(this.EffectsCMB);
            this.MainPanel.Controls.Add(this.label6);
            this.MainPanel.Controls.Add(this.TextureCMB);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.PostProcessingCMB);
            this.MainPanel.Controls.Add(this.label4);
            this.MainPanel.Controls.Add(this.ShadowCMB);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.AntiAliasingCMB);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.ViewDistanceCMB);
            this.MainPanel.Location = new System.Drawing.Point(9, 38);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(375, 310);
            this.MainPanel.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(26, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 15);
            this.label9.TabIndex = 25;
            this.label9.Text = "Animation Quality";
            // 
            // AnimationCMB
            // 
            this.AnimationCMB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AnimationCMB.Cursor = System.Windows.Forms.Cursors.Default;
            this.AnimationCMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AnimationCMB.ForeColor = System.Drawing.Color.Silver;
            this.AnimationCMB.FormattingEnabled = true;
            this.AnimationCMB.Items.AddRange(new object[] {
            "Very Low",
            "Low",
            "Medium",
            "High",
            "Ultra"});
            this.AnimationCMB.Location = new System.Drawing.Point(14, 272);
            this.AnimationCMB.Name = "AnimationCMB";
            this.AnimationCMB.Size = new System.Drawing.Size(121, 21);
            this.AnimationCMB.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(221, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Shading Quality";
            // 
            // ShadingCMB
            // 
            this.ShadingCMB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ShadingCMB.Cursor = System.Windows.Forms.Cursors.Default;
            this.ShadingCMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShadingCMB.ForeColor = System.Drawing.Color.Silver;
            this.ShadingCMB.FormattingEnabled = true;
            this.ShadingCMB.Items.AddRange(new object[] {
            "Very Low",
            "Low",
            "Medium",
            "High",
            "Ultra"});
            this.ShadingCMB.Location = new System.Drawing.Point(203, 210);
            this.ShadingCMB.Name = "ShadingCMB";
            this.ShadingCMB.Size = new System.Drawing.Size(121, 21);
            this.ShadingCMB.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(29, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Foliage Quality";
            // 
            // FoliageCMB
            // 
            this.FoliageCMB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FoliageCMB.Cursor = System.Windows.Forms.Cursors.Default;
            this.FoliageCMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FoliageCMB.ForeColor = System.Drawing.Color.Silver;
            this.FoliageCMB.FormattingEnabled = true;
            this.FoliageCMB.Items.AddRange(new object[] {
            "Very Low",
            "Low",
            "Medium",
            "High",
            "Ultra"});
            this.FoliageCMB.Location = new System.Drawing.Point(14, 210);
            this.FoliageCMB.Name = "FoliageCMB";
            this.FoliageCMB.Size = new System.Drawing.Size(121, 21);
            this.FoliageCMB.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(221, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Effects Quality";
            // 
            // EffectsCMB
            // 
            this.EffectsCMB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EffectsCMB.Cursor = System.Windows.Forms.Cursors.Default;
            this.EffectsCMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EffectsCMB.ForeColor = System.Drawing.Color.Silver;
            this.EffectsCMB.FormattingEnabled = true;
            this.EffectsCMB.Items.AddRange(new object[] {
            "Very Low",
            "Low",
            "Medium",
            "High",
            "Ultra"});
            this.EffectsCMB.Location = new System.Drawing.Point(203, 147);
            this.EffectsCMB.Name = "EffectsCMB";
            this.EffectsCMB.Size = new System.Drawing.Size(121, 21);
            this.EffectsCMB.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(29, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Texture Quality";
            // 
            // TextureCMB
            // 
            this.TextureCMB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextureCMB.Cursor = System.Windows.Forms.Cursors.Default;
            this.TextureCMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TextureCMB.ForeColor = System.Drawing.Color.Silver;
            this.TextureCMB.FormattingEnabled = true;
            this.TextureCMB.Items.AddRange(new object[] {
            "Very Low",
            "Low",
            "Medium",
            "High",
            "Ultra"});
            this.TextureCMB.Location = new System.Drawing.Point(14, 146);
            this.TextureCMB.Name = "TextureCMB";
            this.TextureCMB.Size = new System.Drawing.Size(121, 21);
            this.TextureCMB.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(200, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Post Processing Quality";
            // 
            // PostProcessingCMB
            // 
            this.PostProcessingCMB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PostProcessingCMB.Cursor = System.Windows.Forms.Cursors.Default;
            this.PostProcessingCMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PostProcessingCMB.ForeColor = System.Drawing.Color.Silver;
            this.PostProcessingCMB.FormattingEnabled = true;
            this.PostProcessingCMB.Items.AddRange(new object[] {
            "Very Low",
            "Low",
            "Medium",
            "High",
            "Ultra"});
            this.PostProcessingCMB.Location = new System.Drawing.Point(203, 87);
            this.PostProcessingCMB.Name = "PostProcessingCMB";
            this.PostProcessingCMB.Size = new System.Drawing.Size(121, 21);
            this.PostProcessingCMB.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(29, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Shadow Quality";
            // 
            // ShadowCMB
            // 
            this.ShadowCMB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ShadowCMB.Cursor = System.Windows.Forms.Cursors.Default;
            this.ShadowCMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShadowCMB.ForeColor = System.Drawing.Color.Silver;
            this.ShadowCMB.FormattingEnabled = true;
            this.ShadowCMB.Items.AddRange(new object[] {
            "Very Low",
            "Low",
            "Medium",
            "High",
            "Ultra"});
            this.ShadowCMB.Location = new System.Drawing.Point(14, 87);
            this.ShadowCMB.Name = "ShadowCMB";
            this.ShadowCMB.Size = new System.Drawing.Size(121, 21);
            this.ShadowCMB.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(203, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Anti-Aliasing Quality";
            // 
            // AntiAliasingCMB
            // 
            this.AntiAliasingCMB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AntiAliasingCMB.Cursor = System.Windows.Forms.Cursors.Default;
            this.AntiAliasingCMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AntiAliasingCMB.ForeColor = System.Drawing.Color.Silver;
            this.AntiAliasingCMB.FormattingEnabled = true;
            this.AntiAliasingCMB.Items.AddRange(new object[] {
            "Off",
            "Very Low",
            "Low",
            "Medium",
            "High",
            "Ultra"});
            this.AntiAliasingCMB.Location = new System.Drawing.Point(203, 28);
            this.AntiAliasingCMB.Name = "AntiAliasingCMB";
            this.AntiAliasingCMB.Size = new System.Drawing.Size(121, 21);
            this.AntiAliasingCMB.TabIndex = 10;
            this.AntiAliasingCMB.SelectedIndexChanged += new System.EventHandler(this.AntiAliasingCMB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "View Distance Quality";
            // 
            // ViewDistanceCMB
            // 
            this.ViewDistanceCMB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ViewDistanceCMB.Cursor = System.Windows.Forms.Cursors.Default;
            this.ViewDistanceCMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ViewDistanceCMB.ForeColor = System.Drawing.Color.Silver;
            this.ViewDistanceCMB.FormattingEnabled = true;
            this.ViewDistanceCMB.Items.AddRange(new object[] {
            "Very Low",
            "Low",
            "Medium",
            "High",
            "Ultra"});
            this.ViewDistanceCMB.Location = new System.Drawing.Point(14, 28);
            this.ViewDistanceCMB.Name = "ViewDistanceCMB";
            this.ViewDistanceCMB.Size = new System.Drawing.Size(121, 21);
            this.ViewDistanceCMB.TabIndex = 0;
            this.ViewDistanceCMB.SelectedIndexChanged += new System.EventHandler(this.ViewDistanceCMB_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1000, 620);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.MiscPanel);
            this.Controls.Add(this.ConfigPanel);
            this.Controls.Add(this.TitleBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Opacity = 0.97D;
            this.Text = "MainForm";
            this.Activated += new System.EventHandler(this.OnFormFocus);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TitleBarPanel.ResumeLayout(false);
            this.TitleBarPanel.PerformLayout();
            this.ConfigPanel.ResumeLayout(false);
            this.ConfigPanel.PerformLayout();
            this.MiscPanel.ResumeLayout(false);
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitleBarPanel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label ExitButton;
        private System.Windows.Forms.Label MinimizeButton;
        private System.Windows.Forms.Panel ConfigPanel;
        private System.Windows.Forms.TextBox GamePathTextBox;
        private System.Windows.Forms.Button ChangeConfigPathButton;
        private System.Windows.Forms.Button OpenConfigLocationButton;
        private System.Windows.Forms.Button InjectConfigButton;
        private System.Windows.Forms.Button CopyConfigButton;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.Button ExportConfigButton;
        private System.Windows.Forms.Panel MiscPanel;
        private System.Windows.Forms.Button UnlockFPSButton;
        private System.Windows.Forms.Button VSyncButton;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Label FPSInfoLabel;
        private System.Windows.Forms.Label VSyncInfolabel;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Timer TimerInit;
        private System.Windows.Forms.Button MotionBlurButton;
        private System.Windows.Forms.Label MotionBlurInfoLabel;
        private System.Windows.Forms.Label BloomInfoLabel;
        private System.Windows.Forms.Button BloomButton;
        private System.Windows.Forms.Button LensFlareButton;
        private System.Windows.Forms.Label LensFlareInfoLabel;
        private System.Windows.Forms.Button AmbientOcclusionButton;
        private System.Windows.Forms.Label AmbientOcclusionInfoLabel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.ComboBox ViewDistanceCMB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ShadingCMB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox FoliageCMB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox EffectsCMB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox TextureCMB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox PostProcessingCMB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ShadowCMB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox AntiAliasingCMB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox AnimationCMB;
    }
}

