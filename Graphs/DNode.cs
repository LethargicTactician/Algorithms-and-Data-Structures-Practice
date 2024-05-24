using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    public class DNode
    {
        public Vertex Vertex { get; set; }
        public bool Visited { get; set; }
        public Vertex Previous { get; set; }

        //Distance int32.max
        public int Distance { get; set; }

        public DNode(Vertex vertex)
        {
            Vertex = vertex;
            Visited = false;
            Previous = null;
            Distance = Int32.MaxValue;
        }


    }
}
