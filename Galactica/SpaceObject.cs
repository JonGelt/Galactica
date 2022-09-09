using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica
{
    internal abstract class SpaceObject
    {

        public string Id { get; set; } 

        public string Name { get; set; }
        public Positions ObjectPositions { get; set; } = new Positions();

        public class Positions
        {
           public int X { get; set; }
            
           public int Y { get; set; }

            public override string ToString() 
            {
                return $"({X},{Y})";
            }

        }
        

    }
}
