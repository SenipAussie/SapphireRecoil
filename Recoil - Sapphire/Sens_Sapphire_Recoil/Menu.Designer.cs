namespace Sens_Sapphire_Recoil
{
    partial class SapphireRecoil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SapphireRecoil));
            this.lblInfo = new System.Windows.Forms.Label();
            this.pnlStart = new System.Windows.Forms.Panel();
            this.btnEnable = new System.Windows.Forms.Button();
            this.pnlGameSettings = new System.Windows.Forms.Panel();
            this.grpboxInGame = new System.Windows.Forms.GroupBox();
            this.lblGameSensValue = new System.Windows.Forms.Label();
            this.lblGameFOVValue = new System.Windows.Forms.Label();
            this.trkbarFOV = new System.Windows.Forms.TrackBar();
            this.trkbarSens = new System.Windows.Forms.TrackBar();
            this.lblGameFOV = new System.Windows.Forms.Label();
            this.lblGameSens = new System.Windows.Forms.Label();
            this.pnlColor = new System.Windows.Forms.Panel();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlWeaponSettings = new System.Windows.Forms.Panel();
            this.grpboxWeapons = new System.Windows.Forms.GroupBox();
            this.lblRandomnessValue = new System.Windows.Forms.Label();
            this.lblRandomness = new System.Windows.Forms.Label();
            this.cboWeapons = new System.Windows.Forms.ComboBox();
            this.trkbarRandomness = new System.Windows.Forms.TrackBar();
            this.lblBarrelAttachment = new System.Windows.Forms.Label();
            this.cboBarrels = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProcessInfo = new System.Windows.Forms.Label();
            this.cboScopes = new System.Windows.Forms.ComboBox();
            this.pnlStart.SuspendLayout();
            this.pnlGameSettings.SuspendLayout();
            this.grpboxInGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkbarFOV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkbarSens)).BeginInit();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.pnlWeaponSettings.SuspendLayout();
            this.grpboxWeapons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkbarRandomness)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(278, 349);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(259, 20);
            this.lblInfo.TabIndex = 88;
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlStart
            // 
            this.pnlStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlStart.Controls.Add(this.btnEnable);
            this.pnlStart.Location = new System.Drawing.Point(278, 278);
            this.pnlStart.Name = "pnlStart";
            this.pnlStart.Size = new System.Drawing.Size(261, 65);
            this.pnlStart.TabIndex = 85;
            // 
            // btnEnable
            // 
            this.btnEnable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnEnable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEnable.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEnable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnEnable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnEnable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnable.ForeColor = System.Drawing.Color.White;
            this.btnEnable.Location = new System.Drawing.Point(10, 9);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(242, 45);
            this.btnEnable.TabIndex = 7;
            this.btnEnable.Text = "Start";
            this.btnEnable.UseVisualStyleBackColor = false;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // pnlGameSettings
            // 
            this.pnlGameSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlGameSettings.Controls.Add(this.grpboxInGame);
            this.pnlGameSettings.Location = new System.Drawing.Point(278, 63);
            this.pnlGameSettings.Name = "pnlGameSettings";
            this.pnlGameSettings.Size = new System.Drawing.Size(261, 209);
            this.pnlGameSettings.TabIndex = 84;
            // 
            // grpboxInGame
            // 
            this.grpboxInGame.Controls.Add(this.lblGameSensValue);
            this.grpboxInGame.Controls.Add(this.lblGameFOVValue);
            this.grpboxInGame.Controls.Add(this.trkbarFOV);
            this.grpboxInGame.Controls.Add(this.trkbarSens);
            this.grpboxInGame.Controls.Add(this.lblGameFOV);
            this.grpboxInGame.Controls.Add(this.lblGameSens);
            this.grpboxInGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grpboxInGame.ForeColor = System.Drawing.Color.White;
            this.grpboxInGame.Location = new System.Drawing.Point(6, 3);
            this.grpboxInGame.Name = "grpboxInGame";
            this.grpboxInGame.Size = new System.Drawing.Size(249, 194);
            this.grpboxInGame.TabIndex = 80;
            this.grpboxInGame.TabStop = false;
            this.grpboxInGame.Text = "In-Game Settings";
            // 
            // lblGameSensValue
            // 
            this.lblGameSensValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblGameSensValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameSensValue.ForeColor = System.Drawing.Color.White;
            this.lblGameSensValue.Location = new System.Drawing.Point(123, 28);
            this.lblGameSensValue.Name = "lblGameSensValue";
            this.lblGameSensValue.Size = new System.Drawing.Size(104, 20);
            this.lblGameSensValue.TabIndex = 80;
            this.lblGameSensValue.Text = "1.0";
            this.lblGameSensValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGameFOVValue
            // 
            this.lblGameFOVValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblGameFOVValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameFOVValue.ForeColor = System.Drawing.Color.White;
            this.lblGameFOVValue.Location = new System.Drawing.Point(123, 109);
            this.lblGameFOVValue.Name = "lblGameFOVValue";
            this.lblGameFOVValue.Size = new System.Drawing.Size(104, 20);
            this.lblGameFOVValue.TabIndex = 79;
            this.lblGameFOVValue.Text = "90";
            this.lblGameFOVValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trkbarFOV
            // 
            this.trkbarFOV.Location = new System.Drawing.Point(11, 138);
            this.trkbarFOV.Maximum = 90;
            this.trkbarFOV.Minimum = 70;
            this.trkbarFOV.Name = "trkbarFOV";
            this.trkbarFOV.Size = new System.Drawing.Size(223, 45);
            this.trkbarFOV.TabIndex = 6;
            this.trkbarFOV.Value = 90;
            this.trkbarFOV.Scroll += new System.EventHandler(this.trkbarFOV_Scroll);
            // 
            // trkbarSens
            // 
            this.trkbarSens.Location = new System.Drawing.Point(11, 59);
            this.trkbarSens.Maximum = 20;
            this.trkbarSens.Name = "trkbarSens";
            this.trkbarSens.Size = new System.Drawing.Size(223, 45);
            this.trkbarSens.TabIndex = 5;
            this.trkbarSens.Value = 10;
            this.trkbarSens.Scroll += new System.EventHandler(this.trkbarSens_Scroll);
            // 
            // lblGameFOV
            // 
            this.lblGameFOV.AutoSize = true;
            this.lblGameFOV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameFOV.ForeColor = System.Drawing.Color.White;
            this.lblGameFOV.Location = new System.Drawing.Point(14, 107);
            this.lblGameFOV.Name = "lblGameFOV";
            this.lblGameFOV.Size = new System.Drawing.Size(104, 20);
            this.lblGameFOV.TabIndex = 77;
            this.lblGameFOV.Text = "Ingame FOV:";
            // 
            // lblGameSens
            // 
            this.lblGameSens.AutoSize = true;
            this.lblGameSens.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameSens.ForeColor = System.Drawing.Color.White;
            this.lblGameSens.Location = new System.Drawing.Point(14, 25);
            this.lblGameSens.Name = "lblGameSens";
            this.lblGameSens.Size = new System.Drawing.Size(108, 20);
            this.lblGameSens.TabIndex = 75;
            this.lblGameSens.Text = "Ingame Sens:";
            // 
            // pnlColor
            // 
            this.pnlColor.BackColor = System.Drawing.Color.White;
            this.pnlColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlColor.Location = new System.Drawing.Point(0, 44);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(547, 5);
            this.pnlColor.TabIndex = 86;
            this.pnlColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlColor_MouseDown);
            this.pnlColor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlColor_MouseMove);
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlTitle.Controls.Add(this.picIcon);
            this.pnlTitle.Controls.Add(this.btnMin);
            this.pnlTitle.Controls.Add(this.btnExit);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(547, 44);
            this.pnlTitle.TabIndex = 87;
            this.pnlTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseDown);
            this.pnlTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseMove);
            // 
            // picIcon
            // 
            this.picIcon.Image = ((System.Drawing.Image)(resources.GetObject("picIcon.Image")));
            this.picIcon.Location = new System.Drawing.Point(6, 5);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(35, 33);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 10;
            this.picIcon.TabStop = false;
            this.picIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picIcon_MouseDown);
            this.picIcon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picIcon_MouseMove);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.White;
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.Location = new System.Drawing.Point(456, 3);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(39, 35);
            this.btnMin.TabIndex = 8;
            this.btnMin.Text = "-";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(501, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(39, 35);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(48, -1);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(371, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Sapphire Recoil";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseDown);
            this.lblTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseMove);
            // 
            // pnlWeaponSettings
            // 
            this.pnlWeaponSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlWeaponSettings.Controls.Add(this.grpboxWeapons);
            this.pnlWeaponSettings.Location = new System.Drawing.Point(11, 63);
            this.pnlWeaponSettings.Name = "pnlWeaponSettings";
            this.pnlWeaponSettings.Size = new System.Drawing.Size(261, 306);
            this.pnlWeaponSettings.TabIndex = 83;
            // 
            // grpboxWeapons
            // 
            this.grpboxWeapons.Controls.Add(this.lblRandomnessValue);
            this.grpboxWeapons.Controls.Add(this.lblRandomness);
            this.grpboxWeapons.Controls.Add(this.cboWeapons);
            this.grpboxWeapons.Controls.Add(this.trkbarRandomness);
            this.grpboxWeapons.Controls.Add(this.lblBarrelAttachment);
            this.grpboxWeapons.Controls.Add(this.cboBarrels);
            this.grpboxWeapons.Controls.Add(this.label1);
            this.grpboxWeapons.Controls.Add(this.lblProcessInfo);
            this.grpboxWeapons.Controls.Add(this.cboScopes);
            this.grpboxWeapons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grpboxWeapons.ForeColor = System.Drawing.Color.White;
            this.grpboxWeapons.Location = new System.Drawing.Point(3, 3);
            this.grpboxWeapons.Name = "grpboxWeapons";
            this.grpboxWeapons.Size = new System.Drawing.Size(255, 297);
            this.grpboxWeapons.TabIndex = 81;
            this.grpboxWeapons.TabStop = false;
            this.grpboxWeapons.Text = "Weapon Settings";
            // 
            // lblRandomnessValue
            // 
            this.lblRandomnessValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblRandomnessValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRandomnessValue.ForeColor = System.Drawing.Color.White;
            this.lblRandomnessValue.Location = new System.Drawing.Point(126, 222);
            this.lblRandomnessValue.Name = "lblRandomnessValue";
            this.lblRandomnessValue.Size = new System.Drawing.Size(104, 20);
            this.lblRandomnessValue.TabIndex = 81;
            this.lblRandomnessValue.Text = "5";
            this.lblRandomnessValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRandomness
            // 
            this.lblRandomness.AutoSize = true;
            this.lblRandomness.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRandomness.ForeColor = System.Drawing.Color.White;
            this.lblRandomness.Location = new System.Drawing.Point(17, 220);
            this.lblRandomness.Name = "lblRandomness";
            this.lblRandomness.Size = new System.Drawing.Size(108, 20);
            this.lblRandomness.TabIndex = 73;
            this.lblRandomness.Text = "Randomness:";
            // 
            // cboWeapons
            // 
            this.cboWeapons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cboWeapons.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboWeapons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWeapons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboWeapons.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboWeapons.ForeColor = System.Drawing.Color.White;
            this.cboWeapons.FormattingEnabled = true;
            this.cboWeapons.Location = new System.Drawing.Point(15, 48);
            this.cboWeapons.Name = "cboWeapons";
            this.cboWeapons.Size = new System.Drawing.Size(224, 28);
            this.cboWeapons.TabIndex = 1;
            this.cboWeapons.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cboWeapons_DrawItem);
            this.cboWeapons.SelectedIndexChanged += new System.EventHandler(this.cboWeapons_SelectedIndexChanged);
            // 
            // trkbarRandomness
            // 
            this.trkbarRandomness.LargeChange = 1;
            this.trkbarRandomness.Location = new System.Drawing.Point(12, 243);
            this.trkbarRandomness.Name = "trkbarRandomness";
            this.trkbarRandomness.Size = new System.Drawing.Size(223, 45);
            this.trkbarRandomness.TabIndex = 4;
            this.trkbarRandomness.Value = 5;
            this.trkbarRandomness.Scroll += new System.EventHandler(this.trkbarRandomness_Scroll);
            // 
            // lblBarrelAttachment
            // 
            this.lblBarrelAttachment.AutoSize = true;
            this.lblBarrelAttachment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarrelAttachment.ForeColor = System.Drawing.Color.White;
            this.lblBarrelAttachment.Location = new System.Drawing.Point(11, 155);
            this.lblBarrelAttachment.Name = "lblBarrelAttachment";
            this.lblBarrelAttachment.Size = new System.Drawing.Size(142, 20);
            this.lblBarrelAttachment.TabIndex = 69;
            this.lblBarrelAttachment.Text = "Barrel Attachment:";
            // 
            // cboBarrels
            // 
            this.cboBarrels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cboBarrels.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboBarrels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBarrels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboBarrels.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBarrels.ForeColor = System.Drawing.Color.White;
            this.cboBarrels.FormattingEnabled = true;
            this.cboBarrels.Location = new System.Drawing.Point(15, 178);
            this.cboBarrels.Name = "cboBarrels";
            this.cboBarrels.Size = new System.Drawing.Size(224, 28);
            this.cboBarrels.TabIndex = 3;
            this.cboBarrels.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cboBarrels_DrawItem);
            this.cboBarrels.SelectedIndexChanged += new System.EventHandler(this.cboBarrels_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 67;
            this.label1.Text = "Scope Attachment:";
            // 
            // lblProcessInfo
            // 
            this.lblProcessInfo.AutoSize = true;
            this.lblProcessInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcessInfo.ForeColor = System.Drawing.Color.White;
            this.lblProcessInfo.Location = new System.Drawing.Point(11, 25);
            this.lblProcessInfo.Name = "lblProcessInfo";
            this.lblProcessInfo.Size = new System.Drawing.Size(73, 20);
            this.lblProcessInfo.TabIndex = 0;
            this.lblProcessInfo.Text = "Weapon:";
            // 
            // cboScopes
            // 
            this.cboScopes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cboScopes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboScopes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboScopes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboScopes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboScopes.ForeColor = System.Drawing.Color.White;
            this.cboScopes.FormattingEnabled = true;
            this.cboScopes.Location = new System.Drawing.Point(15, 111);
            this.cboScopes.Name = "cboScopes";
            this.cboScopes.Size = new System.Drawing.Size(224, 28);
            this.cboScopes.TabIndex = 2;
            this.cboScopes.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cboScopes_DrawItem);
            this.cboScopes.SelectedIndexChanged += new System.EventHandler(this.cboScopes_SelectedIndexChanged);
            // 
            // SapphireRecoil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Sens_Sapphire_Recoil.Properties.Resources.backgroundTexture;
            this.ClientSize = new System.Drawing.Size(547, 379);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.pnlStart);
            this.Controls.Add(this.pnlGameSettings);
            this.Controls.Add(this.pnlColor);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.pnlWeaponSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SapphireRecoil";
            this.Text = "Amethyst Recoil";
            this.pnlStart.ResumeLayout(false);
            this.pnlGameSettings.ResumeLayout(false);
            this.grpboxInGame.ResumeLayout(false);
            this.grpboxInGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkbarFOV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkbarSens)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.pnlWeaponSettings.ResumeLayout(false);
            this.grpboxWeapons.ResumeLayout(false);
            this.grpboxWeapons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkbarRandomness)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Panel pnlStart;
        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.Panel pnlGameSettings;
        private System.Windows.Forms.GroupBox grpboxInGame;
        private System.Windows.Forms.Label lblGameSensValue;
        private System.Windows.Forms.Label lblGameFOVValue;
        private System.Windows.Forms.TrackBar trkbarFOV;
        private System.Windows.Forms.TrackBar trkbarSens;
        private System.Windows.Forms.Label lblGameFOV;
        private System.Windows.Forms.Label lblGameSens;
        private System.Windows.Forms.Panel pnlColor;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlWeaponSettings;
        private System.Windows.Forms.GroupBox grpboxWeapons;
        private System.Windows.Forms.Label lblRandomnessValue;
        private System.Windows.Forms.Label lblRandomness;
        private System.Windows.Forms.ComboBox cboWeapons;
        private System.Windows.Forms.TrackBar trkbarRandomness;
        private System.Windows.Forms.Label lblBarrelAttachment;
        private System.Windows.Forms.ComboBox cboBarrels;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProcessInfo;
        private System.Windows.Forms.ComboBox cboScopes;
    }
}

