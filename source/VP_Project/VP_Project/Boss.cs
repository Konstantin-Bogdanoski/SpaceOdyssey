using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public Boss()
        {
            this.Location = new Point(0, 50);
            this.Speed = 35;
            this.Health = 150;
            this.Bullets = new List<Bullet>();
            this.Direction = DIRECTION.LEFT;
            this.Image = VP_Project.Properties.Resources.EnemyBoss;
            Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
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
            g.DrawImage(Image, Location);
        }
        public void Shoot()
        {
            this.Bullets.Add(new Bullet(Location));
        }
    }
}
