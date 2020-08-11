using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinosaurs
{
    public class Dinosaur
    {
        public string type;
        public int hitPoints;
        public int energy;
        public int attackPower;

        public Dinosaur(string type, int hitPoints, int attackPower, int energy)
        {
            this.type = type;
            this.hitPoints = hitPoints;
            this.attackPower = attackPower;
            this.energy = 100;

        }

        public int AttackRobot(Robot robot)
        {
            robot.hitPoints -= attackPower;
            energy -= 10;
            return hitPoints;
        }

        //public bool DeadDinosaur(Dinosaur dinosaur)
        //{
            
        //}

        //public bool PointCounterDinosaurs(Robot robots)
        //{
        //    if (robots.hitPoints <= 0)
        //    {
        //        Console.WriteLine("One of the robots have been eliminated from battle!");
        //        return true;
        //    }
        //    else (robots.hitPoints > 1)

        //}
    }
}
