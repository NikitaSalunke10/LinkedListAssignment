using LinkedListAssignment;

LinkedList list = new LinkedList(); 
list.Add(56);
//list.Add(30);
list.Add(70);
list.Insert(30);
list.Display();
list.RemoveFirstNode();
Console.WriteLine("\nList after deleting first node:");
list.Display();