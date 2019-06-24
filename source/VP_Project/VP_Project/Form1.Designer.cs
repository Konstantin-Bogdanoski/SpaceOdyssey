namespace VP_Project
{
    partial class SpaceOdyssey
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
            this.label1 = new System.Windows.Forms.Label();
            this.StartNewGame = new System.Windows.Forms.Button();
            this.InstructionButton = new System.Windows.Forms.Button();
            this.QuitGame = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ResumeButton = new System.Windows.Forms.Button();
            this.NewGame = new System.Windows.Forms.Button();
            this.QtMainMenu = new System.Windows.Forms.Button();
            this.LoadGame = new System.Windows.Forms.Button();
            this.SaveGame = new System.Windows.Forms.Button();
            this.PickHero1 = new System.Windows.Forms.Button();
            this.PickHero2 = new System.Windows.Forms.Button();
            this.PickHero3 = new System.Windows.Forms.Button();
            this.PickHero4 = new System.Windows.Forms.Button();
            this.Heropicklabel = new System.Windows.Forms.Label();
            this.BacktoMM = new System.Windows.Forms.Button();
            this.HeroBulletTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 85.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(22, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1028, 146);
            this.label1.TabIndex = 0;
            this.label1.Text = "SpaceOdyssey";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartNewGame
            // 
            this.StartNewGame.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StartNewGame.AutoSize = true;
            this.StartNewGame.BackColor = System.Drawing.Color.Transparent;
            this.StartNewGame.FlatAppearance.BorderSize = 0;
            this.StartNewGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.StartNewGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.StartNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartNewGame.Font = new System.Drawing.Font("OCR A Extended", 49.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartNewGame.ForeColor = System.Drawing.Color.SeaGreen;
            this.StartNewGame.Location = new System.Drawing.Point(33, 148);
            this.StartNewGame.Margin = new System.Windows.Forms.Padding(2);
            this.StartNewGame.Name = "StartNewGame";
            this.StartNewGame.Size = new System.Drawing.Size(600, 79);
            this.StartNewGame.TabIndex = 1;
            this.StartNewGame.Text = "Start New Game";
            this.StartNewGame.UseVisualStyleBackColor = false;
            this.StartNewGame.Click += new System.EventHandler(this.StartNewGame_Click);
            this.StartNewGame.MouseEnter += new System.EventHandler(this.StartNewGame_MouseEnter);
            this.StartNewGame.MouseLeave += new System.EventHandler(this.StartNewGame_MouseLeave);
            // 
            // InstructionButton
            // 
            this.InstructionButton.AutoSize = true;
            this.InstructionButton.BackColor = System.Drawing.Color.Transparent;
            this.InstructionButton.FlatAppearance.BorderSize = 0;
            this.InstructionButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.InstructionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.InstructionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InstructionButton.Font = new System.Drawing.Font("OCR A Extended", 49.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.InstructionButton.Location = new System.Drawing.Point(33, 241);
            this.InstructionButton.Margin = new System.Windows.Forms.Padding(2);
            this.InstructionButton.Name = "InstructionButton";
            this.InstructionButton.Size = new System.Drawing.Size(520, 81);
            this.InstructionButton.TabIndex = 2;
            this.InstructionButton.Text = "Instructions";
            this.InstructionButton.UseVisualStyleBackColor = false;
            this.InstructionButton.Click += new System.EventHandler(this.InstructionButton_Click);
            this.InstructionButton.MouseEnter += new System.EventHandler(this.InstructionButton_MouseEnter);
            this.InstructionButton.MouseLeave += new System.EventHandler(this.InstructionButton_MouseLeave);
            // 
            // QuitGame
            // 
            this.QuitGame.AutoSize = true;
            this.QuitGame.BackColor = System.Drawing.Color.Transparent;
            this.QuitGame.FlatAppearance.BorderSize = 0;
            this.QuitGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.QuitGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.QuitGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuitGame.Font = new System.Drawing.Font("OCR A Extended", 49.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitGame.ForeColor = System.Drawing.Color.SeaGreen;
            this.QuitGame.Location = new System.Drawing.Point(33, 341);
            this.QuitGame.Margin = new System.Windows.Forms.Padding(2);
            this.QuitGame.Name = "QuitGame";
            this.QuitGame.Size = new System.Drawing.Size(400, 80);
            this.QuitGame.TabIndex = 3;
            this.QuitGame.Text = "Quit Game";
            this.QuitGame.UseVisualStyleBackColor = false;
            this.QuitGame.Click += new System.EventHandler(this.QuitGame_Click);
            this.QuitGame.MouseEnter += new System.EventHandler(this.QuitGame_MouseEnter);
            this.QuitGame.MouseLeave += new System.EventHandler(this.QuitGame_MouseLeave);
            // 
            // BackButton
            // 
            this.BackButton.AutoSize = true;
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.BackButton.Enabled = false;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("OCR A Extended", 49.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.BackButton.Location = new System.Drawing.Point(0, 146);
            this.BackButton.Margin = new System.Windows.Forms.Padding(2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(1028, 96);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Back to Main Menu";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Visible = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            this.BackButton.MouseEnter += new System.EventHandler(this.BackButton_MouseEnter);
            this.BackButton.MouseLeave += new System.EventHandler(this.BackButton_MouseLeave);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 16;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ResumeButton
            // 
            this.ResumeButton.AutoSize = true;
            this.ResumeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ResumeButton.BackColor = System.Drawing.Color.Transparent;
            this.ResumeButton.Enabled = false;
            this.ResumeButton.FlatAppearance.BorderSize = 0;
            this.ResumeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ResumeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ResumeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResumeButton.Font = new System.Drawing.Font("OCR A Extended", 34.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResumeButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.ResumeButton.Location = new System.Drawing.Point(936, 267);
            this.ResumeButton.Name = "ResumeButton";
            this.ResumeButton.Size = new System.Drawing.Size(200, 59);
            this.ResumeButton.TabIndex = 5;
            this.ResumeButton.Text = "Resume";
            this.ResumeButton.UseVisualStyleBackColor = false;
            this.ResumeButton.Visible = false;
            this.ResumeButton.Click += new System.EventHandler(this.ResumeButton_Click);
            this.ResumeButton.MouseEnter += new System.EventHandler(this.ResumeButton_MouseEnter);
            this.ResumeButton.MouseLeave += new System.EventHandler(this.ResumeButton_MouseLeave);
            // 
            // NewGame
            // 
            this.NewGame.AutoSize = true;
            this.NewGame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NewGame.BackColor = System.Drawing.Color.Transparent;
            this.NewGame.Enabled = false;
            this.NewGame.FlatAppearance.BorderSize = 0;
            this.NewGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.NewGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.NewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewGame.Font = new System.Drawing.Font("OCR A Extended", 34.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewGame.ForeColor = System.Drawing.Color.SeaGreen;
            this.NewGame.Location = new System.Drawing.Point(936, 355);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(256, 59);
            this.NewGame.TabIndex = 6;
            this.NewGame.Text = "New Game";
            this.NewGame.UseVisualStyleBackColor = false;
            this.NewGame.Visible = false;
            this.NewGame.MouseEnter += new System.EventHandler(this.NewGame_MouseEnter);
            this.NewGame.MouseLeave += new System.EventHandler(this.NewGame_MouseLeave);
            // 
            // QtMainMenu
            // 
            this.QtMainMenu.AutoSize = true;
            this.QtMainMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.QtMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.QtMainMenu.Enabled = false;
            this.QtMainMenu.FlatAppearance.BorderSize = 0;
            this.QtMainMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.QtMainMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.QtMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QtMainMenu.Font = new System.Drawing.Font("OCR A Extended", 34.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QtMainMenu.ForeColor = System.Drawing.Color.SeaGreen;
            this.QtMainMenu.Location = new System.Drawing.Point(753, 554);
            this.QtMainMenu.Name = "QtMainMenu";
            this.QtMainMenu.Size = new System.Drawing.Size(508, 59);
            this.QtMainMenu.TabIndex = 7;
            this.QtMainMenu.Text = "Quit to Main Menu";
            this.QtMainMenu.UseVisualStyleBackColor = false;
            this.QtMainMenu.Visible = false;
            this.QtMainMenu.Click += new System.EventHandler(this.QtMainMenu_Click);
            this.QtMainMenu.MouseEnter += new System.EventHandler(this.QtMainMenu_MouseEnter);
            this.QtMainMenu.MouseLeave += new System.EventHandler(this.QtMainMenu_MouseLeave);
            // 
            // LoadGame
            // 
            this.LoadGame.AutoSize = true;
            this.LoadGame.BackColor = System.Drawing.Color.Transparent;
            this.LoadGame.FlatAppearance.BorderSize = 0;
            this.LoadGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LoadGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.LoadGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadGame.Font = new System.Drawing.Font("OCR A Extended", 49.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadGame.ForeColor = System.Drawing.Color.SeaGreen;
            this.LoadGame.Location = new System.Drawing.Point(-91, 420);
            this.LoadGame.Name = "LoadGame";
            this.LoadGame.Size = new System.Drawing.Size(662, 100);
            this.LoadGame.TabIndex = 8;
            this.LoadGame.Text = "Load Game";
            this.LoadGame.UseVisualStyleBackColor = false;
            this.LoadGame.MouseEnter += new System.EventHandler(this.LoadGame_MouseEnter);
            this.LoadGame.MouseLeave += new System.EventHandler(this.LoadGame_MouseLeave);
            // 
            // SaveGame
            // 
            this.SaveGame.AutoSize = true;
            this.SaveGame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveGame.BackColor = System.Drawing.Color.Transparent;
            this.SaveGame.Enabled = false;
            this.SaveGame.FlatAppearance.BorderSize = 0;
            this.SaveGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SaveGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SaveGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveGame.Font = new System.Drawing.Font("OCR A Extended", 34.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveGame.ForeColor = System.Drawing.Color.SeaGreen;
            this.SaveGame.Location = new System.Drawing.Point(936, 463);
            this.SaveGame.Name = "SaveGame";
            this.SaveGame.Size = new System.Drawing.Size(284, 59);
            this.SaveGame.TabIndex = 9;
            this.SaveGame.Text = "Save Game";
            this.SaveGame.UseVisualStyleBackColor = false;
            this.SaveGame.Visible = false;
            this.SaveGame.MouseEnter += new System.EventHandler(this.SaveGame_MouseEnter);
            this.SaveGame.MouseLeave += new System.EventHandler(this.SaveGame_MouseLeave);
            // 
            // PickHero1
            // 
            this.PickHero1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PickHero1.BackColor = System.Drawing.Color.Transparent;
            this.PickHero1.BackgroundImage = global::VP_Project.Properties.Resources.HeroShip1_1;
            this.PickHero1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PickHero1.Enabled = false;
            this.PickHero1.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.PickHero1.FlatAppearance.BorderSize = 0;
            this.PickHero1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.PickHero1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.PickHero1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PickHero1.Location = new System.Drawing.Point(9, 17);
            this.PickHero1.Margin = new System.Windows.Forms.Padding(2);
            this.PickHero1.Name = "PickHero1";
            this.PickHero1.Size = new System.Drawing.Size(263, 305);
            this.PickHero1.TabIndex = 10;
            this.PickHero1.UseVisualStyleBackColor = false;
            this.PickHero1.Visible = false;
            this.PickHero1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PickHero1_MouseClick);
            this.PickHero1.MouseEnter += new System.EventHandler(this.PickHero1_MouseEnter);
            this.PickHero1.MouseLeave += new System.EventHandler(this.PickHero1_MouseLeave);
            // 
            // PickHero2
            // 
            this.PickHero2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PickHero2.BackColor = System.Drawing.Color.Transparent;
            this.PickHero2.BackgroundImage = global::VP_Project.Properties.Resources.HeroShip2;
            this.PickHero2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PickHero2.Enabled = false;
            this.PickHero2.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.PickHero2.FlatAppearance.BorderSize = 0;
            this.PickHero2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.PickHero2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.PickHero2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PickHero2.Location = new System.Drawing.Point(205, 32);
            this.PickHero2.Margin = new System.Windows.Forms.Padding(2);
            this.PickHero2.Name = "PickHero2";
            this.PickHero2.Size = new System.Drawing.Size(266, 286);
            this.PickHero2.TabIndex = 11;
            this.PickHero2.UseVisualStyleBackColor = false;
            this.PickHero2.Visible = false;
            this.PickHero2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PickHero2_MouseClick);
            this.PickHero2.MouseEnter += new System.EventHandler(this.PickHero2_MouseEnter);
            this.PickHero2.MouseLeave += new System.EventHandler(this.PickHero2_MouseLeave);
            // 
            // PickHero3
            // 
            this.PickHero3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PickHero3.BackColor = System.Drawing.Color.Transparent;
            this.PickHero3.BackgroundImage = global::VP_Project.Properties.Resources.HeroShip3;
            this.PickHero3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PickHero3.Enabled = false;
            this.PickHero3.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.PickHero3.FlatAppearance.BorderSize = 0;
            this.PickHero3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.PickHero3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.PickHero3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PickHero3.Location = new System.Drawing.Point(11, 246);
            this.PickHero3.Margin = new System.Windows.Forms.Padding(2);
            this.PickHero3.Name = "PickHero3";
            this.PickHero3.Size = new System.Drawing.Size(264, 285);
            this.PickHero3.TabIndex = 12;
            this.PickHero3.UseVisualStyleBackColor = false;
            this.PickHero3.Visible = false;
            this.PickHero3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PickHero3_MouseClick);
            this.PickHero3.MouseEnter += new System.EventHandler(this.PickHero3_MouseEnter);
            this.PickHero3.MouseLeave += new System.EventHandler(this.PickHero3_MouseLeave);
            // 
            // PickHero4
            // 
            this.PickHero4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PickHero4.BackColor = System.Drawing.Color.Transparent;
            this.PickHero4.BackgroundImage = global::VP_Project.Properties.Resources.HeroShip4;
            this.PickHero4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PickHero4.Enabled = false;
            this.PickHero4.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.PickHero4.FlatAppearance.BorderSize = 0;
            this.PickHero4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.PickHero4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.PickHero4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PickHero4.Location = new System.Drawing.Point(212, 246);
            this.PickHero4.Margin = new System.Windows.Forms.Padding(2);
            this.PickHero4.Name = "PickHero4";
            this.PickHero4.Size = new System.Drawing.Size(264, 285);
            this.PickHero4.TabIndex = 13;
            this.PickHero4.UseVisualStyleBackColor = false;
            this.PickHero4.Visible = false;
            this.PickHero4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PickHero4_MouseClick);
            this.PickHero4.MouseEnter += new System.EventHandler(this.PickHero4_MouseEnter);
            this.PickHero4.MouseLeave += new System.EventHandler(this.PickHero4_MouseLeave);
            // 
            // Heropicklabel
            // 
            this.Heropicklabel.BackColor = System.Drawing.Color.Transparent;
            this.Heropicklabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Heropicklabel.Enabled = false;
            this.Heropicklabel.Font = new System.Drawing.Font("OCR A Extended", 50F, System.Drawing.FontStyle.Italic);
            this.Heropicklabel.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.Heropicklabel.Location = new System.Drawing.Point(0, 242);
            this.Heropicklabel.Margin = new System.Windows.Forms.Padding(22, 0, 2, 0);
            this.Heropicklabel.Name = "Heropicklabel";
            this.Heropicklabel.Size = new System.Drawing.Size(1028, 146);
            this.Heropicklabel.TabIndex = 14;
            this.Heropicklabel.Text = "Pick your ship";
            this.Heropicklabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Heropicklabel.Visible = false;
            // 
            // BacktoMM
            // 
            this.BacktoMM.AutoSize = true;
            this.BacktoMM.BackColor = System.Drawing.Color.Transparent;
            this.BacktoMM.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BacktoMM.Enabled = false;
            this.BacktoMM.FlatAppearance.BorderSize = 0;
            this.BacktoMM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BacktoMM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BacktoMM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BacktoMM.Font = new System.Drawing.Font("OCR A Extended", 49.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BacktoMM.ForeColor = System.Drawing.Color.SeaGreen;
            this.BacktoMM.Location = new System.Drawing.Point(0, 513);
            this.BacktoMM.Margin = new System.Windows.Forms.Padding(2);
            this.BacktoMM.Name = "BacktoMM";
            this.BacktoMM.Size = new System.Drawing.Size(1028, 96);
            this.BacktoMM.TabIndex = 15;
            this.BacktoMM.Text = "Back to Main Menu";
            this.BacktoMM.UseVisualStyleBackColor = false;
            this.BacktoMM.Visible = false;
            this.BacktoMM.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BacktoMM_MouseClick);
            this.BacktoMM.MouseEnter += new System.EventHandler(this.BacktoMM_MouseEnter);
            this.BacktoMM.MouseLeave += new System.EventHandler(this.BacktoMM_MouseLeave);
            // 
            // HeroBulletTimer
            // 
            this.HeroBulletTimer.Enabled = true;
            this.HeroBulletTimer.Tick += new System.EventHandler(this.HeroBulletTimer_Tick);
            // 
            // SpaceOdyssey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VP_Project.Properties.Resources.BackgroundPic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.PickHero4);
            this.Controls.Add(this.PickHero3);
            this.Controls.Add(this.BacktoMM);
            this.Controls.Add(this.Heropicklabel);
            this.Controls.Add(this.PickHero2);
            this.Controls.Add(this.PickHero1);
            this.Controls.Add(this.SaveGame);
            this.Controls.Add(this.LoadGame);
            this.Controls.Add(this.QtMainMenu);
            this.Controls.Add(this.NewGame);
            this.Controls.Add(this.ResumeButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.QuitGame);
            this.Controls.Add(this.InstructionButton);
            this.Controls.Add(this.StartNewGame);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SpaceOdyssey";
            this.Text = "SpaceOdyssey";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SpaceOdyssey_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SpaceOdyssey_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SpaceOdyssey_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartNewGame;
        private System.Windows.Forms.Button InstructionButton;
        private System.Windows.Forms.Button QuitGame;
        
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Timer timer1;

        private System.Windows.Forms.Button ResumeButton;
        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.Button QtMainMenu;
        private System.Windows.Forms.Button LoadGame;
        private System.Windows.Forms.Button SaveGame;
        private System.Windows.Forms.Button PickHero1;
        private System.Windows.Forms.Button PickHero2;
        private System.Windows.Forms.Button PickHero3;
        private System.Windows.Forms.Button PickHero4;
        private System.Windows.Forms.Label Heropicklabel;
        private System.Windows.Forms.Button BacktoMM;
        private System.Windows.Forms.Timer HeroBulletTimer;
    }
}

