using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinosaurs
{
    public class Fleet
    {
        public List<Robot> robots;

        public Fleet()
        {
            robots = new List<Robot>();
            Robot Shredder = new Robot("Shredder", 65, "Chainsaw", 30, 100);
            Robot Blingtron = new Robot("Blingtron 600", 90, "wrench", 20, 100);
            Robot Curator = new Robot("The Curator", 200, "Electric Fist", 5, 100);
            robots.Add(Shredder);
            robots.Add(Blingtron);
            robots.Add(Curator);
        }

        public void AddRobotToFleet(Robot robot)
        {
            robots.Add(robot);
        }

        public void RemoveRobot(Robot robot)
        {
            robots.Remove(robot);
        }
        

    }
}
