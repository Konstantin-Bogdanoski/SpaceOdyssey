using System.Drawing;

namespace VP_Project
{
    public class Bullet
    {
        public Bitmap Image { get; set; }
        public int Damage { get; set; }
        public int Speed { get; set; }
        public Point Location { get; set; }
        public bool ToBeRemoved { get; set; }
        public Bullet(Point Location)
        {
            this.Image = VP_Project.Properties.Resources.Bullet;
            Image.RotateFlip(RotateFlipType.Rotate90FlipNone); // Should be OK, need to check ROTATION
            this.Speed = 20;
            this.Location = Location;
            this.Damage = 20;
            this.ToBeRemoved = false;
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

        // Remove the bullet from the screen when it hits the HeroShip or leaves screen
        public void HitOrOutOfMap(int height) // Add Hero Location
        {
            if (this.Location.Y > height)
                ToBeRemoved = true;
            else // Hero Location
            {

            }
        }
    }
}