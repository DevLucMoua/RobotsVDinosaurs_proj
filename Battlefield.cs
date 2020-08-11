using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinosaurs
{
    public class Battlefield
    {
        Fleet fleet; //= new Fleet();
        Herd herd; /*= new Herd();*/

        public Battlefield()
        {
            fleet = new Fleet();
            herd = new Herd();
        }
        public void RunBattle()
        {
            int dinolist = herd.dinosaurs.Count;
            int robotlist = fleet.robots.Count;
            bool playAnotherRound = true;
            while (playAnotherRound)
            {
                if (herd.dinosaurs.Count >= 1 || fleet.robots.Count >= 1)
                {
                    fleet.robots[0].AttackDinosaur(herd.dinosaurs[0]);
                    herd.dinosaurs[0].AttackRobot(fleet.robots[0]);
                    CheckIfDinoIsDead(herd.dinosaurs[0]);
                    CheckIfRoboIsDead(fleet.robots[0]);
                }
               if(fleet.robots.Count == 0 || herd.dinosaurs.Count == 0)
                {
                    Console.WriteLine("Game over!");
                    playAnotherRound = false;
                }
            }
        }


        //run battle method
        //inside you need to have 1 robot attack 1 dino
        //one dino attack one robot
        //check to see if anyone is dead
        //remove them from the list
        //repeat

        public void CheckIfDinoIsDead(Dinosaur dinosaur)
        {
            if (dinosaur.hitPoints <= 0)
            {
                herd.RemoveDinosaur(dinosaur);
                Console.WriteLine("A DINOSAUR HAS BEEN ELIMINATED FROM BATTLE!");
            }

        }

        public void CheckIfRoboIsDead(Robot robot)
        {
            if (robot.hitPoints <= 0)
            {
                fleet.RemoveRobot(robot);
                Console.WriteLine("A ROBOT HAS BEEN ELIMINATED FROM BATTLE!");
            }
        }

    }
}
