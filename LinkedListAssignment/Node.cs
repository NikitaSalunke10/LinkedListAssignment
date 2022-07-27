using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListAssignment
{
    internal class Node 
    {
        public int data; // this will store the data or value 
        public Node next;// this will store the address of next node
        public Node(int data) // constructor is used to assign the value to data
        {
            this.data = data;
        }
    }
}
