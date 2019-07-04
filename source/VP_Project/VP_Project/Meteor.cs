using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_Project
{
    [Serializable]
    public class Meteor
    {
        public Bitmap Image { get; set; }
        private int Speed { get; set; }
        public int Health { get; set; }
        public Point Location { get; set; }
        private int Damage { get; set; }
        

        public Meteor(int width)
        {
            Random random = new Random();
            int choice = random.Next(1, 4);
            int ypos = random.Next(0, width);
            this.Location = new Point(ypos, -50);
            this.Health = 40;
            this.Speed = 12;
            this.Damage = 100;
            if (choice == 1) // Randomize image selection
                Image = VP_Project.Properties.Resources.Meteor1;
            else if (choice == 2)
                Image = VP_Project.Properties.Resources.Meteor2;
            else if (choice == 3)
                Image = VP_Project.Properties.Resources.Meteor3;
            else if (choice == 4)
                Image = VP_Project.Properties.Resources.Meteor4;
        }

        public void Move(int height)
        {
            Point temp = Location;
            if(temp.Y <= height)
            {
            temp.Y = temp.Y + Speed;
            }
            Location = temp;
        }

        public void Draw(Graphics g)
        {
            //Pen p = new Pen(Color.Red);
            //Rectangle h = new Rectangle(this.Location.X, this.Location.Y, 50, 50);
            //g.DrawRectangle(p, h);
            g.DrawImage(this.Image, this.Location);
        }

        
        public void checkCollision()
        {
            //IMPLEMENTED IN Game.cs
        }
    }
}
