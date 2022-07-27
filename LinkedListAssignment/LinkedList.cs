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
        internal Node RemovaLastNode()// this method is used to remove last node in list
        {
            if (head == null) // if statement is used to check whether the list is empty
                return null;
            if (head.next == null) //if statement is used to check whether the next node is null i.e. if list contains only head node
                return null;
            Node newNode = head; // head address is stored to newNode
            while (newNode.next.next != null) // while loop is used to find the last second node
            {
                newNode = newNode.next; // the last second node next address will be stored in newNode
            }
            newNode.next = null;
            return head;
        }
        internal Node Search(int value)// this method is used the search the given value in list
        {
            Node current = head;
            while (current != null)// while loop is used to match the value with present elements in list one by one
            {
                if (current.data == value)//if statement is to check whether the value is same as head.data
                { //if condition become true the below statement will be printed and return
                    Console.WriteLine("\nThe element {0} found in list", value);
                    return current;
                }
                current = current.next;//if value is doesn't match then next node address is assign to head
            }
            Console.WriteLine("\nThe element {0} not found in list", value); //if value is not found in list then this statement is displayed
            return null;
        }
        internal void InsertAtParticularPosition(int position, int data) // this method is used to insert a element at particular position
        {
            Node newNode = new Node(data);
            if (position < 1) //here we are checking if position is greater than 1 or not
            {
                Console.WriteLine("\nInvalid Position.");
            }
            else if (position == 1) // if this condition becomes true it means that we have to insert the new value at head position
            {
                newNode.next = head; 
                head = newNode;
            }
            else
            {
                Node temp = new Node(data);
                temp = head; // storing head address in temp
                for (int i = 1; i < position; i++) // for loop is used to find the address of given position
                {
                    if (temp != null)
                    {
                        temp = temp.next;
                    }
                }
                if (temp != null) // this condition is used to check that the data we want to insert at position is not null
                {
                    newNode.next = temp.next; 
                    temp.next = newNode; 
                }
                else
                {
                    Console.WriteLine("\nPrevious node is null");
                }
            }
        }
        internal void DeleteAtPosition(int value)
        {
            Node temp = Search(value);
            Node newNode = head;
            for(int i = 0; newNode != temp; i++)
            {
                newNode = newNode.next;
                if(newNode.next == temp)
                {
                    Node deleteNode = newNode.next;
                    newNode.next = newNode.next.next;
                    return;
                }
            }
        }
    }    
}
