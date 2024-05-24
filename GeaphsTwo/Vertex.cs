using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeaphsTwo
{
    public class Vertex
    {
        public string Id { get; set; }
        public List<Edge> EdgeList { get; set; }

        public Vertex(string id)
        {
            Id = id;
            EdgeList = new List<Edge>();
        }

        public override string ToString()
        {
            return Id;
        }
    }

}
