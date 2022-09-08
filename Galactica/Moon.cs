using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica
{
    internal sealed class Moon : Planet
    {
        public Planet Orbiting { get; set; }

        public double Distance(Planet planet)
        {
            int x2 = planet.ObjectPositions.X;
            int x1 = ObjectPositions.X;
            int y2 = planet.ObjectPositions.Y;
            int y1 = ObjectPositions.Y;

            double distance = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));

            return distance;
        }
       
    }

   
}
