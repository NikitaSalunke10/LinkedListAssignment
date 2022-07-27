using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListAssignment
{
    internal class LinkedList
    {
        internal Node head;
        internal void Add(int data) // this methods used to insert or add the value in list
        {
            Node node = new Node(data); // creating object of node class
            if (this.head == null) // if this condition becomes true then node address will be assign to head
                this.head = node;
            else // if condition becomes false means head is not null and we will store the value in next node
            {
                Node temp = head; // storing the head address in temp
                while (temp.next != null) // through while loop  we are checking where the next node is not null
                { //if yes then it will come inside loop and store the next node address in temp and continue the loop till it becomes false
                    temp = temp.next; // 
                }
                temp.next = node; // the node address will be store in next 
            }
            Console.WriteLine("{0} inserted into the linked list", node.data); // display the value stored in list
        }

        internal void Display() // this method is used to display the values in list
        {
            Node temp = this.head; // storing the head address to temp
            if (temp == null) // checks the condition whether the temp is null or not and if yes then it will print below message and return
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while (temp != null) // while loop is used to print one by one values present in linked list
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        internal void Insert(int data) // this method is used to insert the value in middle 
        {
            Node node = new Node(data);
            if (this.head == null) // if this condition becomes true then node address will be assign to head
                this.head = node;
            else
            {
                Node temp = head; // assigning head address to temp
                Node middle = head;// assigning head address to middle
                while (temp.next != null && temp.next.next != null) // while loop is used to find the middle values where we can add the value
                {
                    temp = temp.next.next;
                    middle = middle.next;
                }
                node.next = middle.next; // the address of current middle.next will be stored in next node
                middle.next = node; // the new node address will be stored in middle.next
            }
            Console.WriteLine("{0} inserted in middle of linked list", node.data);
        }
        internal Node RemoveFirstNode() // this method is used to remove the first element
        {
            if (head == null) // if statement is used to check whether the list is empty
            {
                Console.WriteLine("List is empty");
                return null;
            }
            head = head.next; // we are assigning the next node address to head
            return head;
        }
    }
}
