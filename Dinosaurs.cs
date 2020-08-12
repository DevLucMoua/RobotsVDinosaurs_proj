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
        public string[] abilites = {"Charge", "Slash", "Bite", };

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


    }
}
