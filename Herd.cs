using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinosaurs
{
    public class Herd
    {
        public List<Dinosaur> dinosaurs;

        public Herd()
        {
            dinosaurs = new List<Dinosaur>();
            Dinosaur raptor = new Dinosaur("Raptor", 65, 30, 100);
            Dinosaur trex = new Dinosaur("T-rex", 100, 25, 100);
            Dinosaur triceratops = new Dinosaur("Tricaratops", 110, 15, 100);
            dinosaurs.Add(raptor);
            dinosaurs.Add(trex);
            dinosaurs.Add(triceratops);
        }

        public  void AddDinosaursToHerd(Dinosaur dinosaur)
        {
            dinosaurs.Add(dinosaur);
        }

    }
}
