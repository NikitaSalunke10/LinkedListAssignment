using LinkedListAssignment;

LinkedList list = new LinkedList(); 
list.Add(56);
//list.Add(30);
list.Add(70);
list.Insert(30);
list.Display();
//list.RemoveFirstNode();
//list.RemovaLastNode();
//Console.WriteLine("\nList after deleting last node:");
//list.Display();
list.Search(30);
list.InsertAtParticularPosition(2, 40);
Console.WriteLine("After inserting value at particular position");
list.Display();