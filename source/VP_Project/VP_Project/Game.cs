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
            if (Hero.Health==0)
            {
                Hero.ShowHeroShip = false;
                for (int i = 0; i < Enemies.Count; i++)
                    if (Enemies.ElementAt(i).Health <= 0)
                        Enemies.RemoveAt(i);
            }
        }
        public Game(int width, int height)
        {
            this.Hero = new Hero(new Point((int)width / 2 - 50, height - 100));
            this.Height = height;
            this.Width = width;
            this.Level = 1;
            this.TimeCounter = 1000;
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
            if(!(Boss is null)) // Move only on the 3rd level (Boss level)
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
                foreach (HeroBullet bullet in Hero.bullets)
                {
                    foreach (Enemy enemy in Enemies)
                    {
                        Rectangle b = new Rectangle(bullet.Location.X, bullet.Location.Y, bullet.BulletImg.Width, bullet.BulletImg.Height);
                        Rectangle h = new Rectangle(enemy.Location.X, enemy.Location.Y, 37, 35);
                        if (b.IntersectsWith(h))
                        {
                            bullet.Hit = true;
                            enemy.Health -= 50;
                        }
                    }
                    for (int i = 0; i < Enemies.Count; i++)
                        if (Enemies.ElementAt(i).Health <= 0)
                            Enemies.RemoveAt(i);
                }
            

                //Hero to Meteors
                foreach (HeroBullet bullet in Hero.bullets)
                {
                    foreach (Meteor meteor in Meteors)
                    {
                        Rectangle b = new Rectangle(bullet.Location.X, bullet.Location.Y, bullet.BulletImg.Width, bullet.BulletImg.Height);
                        Rectangle m= new Rectangle(meteor.Location.X, meteor.Location.Y, 40, 40);
                        Rectangle h = new Rectangle(Hero.Location.X, Hero.Location.Y + 30, 70, 80);
                        if (b.IntersectsWith(m))
                        {
                            bullet.Hit = true;
                            meteor.Health -= 40;
                        }
                        if (h.IntersectsWith(m))
                        {
                            Hero.Health = 0;
                        }
                    }

                    for (int i = 0; i < Meteors.Count; i++)
                        if (Meteors.ElementAt(i).Health <= 0)
                            Meteors.RemoveAt(i);
                }

                //Enemies to Hero
                foreach (Enemy enemy in Enemies)
                {
                    foreach (Bullet bullet in enemy.Bullets) {
                        Rectangle b = new Rectangle(bullet.Location.X, bullet.Location.Y, bullet.Image.Width, bullet.Image.Height);
                        Rectangle h = new Rectangle(Hero.Location.X, Hero.Location.Y+30, 70, 80);
                        if (b.IntersectsWith(h))
                        {
                            bullet.ToBeRemoved = true;
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
                    Rectangle h = new Rectangle(Hero.Location.X, Hero.Location.Y + 30, 70, 80);
                    if (m.IntersectsWith(h))
                        Hero.Health = 0;
                }
                for (int i = 0; i < Meteors.Count; i++)
                    if (Meteors.ElementAt(i).Health <= 0)
                        Meteors.RemoveAt(i);

                for (int i = 0; i < Enemies.Count; i++)
                    if (Enemies.ElementAt(i).Health <= 0)
                        Enemies.RemoveAt(i);
            }
            else if(Level == 2)
            {
                //Hero to Meteors
                foreach (HeroBullet bullet in Hero.bullets)
                {
                    foreach (Meteor meteor in Meteors)
                    {
                        Rectangle b = new Rectangle(bullet.Location.X, bullet.Location.Y, bullet.BulletImg.Width, bullet.BulletImg.Height);
                        Rectangle m = new Rectangle(meteor.Location.X, meteor.Location.Y, 40, 40);
                        Rectangle h = new Rectangle(Hero.Location.X, Hero.Location.Y + 30, 70, 80);
                        if (b.IntersectsWith(m))
                        {
                            bullet.Hit = true;
                            meteor.Health -= 40;
                        }
                        if (h.IntersectsWith(m))
                        {
                            Hero.Health = 0;
                        }
                    }

                    for (int i = 0; i < Meteors.Count; i++)
                        if (Meteors.ElementAt(i).Health <= 0)
                            Meteors.RemoveAt(i);
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
                    Rectangle h = new Rectangle(Hero.Location.X, Hero.Location.Y + 30, 70, 80);
                    if (m.IntersectsWith(h))
                        Hero.Health = 0;
                }
                for (int i = 0; i < Meteors.Count; i++)
                    if (Meteors.ElementAt(i).Health <= 0)
                        Meteors.RemoveAt(i);

                for (int i = 0; i < Enemies.Count; i++)
                    if (Enemies.ElementAt(i).Health <= 0)
                        Enemies.RemoveAt(i);
            }
            else if(Level == 3)
            {
                //Hero to Boss


                //Boss to Hero

            }

            for (int i = 0; i < Hero.bullets.Count; i++)
                if (Hero.bullets.ElementAt(i).Hit)
                    Hero.bullets.RemoveAt(i);

            foreach (Enemy enemy in Enemies)
                for (int i = 0; i < enemy.Bullets.Count; i++)
                    if (enemy.Bullets.ElementAt(i).ToBeRemoved)
                        enemy.Bullets.RemoveAt(i);


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
                        Enemies.RemoveAt(i);

                for(int i=0; i<Meteors.Count; i++)
                {
                    if (Meteors.ElementAt(i).Location.Y > this.Height)
                        Meteors.RemoveAt(i);
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
            if (NumOfEnemies < 10)
            {
                Enemies.Add(new Enemy(this.Width, this.Height));
                NumOfEnemies++;
            }
            NextLevel();
        }
        public void NextLevel()
        {
            if (Enemies.Count == 0 && NumOfEnemies == 10)
                Level++;
            if (TimeCounter == 0 && Level == 2)
            {
                Level++;
                Boss = new Boss(this.Width);
            }
        }
    }
}
