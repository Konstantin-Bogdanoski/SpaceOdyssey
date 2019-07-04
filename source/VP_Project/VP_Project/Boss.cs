using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace VP_Project
{
    [Serializable]
    public class Boss
    {
        public enum DIRECTION { LEFT, RIGHT };
        public Point Location { get; set; }
        public int Speed { get; set; }
        public int Health { get; set; }
        public List<Bullet> Bullets { get; set; }
        public DIRECTION Direction { get; set; }
        public Bitmap Image { get; set; }
        private static System.Timers.Timer aTimer;
        public Boss(int width)
        {
            aTimer = new System.Timers.Timer(1000);
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;

            this.Location = new Point(width/2, 50);
            this.Speed = 35;
            this.Health = 150;
            this.Bullets = new List<Bullet>();
            this.Direction = DIRECTION.LEFT;
            this.Image = VP_Project.Properties.Resources.EnemyBoss;
            Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
        }

        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            this.Shoot();
        }

        public void Move(int width)
        {
            Point temp = Location;
            if (Direction == DIRECTION.LEFT)
            {
                if (temp.X <= 0)
                    Direction = DIRECTION.RIGHT;
                else
                    temp.X--;
            }
            else if (Direction == DIRECTION.RIGHT)
            {
                if (temp.X <= width)
                    Direction = DIRECTION.LEFT;
                else
                    temp.X++;
            }
            Location = temp;
        }
        public void Draw(Graphics g)
        {
            Pen p = new Pen(Color.Red);
            Rectangle h = new Rectangle(this.Location.X, this.Location.Y, 50, 50);
            g.DrawRectangle(p, h);
            g.DrawImage(Image, Location);
        }
        public void Shoot()
        {
            this.Bullets.Add(new Bullet(Location));
            this.Bullets.Add(new Bullet(new Point(Location.X - 20, Location.Y)));
            this.Bullets.Add(new Bullet(new Point(Location.X + 20, Location.Y)));
        }
    }
}
