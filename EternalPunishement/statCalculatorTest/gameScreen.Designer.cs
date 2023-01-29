namespace statCalculatorTest
{
    partial class gameScreen
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
            this.GameTime = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.AgilityAddButton = new System.Windows.Forms.Button();
            this.MindfulnessAddButton = new System.Windows.Forms.Button();
            this.SharpnessAddButton = new System.Windows.Forms.Button();
            this.ConstitutionAddButton = new System.Windows.Forms.Button();
            this.DexterityAddButton = new System.Windows.Forms.Button();
            this.StrengthAddButton = new System.Windows.Forms.Button();
            this.HealthAddButton = new System.Windows.Forms.Button();
            this.ExperienceBar = new System.Windows.Forms.ProgressBar();
            this.ExperienceName = new System.Windows.Forms.Label();
            this.HPSeparator = new System.Windows.Forms.Label();
            this.MaxHPLabel = new System.Windows.Forms.Label();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.LevelName = new System.Windows.Forms.Label();
            this.CurrentHPLabel = new System.Windows.Forms.Label();
            this.AgilityLabel = new System.Windows.Forms.Label();
            this.MindfulnessLabel = new System.Windows.Forms.Label();
            this.SharpnessLabel = new System.Windows.Forms.Label();
            this.ConstitutionLabel = new System.Windows.Forms.Label();
            this.DexterityLabel = new System.Windows.Forms.Label();
            this.StrengthLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.HealthName = new System.Windows.Forms.Label();
            this.AgilityName = new System.Windows.Forms.Label();
            this.MindfulnessName = new System.Windows.Forms.Label();
            this.SharpnessName = new System.Windows.Forms.Label();
            this.ConstitutionName = new System.Windows.Forms.Label();
            this.DexterityName = new System.Windows.Forms.Label();
            this.StrengthName = new System.Windows.Forms.Label();
            this.NameName = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.PhysicalResistanceLabel = new System.Windows.Forms.Label();
            this.MagicResistanceLabel = new System.Windows.Forms.Label();
            this.HeavyWeaponEfficiencyLabel = new System.Windows.Forms.Label();
            this.LightWeaponEfficiencyLabel = new System.Windows.Forms.Label();
            this.MaxEquipLoadLabel = new System.Windows.Forms.Label();
            this.PhysicalResistanceName = new System.Windows.Forms.Label();
            this.MagicResistanceName = new System.Windows.Forms.Label();
            this.HeavyWeaponEfficiencyName = new System.Windows.Forms.Label();
            this.LightWeaponEfficiencyName = new System.Windows.Forms.Label();
            this.MaxEquipLoadName = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.RecoveryItemLabel = new System.Windows.Forms.Label();
            this.EquippedRecoveryBox = new System.Windows.Forms.ComboBox();
            this.EquippedTrinketLabel = new System.Windows.Forms.Label();
            this.EquippedTrinketBox = new System.Windows.Forms.ComboBox();
            this.EquippedWeaponLabel = new System.Windows.Forms.Label();
            this.EquippedWeaponBox = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.TextSpeedBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.UsedItemLabel = new System.Windows.Forms.Label();
            this.KillLabel = new System.Windows.Forms.Label();
            this.UsedItemName = new System.Windows.Forms.Label();
            this.KillName = new System.Windows.Forms.Label();
            this.GameTimeLabel = new System.Windows.Forms.Label();
            this.GameTimeName = new System.Windows.Forms.Label();
            this.SaveExitButton = new System.Windows.Forms.Button();
            this.UseItemButton = new System.Windows.Forms.Button();
            this.OkayButton = new System.Windows.Forms.Button();
            this.ShowWeaponButton = new System.Windows.Forms.Button();
            this.ShowTrinketButton = new System.Windows.Forms.Button();
            this.ShowRecoveryButton = new System.Windows.Forms.Button();
            this.StatButton = new System.Windows.Forms.Button();
            this.AttackButton = new System.Windows.Forms.Button();
            this.EnemyStatButton = new System.Windows.Forms.Button();
            this.MainTextBox = new System.Windows.Forms.RichTextBox();
            this.EnemyHealthBar = new System.Windows.Forms.ProgressBar();
            this.EnemyPictureBox = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextSpeedBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTime
            // 
            this.GameTime.Enabled = true;
            this.GameTime.Interval = 1000;
            this.GameTime.Tick += new System.EventHandler(this.GameTime_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(547, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(233, 245);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.AgilityAddButton);
            this.tabPage1.Controls.Add(this.MindfulnessAddButton);
            this.tabPage1.Controls.Add(this.SharpnessAddButton);
            this.tabPage1.Controls.Add(this.ConstitutionAddButton);
            this.tabPage1.Controls.Add(this.DexterityAddButton);
            this.tabPage1.Controls.Add(this.StrengthAddButton);
            this.tabPage1.Controls.Add(this.HealthAddButton);
            this.tabPage1.Controls.Add(this.ExperienceBar);
            this.tabPage1.Controls.Add(this.ExperienceName);
            this.tabPage1.Controls.Add(this.HPSeparator);
            this.tabPage1.Controls.Add(this.MaxHPLabel);
            this.tabPage1.Controls.Add(this.LevelLabel);
            this.tabPage1.Controls.Add(this.LevelName);
            this.tabPage1.Controls.Add(this.CurrentHPLabel);
            this.tabPage1.Controls.Add(this.AgilityLabel);
            this.tabPage1.Controls.Add(this.MindfulnessLabel);
            this.tabPage1.Controls.Add(this.SharpnessLabel);
            this.tabPage1.Controls.Add(this.ConstitutionLabel);
            this.tabPage1.Controls.Add(this.DexterityLabel);
            this.tabPage1.Controls.Add(this.StrengthLabel);
            this.tabPage1.Controls.Add(this.NameLabel);
            this.tabPage1.Controls.Add(this.HealthName);
            this.tabPage1.Controls.Add(this.AgilityName);
            this.tabPage1.Controls.Add(this.MindfulnessName);
            this.tabPage1.Controls.Add(this.SharpnessName);
            this.tabPage1.Controls.Add(this.ConstitutionName);
            this.tabPage1.Controls.Add(this.DexterityName);
            this.tabPage1.Controls.Add(this.StrengthName);
            this.tabPage1.Controls.Add(this.NameName);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(225, 219);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Stats";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // AgilityAddButton
            // 
            this.AgilityAddButton.Location = new System.Drawing.Point(89, 188);
            this.AgilityAddButton.Margin = new System.Windows.Forms.Padding(2);
            this.AgilityAddButton.Name = "AgilityAddButton";
            this.AgilityAddButton.Size = new System.Drawing.Size(15, 24);
            this.AgilityAddButton.TabIndex = 28;
            this.AgilityAddButton.Text = "+";
            this.AgilityAddButton.UseVisualStyleBackColor = true;
            this.AgilityAddButton.Click += new System.EventHandler(this.AgilityAddButton_Click);
            // 
            // MindfulnessAddButton
            // 
            this.MindfulnessAddButton.Location = new System.Drawing.Point(89, 162);
            this.MindfulnessAddButton.Margin = new System.Windows.Forms.Padding(2);
            this.MindfulnessAddButton.Name = "MindfulnessAddButton";
            this.MindfulnessAddButton.Size = new System.Drawing.Size(15, 24);
            this.MindfulnessAddButton.TabIndex = 27;
            this.MindfulnessAddButton.Text = "+";
            this.MindfulnessAddButton.UseVisualStyleBackColor = true;
            this.MindfulnessAddButton.Click += new System.EventHandler(this.MindfulnessAddButton_Click);
            // 
            // SharpnessAddButton
            // 
            this.SharpnessAddButton.Location = new System.Drawing.Point(89, 136);
            this.SharpnessAddButton.Margin = new System.Windows.Forms.Padding(2);
            this.SharpnessAddButton.Name = "SharpnessAddButton";
            this.SharpnessAddButton.Size = new System.Drawing.Size(15, 24);
            this.SharpnessAddButton.TabIndex = 26;
            this.SharpnessAddButton.Text = "+";
            this.SharpnessAddButton.UseVisualStyleBackColor = true;
            this.SharpnessAddButton.Click += new System.EventHandler(this.SharpnessAddButton_Click);
            // 
            // ConstitutionAddButton
            // 
            this.ConstitutionAddButton.Location = new System.Drawing.Point(89, 110);
            this.ConstitutionAddButton.Margin = new System.Windows.Forms.Padding(2);
            this.ConstitutionAddButton.Name = "ConstitutionAddButton";
            this.ConstitutionAddButton.Size = new System.Drawing.Size(15, 24);
            this.ConstitutionAddButton.TabIndex = 25;
            this.ConstitutionAddButton.Text = "+";
            this.ConstitutionAddButton.UseVisualStyleBackColor = true;
            this.ConstitutionAddButton.Click += new System.EventHandler(this.ConstitutionAddButton_Click);
            // 
            // DexterityAddButton
            // 
            this.DexterityAddButton.Location = new System.Drawing.Point(89, 86);
            this.DexterityAddButton.Margin = new System.Windows.Forms.Padding(2);
            this.DexterityAddButton.Name = "DexterityAddButton";
            this.DexterityAddButton.Size = new System.Drawing.Size(15, 24);
            this.DexterityAddButton.TabIndex = 24;
            this.DexterityAddButton.Text = "+";
            this.DexterityAddButton.UseVisualStyleBackColor = true;
            this.DexterityAddButton.Click += new System.EventHandler(this.DexterityAddButton_Click);
            // 
            // StrengthAddButton
            // 
            this.StrengthAddButton.Location = new System.Drawing.Point(89, 59);
            this.StrengthAddButton.Margin = new System.Windows.Forms.Padding(2);
            this.StrengthAddButton.Name = "StrengthAddButton";
            this.StrengthAddButton.Size = new System.Drawing.Size(15, 24);
            this.StrengthAddButton.TabIndex = 23;
            this.StrengthAddButton.Text = "+";
            this.StrengthAddButton.UseVisualStyleBackColor = true;
            this.StrengthAddButton.Click += new System.EventHandler(this.StrengthAddButton_Click);
            // 
            // HealthAddButton
            // 
            this.HealthAddButton.Location = new System.Drawing.Point(89, 31);
            this.HealthAddButton.Margin = new System.Windows.Forms.Padding(2);
            this.HealthAddButton.Name = "HealthAddButton";
            this.HealthAddButton.Size = new System.Drawing.Size(15, 24);
            this.HealthAddButton.TabIndex = 22;
            this.HealthAddButton.Text = "+";
            this.HealthAddButton.UseVisualStyleBackColor = true;
            this.HealthAddButton.Click += new System.EventHandler(this.HealthAddButton_Click);
            // 
            // ExperienceBar
            // 
            this.ExperienceBar.Location = new System.Drawing.Point(110, 171);
            this.ExperienceBar.Margin = new System.Windows.Forms.Padding(2);
            this.ExperienceBar.Name = "ExperienceBar";
            this.ExperienceBar.Size = new System.Drawing.Size(56, 35);
            this.ExperienceBar.TabIndex = 21;
            // 
            // ExperienceName
            // 
            this.ExperienceName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExperienceName.AutoSize = true;
            this.ExperienceName.Location = new System.Drawing.Point(107, 155);
            this.ExperienceName.Margin = new System.Windows.Forms.Padding(0);
            this.ExperienceName.Name = "ExperienceName";
            this.ExperienceName.Size = new System.Drawing.Size(60, 13);
            this.ExperienceName.TabIndex = 20;
            this.ExperienceName.Text = "Experience";
            // 
            // HPSeparator
            // 
            this.HPSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HPSeparator.AutoSize = true;
            this.HPSeparator.Location = new System.Drawing.Point(133, 38);
            this.HPSeparator.Margin = new System.Windows.Forms.Padding(0);
            this.HPSeparator.Name = "HPSeparator";
            this.HPSeparator.Size = new System.Drawing.Size(12, 13);
            this.HPSeparator.TabIndex = 19;
            this.HPSeparator.Text = "/";
            // 
            // MaxHPLabel
            // 
            this.MaxHPLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxHPLabel.AutoSize = true;
            this.MaxHPLabel.Location = new System.Drawing.Point(145, 38);
            this.MaxHPLabel.Margin = new System.Windows.Forms.Padding(0);
            this.MaxHPLabel.Name = "MaxHPLabel";
            this.MaxHPLabel.Size = new System.Drawing.Size(13, 13);
            this.MaxHPLabel.TabIndex = 18;
            this.MaxHPLabel.Text = "0";
            // 
            // LevelLabel
            // 
            this.LevelLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.Location = new System.Drawing.Point(145, 141);
            this.LevelLabel.Margin = new System.Windows.Forms.Padding(0);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(13, 13);
            this.LevelLabel.TabIndex = 17;
            this.LevelLabel.Text = "0";
            // 
            // LevelName
            // 
            this.LevelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LevelName.AutoSize = true;
            this.LevelName.Location = new System.Drawing.Point(107, 141);
            this.LevelName.Margin = new System.Windows.Forms.Padding(0);
            this.LevelName.Name = "LevelName";
            this.LevelName.Size = new System.Drawing.Size(36, 13);
            this.LevelName.TabIndex = 16;
            this.LevelName.Text = "Level:";
            // 
            // CurrentHPLabel
            // 
            this.CurrentHPLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentHPLabel.AutoSize = true;
            this.CurrentHPLabel.Location = new System.Drawing.Point(63, 38);
            this.CurrentHPLabel.Margin = new System.Windows.Forms.Padding(0);
            this.CurrentHPLabel.Name = "CurrentHPLabel";
            this.CurrentHPLabel.Size = new System.Drawing.Size(25, 13);
            this.CurrentHPLabel.TabIndex = 15;
            this.CurrentHPLabel.Text = "000";
            // 
            // AgilityLabel
            // 
            this.AgilityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AgilityLabel.AutoSize = true;
            this.AgilityLabel.Location = new System.Drawing.Point(75, 193);
            this.AgilityLabel.Margin = new System.Windows.Forms.Padding(0);
            this.AgilityLabel.Name = "AgilityLabel";
            this.AgilityLabel.Size = new System.Drawing.Size(13, 13);
            this.AgilityLabel.TabIndex = 14;
            this.AgilityLabel.Text = "0";
            // 
            // MindfulnessLabel
            // 
            this.MindfulnessLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MindfulnessLabel.AutoSize = true;
            this.MindfulnessLabel.Location = new System.Drawing.Point(75, 167);
            this.MindfulnessLabel.Margin = new System.Windows.Forms.Padding(0);
            this.MindfulnessLabel.Name = "MindfulnessLabel";
            this.MindfulnessLabel.Size = new System.Drawing.Size(13, 13);
            this.MindfulnessLabel.TabIndex = 13;
            this.MindfulnessLabel.Text = "0";
            // 
            // SharpnessLabel
            // 
            this.SharpnessLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SharpnessLabel.AutoSize = true;
            this.SharpnessLabel.Location = new System.Drawing.Point(75, 141);
            this.SharpnessLabel.Margin = new System.Windows.Forms.Padding(0);
            this.SharpnessLabel.Name = "SharpnessLabel";
            this.SharpnessLabel.Size = new System.Drawing.Size(13, 13);
            this.SharpnessLabel.TabIndex = 12;
            this.SharpnessLabel.Text = "0";
            // 
            // ConstitutionLabel
            // 
            this.ConstitutionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConstitutionLabel.AutoSize = true;
            this.ConstitutionLabel.Location = new System.Drawing.Point(75, 115);
            this.ConstitutionLabel.Margin = new System.Windows.Forms.Padding(0);
            this.ConstitutionLabel.Name = "ConstitutionLabel";
            this.ConstitutionLabel.Size = new System.Drawing.Size(13, 13);
            this.ConstitutionLabel.TabIndex = 11;
            this.ConstitutionLabel.Text = "0";
            // 
            // DexterityLabel
            // 
            this.DexterityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DexterityLabel.AutoSize = true;
            this.DexterityLabel.Location = new System.Drawing.Point(75, 91);
            this.DexterityLabel.Margin = new System.Windows.Forms.Padding(0);
            this.DexterityLabel.Name = "DexterityLabel";
            this.DexterityLabel.Size = new System.Drawing.Size(13, 13);
            this.DexterityLabel.TabIndex = 10;
            this.DexterityLabel.Text = "0";
            // 
            // StrengthLabel
            // 
            this.StrengthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StrengthLabel.AutoSize = true;
            this.StrengthLabel.Location = new System.Drawing.Point(75, 64);
            this.StrengthLabel.Margin = new System.Windows.Forms.Padding(0);
            this.StrengthLabel.Name = "StrengthLabel";
            this.StrengthLabel.Size = new System.Drawing.Size(13, 13);
            this.StrengthLabel.TabIndex = 9;
            this.StrengthLabel.Text = "0";
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(75, 12);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(13, 13);
            this.NameLabel.TabIndex = 8;
            this.NameLabel.Text = "?";
            // 
            // HealthName
            // 
            this.HealthName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HealthName.AutoSize = true;
            this.HealthName.Location = new System.Drawing.Point(2, 38);
            this.HealthName.Margin = new System.Windows.Forms.Padding(0);
            this.HealthName.Name = "HealthName";
            this.HealthName.Size = new System.Drawing.Size(41, 13);
            this.HealthName.TabIndex = 7;
            this.HealthName.Text = "Health:";
            // 
            // AgilityName
            // 
            this.AgilityName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AgilityName.AutoSize = true;
            this.AgilityName.Location = new System.Drawing.Point(2, 193);
            this.AgilityName.Margin = new System.Windows.Forms.Padding(0);
            this.AgilityName.Name = "AgilityName";
            this.AgilityName.Size = new System.Drawing.Size(37, 13);
            this.AgilityName.TabIndex = 6;
            this.AgilityName.Text = "Agility:";
            // 
            // MindfulnessName
            // 
            this.MindfulnessName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MindfulnessName.AutoSize = true;
            this.MindfulnessName.Location = new System.Drawing.Point(2, 167);
            this.MindfulnessName.Margin = new System.Windows.Forms.Padding(0);
            this.MindfulnessName.Name = "MindfulnessName";
            this.MindfulnessName.Size = new System.Drawing.Size(66, 13);
            this.MindfulnessName.TabIndex = 5;
            this.MindfulnessName.Text = "Mindfulness:";
            // 
            // SharpnessName
            // 
            this.SharpnessName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SharpnessName.AutoSize = true;
            this.SharpnessName.Location = new System.Drawing.Point(2, 141);
            this.SharpnessName.Margin = new System.Windows.Forms.Padding(0);
            this.SharpnessName.Name = "SharpnessName";
            this.SharpnessName.Size = new System.Drawing.Size(60, 13);
            this.SharpnessName.TabIndex = 4;
            this.SharpnessName.Text = "Sharpness:";
            // 
            // ConstitutionName
            // 
            this.ConstitutionName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConstitutionName.AutoSize = true;
            this.ConstitutionName.Location = new System.Drawing.Point(2, 115);
            this.ConstitutionName.Margin = new System.Windows.Forms.Padding(0);
            this.ConstitutionName.Name = "ConstitutionName";
            this.ConstitutionName.Size = new System.Drawing.Size(65, 13);
            this.ConstitutionName.TabIndex = 3;
            this.ConstitutionName.Text = "Constitution:";
            // 
            // DexterityName
            // 
            this.DexterityName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DexterityName.AutoSize = true;
            this.DexterityName.Location = new System.Drawing.Point(2, 91);
            this.DexterityName.Margin = new System.Windows.Forms.Padding(0);
            this.DexterityName.Name = "DexterityName";
            this.DexterityName.Size = new System.Drawing.Size(51, 13);
            this.DexterityName.TabIndex = 2;
            this.DexterityName.Text = "Dexterity:";
            // 
            // StrengthName
            // 
            this.StrengthName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StrengthName.AutoSize = true;
            this.StrengthName.Location = new System.Drawing.Point(2, 64);
            this.StrengthName.Margin = new System.Windows.Forms.Padding(0);
            this.StrengthName.Name = "StrengthName";
            this.StrengthName.Size = new System.Drawing.Size(50, 13);
            this.StrengthName.TabIndex = 1;
            this.StrengthName.Text = "Strength:";
            // 
            // NameName
            // 
            this.NameName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameName.AutoSize = true;
            this.NameName.Location = new System.Drawing.Point(2, 12);
            this.NameName.Margin = new System.Windows.Forms.Padding(0);
            this.NameName.Name = "NameName";
            this.NameName.Size = new System.Drawing.Size(38, 13);
            this.NameName.TabIndex = 0;
            this.NameName.Text = "Name:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.PhysicalResistanceLabel);
            this.tabPage2.Controls.Add(this.MagicResistanceLabel);
            this.tabPage2.Controls.Add(this.HeavyWeaponEfficiencyLabel);
            this.tabPage2.Controls.Add(this.LightWeaponEfficiencyLabel);
            this.tabPage2.Controls.Add(this.MaxEquipLoadLabel);
            this.tabPage2.Controls.Add(this.PhysicalResistanceName);
            this.tabPage2.Controls.Add(this.MagicResistanceName);
            this.tabPage2.Controls.Add(this.HeavyWeaponEfficiencyName);
            this.tabPage2.Controls.Add(this.LightWeaponEfficiencyName);
            this.tabPage2.Controls.Add(this.MaxEquipLoadName);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(225, 219);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Stats+";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // PhysicalResistanceLabel
            // 
            this.PhysicalResistanceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhysicalResistanceLabel.AutoSize = true;
            this.PhysicalResistanceLabel.Location = new System.Drawing.Point(130, 106);
            this.PhysicalResistanceLabel.Margin = new System.Windows.Forms.Padding(0);
            this.PhysicalResistanceLabel.Name = "PhysicalResistanceLabel";
            this.PhysicalResistanceLabel.Size = new System.Drawing.Size(13, 13);
            this.PhysicalResistanceLabel.TabIndex = 24;
            this.PhysicalResistanceLabel.Text = "0";
            // 
            // MagicResistanceLabel
            // 
            this.MagicResistanceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MagicResistanceLabel.AutoSize = true;
            this.MagicResistanceLabel.Location = new System.Drawing.Point(130, 80);
            this.MagicResistanceLabel.Margin = new System.Windows.Forms.Padding(0);
            this.MagicResistanceLabel.Name = "MagicResistanceLabel";
            this.MagicResistanceLabel.Size = new System.Drawing.Size(13, 13);
            this.MagicResistanceLabel.TabIndex = 23;
            this.MagicResistanceLabel.Text = "0";
            // 
            // HeavyWeaponEfficiencyLabel
            // 
            this.HeavyWeaponEfficiencyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeavyWeaponEfficiencyLabel.AutoSize = true;
            this.HeavyWeaponEfficiencyLabel.Location = new System.Drawing.Point(130, 54);
            this.HeavyWeaponEfficiencyLabel.Margin = new System.Windows.Forms.Padding(0);
            this.HeavyWeaponEfficiencyLabel.Name = "HeavyWeaponEfficiencyLabel";
            this.HeavyWeaponEfficiencyLabel.Size = new System.Drawing.Size(13, 13);
            this.HeavyWeaponEfficiencyLabel.TabIndex = 22;
            this.HeavyWeaponEfficiencyLabel.Text = "0";
            // 
            // LightWeaponEfficiencyLabel
            // 
            this.LightWeaponEfficiencyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LightWeaponEfficiencyLabel.AutoSize = true;
            this.LightWeaponEfficiencyLabel.Location = new System.Drawing.Point(130, 28);
            this.LightWeaponEfficiencyLabel.Margin = new System.Windows.Forms.Padding(0);
            this.LightWeaponEfficiencyLabel.Name = "LightWeaponEfficiencyLabel";
            this.LightWeaponEfficiencyLabel.Size = new System.Drawing.Size(13, 13);
            this.LightWeaponEfficiencyLabel.TabIndex = 21;
            this.LightWeaponEfficiencyLabel.Text = "0";
            // 
            // MaxEquipLoadLabel
            // 
            this.MaxEquipLoadLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxEquipLoadLabel.AutoSize = true;
            this.MaxEquipLoadLabel.Location = new System.Drawing.Point(130, 4);
            this.MaxEquipLoadLabel.Margin = new System.Windows.Forms.Padding(0);
            this.MaxEquipLoadLabel.Name = "MaxEquipLoadLabel";
            this.MaxEquipLoadLabel.Size = new System.Drawing.Size(13, 13);
            this.MaxEquipLoadLabel.TabIndex = 20;
            this.MaxEquipLoadLabel.Text = "0";
            // 
            // PhysicalResistanceName
            // 
            this.PhysicalResistanceName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhysicalResistanceName.AutoSize = true;
            this.PhysicalResistanceName.Location = new System.Drawing.Point(2, 106);
            this.PhysicalResistanceName.Margin = new System.Windows.Forms.Padding(0);
            this.PhysicalResistanceName.Name = "PhysicalResistanceName";
            this.PhysicalResistanceName.Size = new System.Drawing.Size(102, 13);
            this.PhysicalResistanceName.TabIndex = 19;
            this.PhysicalResistanceName.Text = "Physical Resistance";
            // 
            // MagicResistanceName
            // 
            this.MagicResistanceName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MagicResistanceName.AutoSize = true;
            this.MagicResistanceName.Location = new System.Drawing.Point(2, 80);
            this.MagicResistanceName.Margin = new System.Windows.Forms.Padding(0);
            this.MagicResistanceName.Name = "MagicResistanceName";
            this.MagicResistanceName.Size = new System.Drawing.Size(95, 13);
            this.MagicResistanceName.TabIndex = 18;
            this.MagicResistanceName.Text = "Magic Resistance:";
            // 
            // HeavyWeaponEfficiencyName
            // 
            this.HeavyWeaponEfficiencyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeavyWeaponEfficiencyName.AutoSize = true;
            this.HeavyWeaponEfficiencyName.Location = new System.Drawing.Point(2, 54);
            this.HeavyWeaponEfficiencyName.Margin = new System.Windows.Forms.Padding(0);
            this.HeavyWeaponEfficiencyName.Name = "HeavyWeaponEfficiencyName";
            this.HeavyWeaponEfficiencyName.Size = new System.Drawing.Size(131, 13);
            this.HeavyWeaponEfficiencyName.TabIndex = 17;
            this.HeavyWeaponEfficiencyName.Text = "Heavy Weapon Efficiency";
            // 
            // LightWeaponEfficiencyName
            // 
            this.LightWeaponEfficiencyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LightWeaponEfficiencyName.AutoSize = true;
            this.LightWeaponEfficiencyName.Location = new System.Drawing.Point(2, 28);
            this.LightWeaponEfficiencyName.Margin = new System.Windows.Forms.Padding(0);
            this.LightWeaponEfficiencyName.Name = "LightWeaponEfficiencyName";
            this.LightWeaponEfficiencyName.Size = new System.Drawing.Size(123, 13);
            this.LightWeaponEfficiencyName.TabIndex = 16;
            this.LightWeaponEfficiencyName.Text = "Light Weapon Efficiency";
            // 
            // MaxEquipLoadName
            // 
            this.MaxEquipLoadName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxEquipLoadName.AutoSize = true;
            this.MaxEquipLoadName.Location = new System.Drawing.Point(2, 4);
            this.MaxEquipLoadName.Margin = new System.Windows.Forms.Padding(0);
            this.MaxEquipLoadName.Name = "MaxEquipLoadName";
            this.MaxEquipLoadName.Size = new System.Drawing.Size(87, 13);
            this.MaxEquipLoadName.TabIndex = 15;
            this.MaxEquipLoadName.Text = "Max Equip Load:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.RecoveryItemLabel);
            this.tabPage3.Controls.Add(this.EquippedRecoveryBox);
            this.tabPage3.Controls.Add(this.EquippedTrinketLabel);
            this.tabPage3.Controls.Add(this.EquippedTrinketBox);
            this.tabPage3.Controls.Add(this.EquippedWeaponLabel);
            this.tabPage3.Controls.Add(this.EquippedWeaponBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(225, 219);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Items";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // RecoveryItemLabel
            // 
            this.RecoveryItemLabel.AutoSize = true;
            this.RecoveryItemLabel.Location = new System.Drawing.Point(40, 151);
            this.RecoveryItemLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RecoveryItemLabel.Name = "RecoveryItemLabel";
            this.RecoveryItemLabel.Size = new System.Drawing.Size(81, 13);
            this.RecoveryItemLabel.TabIndex = 5;
            this.RecoveryItemLabel.Text = "Recovery Items";
            // 
            // EquippedRecoveryBox
            // 
            this.EquippedRecoveryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EquippedRecoveryBox.FormattingEnabled = true;
            this.EquippedRecoveryBox.Location = new System.Drawing.Point(2, 167);
            this.EquippedRecoveryBox.Margin = new System.Windows.Forms.Padding(2);
            this.EquippedRecoveryBox.Name = "EquippedRecoveryBox";
            this.EquippedRecoveryBox.Size = new System.Drawing.Size(167, 21);
            this.EquippedRecoveryBox.Sorted = true;
            this.EquippedRecoveryBox.TabIndex = 4;
            this.EquippedRecoveryBox.TabStop = false;
            // 
            // EquippedTrinketLabel
            // 
            this.EquippedTrinketLabel.AutoSize = true;
            this.EquippedTrinketLabel.Location = new System.Drawing.Point(40, 80);
            this.EquippedTrinketLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EquippedTrinketLabel.Name = "EquippedTrinketLabel";
            this.EquippedTrinketLabel.Size = new System.Drawing.Size(88, 13);
            this.EquippedTrinketLabel.TabIndex = 3;
            this.EquippedTrinketLabel.Text = "Equipped Trinket";
            // 
            // EquippedTrinketBox
            // 
            this.EquippedTrinketBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EquippedTrinketBox.FormattingEnabled = true;
            this.EquippedTrinketBox.Location = new System.Drawing.Point(2, 96);
            this.EquippedTrinketBox.Margin = new System.Windows.Forms.Padding(2);
            this.EquippedTrinketBox.Name = "EquippedTrinketBox";
            this.EquippedTrinketBox.Size = new System.Drawing.Size(167, 21);
            this.EquippedTrinketBox.Sorted = true;
            this.EquippedTrinketBox.TabIndex = 2;
            this.EquippedTrinketBox.TabStop = false;
            // 
            // EquippedWeaponLabel
            // 
            this.EquippedWeaponLabel.AutoSize = true;
            this.EquippedWeaponLabel.Location = new System.Drawing.Point(40, 4);
            this.EquippedWeaponLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EquippedWeaponLabel.Name = "EquippedWeaponLabel";
            this.EquippedWeaponLabel.Size = new System.Drawing.Size(96, 13);
            this.EquippedWeaponLabel.TabIndex = 1;
            this.EquippedWeaponLabel.Text = "Equipped Weapon";
            // 
            // EquippedWeaponBox
            // 
            this.EquippedWeaponBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EquippedWeaponBox.FormattingEnabled = true;
            this.EquippedWeaponBox.Location = new System.Drawing.Point(2, 20);
            this.EquippedWeaponBox.Margin = new System.Windows.Forms.Padding(2);
            this.EquippedWeaponBox.Name = "EquippedWeaponBox";
            this.EquippedWeaponBox.Size = new System.Drawing.Size(167, 21);
            this.EquippedWeaponBox.Sorted = true;
            this.EquippedWeaponBox.TabIndex = 0;
            this.EquippedWeaponBox.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.TextSpeedBar);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.UsedItemLabel);
            this.tabPage4.Controls.Add(this.KillLabel);
            this.tabPage4.Controls.Add(this.UsedItemName);
            this.tabPage4.Controls.Add(this.KillName);
            this.tabPage4.Controls.Add(this.GameTimeLabel);
            this.tabPage4.Controls.Add(this.GameTimeName);
            this.tabPage4.Controls.Add(this.SaveExitButton);
            this.tabPage4.Location = new System.Drawing.Point(4, 4);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(225, 219);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Options";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // TextSpeedBar
            // 
            this.TextSpeedBar.LargeChange = 2;
            this.TextSpeedBar.Location = new System.Drawing.Point(66, 141);
            this.TextSpeedBar.Margin = new System.Windows.Forms.Padding(2);
            this.TextSpeedBar.Maximum = 4;
            this.TextSpeedBar.Name = "TextSpeedBar";
            this.TextSpeedBar.Size = new System.Drawing.Size(104, 45);
            this.TextSpeedBar.TabIndex = 8;
            this.TextSpeedBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.TextSpeedBar.Value = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Text speed";
            // 
            // UsedItemLabel
            // 
            this.UsedItemLabel.AutoSize = true;
            this.UsedItemLabel.Location = new System.Drawing.Point(149, 60);
            this.UsedItemLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UsedItemLabel.Name = "UsedItemLabel";
            this.UsedItemLabel.Size = new System.Drawing.Size(13, 13);
            this.UsedItemLabel.TabIndex = 6;
            this.UsedItemLabel.Text = "0";
            // 
            // KillLabel
            // 
            this.KillLabel.AutoSize = true;
            this.KillLabel.Location = new System.Drawing.Point(149, 36);
            this.KillLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.KillLabel.Name = "KillLabel";
            this.KillLabel.Size = new System.Drawing.Size(13, 13);
            this.KillLabel.TabIndex = 5;
            this.KillLabel.Text = "0";
            // 
            // UsedItemName
            // 
            this.UsedItemName.AutoSize = true;
            this.UsedItemName.Location = new System.Drawing.Point(2, 60);
            this.UsedItemName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UsedItemName.Name = "UsedItemName";
            this.UsedItemName.Size = new System.Drawing.Size(107, 13);
            this.UsedItemName.TabIndex = 4;
            this.UsedItemName.Text = "Used Recovery Item:";
            // 
            // KillName
            // 
            this.KillName.AutoSize = true;
            this.KillName.Location = new System.Drawing.Point(5, 36);
            this.KillName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.KillName.Name = "KillName";
            this.KillName.Size = new System.Drawing.Size(74, 13);
            this.KillName.TabIndex = 3;
            this.KillName.Text = "Number of kill:";
            // 
            // GameTimeLabel
            // 
            this.GameTimeLabel.AutoSize = true;
            this.GameTimeLabel.Location = new System.Drawing.Point(74, 6);
            this.GameTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GameTimeLabel.Name = "GameTimeLabel";
            this.GameTimeLabel.Size = new System.Drawing.Size(0, 13);
            this.GameTimeLabel.TabIndex = 2;
            // 
            // GameTimeName
            // 
            this.GameTimeName.AutoSize = true;
            this.GameTimeName.Location = new System.Drawing.Point(5, 6);
            this.GameTimeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GameTimeName.Name = "GameTimeName";
            this.GameTimeName.Size = new System.Drawing.Size(64, 13);
            this.GameTimeName.TabIndex = 1;
            this.GameTimeName.Text = "Game Time:";
            // 
            // SaveExitButton
            // 
            this.SaveExitButton.Location = new System.Drawing.Point(5, 197);
            this.SaveExitButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveExitButton.Name = "SaveExitButton";
            this.SaveExitButton.Size = new System.Drawing.Size(165, 19);
            this.SaveExitButton.TabIndex = 0;
            this.SaveExitButton.Text = "Save and Exit";
            this.SaveExitButton.UseVisualStyleBackColor = true;
            this.SaveExitButton.Click += new System.EventHandler(this.SaveExitButton_Click);
            // 
            // UseItemButton
            // 
            this.UseItemButton.Location = new System.Drawing.Point(10, 314);
            this.UseItemButton.Margin = new System.Windows.Forms.Padding(2);
            this.UseItemButton.Name = "UseItemButton";
            this.UseItemButton.Size = new System.Drawing.Size(103, 32);
            this.UseItemButton.TabIndex = 2;
            this.UseItemButton.Text = "Use Item";
            this.UseItemButton.UseVisualStyleBackColor = true;
            // 
            // OkayButton
            // 
            this.OkayButton.Location = new System.Drawing.Point(9, 240);
            this.OkayButton.Margin = new System.Windows.Forms.Padding(2);
            this.OkayButton.Name = "OkayButton";
            this.OkayButton.Size = new System.Drawing.Size(103, 32);
            this.OkayButton.TabIndex = 3;
            this.OkayButton.Text = "Start!";
            this.OkayButton.UseVisualStyleBackColor = true;
            this.OkayButton.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // ShowWeaponButton
            // 
            this.ShowWeaponButton.Location = new System.Drawing.Point(568, 260);
            this.ShowWeaponButton.Margin = new System.Windows.Forms.Padding(2);
            this.ShowWeaponButton.Name = "ShowWeaponButton";
            this.ShowWeaponButton.Size = new System.Drawing.Size(175, 23);
            this.ShowWeaponButton.TabIndex = 4;
            this.ShowWeaponButton.Text = "Weapon Description";
            this.ShowWeaponButton.UseVisualStyleBackColor = true;
            this.ShowWeaponButton.Visible = false;
            this.ShowWeaponButton.Click += new System.EventHandler(this.ShowWeaponButton_Click);
            // 
            // ShowTrinketButton
            // 
            this.ShowTrinketButton.Location = new System.Drawing.Point(568, 288);
            this.ShowTrinketButton.Margin = new System.Windows.Forms.Padding(2);
            this.ShowTrinketButton.Name = "ShowTrinketButton";
            this.ShowTrinketButton.Size = new System.Drawing.Size(175, 23);
            this.ShowTrinketButton.TabIndex = 5;
            this.ShowTrinketButton.Text = "Trinket Description";
            this.ShowTrinketButton.UseVisualStyleBackColor = true;
            this.ShowTrinketButton.Visible = false;
            this.ShowTrinketButton.Click += new System.EventHandler(this.ShowTrinketButton_Click);
            // 
            // ShowRecoveryButton
            // 
            this.ShowRecoveryButton.Location = new System.Drawing.Point(568, 315);
            this.ShowRecoveryButton.Margin = new System.Windows.Forms.Padding(2);
            this.ShowRecoveryButton.Name = "ShowRecoveryButton";
            this.ShowRecoveryButton.Size = new System.Drawing.Size(175, 23);
            this.ShowRecoveryButton.TabIndex = 6;
            this.ShowRecoveryButton.Text = "Recovery Item Description";
            this.ShowRecoveryButton.UseVisualStyleBackColor = true;
            this.ShowRecoveryButton.Visible = false;
            this.ShowRecoveryButton.Click += new System.EventHandler(this.ShowRecoveryButton_Click);
            // 
            // StatButton
            // 
            this.StatButton.Location = new System.Drawing.Point(304, 277);
            this.StatButton.Margin = new System.Windows.Forms.Padding(2);
            this.StatButton.Name = "StatButton";
            this.StatButton.Size = new System.Drawing.Size(103, 32);
            this.StatButton.TabIndex = 7;
            this.StatButton.Text = "stat sheet";
            this.StatButton.UseVisualStyleBackColor = true;
            this.StatButton.Click += new System.EventHandler(this.StatButton_Click);
            // 
            // AttackButton
            // 
            this.AttackButton.Location = new System.Drawing.Point(10, 277);
            this.AttackButton.Margin = new System.Windows.Forms.Padding(2);
            this.AttackButton.Name = "AttackButton";
            this.AttackButton.Size = new System.Drawing.Size(103, 32);
            this.AttackButton.TabIndex = 8;
            this.AttackButton.Text = "Attack";
            this.AttackButton.UseVisualStyleBackColor = true;
            this.AttackButton.Click += new System.EventHandler(this.AttackButton_Click);
            // 
            // EnemyStatButton
            // 
            this.EnemyStatButton.Location = new System.Drawing.Point(304, 314);
            this.EnemyStatButton.Margin = new System.Windows.Forms.Padding(2);
            this.EnemyStatButton.Name = "EnemyStatButton";
            this.EnemyStatButton.Size = new System.Drawing.Size(103, 32);
            this.EnemyStatButton.TabIndex = 9;
            this.EnemyStatButton.Text = "Enemy stat sheet";
            this.EnemyStatButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.EnemyStatButton.UseVisualStyleBackColor = true;
            this.EnemyStatButton.Click += new System.EventHandler(this.EnemyStatButton_Click);
            // 
            // MainTextBox
            // 
            this.MainTextBox.Location = new System.Drawing.Point(9, 11);
            this.MainTextBox.Name = "MainTextBox";
            this.MainTextBox.ReadOnly = true;
            this.MainTextBox.Size = new System.Drawing.Size(398, 224);
            this.MainTextBox.TabIndex = 10;
            this.MainTextBox.TabStop = false;
            this.MainTextBox.Text = "";
            // 
            // EnemyHealthBar
            // 
            this.EnemyHealthBar.Location = new System.Drawing.Point(414, 151);
            this.EnemyHealthBar.Name = "EnemyHealthBar";
            this.EnemyHealthBar.Size = new System.Drawing.Size(128, 32);
            this.EnemyHealthBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.EnemyHealthBar.TabIndex = 12;
            // 
            // EnemyPictureBox
            // 
            this.EnemyPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EnemyPictureBox.Location = new System.Drawing.Point(414, 15);
            this.EnemyPictureBox.Name = "EnemyPictureBox";
            this.EnemyPictureBox.Size = new System.Drawing.Size(128, 128);
            this.EnemyPictureBox.TabIndex = 11;
            this.EnemyPictureBox.TabStop = false;
            // 
            // gameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 366);
            this.Controls.Add(this.EnemyHealthBar);
            this.Controls.Add(this.EnemyPictureBox);
            this.Controls.Add(this.MainTextBox);
            this.Controls.Add(this.EnemyStatButton);
            this.Controls.Add(this.AttackButton);
            this.Controls.Add(this.StatButton);
            this.Controls.Add(this.ShowRecoveryButton);
            this.Controls.Add(this.ShowTrinketButton);
            this.Controls.Add(this.ShowWeaponButton);
            this.Controls.Add(this.OkayButton);
            this.Controls.Add(this.UseItemButton);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "gameScreen";
            this.Text = "gameScreen";
            this.Load += new System.EventHandler(this.gameScreen_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextSpeedBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer GameTime;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label AgilityName;
        private System.Windows.Forms.Label MindfulnessName;
        private System.Windows.Forms.Label SharpnessName;
        private System.Windows.Forms.Label ConstitutionName;
        private System.Windows.Forms.Label DexterityName;
        private System.Windows.Forms.Label StrengthName;
        private System.Windows.Forms.Label NameName;
        private System.Windows.Forms.Label HealthName;
        private System.Windows.Forms.Label CurrentHPLabel;
        private System.Windows.Forms.Label AgilityLabel;
        private System.Windows.Forms.Label MindfulnessLabel;
        private System.Windows.Forms.Label SharpnessLabel;
        private System.Windows.Forms.Label ConstitutionLabel;
        private System.Windows.Forms.Label DexterityLabel;
        private System.Windows.Forms.Label StrengthLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PhysicalResistanceLabel;
        private System.Windows.Forms.Label MagicResistanceLabel;
        private System.Windows.Forms.Label HeavyWeaponEfficiencyLabel;
        private System.Windows.Forms.Label LightWeaponEfficiencyLabel;
        private System.Windows.Forms.Label MaxEquipLoadLabel;
        private System.Windows.Forms.Label PhysicalResistanceName;
        private System.Windows.Forms.Label MagicResistanceName;
        private System.Windows.Forms.Label HeavyWeaponEfficiencyName;
        private System.Windows.Forms.Label LightWeaponEfficiencyName;
        private System.Windows.Forms.Label MaxEquipLoadName;
        private System.Windows.Forms.ComboBox EquippedWeaponBox;
        private System.Windows.Forms.Button SaveExitButton;
        private System.Windows.Forms.Button UseItemButton;
        private System.Windows.Forms.Label EquippedWeaponLabel;
        private System.Windows.Forms.Label RecoveryItemLabel;
        private System.Windows.Forms.ComboBox EquippedRecoveryBox;
        private System.Windows.Forms.Label EquippedTrinketLabel;
        private System.Windows.Forms.ComboBox EquippedTrinketBox;
        private System.Windows.Forms.Button OkayButton;
        private System.Windows.Forms.Button ShowWeaponButton;
        private System.Windows.Forms.Button ShowTrinketButton;
        private System.Windows.Forms.Button ShowRecoveryButton;
        private System.Windows.Forms.Label GameTimeLabel;
        private System.Windows.Forms.Label GameTimeName;
        private System.Windows.Forms.Label LevelLabel;
        private System.Windows.Forms.Label LevelName;
        private System.Windows.Forms.Label UsedItemLabel;
        private System.Windows.Forms.Label KillLabel;
        private System.Windows.Forms.Label UsedItemName;
        private System.Windows.Forms.Label KillName;
        private System.Windows.Forms.Button StatButton;
        private System.Windows.Forms.Label HPSeparator;
        private System.Windows.Forms.Label MaxHPLabel;
        private System.Windows.Forms.Button AttackButton;
        private System.Windows.Forms.Button EnemyStatButton;
        private System.Windows.Forms.TrackBar TextSpeedBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar ExperienceBar;
        private System.Windows.Forms.Label ExperienceName;
        private System.Windows.Forms.Button AgilityAddButton;
        private System.Windows.Forms.Button MindfulnessAddButton;
        private System.Windows.Forms.Button SharpnessAddButton;
        private System.Windows.Forms.Button ConstitutionAddButton;
        private System.Windows.Forms.Button DexterityAddButton;
        private System.Windows.Forms.Button StrengthAddButton;
        private System.Windows.Forms.Button HealthAddButton;
        private System.Windows.Forms.RichTextBox MainTextBox;
        private System.Windows.Forms.PictureBox EnemyPictureBox;
        private System.Windows.Forms.ProgressBar EnemyHealthBar;
    }
}