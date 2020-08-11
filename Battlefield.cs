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

        }

        public void RemoveDeadDinosaur(Dinosaur dinosaur)
        {
            
        }
    }
}
