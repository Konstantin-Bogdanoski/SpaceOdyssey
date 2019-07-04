using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;

namespace VP_Project
{
    [Serializable]
    public class Enemy
    {
        public enum DIRECTION
        {
            UP, DOWN, LEFT, RIGHT, UP_LEFT, UP_RIGHT, DOWN_LEFT, DOWN_RIGHT
        }
        public static Random Random { get; set; }
        public Bitmap Image { get; set; }
        public int Health { get; set; }
        public int Speed { get; set; }
        public Point Location { get; set; }
        public List<Bullet> Bullets { get; set; }
        public DIRECTION Direction { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        private static System.Timers.Timer aTimer;
        public Enemy(int width, int height)
        {
            aTimer = new System.Timers.Timer(2000); 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;

            this.Width = width;
            this.Height = height;
            this.Direction = DIRECTION.DOWN;
            this.Health = 100;
            this.Speed = 25;
            this.Bullets = new List<Bullet>();
            Enemy.Random = new Random();
            this.Location = new Point(Enemy.Random.Next(10, this.Width), -50); // TO BE CHANGED
            int choice = Enemy.Random.Next(1, 4);
            if (choice == 1) // Randomize image selection
                Image = VP_Project.Properties.Resources.EnemyShip1;
            else if (choice == 2)
                Image = VP_Project.Properties.Resources.EnemyShip2;
            else if (choice == 3)
                Image = VP_Project.Properties.Resources.EnemyShip3;
            else if (choice == 4)
                Image = VP_Project.Properties.Resources.EnemyShip4;

            Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
        }

        public void Draw(Graphics g)
        {
            //Pen p = new Pen(Color.Red);
            //Rectangle h = new Rectangle(this.Location.X, this.Location.Y, 37, 35);
            //g.DrawRectangle(p, h);
            g.DrawImage(this.Image, this.Location);
            foreach (Bullet b in Bullets)
                b.Draw(g);
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            this.Shoot();
        }
        public void Shoot()
        {
            this.Bullets.Add(new Bullet(this.Location));
        }

        public void Move()
        {
            int width = this.Width;
            int height = this.Height;
            Point temp = Location;
            if (Direction == DIRECTION.LEFT) {
                if (temp.X <= 0)
                    Direction = (DIRECTION)Enemy.Random.Next(0, 7);
                else 
                    temp.X-=3;
            }
            else if (Direction == DIRECTION.RIGHT)
            {
                if (temp.X >= width - this.Image.Width)
                    Direction = (DIRECTION)Enemy.Random.Next(0, 7);
                else 
                    temp.X+=3;
            }
            else if (Direction == DIRECTION.UP)
            {
                if (temp.Y <= 0)
                    Direction = (DIRECTION)Enemy.Random.Next(0, 7);
                else
                    temp.Y-=3;
            }
            else if (Direction == DIRECTION.DOWN)
            {
                if (temp.Y >= height/2)
                    Direction = (DIRECTION)Enemy.Random.Next(0, 7);
                else
                    temp.Y+=3;
            }
            else if (Direction == DIRECTION.UP_LEFT)
            {
                if (temp.Y <= 0 || temp.X <= 0)
                    Direction = (DIRECTION)Enemy.Random.Next(0, 7);
                else
                {
                    temp.Y -= 2;
                    temp.X -= 2;
                }
            }
            else if (Direction == DIRECTION.DOWN_LEFT)
            {
                if (temp.Y >= height / 2 || temp.X <= 0)
                    Direction = (DIRECTION)Enemy.Random.Next(0, 7);
                else
                {
                    temp.Y += 2;
                    temp.X -= 2;
                }
            }
            else if (Direction == DIRECTION.UP_RIGHT)
            {
                if (temp.Y <= 0 || temp.X >= width - this.Image.Width)
                    Direction = (DIRECTION)Enemy.Random.Next(0, 7);
                else
                {
                    temp.Y -= 2;
                    temp.X += 2;
                }
            }
            else if (Direction == DIRECTION.DOWN_RIGHT)
            {
                if (temp.Y <= 0 || temp.X >= width - this.Image.Width)
                    Direction = (DIRECTION)Enemy.Random.Next(0, 7);
                else
                {
                    temp.Y += 2;
                    temp.X += 2;
                }
            }

            Location = temp;

            //Check position of bullets if they are in a valid position ( IN THE MAP )

            foreach (Bullet b in Bullets)
                b.Move();

            foreach (Bullet b in Bullets)
            {
                b.HitOrOutOfMap(height);
            }

            for (int i = 0; i < Bullets.Count; i++)
                if (Bullets[i].ToBeRemoved)
                    Bullets.RemoveAt(i);
        }


        
    }
}
