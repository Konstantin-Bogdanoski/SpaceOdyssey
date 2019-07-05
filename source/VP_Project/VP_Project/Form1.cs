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
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace VP_Project
{
    public partial class SpaceOdyssey : Form
    {
        public Game Game { get; set; }
        private Bitmap Background = new Bitmap(Properties.Resources.BackgroundPic);
        private Sounds sounds;
        public string FileName { get; set; }
        private int enemyTimerCounter;

        public bool PickedHeroFlag;

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
        public void HidePickHeroUI()
        {
            PickedHeroFlag = true;
            PickHero1.Visible = false;
            PickHero1.Enabled = false;

            PickHero2.Visible = false;
            PickHero2.Enabled = false;

            PickHero3.Visible = false;
            PickHero3.Enabled = false;

            PickHero4.Visible = false;
            PickHero4.Enabled = false;

            Heropicklabel.Visible = false;
            Heropicklabel.Enabled = false;

            BacktoMM.Visible = false;
            BacktoMM.Enabled = false;
        }
        public SpaceOdyssey()
        {
            InitializeComponent();
            DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.KeyPreview = true;
            MissionDebriefTB.Multiline = true;
            // set width and height to resolution width and height
            this.Width = SystemInformation.PrimaryMonitorSize.Width;
            this.Height = SystemInformation.PrimaryMonitorSize.Height;

            GameOverLabel.Visible = false;
            GameOverLabel.Enabled = false;

            enemyTimerCounter = 0;

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
            StartNewGame.Top = this.Top + this.Height/5;


            LoadGame.Left = (this.Width / 2) - (StartNewGame.Width / 2);
            LoadGame.Width = this.Width / 4;
            LoadGame.Top = StartNewGame.Top + this.Height / 5;

            //setting up the positioning of the  Instructions button
            InstructionButton.Left = (this.Width / 2) - (StartNewGame.Width / 2);
            InstructionButton.Width = this.Width / 4;
            InstructionButton.Top = LoadGame.Top + this.Height / 5;

            //setting up the positioning of the Quit Game button
            QuitGame.Left = (this.Width / 2) - (StartNewGame.Width / 2);
            QuitGame.Width = this.Width / 4;
            QuitGame.Top = InstructionButton.Top + this.Height / 5;

            // Pause Menu Resume Button
            ResumeButton.Left = (this.Width / 2) - ResumeButton.Width;
            ResumeButton.Width = this.Width / 4;
            ResumeButton.Top = this.Top + this.Height / 5;

            //pause menu new game button
            NewGame.Left = (this.Width / 2) - ResumeButton.Width;
            NewGame.Width = this.Width / 4;
            NewGame.Top = ResumeButton.Top + this.Height / 5;

            //save menu game button position
            SaveGame.Left = (this.Width / 2) - ResumeButton.Width;
            SaveGame.Width = this.Width / 4;
            SaveGame.Top = NewGame.Top + this.Height / 5;

            //pause menu quit button
            QtMainMenu.Left = (this.Width / 2) - ResumeButton.Width;
            QtMainMenu.Width = this.Width / 4;
            QtMainMenu.Top = SaveGame.Top + this.Height / 5;


            //setting up the positioning of the back game button
            BackButton.Width = this.Width / 4;

            //pick hero1 button placement
            PickHero1.Left = (this.Width / 3) - PickHero1.Width;
            PickHero1.Top = this.Height / 5;
            PickHero1.Width = this.Height / 4;
            PickHero1.Height = this.Height / 4;
            //pick hero2 button placement
            PickHero2.Left = (this.Width) - PickHero1.Width*2;
            PickHero2.Top = this.Height / 5;
            PickHero2.Width = this.Height / 4;
            PickHero2.Height = this.Height / 4;

            //pick hero3 button placement
            PickHero3.Left = (this.Width/3) - PickHero3.Width;
            PickHero3.Top = PickHero2.Height + this.Height / 5 + PickHero3.Height / 2;
            PickHero3.Width = this.Height / 4;
            PickHero3.Height = this.Height / 4;

            //pick hero4 button placement
            PickHero4.Left = (this.Width) - PickHero1.Width * 2;
            PickHero4.Top = PickHero2.Height + this.Height / 5 + PickHero4.Height/2;
            PickHero4.Width = this.Height / 4;
            PickHero4.Height = this.Height / 4;

            //End Game Labels
            ShipStateLabel.Left = 1;
            ShipStateLabel.Top = GameOverLabel.Height + ShipStateLabel.Height;
            ShipStateTB.Left = ShipStateLabel.Width;
            ShipStateTB.Top = GameOverLabel.Height + ShipStateLabel.Height;
            ShipStateTB.Width = this.Width / 6;

            PilotStateLabel.Left = 1;
            PilotStateLabel.Top = ShipStateLabel.Top + PilotStateLabel.Height;
            PilotStateTB.Left = PilotStateLabel.Width;
            PilotStateTB.Top = ShipStateLabel.Top + PilotStateLabel.Height;
            PilotStateTB.Width = this.Width / 6;

            MissionDebriefLabel.Left = 1;
            MissionDebriefLabel.Top = PilotStateLabel.Top + MissionDebriefLabel.Height;
            MissionDebriefTB.Left =1;
            MissionDebriefTB.Top = MissionDebriefLabel.Top + MissionDebriefLabel.Height;
            MissionDebriefTB.Width = this.Width/2;
            MissionDebriefTB.Height = this.Height / 2;
            

            MissionLabel.Left = 1;
            MissionLabel.Top = MissionDebriefTB.Top + MissionDebriefTB.Height;
            MissionTB.Left = MissionLabel.Width;
            MissionTB.Top = MissionDebriefTB.Top +  MissionDebriefTB.Height;
            MissionTB.Width = this.Width / 6;


            EndGameNewGameButton.Left = this.Width / 2 + EndGameNewGameButton.Width;
            EndGameNewGameButton.Top = GameOverLabel.Height + EndGameNewGameButton.Height;

            EndGameQuitGameButton.Left = this.Width / 2 + EndGameNewGameButton.Width;
            EndGameQuitGameButton.Top = EndGameNewGameButton.Top * 2 + EndGameQuitGameButton.Height;

            //FileName property initializing
            FileName = null;

            //positioning hero and boss health
            HeroHealth.Width = this.Width / 6;
            HeroHealth.Left = this.Width - HeroHealth.Width;
            HeroHealth.Top = this.Height;


            BossHealth.Width = this.Width / 6;
            BossHealth.Left = this.Width - HeroHealth.Width;
            BossHealth.Top = BossHealth.Height;

            //instruction positioning
            MovementLabel.Top = BackButton.Height + MovementLabel.Height;
            MovementLabel.Left = 1;
            Shootlabel.Top = MovementLabel.Top + BackButton.Height;
            Shootlabel.Left = 1;
            DodgingLabel.Top = Shootlabel.Top + BackButton.Height;
            DodgingLabel.Left = 1;

            Game = new Game(this.Width, this.Height);
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
            e.SuppressKeyPress = true;
            if (e.KeyCode == Keys.Escape && PickedHeroFlag)
            {
                timer1.Stop();
                HeroBulletTimer.Stop();
                Game.Hero.ShowHeroShip = false;

                NewGame.Visible = true;
                NewGame.Enabled = true;

                ResumeButton.Visible = true;
                ResumeButton.Enabled = true;

                QtMainMenu.Visible = true;
                QtMainMenu.Enabled = true;

                SaveGame.Visible = true;
                SaveGame.Enabled = true;

                HeroHealth.Visible = false;
                HeroHealth.Enabled = false;

                BossHealth.Visible = false;
                BossHealth.Enabled = false;

            }

            else if (e.KeyCode == Keys.A)
            {
                Game.Hero.Move(Keys.Left, this.Width);
                foreach (HeroBullet bullet in Game.Hero.bullets)
                {
                    bullet.UpdatePosition();
                }
            }

            else if (e.KeyCode == Keys.D)
            {
                Game.Hero.Move(Keys.Right, this.Width);
                foreach (HeroBullet bullet in Game.Hero.bullets)
                {
                    bullet.UpdatePosition();
                }
            }

            else if (e.KeyCode == Keys.G)
            {
                Game.Boss.Health -= 25;
            }

            Game.CheckBulletsImpact();
            Game.CheckMeteorImpact();
            Game.MoveEnemies();
            Game.MoveMeteors();
            Game.MoveBoss();

            if (Game.Hero.Health >= 0)
                HeroHealth.Value = Game.Hero.Health;
            else
                GameOverTimer_Tick(sender, e);

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
            Game = new Game(this.Width, this.Height);
            sounds.playButtonClick();
            sounds.playMainMusic();

            Heropicklabel.Visible = true;
            Heropicklabel.Enabled = true;
            PickHero1.Visible = true;
            PickHero1.Enabled = true;

            PickHero2.Visible = true;
            PickHero2.Enabled = true;

            PickHero3.Visible = true;
            PickHero3.Enabled = true;

            PickHero4.Visible = true;
            PickHero4.Enabled = true;

            BacktoMM.Visible = true;
            BacktoMM.Enabled = true;

        }

        private void InstructionButton_Click(object sender, EventArgs e)
        {

            buttonclicked();
            sounds.playButtonClick();
            BackButton.Visible = true;
            BackButton.Enabled = true;

            Shootlabel.Visible = true;
            Shootlabel.Enabled = true;

            DodgingLabel.Visible = true;
            DodgingLabel.Enabled = true;
            
            MovementLabel.Visible = true;
            MovementLabel.Enabled = true;

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            sounds.playButtonClick();

            showMainMenu();

            BackButton.Enabled = false;
            BackButton.Visible = false;

            Shootlabel.Visible = false;
            Shootlabel.Enabled = false;

            DodgingLabel.Visible = false;
            DodgingLabel.Enabled = false;

            MovementLabel.Visible = false;
            MovementLabel.Enabled = false;

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
            Game.Draw(e.Graphics);
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
            Game.Hero.ShowHeroShip = true;
            HeroBulletTimer.Start();
            timer1.Start();
            HidePauseMenu();
            HeroHealth.Visible = true;
            HeroHealth.Enabled = true;
            BossHealth.Visible = true;
            BossHealth.Enabled = true;

        }

        private void QtMainMenu_Click(object sender, EventArgs e)
        {
            HidePauseMenu();
            showMainMenu();
            HeroHealth.Visible = false;
            HeroHealth.Enabled = false;
            BossHealth.Visible = false;
            BossHealth.Enabled = false;
            PickedHeroFlag = false;
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

        private void SaveGame_Click(object sender, EventArgs e)
        {
            
            //FileName = null;
            if (FileName is null)
            {
                SaveFileDialog sv = new SaveFileDialog();
                sv.Filter = "SpaceOdyssey(*.so)|*.so";
                sv.Title = "Save a SpaceOdyssey Game";
                if (sv.ShowDialog() == DialogResult.OK)
                {
                    FileName = sv.FileName;
                }
            }
            if (!(FileName is null))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileStream stream = new FileStream(FileName, FileMode.Create, FileAccess.Write, FileShare.None);
                binaryFormatter.Serialize(stream, Game);
                stream.Close();
            }
            this.Text = FileName;
            this.FileName = null;
            Invalidate(true);
        }

        private void LoadGame_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "SpaceOdyssey(*.so)|*.so";
            ofd.Title = "Load a SpaceOdyssey Game";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileName = ofd.FileName;
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileStream stream = new FileStream(FileName, FileMode.Open, FileAccess.Read, FileShare.None);
                Game = (Game)binaryFormatter.Deserialize(stream);
                stream.Close();
                PickedHeroFlag = true;
                HeroHealth.Enabled = true;
                HeroHealth.Visible = true;
                timer1.Start();
                HeroBulletTimer.Start();
                buttonclicked();
                Game.Hero.ShowHeroShip = true;
            }
            //this.Text = FileName;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Game.Hero.Health >= 0)
                HeroHealth.Value = Game.Hero.Health;
            enemyTimerCounter++;

            if (Game.Level == 2)
                Game.TimeCounter--;

            if (enemyTimerCounter % 2 == 0 && Game.Level == 2 && Game.Enemies.Count == 0)
            {
                Game.TimeCounter--;
                enemyTimerCounter = 0;
                Game.addMeteor();
                Game.NextLevel();
            }

            if(enemyTimerCounter == 20 && Game.Level == 1)
            {
                enemyTimerCounter = 0;
                Game.addEnemy();
                Game.addMeteor();
            }
            Game.MoveEnemies();
            Game.MoveMeteors();
            Game.MoveBoss();

            if(Game.Level == 3 && Game.Boss.Health>0)
            {
                BossHealth.Visible = true;
                BossHealth.Enabled = true;
                BossHealth.Value = Game.Boss.Health;
            }

            if (Game.Hero.Health <= 0 || Game.Boss.Health <= 0)
            {
                Game.GameOver();
                HeroHealth.Visible = false;
                HeroHealth.Enabled = false;
                BossHealth.Visible = false;
                BossHealth.Enabled = false;
                GameOverTimer.Start();
                GameOverLabel.Visible = true;
                GameOverLabel.Enabled = true;

            }

            Game.CheckBulletsImpact();
            Game.CheckMeteorImpact();
        }

        private void BacktoMM_MouseEnter(object sender, EventArgs e)
        {
            BacktoMM.FlatAppearance.BorderSize = 4;
            BacktoMM.FlatAppearance.BorderColor = Color.SeaGreen;
        }

        private void BacktoMM_MouseLeave(object sender, EventArgs e)
        {
            BacktoMM.FlatAppearance.BorderSize = 0;
        }

        private void PickHero1_MouseClick(object sender, MouseEventArgs e)
        {
            HidePickHeroUI();
            Game.Hero.HeroShipImg = VP_Project.Properties.Resources.HeroShip1_1;
            Game.Hero.ShowHeroShip = true;
            HeroBulletTimer.Start();
            timer1.Start();
            HeroHealth.Enabled=true;
            HeroHealth.Visible=true;
            PickedHeroFlag = true;
            HeroHealth.Value = Game.Hero.Health;
            
        }

        private void PickHero1_MouseEnter(object sender, EventArgs e)
        {
            PickHero1.FlatAppearance.BorderSize = 4;
            PickHero1.FlatAppearance.BorderColor = Color.SeaGreen;
        }

        private void PickHero1_MouseLeave(object sender, EventArgs e)
        {
            PickHero1.FlatAppearance.BorderSize = 0;
        }

        private void PickHero2_MouseClick(object sender, MouseEventArgs e)
        {
            HidePickHeroUI();
            Game.Hero.HeroShipImg = VP_Project.Properties.Resources.HeroShip2;
            Game.Hero.ShowHeroShip = true;
            HeroHealth.Enabled = true;
            HeroHealth.Visible = true;
            PickedHeroFlag = true;
            HeroBulletTimer.Start();
            timer1.Start();
            HeroHealth.Value = Game.Hero.Health;
        }

        private void PickHero2_MouseEnter(object sender, EventArgs e)
        {
            PickHero2.FlatAppearance.BorderSize = 4;
            PickHero2.FlatAppearance.BorderColor = Color.SeaGreen;
        }

        private void PickHero2_MouseLeave(object sender, EventArgs e)
        {
            PickHero2.FlatAppearance.BorderSize = 0;
        }

        private void PickHero3_MouseClick(object sender, MouseEventArgs e)
        {
            HidePickHeroUI();
            Game.Hero.HeroShipImg = VP_Project.Properties.Resources.HeroShip3;
            Game.Hero.ShowHeroShip = true;
            HeroHealth.Enabled = true;
            HeroHealth.Visible = true;
            PickedHeroFlag = true;
            HeroBulletTimer.Start();
            timer1.Start();
            HeroHealth.Value = Game.Hero.Health;
        }

        private void PickHero3_MouseEnter(object sender, EventArgs e)
        {
            PickHero3.FlatAppearance.BorderSize = 4;
            PickHero3.FlatAppearance.BorderColor = Color.SeaGreen;
        }

        private void PickHero3_MouseLeave(object sender, EventArgs e)
        {
            PickHero3.FlatAppearance.BorderSize = 0;
        }

        private void PickHero4_MouseClick(object sender, MouseEventArgs e)
        {
            HidePickHeroUI();
            Game.Hero.HeroShipImg = VP_Project.Properties.Resources.HeroShip4;
            Game.Hero.ShowHeroShip = true;
            HeroHealth.Enabled = true;
            HeroHealth.Visible = true;
            PickedHeroFlag = true;
            HeroBulletTimer.Start();
            timer1.Start();
            HeroHealth.Value = Game.Hero.Health;
        }

        private void PickHero4_MouseEnter(object sender, EventArgs e)
        {
            PickHero4.FlatAppearance.BorderSize = 4;
            PickHero4.FlatAppearance.BorderColor = Color.SeaGreen;
        }

        private void PickHero4_MouseLeave(object sender, EventArgs e)
        {
            PickHero4.FlatAppearance.BorderSize = 0;
        }

        private void BacktoMM_MouseClick(object sender, MouseEventArgs e)
        {
            HidePickHeroUI();
            showMainMenu();
        }

        private void HeroBulletTimer_Tick(object sender, EventArgs e)
        {
            foreach (HeroBullet bullet in Game.Hero.bullets)
            {
                bullet.UpdatePosition();
            }

            Game.Hero.CheckHeroBulletCollison();

            Invalidate(true);
        }

        private void SpaceOdyssey_MouseClick(object sender, MouseEventArgs e)
        {
            HeroBullet bullet = new HeroBullet(new Point(Game.Hero.Location.X + Game.Hero.HeroShipImg.Width / 2 - 101, Game.Hero.Location.Y));
            Game.Hero.AddHeroBullet(bullet);

            foreach (HeroBullet bullet1 in Game.Hero.bullets)
            {
                bullet1.UpdatePosition();
            }
        }

        private void GameOverTimer_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            PickedHeroFlag = false;
            string Shipstate = "DESTROYED";
            string Pilotstate = "KIA";
            string Missiondebrief = "Due to the sheer number of enemies and unforseen space debries, the mission to intercept and deflect the incoming invasion has ended in failure" +
                "\n Your valiant effort and sacrifice will not be forgotten";
            string Missionend = "FAILED";

            // WON
            string ShipstateWon = "FUNCTIONAL"; 
            string PilotStateWon = "ALIVE";
            string MissionDebriefWon = "We have witnessed history, through your brave and gallant effort, the mission to intercept and deflect the incoming invasion was a success" +
                "\n Prepare yourself for the media, HERO";
            string MissionendWon = "SUCCESS";


            
            EndGameNewGameButton.Enabled = true;
            EndGameNewGameButton.Visible = true;

            EndGameQuitGameButton.Enabled = true;
            EndGameQuitGameButton.Visible = true;

            ShipStateLabel.Visible = true;
            ShipStateLabel.Enabled = true;

            PilotStateLabel.Visible = true;
            PilotStateLabel.Enabled = true;

            MissionDebriefLabel.Visible = true;
            MissionDebriefLabel.Enabled = true;

            MissionLabel.Visible = true;
            MissionLabel.Enabled = true;


            ShipStateTB.Visible = true;
            ShipStateTB.Enabled = true;

            PilotStateTB.Visible = true;
            PilotStateTB.Enabled = true;

            MissionDebriefTB.Visible = true;
            MissionDebriefTB.Enabled = true;

            MissionTB.Visible = true;
            MissionTB.Enabled = true;

            if (Game.Hero.Health <= 0)
            {
                for (int i = 0; i < Shipstate.Length; i++)
                {
                    Invoke(new MethodInvoker(delegate { ShipStateTB.AppendText(Shipstate[i].ToString()); }));
                    System.Threading.Thread.Sleep(150);
                    if (i == Shipstate.Length - 1) break;
                }

                for (int i = 0; i < Pilotstate.Length; i++)
                {
                    Invoke(new MethodInvoker(delegate { PilotStateTB.AppendText(Pilotstate[i].ToString()); }));
                    System.Threading.Thread.Sleep(150);
                    if (i == Pilotstate.Length - 1) break;
                }

                for (int i = 0; i < Missiondebrief.Length; i++)
                {
                    Invoke(new MethodInvoker(delegate { MissionDebriefTB.AppendText(Missiondebrief[i].ToString()); }));
                    System.Threading.Thread.Sleep(10);
                    if (i == Missiondebrief.Length - 1) break;
                }

                for (int i = 0; i < Missionend.Length; i++)
                {
                    Invoke(new MethodInvoker(delegate { MissionTB.AppendText(Missionend[i].ToString()); }));
                    System.Threading.Thread.Sleep(150);
                    Game.Hero.Health = 100;
                    if (i == Missionend.Length - 1) break;
                }
            }
            else if (Game.Boss.Health <= 0)
            {
                for (int i = 0; i < ShipstateWon.Length; i++)
                {
                    Invoke(new MethodInvoker(delegate { ShipStateTB.AppendText(ShipstateWon[i].ToString()); }));
                    System.Threading.Thread.Sleep(150);
                    if (i == ShipstateWon.Length - 1) break;
                }

                for (int i = 0; i < PilotStateWon.Length; i++)
                {
                    Invoke(new MethodInvoker(delegate { PilotStateTB.AppendText(PilotStateWon[i].ToString()); }));
                    System.Threading.Thread.Sleep(150);
                    if (i == PilotStateWon.Length - 1) break;
                }

                for (int i = 0; i < MissionDebriefWon.Length; i++)
                {
                    Invoke(new MethodInvoker(delegate { MissionDebriefTB.AppendText(MissionDebriefWon[i].ToString()); }));
                    System.Threading.Thread.Sleep(10);
                    if (i == MissionDebriefWon.Length - 1) break;
                }

                for (int i = 0; i < MissionendWon.Length; i++)
                {
                    Invoke(new MethodInvoker(delegate { MissionTB.AppendText(MissionendWon[i].ToString()); }));
                    System.Threading.Thread.Sleep(150);
                    Game.Boss.Health = 150;
                    if (i == MissionendWon.Length - 1) break;
                }
            }
            GameOverTimer.Stop();
        }

        private void EndGameNewGameButton_Click(object sender, EventArgs e)
        {
            PickedHeroFlag = false;
            GameOverLabel.Visible = false;
            GameOverLabel.Enabled = false;

            MissionLabel.Visible = false;
            MissionLabel.Enabled = false;

            EndGameQuitGameButton.Visible = false;
            EndGameQuitGameButton.Enabled = false;

            EndGameNewGameButton.Visible = false;
            EndGameNewGameButton.Enabled = false;

            ShipStateLabel.Visible = false;
            ShipStateLabel.Enabled = false;

            PilotStateLabel.Visible = false;
            PilotStateLabel.Enabled = false;

            MissionDebriefLabel.Visible = false;
            MissionDebriefLabel.Enabled = false;

            ShipStateTB.Visible = false;
            ShipStateTB.Enabled = false;

            PilotStateTB.Visible = false;
            PilotStateTB.Enabled = false;

            MissionDebriefTB.Visible = false;
            MissionDebriefTB.Enabled = false;

            MissionTB.Visible = false;
            MissionTB.Enabled = false;

            PickHero1.Visible = true;
            PickHero1.Enabled = true;

            PickHero2.Visible = true;
            PickHero2.Enabled = true;

            PickHero3.Visible = true;
            PickHero3.Enabled = true;

            PickHero4.Visible = true;
            PickHero4.Enabled = true;

            Heropicklabel.Visible = true;
            Heropicklabel.Enabled = true;


            BacktoMM.Visible = true;
            BacktoMM.Enabled = true;

            ShipStateTB.Text = "";
            PilotStateTB.Text = "";
            MissionDebriefTB.Text = "";
            MissionTB.Text = "";

            enemyTimerCounter = 0;
            Game = new Game(this.Width, this.Height);
            
        }

        private void EndGameQuitGameButton_Click(object sender, EventArgs e)
        {
            PickedHeroFlag = false;
            GameOverLabel.Visible = false;
            GameOverLabel.Enabled = false;

            MissionLabel.Visible = false;
            MissionLabel.Enabled = false;

            EndGameQuitGameButton.Visible = false;
            EndGameQuitGameButton.Enabled = false;

            EndGameNewGameButton.Visible = false;
            EndGameNewGameButton.Enabled = false;

            ShipStateLabel.Visible = false;
            ShipStateLabel.Enabled = false;

            PilotStateLabel.Visible = false;
            PilotStateLabel.Enabled = false;

            MissionDebriefLabel.Visible = false;
            MissionDebriefLabel.Enabled = false;

            ShipStateTB.Visible = false;
            ShipStateTB.Enabled = false;

            PilotStateTB.Visible = false;
            PilotStateTB.Enabled = false;

            MissionDebriefTB.Visible = false;
            MissionDebriefTB.Enabled = false;

            MissionTB.Visible = false;
            MissionTB.Enabled = false;

            ShipStateTB.Text = "";
            PilotStateTB.Text = "";
            MissionDebriefTB.Text = "";
            MissionTB.Text = "";


            enemyTimerCounter = 0;
            showMainMenu();
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            HeroHealth.Visible = true;
            HeroHealth.Enabled = true;
            enemyTimerCounter = 0;
            Game = new Game(this.Width, this.Height);
            timer1.Start();
            HeroBulletTimer.Start();
            Game.Hero.ShowHeroShip = true;
            HidePauseMenu();
        }
    }
}
