using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Project
{
    [Serializable]
    public class Game
    {
        public List<Enemy> Enemies { get; set; }
        public Hero Hero { get; set; }
        public Boss Boss { get; set; }
        public List<Meteor> Meteors { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Level { get; set; }
        public int TimeCounter { get; set; }
        private int NumOfEnemies { get; set; }
        
        public void GameOver()
        {
            if (Hero.Health<=0 || Boss.Health<=0)
            {
                Hero.ShowHeroShip = false;
                
                for (int i = 0; i < Enemies.Count; i++)
                {
                    if (Enemies.ElementAt(i).Health <= 0)
                        {
                            Enemies.RemoveAt(i);
                            i--;
                        }
                }
            }
        }
        public Game(int width, int height)
        {
            this.Hero = new Hero(new Point((int)width / 2 - 50, height - 100));
            this.Height = height;
            this.Width = width;
            this.Level = 1;
            this.TimeCounter = 300;
            this.Enemies = new List<Enemy>();
            this.Meteors = new List<Meteor>();
            this.Boss = new Boss(this.Width);
            this.NumOfEnemies = 0;
        }
        public void Draw(Graphics g)
        {
            if(Hero.ShowHeroShip)
            {
                Hero.Draw(g);
                foreach (Enemy enemy in Enemies)
                    enemy.Draw(g);
                foreach (Meteor meteor in Meteors)
                    meteor.Draw(g);
                if (Level == 3 && Meteors.Count <= 0)
                    Boss.Draw(g);
            }
        }
        public void MoveEnemies()
        {
            foreach(Enemy enemy in Enemies)
            {
                enemy.Move();
            }
        }
        public void MoveHero(Keys key, int width)
        {
            Hero.Move(key,width);
        }
        public void MoveBoss()
        {
            if(Level == 3) // Move only on the 3rd level (Boss level)
                Boss.Move(this.Width);
        }

        public void MoveMeteors()
        {
            if (!(Meteors is null))
                foreach (Meteor meteor in Meteors)
                    meteor.Move(this.Height);
        }
        public void CheckBulletsImpact()
        {
            if (Level == 1)
            {
                //Hero to Enemies
                for (int index = 0; index < Hero.bullets.Count; index++)
                {
                    foreach (Enemy enemy in Enemies)
                    {
                        Rectangle b = new Rectangle(Hero.bullets[index].Location.X, Hero.bullets[index].Location.Y, Hero.bullets[index].BulletImg.Width, Hero.bullets[index].BulletImg.Height);
                        Rectangle h = new Rectangle(enemy.Location.X, enemy.Location.Y, 37, 35);
                        if (b.IntersectsWith(h))
                        {
                            Hero.bullets[index].Hit = true;
                            enemy.Health -= 50;
                        }
                    }
                    for (int i = 0; i < Enemies.Count; i++)
                        if (Enemies.ElementAt(i).Health <= 0)
                            {
                                Enemies.RemoveAt(i);
                                i--;    
                            }
                }
            

                //Hero to Meteors
                for (int index = 0; index < Hero.bullets.Count; index++)
                {
                    foreach (Meteor meteor in Meteors)
                    {
                        Rectangle b = new Rectangle(Hero.bullets[index].Location.X, Hero.bullets[index].Location.Y, Hero.bullets[index].BulletImg.Width, Hero.bullets[index].BulletImg.Height);
                        Rectangle m= new Rectangle(meteor.Location.X, meteor.Location.Y, 40, 40);
                        Rectangle h = new Rectangle(Hero.Location.X, Hero.Location.Y + 30, 80, 50);
                        if (b.IntersectsWith(m))
                        {
                            Hero.bullets[index].Hit = true;
                            meteor.Health -= 40;
                        }
                        if (h.IntersectsWith(m))
                        {
                            Hero.Health = 0;
                        }
                    }

                    for (int i = 0; i < Meteors.Count; i++)
                        if (Meteors.ElementAt(i).Health <= 0)
                            {
                                Meteors.RemoveAt(i);
                                i--;
                            }
                }

                //Enemies to Hero
                foreach (Enemy enemy in Enemies)
                {
                    for (int index = 0; index < enemy.Bullets.Count; index++) {
                        Rectangle b = new Rectangle(enemy.Bullets[index].Location.X, enemy.Bullets[index].Location.Y, enemy.Bullets[index].Image.Width, enemy.Bullets[index].Image.Height);
                        Rectangle h = new Rectangle(Hero.Location.X, Hero.Location.Y+30, 70, 80);
                        if (b.IntersectsWith(h))
                        {
                            enemy.Bullets[index].ToBeRemoved = true;
                            Hero.Health -= 1;
                        }
                    }
                }

                //Meteors to Enemies
                foreach(Meteor meteor in Meteors)
                {
                    Rectangle m = new Rectangle(meteor.Location.X, meteor.Location.Y, 50, 50);
                    foreach (Enemy enemy in Enemies)
                    {
                        Rectangle e = new Rectangle(enemy.Location.X, enemy.Location.Y, 37, 35);
                        if (m.IntersectsWith(e))
                        {
                            meteor.Health -= 40;
                            enemy.Health = 0;
                        }
                    }
                    Rectangle h = new Rectangle(Hero.Location.X, Hero.Location.Y + 30, 80, 50);
                    if (m.IntersectsWith(h))
                        Hero.Health = 0;
                }
                for (int i = 0; i < Meteors.Count; i++)
                    if (Meteors.ElementAt(i).Health <= 0)
                        {
                            Meteors.RemoveAt(i);
                            i--;
                        }

                for (int i = 0; i < Enemies.Count; i++)
                    if (Enemies.ElementAt(i).Health <= 0)
                        {
                            Enemies.RemoveAt(i);
                            i--;
                        }
            }
            else if(Level == 2)
            {
                //Hero to Meteors
                for (int index = 0; index < Hero.bullets.Count; index++)
                {
                    foreach (Meteor meteor in Meteors)
                    {
                        Rectangle b = new Rectangle(Hero.bullets[index].Location.X, Hero.bullets[index].Location.Y, Hero.bullets[index].BulletImg.Width, Hero.bullets[index].BulletImg.Height);
                        Rectangle m = new Rectangle(meteor.Location.X, meteor.Location.Y, 40, 40);
                        Rectangle h = new Rectangle(Hero.Location.X, Hero.Location.Y + 30, 80, 50);
                        if (b.IntersectsWith(m))
                        {
                            Hero.bullets[index].Hit = true;
                            meteor.Health -= 40;
                        }
                        if (h.IntersectsWith(m))
                        {
                            Hero.Health = 0;
                        }
                    }

                    for (int i = 0; i < Meteors.Count; i++)
                        if (Meteors.ElementAt(i).Health <= 0)
                            {
                                Meteors.RemoveAt(i);
                                i--;
                            }
                }
                foreach (Meteor meteor in Meteors)
                {
                    Rectangle m = new Rectangle(meteor.Location.X, meteor.Location.Y, 50, 50);
                    foreach (Enemy enemy in Enemies)
                    {
                        Rectangle e = new Rectangle(enemy.Location.X, enemy.Location.Y, 37, 35);
                        if (m.IntersectsWith(e))
                        {
                            meteor.Health -= 40;
                            enemy.Health = 0;
                        }
                    }
                    Rectangle h = new Rectangle(Hero.Location.X, Hero.Location.Y + 30, 80, 50);
                    if (m.IntersectsWith(h))
                        Hero.Health = 0;
                }

                for (int i = 0; i < Meteors.Count; i++)
                    if (Meteors.ElementAt(i).Health <= 0)
                        {
                            Meteors.RemoveAt(i);
                            i--;
                        }

                for (int i = 0; i < Enemies.Count; i++)
                    if (Enemies.ElementAt(i).Health <= 0)
                        {
                            Enemies.RemoveAt(i);
                            i--;
                        }
            }
            else if(Level == 3)
            {
                Rectangle b1 = new Rectangle(Boss.Location.X, Boss.Location.Y+20, 150, 50);
                Rectangle b2 = new Rectangle(Boss.Location.X+55, Boss.Location.Y, 50, 150);
                Rectangle h = new Rectangle(Hero.Location.X, Hero.Location.Y + 30, 80, 50);

                //Hero to Boss
                for(int index = 0; index < Hero.bullets.Count; index++)
                {
                    Rectangle b = new Rectangle(Hero.bullets[index].Location.X, Hero.bullets[index].Location.Y, Hero.bullets[index].BulletImg.Width, Hero.bullets[index].BulletImg.Height);
                    if (b.IntersectsWith(b1) || b.IntersectsWith(b2))
                    {
                        Boss.Health -= 5;
                        Hero.bullets[index].Hit = true;
                    }
                }

                //Boss to Hero
                for(int index = 0; index < Boss.Bullets.Count; index++)
                {
                    Rectangle b = new Rectangle(Boss.Bullets[index].Location.X, Boss.Bullets[index].Location.Y, Boss.Bullets[index].Image.Width, Boss.Bullets[index].Image.Height);
                    if (b.IntersectsWith(h))
                    {
                        Hero.Health -= 35;
                        Boss.Bullets[index].ToBeRemoved = true;
                    }
                }

                for (int index = 0; index < Hero.bullets.Count; index++)
                {
                    foreach (Meteor meteor in Meteors)
                    {
                        Rectangle b = new Rectangle(Hero.bullets[index].Location.X, Hero.bullets[index].Location.Y, Hero.bullets[index].BulletImg.Width, Hero.bullets[index].BulletImg.Height);
                        Rectangle m = new Rectangle(meteor.Location.X, meteor.Location.Y, 40, 40);
                        Rectangle h1 = new Rectangle(Hero.Location.X, Hero.Location.Y + 30, 80, 50);
                        if (b.IntersectsWith(m))
                        {
                            Hero.bullets[index].Hit = true;
                            meteor.Health -= 40;
                        }
                        if (h.IntersectsWith(m))
                        {
                            Hero.Health = 0;
                        }
                    }
                }

                    for (int i = 0; i < Meteors.Count; i++)
                        if (Meteors.ElementAt(i).Health <= 0)
                            {
                                Meteors.RemoveAt(i);
                                i--;    
                            }
                    if (Boss.Health <= 0)
                {
                    //GAME OVER - WIN
                }
            }

            for (int i = 0; i < Hero.bullets.Count; i++)
                if (Hero.bullets.ElementAt(i).Hit)
                    {
                        Hero.bullets.RemoveAt(i);
                        i--;
                    }

            for (int i = 0; i < Boss.Bullets.Count; i++)
                if (Boss.Bullets.ElementAt(i).ToBeRemoved)
                    {
                        Boss.Bullets.RemoveAt(i);
                        i--;
                    }
                    

            foreach (Enemy enemy in Enemies)
                for (int i = 0; i < enemy.Bullets.Count; i++)
                    if (enemy.Bullets.ElementAt(i).ToBeRemoved)
                        {
                            enemy.Bullets.RemoveAt(i);
                            i--;
                        }
                         
        }
        public void CheckMeteorImpact()
        {
            if (!(Meteors is null))
            {
                foreach (Meteor meteor in Meteors)
                {
                    if (meteor.Location.Equals(Hero.Location))
                        Hero.Health = 0;

                    foreach (Enemy enemy in Enemies)
                    {
                        if (meteor.Location.Equals(enemy.Location))
                            enemy.Health = 0;
                    }
                }

                for (int i = 0; i < Enemies.Count; i++)
                    if (Enemies.ElementAt(i).Health == 0)
                        {
                            Enemies.RemoveAt(i);
                            i--;
                        }

                for(int i=0; i<Meteors.Count; i++)
                {
                    if (Meteors.ElementAt(i).Location.Y > this.Height)
                        {   
                            Meteors.RemoveAt(i);
                            i--;
                        }
                }
            }
        }

        public void addMeteor()
        {
            if (Level == 1 && Meteors.Count <= 4)
                Meteors.Add(new Meteor(this.Width));
            else if (Level == 2)
                Meteors.Add(new Meteor(this.Width));
        }

        public void addEnemy()
        {
            addMeteor();
            if (NumOfEnemies < 20)
            {
                Enemies.Add(new Enemy(this.Width, this.Height));
                NumOfEnemies++;
            }
            NextLevel();
        }
        public void NextLevel()
        {
            if (Enemies.Count == 0 && NumOfEnemies == 20 && Level == 1)
                Level++;
            else if (TimeCounter <= 0 && Level == 2)
                Level++;
        }
    }
}
