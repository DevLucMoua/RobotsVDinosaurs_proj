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

        }

        public void PracticeMethod()
        {
           
            fleet.robots[0].AttackDinosuar(herd.dinosaurs[0]);
          
        }
    }
}
