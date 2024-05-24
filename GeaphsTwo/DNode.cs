using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeaphsTwo
{
    public class DNode
    {
        public Vertex Vertex { get; set; }
        public int Distance { get; set; }
        public bool Visited { get; set; }
        public Vertex Previous { get; set; }

        public DNode(Vertex vertex)
        {
            Vertex = vertex;
            Distance = int.MaxValue;
            Visited = false;
            Previous = null;
        }
    }
}
