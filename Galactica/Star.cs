using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica
{
    internal class Star : SpaceObject
    {
        public enum Startype
        {
            Yellow_Dwarf, White, BlueNeutron, RedGiant
        }

        public Startype StarType { get; set; }    
        public double Temperature { get; set; }              
        public List <Planet> Planets { get; set; } = new List<Planet>();

    }
}
