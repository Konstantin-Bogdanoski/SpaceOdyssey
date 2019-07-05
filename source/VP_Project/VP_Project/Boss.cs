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
        public enum DIRECTION { LEFT, RIGHT, DOWN };
        public Point Location { get; set; }
        public int Speed { get; set; }
        public int Health { get; set; }
        public List<Bullet> Bullets { get; set; }
        public DIRECTION Direction { get; set; }
        public Bitmap Image { get; set; }
        private static System.Timers.Timer aTimer;
        private Random random;
        
        public Boss(int width)
        {
            aTimer = new System.Timers.Timer(1500);
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;

            this.Location = new Point(width/2-50, -250);
            this.Speed = 35;
            this.Health = 150;
            this.Bullets = new List<Bullet>();
            this.Direction = DIRECTION.DOWN;
            this.Image = VP_Project.Properties.Resources.EnemyBoss;
            this.random = new Random();

            Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
        }

        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            this.Shoot();
        }

        public void Move(int width)
        {
            for (int index = 0; index < Bullets.Count; index++)
                Bullets[index].Move();
            Point temp = Location;
            /*if(Direction == DIRECTION.DOWN)
            {
                if (temp.Y >= 10)
                    Direction = DIRECTION.RIGHT;
                else
                    temp.Y++;
            }
            else if (Direction == DIRECTION.LEFT)
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
            */
            if(Direction == DIRECTION.DOWN)
            {
                if(temp.Y >= 10)
                {
                    int direction = random.Next(0,2);
                    if(direction == 0)
                    {
                        Direction = DIRECTION.LEFT;
                    }
                    else
                    {
                        Direction = DIRECTION.RIGHT;
                    }
                }
                temp.Y++;
            }
            
            if(Direction == DIRECTION.LEFT)
            {
                if(temp.X <= 1 )
                {
                    Direction = DIRECTION.RIGHT;
                }
                temp.X--;
            }

            if(Direction == DIRECTION.RIGHT)
            {
                if(temp.X >= width - 160)
                {
                    Direction = DIRECTION.LEFT;
                }
                temp.X++;
            }

            this.Location = temp;
        }

        public void Draw(Graphics g)
        {
            //CHECKING HITBOX
            //Pen p = new Pen(Color.Red);
            //Rectangle h1 = new Rectangle(this.Location.X, this.Location.Y+20, 150, 50);
            //Rectangle h2 = new Rectangle(this.Location.X+55, this.Location.Y, 50, 150);
            //g.DrawRectangle(p, h1);
            //g.DrawRectangle(p, h2);
            for (int i = 0; i < Bullets.Count; i++)
                Bullets.ElementAt(i).Draw(g);
            g.DrawImage(Image, Location);
        }
        public void Shoot()
        {
            this.Bullets.Add(new Bullet(new Point(Location.X, Location.Y + 10)));
            this.Bullets.Add(new Bullet(new Point(Location.X + 57, Location.Y+70)));
            this.Bullets.Add(new Bullet(new Point(Location.X + 120, Location.Y+10)));
        }
    }
}
