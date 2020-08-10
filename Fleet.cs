﻿using System;
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
            Robot Shredder = new Robot("Shredder", 65, "Chainsaw", 30);
            Robot Blingtron = new Robot("Blingtron 600", 90, "wrench", 20);
            Robot Curator = new Robot("The Curator", 125, "Electric Fist", 5);
            robots.Add(Shredder);
            robots.Add(Blingtron);
            robots.Add(Curator);
        }

        public void AddRobotToFleet(Robot robot)
        {
            robots.Add(robot);
        }
    }
}
