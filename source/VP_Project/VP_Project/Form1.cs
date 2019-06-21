using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace VP_Project
{
    public partial class SpaceOdyssey : Form
    {
        private Bitmap Background = new Bitmap(Properties.Resources.BackgroundPic);

        public bool NewGameFlag;
        private Bitmap Background = new Bitmap(Properties.Resources.BackgroundPic);

        public void buttonclicked()
        {
            label1.Visible = false;
            label1.Enabled = false;

            StartNewGame.Visible = false;
            StartNewGame.Enabled = false;

            InstructionButton.Visible = false;
            InstructionButton.Enabled = false;

            QuitGame.Visible = false;
            QuitGame.Enabled = false;

            LoadGame.Visible = false;
            LoadGame.Enabled = false;
        }

        public void showMainMenu()
        {
            label1.Visible = true;
            label1.Enabled = true;

            StartNewGame.Visible = true;
            StartNewGame.Enabled = true;

            InstructionButton.Visible = true;
            InstructionButton.Enabled = true;

            QuitGame.Visible = true;
            QuitGame.Enabled = true;

            LoadGame.Visible = true;
            LoadGame.Enabled = true;
        }
        public void HidePauseMenu()
        {
            NewGame.Visible = false;
            NewGame.Enabled = false;

            ResumeButton.Visible = false;
            ResumeButton.Enabled = false;

            QtMainMenu.Visible = false;
            QtMainMenu.Enabled = false;

            SaveGame.Visible = false;
            SaveGame.Enabled = false;
        }
        public SpaceOdyssey()
        {
            InitializeComponent();
            DoubleBuffered = true;
            this.KeyPreview = true;
            // set width and height to resolution width and height
            this.Width = SystemInformation.VirtualScreen.Width;
            this.Height = SystemInformation.VirtualScreen.Height;

            Background.SetResolution(this.Width, this.Height);
            this.BackgroundImage = Background;

            // make the form fullscreen
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            // Setting the positioning of the title
            label1.Left = this.Width/2;

            //setting background image
            Background.SetResolution(1200, Height);
            this.BackgroundImage = Background;
            //Setting up the positioning of the New Game button
            StartNewGame.Left = (this.Width / 2) - (StartNewGame.Width/2);
            StartNewGame.Width = this.Width / 4;
            StartNewGame.Top = this.Top + (int)(label1.Height * 1.3);


            LoadGame.Left = (this.Width / 2) - (StartNewGame.Width / 2);
            LoadGame.Width = this.Width / 4;
            LoadGame.Top = StartNewGame.Top + (int)(label1.Height * 1.3);

            //setting up the positioning of the  Instructions button
            InstructionButton.Left = (this.Width / 2) - (StartNewGame.Width / 2);
            InstructionButton.Width = this.Width / 4;
            InstructionButton.Top = LoadGame.Top + (int)(label1.Height * 1.3);

            //setting up the positioning of the Quit Game button
            QuitGame.Left = (this.Width / 2) - (StartNewGame.Width / 2);
            QuitGame.Width = this.Width / 4;
            QuitGame.Top = InstructionButton.Top + (int)(label1.Height * 1.3);

            // Pause Menu Resume Button
            ResumeButton.Left = (this.Width / 2) - ResumeButton.Width;
            ResumeButton.Width = this.Width / 4;
            ResumeButton.Top = this.Top + (label1.Height);

            //pause menu new game button
            NewGame.Left = (this.Width / 2) - ResumeButton.Width;
            NewGame.Width = this.Width / 4;
            NewGame.Top = ResumeButton.Top + (label1.Height);

            //save menu game button position
            SaveGame.Left = (this.Width / 2) - ResumeButton.Width;
            SaveGame.Width = this.Width / 4;
            SaveGame.Top = NewGame.Top + (label1.Height);

            //pause menu quit button
            QtMainMenu.Left = (this.Width / 2) - ResumeButton.Width;
            QtMainMenu.Width = this.Width / 4;
            QtMainMenu.Top = SaveGame.Top +(label1.Height);


            //setting up the positioning of the back game button
            BackButton.Width = this.Width / 4;

            SoundPlayer player = new SoundPlayer();
            sounds = new Sounds();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void StartNewGame_MouseEnter(object sender, EventArgs e)
        {
            StartNewGame.Width += 40;
            StartNewGame.Height += 40;
            StartNewGame.FlatAppearance.BorderSize = 4;
            StartNewGame.FlatAppearance.BorderColor = Color.SeaGreen;
            
        }

        private void StartNewGame_MouseLeave(object sender, EventArgs e)
        {
            StartNewGame.Width -= 40;
            StartNewGame.Height -= 40;
            StartNewGame.FlatAppearance.BorderSize = 0;
        }

        private void InstructionButton_MouseEnter(object sender, EventArgs e)
        {
            InstructionButton.Width += 40;
            InstructionButton.Height += 40;
            InstructionButton.FlatAppearance.BorderSize = 4;
            InstructionButton.FlatAppearance.BorderColor = Color.SeaGreen;
        }

        private void InstructionButton_MouseLeave(object sender, EventArgs e)
        {
            InstructionButton.Width -= 40;
            InstructionButton.Height -= 40;
            InstructionButton.FlatAppearance.BorderSize = 0;
        }

        private void QuitGame_MouseEnter(object sender, EventArgs e)
        {
            QuitGame.Width += 40;
            QuitGame.Height += 40;
            QuitGame.FlatAppearance.BorderSize = 4;
            QuitGame.FlatAppearance.BorderColor = Color.SeaGreen;
        }

        private void QuitGame_MouseLeave(object sender, EventArgs e)
        {
            QuitGame.Width -= 40;
            QuitGame.Height -= 40;
            QuitGame.FlatAppearance.BorderSize = 0;
        }

        private void SpaceOdyssey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && NewGameFlag)
            {
                timer1.Stop();
                NewGame.Visible = true;
                NewGame.Enabled = true;

                ResumeButton.Visible = true;
                ResumeButton.Enabled = true;

                QtMainMenu.Visible = true;
                QtMainMenu.Enabled = true;

                SaveGame.Visible = true;
                SaveGame.Enabled = true;
            }

            Invalidate(true);
        }

        private void QuitGame_Click(object sender, EventArgs e)
        {
            this.Close();
            sounds.playButtonClick();
        }

        private void StartNewGame_Click(object sender, EventArgs e) // STARTED NEW GAME
        {
            buttonclicked();
            sounds.playButtonClick();
            sounds.playMainMusic();
            NewGameFlag = true;
        }

        private void InstructionButton_Click(object sender, EventArgs e)
        {

            buttonclicked();
            sounds.playButtonClick();
            BackButton.Visible = true;
            BackButton.Enabled = true;         
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            sounds.playButtonClick();

            showMainMenu();

            BackButton.Enabled = false;
            BackButton.Visible = false;

        }

        private void BackButton_MouseEnter(object sender, EventArgs e)
        {
            BackButton.Width += 40;
            BackButton.Height += 40;
            BackButton.FlatAppearance.BorderSize = 4;
            BackButton.FlatAppearance.BorderColor = Color.SeaGreen;
        }

        private void BackButton_MouseLeave(object sender, EventArgs e)
        {
            BackButton.Width -= 40;
            BackButton.Height -= 40;
            BackButton.FlatAppearance.BorderSize = 0;
        }

        private void SpaceOdyssey_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

        }

        private void ResumeButton_MouseEnter(object sender, EventArgs e)
        {
            ResumeButton.Width += 40;
            ResumeButton.Height += 40;
            ResumeButton.FlatAppearance.BorderSize = 4;
            ResumeButton.FlatAppearance.BorderColor = Color.SeaGreen;
        }

        private void ResumeButton_MouseLeave(object sender, EventArgs e)
        {
            ResumeButton.Width -= 40;
            ResumeButton.Height -= 40;
            ResumeButton.FlatAppearance.BorderSize = 0;
        }

        private void NewGame_MouseEnter(object sender, EventArgs e)
        {
            NewGame.Width += 40;
            NewGame.Height += 40;
            NewGame.FlatAppearance.BorderSize = 4;
            NewGame.FlatAppearance.BorderColor = Color.SeaGreen;
        }

        private void NewGame_MouseLeave(object sender, EventArgs e)
        {
            NewGame.Width -= 40;
            NewGame.Height -= 40;
            NewGame.FlatAppearance.BorderSize = 0;
        }

        private void QtMainMenu_MouseEnter(object sender, EventArgs e)
        {
            QtMainMenu.Width += 40;
            QtMainMenu.Height += 40;
            QtMainMenu.FlatAppearance.BorderSize = 4;
            QtMainMenu.FlatAppearance.BorderColor = Color.SeaGreen;
        }

        private void QtMainMenu_MouseLeave(object sender, EventArgs e)
        {
            QtMainMenu.Width -= 40;
            QtMainMenu.Height -= 40;
            QtMainMenu.FlatAppearance.BorderSize = 0;
        }

        private void ResumeButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
            HidePauseMenu();
        }

        private void QtMainMenu_Click(object sender, EventArgs e)
        {
            HidePauseMenu();
            showMainMenu();  
        }

        private void LoadGame_MouseEnter(object sender, EventArgs e)
        {
            LoadGame.Width += 40;
            LoadGame.Height += 40;
            LoadGame.FlatAppearance.BorderSize = 4;
            LoadGame.FlatAppearance.BorderColor = Color.SeaGreen;
        }

        private void LoadGame_MouseLeave(object sender, EventArgs e)
        {
            LoadGame.Width -= 40;
            LoadGame.Height -= 40;
            LoadGame.FlatAppearance.BorderSize = 0;
        }

        private void SaveGame_MouseEnter(object sender, EventArgs e)
        {
            SaveGame.Width += 40;
            SaveGame.Height += 40;
            SaveGame.FlatAppearance.BorderSize = 4;
            SaveGame.FlatAppearance.BorderColor = Color.SeaGreen;
        }

        private void SaveGame_MouseLeave(object sender, EventArgs e)
        {
            SaveGame.Width -= 40;
            SaveGame.Height -= 40;
            SaveGame.FlatAppearance.BorderSize = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
