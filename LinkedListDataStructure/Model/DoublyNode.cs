using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure.Model
{
    internal class DoublyNode
    {
        internal DoublyNode Prev { get; set; }
        internal int Data { get; set; }
        internal DoublyNode Next { get; set; }
        public DoublyNode(int data)
        {
            Data = data;
            Next = null;
            Prev = null;
        }
    }
}
