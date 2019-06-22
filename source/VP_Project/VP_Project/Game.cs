using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Project
{
    public class Game
    {
        public List<Enemy> Enemies { get; set; }
        public Hero Hero { get; set; }
        public Boss Boss { get; set; }
        public List<Meteor> Meteors { get; set; }
        public Game(int width, int height)
        {
            this.Hero = new Hero(new Point((int)width / 2 - 50, height - 100));
        }
        public void Draw(Graphics g)
        {
            if(Hero.ShowHeroShip)
            {
                Hero.Draw(g);
            }
        }
        public void MoveEnemies()
        {

        }
        public void MoveHero(Keys key, int width)
        {
            Hero.Move(key,width);
        }
        public void MoveBoss()
        {

        }
        public void CheckBulletsImpact()
        {

        }
        public void CheckMeteorImpact()
        {

        }
        public void NextLevel()
        {

        }
    }
}
