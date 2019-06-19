using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_Project
{
    public class Enemy
    {
        private enum DIRECTION
        {
            UP, DOWN, LEFT, RIGHT, UP_LEFT, UP_RIGHT, DOWN_LEFT, DOWN_RIGHT
        }
        private Bitmap Image { get; set; }
        private int Health { get; set; }
        private int Speed { get; set; }
        private Point Location { get; set; }
        private List<Bullet> Bullets { get; set; }
        private DIRECTION Direction { get; set; }
        public Enemy()
        {
            this.Location = new Point(10, 10); // TO BE CHANGED
            this.Direction = DIRECTION.RIGHT;
            this.Health = 20;
            this.Speed = 25;
            this.Bullets = new List<Bullet>();
            Random random = new Random();
            int choice = random.Next(1, 4);
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
            g.DrawImage(this.Image, this.Location);
            foreach (Bullet b in Bullets)
                b.Draw(g);
        }

        public void Shoot()
        {
            this.Bullets.Add(new Bullet(this.Location));
        }

        public void Move(int width, int height)
        {
            Point temp = Location;
            if (Direction == DIRECTION.LEFT) {
                if (temp.X <= 0)
                    Direction = DIRECTION.RIGHT;
                temp.X-=10;
            }
            else if (Direction == DIRECTION.RIGHT)
            {
                if (temp.X >= width - this.Image.Width)
                    Direction = DIRECTION.LEFT;
                temp.X+=10;
            }
            else if (Direction == DIRECTION.UP)
            {
                if (temp.Y <= 0)
                    Direction = DIRECTION.DOWN;
                temp.Y+=10;
            }
            else if (Direction == DIRECTION.DOWN)
            {
                if (temp.Y >= height/2)
                    Direction = DIRECTION.UP;
                temp.Y-=10;
            }

            //RANDOMIZE DIRECTION AND IMPLEMENT DIAGONAL MOVEMENT

            Location = temp;
        }


        
    }
}
