using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_Project
{
    [Serializable]
    public class HeroBullet
    {
        public Point Location { get; set; }
        public Bitmap BulletImg { get; set; }
        public bool Hit { get; set; }
        public int Speed { get; set; }

        public HeroBullet(Point Location)
        {
            this.Location = Location;
            this.BulletImg = VP_Project.Properties.Resources.HeroBullet1;
            this.Hit = false;
            this.Speed = 25;
        }

        public void UpdatePosition()
        {
            if (Location.Y > -10)
                this.Location = new Point(this.Location.X, this.Location.Y - Speed);
            else
                this.Hit = true;
            
        }

        public void Draw(Graphics g)
        {
            if (!Hit)
            {
                g.DrawImage(BulletImg, Location);
            }
        }
    }
}
