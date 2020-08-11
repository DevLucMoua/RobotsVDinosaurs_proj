using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinosaurs
{
    public class Robot
    {
        public string name;
        public int hitPoints;
        int powerLevel;
        public string weapon;
        public int attackPower;

        public Robot(string name, int hitPoints, string weapon, int attackPower, int powerLevel)
        {
            this.name = name;
            this.hitPoints = hitPoints;
            this.weapon = weapon;
            this.attackPower = attackPower;
            this.powerLevel = 100;
        }

        public int AttackDinosaur(Dinosaur dinosaur)
        {
            dinosaur.hitPoints -= attackPower;
            powerLevel -= 10;
            return hitPoints;
            
        }

    }
}
