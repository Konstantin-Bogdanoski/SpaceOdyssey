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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 85.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1432, 146);
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
            this.StartNewGame.Location = new System.Drawing.Point(80, 204);
            this.StartNewGame.Name = "StartNewGame";
            this.StartNewGame.Size = new System.Drawing.Size(747, 96);
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
            this.InstructionButton.Location = new System.Drawing.Point(44, 297);
            this.InstructionButton.Name = "InstructionButton";
            this.InstructionButton.Size = new System.Drawing.Size(662, 100);
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
            this.QuitGame.Location = new System.Drawing.Point(44, 420);
            this.QuitGame.Name = "QuitGame";
            this.QuitGame.Size = new System.Drawing.Size(507, 98);
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
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(1432, 96);
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
            this.ResumeButton.Size = new System.Drawing.Size(245, 70);
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
            this.NewGame.Size = new System.Drawing.Size(315, 70);
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
            this.QtMainMenu.Size = new System.Drawing.Size(630, 70);
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
            this.LoadGame.Location = new System.Drawing.Point(44, 524);
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
            this.SaveGame.Size = new System.Drawing.Size(350, 70);
            this.SaveGame.TabIndex = 9;
            this.SaveGame.Text = "Save Game";
            this.SaveGame.UseVisualStyleBackColor = false;
            this.SaveGame.Visible = false;
            this.SaveGame.MouseEnter += new System.EventHandler(this.SaveGame_MouseEnter);
            this.SaveGame.MouseLeave += new System.EventHandler(this.SaveGame_MouseLeave);
            // 
            // SpaceOdyssey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VP_Project.Properties.Resources.BackgroundPic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1432, 719);
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
            this.Name = "SpaceOdyssey";
            this.Text = "SpaceOdyssey";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SpaceOdyssey_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SpaceOdyssey_KeyDown);
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

    }
}

