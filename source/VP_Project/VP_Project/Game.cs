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
        private int Level { get; set; }
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
            this.Width = Width;
            this.Level = 1;
            this.Enemies = new List<Enemy>();
            this.Boss = new Boss();
        }
        public void Draw(Graphics g)
        {
            if(Hero.ShowHeroShip)
            {
                Hero.Draw(g);
                foreach (Enemy enemy in Enemies)
                    enemy.Draw(g);
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
        public void CheckBulletsImpact()
        {
            if (Level == 1)
            {
                //Hero to Enemies
                foreach(HeroBullet bullet in Hero.bullets)
                {
                    foreach(Enemy enemy in Enemies)
                        if(bullet.Location.Y - 1 <= enemy.Location.Y)
                        {
                            bullet.Hit = true;
                            enemy.Health -= 20;
                        }

                    for (int i = 0; i < Enemies.Count; i++)
                        if (Enemies.ElementAt(i).Health <= 0)
                            Enemies.RemoveAt(i);
                }

                //Hero to Meteors
                foreach (HeroBullet bullet in Hero.bullets)
                {
                    foreach (Meteor meteor in Meteors)
                        if (bullet.Location.Y - 1 <= meteor.Location.Y)
                        {
                            bullet.Hit = true;
                            meteor.Health -= 20;
                        }

                    for (int i = 0; i < Meteors.Count; i++)
                        if (Meteors.ElementAt(i).Health <= 0)
                            Meteors.RemoveAt(i);
                }

                //Enemies to Hero
                foreach (Enemy enemy in Enemies)
                {
                    foreach (Bullet bullet in enemy.Bullets)
                        if (bullet.Location.Y + 1 <= Hero.Location.Y)
                        {
                            bullet.ToBeRemoved = true;
                            Hero.Health -= 20;
                        }
                }



            }
            else if(Level == 2)
            {
                //Hero to Meteors
                foreach (HeroBullet bullet in Hero.bullets)
                {
                    foreach (Meteor meteor in Meteors)
                        if (bullet.Location.Y - 1 <= meteor.Location.Y)
                        {
                            bullet.Hit = true;
                            meteor.Health -= 20;
                        }

                    for (int i = 0; i < Meteors.Count; i++)
                        if (Meteors.ElementAt(i).Health <= 0)
                            Meteors.RemoveAt(i);
                }

            }
            else if(Level == 3)
            {
                //Hero to Boss


                //Boss to Hero

            }
        }
        public void CheckMeteorImpact()
        {
            foreach(Meteor meteor in Meteors)
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

            //if(Hero.Health == 0)
            //  GAME OVER
        }

        public void addEnemy()
        {
            if(Enemies.Count < 20)
                Enemies.Add(new Enemy(this.Width, this.Height));
        }
        public void NextLevel()
        {

        }
    }
}
