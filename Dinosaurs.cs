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
           
            return hitPoints;
        }


    }
}
