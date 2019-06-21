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
        //Vlad Hero
        public Hero hero { get; set; }

        private Bitmap Background = new Bitmap(Properties.Resources.BackgroundPic);

        public Sounds sounds;
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
            this.BackgroundImage = Properties.Resources.BackgroundPic;

            //Setting up the positioning of the New Game button
            StartNewGame.Left = (this.Width / 2) - (StartNewGame.Width/2);
            StartNewGame.Width = this.Width / 4;
            StartNewGame.Top = this.Top + (int)(label1.Height*1.8);


            //setting up the positioning of the  Instructions button
            InstructionButton.Left = (this.Width / 2) - (StartNewGame.Width / 2);
            InstructionButton.Width = this.Width / 4;
            InstructionButton.Top = StartNewGame.Top + (int)(label1.Height * 1.8);

            //setting up the positioning of the Quit Game button
            QuitGame.Left = (this.Width / 2) - (StartNewGame.Width / 2);
            QuitGame.Width = this.Width / 4;
            QuitGame.Top = InstructionButton.Top + (int)(label1.Height * 1.8);

            //setting up the positioning of the back game button
            BackButton.Width = this.Width / 4;


            SoundPlayer player = new SoundPlayer();


            hero = new Hero(new Point((int)this.Width/2 - 50, this.Height - 100));
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
            if (e.KeyCode == Keys.Escape)
            {
                WindowState = FormWindowState.Normal;
                FormBorderStyle = FormBorderStyle.FixedDialog;
            }
            if(e.KeyCode == Keys.Left)
            {
                hero.Move(Keys.Left,this.Width);
            }
            if (e.KeyCode == Keys.Right)
            {
                hero.Move(Keys.Right, this.Width);
            }

            if(e.KeyCode == Keys.X)
            {
                HeroBullet bullet = new HeroBullet(new Point(hero.Location.X + hero.HeroShipImg.Width/2 - 101,hero.Location.Y));
                hero.AddHeroBullet(bullet);
            }

            Invalidate(true);
        }

        private void QuitGame_Click(object sender, EventArgs e)
        {
            this.Close();
            sounds.playButtonClick();
        }

        private void StartNewGame_Click(object sender, EventArgs e)
        {
            buttonclicked();
            sounds.playButtonClick();
            sounds.playMainMusic();
            
            //Vlad Hero Ship is displayed
            hero.ShowHeroShip = true;

            Invalidate(true);
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

            label1.Visible = true;
            label1.Enabled = true;

            StartNewGame.Visible = true;
            StartNewGame.Enabled = true;

            InstructionButton.Visible = true;
            InstructionButton.Enabled = true;

            QuitGame.Visible = true;
            QuitGame.Enabled = true;

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

        //Vlad Paint Implementation for hero ship

        private void SpaceOdyssey_Paint(object sender, PaintEventArgs e)
        {
            if (hero.ShowHeroShip)
            {
                hero.Draw(e.Graphics);
            }
        }

        //Vlad Timer Tick for Hero Bullet
        private void HeroBulletTimer_Tick(object sender, EventArgs e)
        {
            foreach(HeroBullet bullet in hero.bullets)
            {
                bullet.UpdatePosition();
            }

            hero.CheckHeroBulletCollison();

            Invalidate(true);
        }
    }
}
