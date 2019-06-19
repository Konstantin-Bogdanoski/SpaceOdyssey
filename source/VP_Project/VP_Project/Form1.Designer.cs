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
            this.label1.Size = new System.Drawing.Size(835, 146);
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
            this.StartNewGame.Location = new System.Drawing.Point(44, 182);
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
            this.BackButton.Size = new System.Drawing.Size(835, 96);
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
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SpaceOdyssey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VP_Project.Properties.Resources.BackgroundPic;
            this.ClientSize = new System.Drawing.Size(835, 553);
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
    }
}

