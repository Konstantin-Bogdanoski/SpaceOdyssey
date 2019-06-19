using System.Drawing;

namespace VP_Project
{
    public class Bullet
    {
        private Bitmap Image { get; set; }
        private int Damage { get; set; }
        private int Speed { get; set; }
        private Point Location { get; set; }
        public Bullet(Point Location)
        {
            this.Image = VP_Project.Properties.Resources.Bullet;
            Image.RotateFlip(RotateFlipType.Rotate90FlipNone); // Should be OK, need to check ROTATION
            this.Speed = 20;
            this.Location = Location;
            this.Damage = 20;
        }

        public void Draw(Graphics g)
        {
            g.DrawImage(this.Image, this.Location);
        }

        public void Move()
        {
            Point temp = this.Location;
            temp.Y += 1; // Update if needed; Check with timer
            this.Location = temp;
        }

        //IMPLEMENT COLLIDE
    }
}