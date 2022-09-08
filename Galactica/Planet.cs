using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica
{
    internal class Planet : SpaceObject
    {
        public enum PlanetType
        {
            Terrestial, Giant, Dwarf, Gas_Giant, Ice_Giant
        }

        public PlanetType Type { get; set; }
        public double Diameter { get; set; }    

        public int RotationPeriod { get; set; }

        public int RevolutionPeriod { get; set; }

        public List <Moon> Moons { get; set; } = new List<Moon>();

        public double Distance(Star star)
        {
            int x2 = star.ObjectPositions.X;
            int x1 = ObjectPositions.X;
            int y2 = star.ObjectPositions.Y;
            int y1 = ObjectPositions.Y;

            double distance = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));

            return distance;
        }
        

        

    }
}
