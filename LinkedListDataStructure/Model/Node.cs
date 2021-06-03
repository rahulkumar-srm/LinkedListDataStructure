using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure.Model
{
    internal class Node
    {
        internal int Data { get; set; }
        internal Node Next { get; set; }
        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }
}
