using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinosaurs
{
    public class Battlefield
    {
        Fleet fleet = new Fleet();
        Herd herd = new Herd();

        public Battlefield()
        {
            fleet.robots[0].AttackDinosuar(herd.dinosaurs[0]);
            herd.dinosaurs[0].AttackRobot(fleet.robots[0]);
            fleet.robots[0].AttackDinosuar(herd.dinosaurs[0]);
            fleet.robots[0].AttackDinosuar(herd.dinosaurs[0]);

        }

        public void RemoveDeadDinosaur(Dinosaur dinosaur)
        {
            if (dinosaur.hitPoints <= 0)
            {
                herd.RemoveDinosaur(dinosaur);
                Console.WriteLine("A DINOSAUR HAS BEEN ELIMINATED FROM BATTLE!");
            }
            else { }

        }

        public void RemoveDeadRobot(Robot robot)
        {
            if (robot.hitPoints <= 0)
            {
                fleet.RemoveRobot(robot);
                Console.WriteLine("A ROBOT HAS BEEN ELIMINATED FROM BATTLE!");
            }
            else { }
        }

        public void DinosaurCount()
        {
            
        }

        public void RobotCount()
        {

        }
    }
}
