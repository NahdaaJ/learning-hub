Console.WriteLine("STACKS ----------------------------------------------------");
var stack = new Stack<int>();
stack.Push(10);
stack.Push(20);
stack.Push(30);

Console.WriteLine($"Stack after pushes: {string.Join(", ", stack)}");
Console.WriteLine($"Popped item: {stack.Pop()}");
Console.WriteLine($"Stack after pop: {string.Join(", ", stack)}");
Console.WriteLine($"Top item (peek): {stack.Peek()}");
Console.WriteLine($"Stack after peek: {string.Join(", ", stack)}");


Console.WriteLine("\n\nQUEUES ----------------------------------------------------");
var queue = new Queue<int>();
queue.Enqueue(10);
queue.Enqueue(20);
queue.Enqueue(30);

Console.WriteLine($"Queue after enqueues: {string.Join(", ", queue)}");
Console.WriteLine($"Dequeued item: {queue.Dequeue()}");
Console.WriteLine($"Queue after dequeue: {string.Join(", ", queue)}");
Console.WriteLine($"Front item (peek): {queue.Peek()}");
Console.WriteLine($"Queue after peek: {string.Join(", ", queue)}");

Console.WriteLine("\n\nPRIORITY QUEUES ----------------------------------------------------");
var priorityQueue = new SortedSet<(int Priority, int Value)>();
priorityQueue.Add((2, 20));
priorityQueue.Add((1, 10));
priorityQueue.Add((1, 15));
priorityQueue.Add((3, 30));

Console.WriteLine("Priority Queue after adds:");
foreach (var item in priorityQueue)
{
    Console.WriteLine($"Priority: {item.Priority}, Value: {item.Value}");
}
var highestPriorityItem = priorityQueue.Min;
priorityQueue.Remove(highestPriorityItem);
Console.WriteLine($"Dequeued item with highest priority: Priority: {highestPriorityItem.Priority}, Value: {highestPriorityItem.Value}");
Console.WriteLine("Priority Queue after dequeue:");
foreach (var item in priorityQueue)
{
    Console.WriteLine($"Priority: {item.Priority}, Value: {item.Value}");
}


Console.WriteLine("\n\nSINGLY LINKED LIST ----------------------------------------------------");

// Example usage:
var linkedList = new SinglyLinkedList();
linkedList.Append(10);
linkedList.Append(20);
linkedList.Append(30);
Console.WriteLine("Singly linked list:");
linkedList.PrintList();

linkedList.InsertAfter(20, 25);  // Inserts 25 after 20
Console.WriteLine("\nSingly linked list updated:");
linkedList.PrintList();



Console.WriteLine("\n\nDOUBLY LINKED LIST ----------------------------------------------------");

// Example usage:
var doublyLinkedList = new DoublyLinkedList();
doublyLinkedList.Append(100);
doublyLinkedList.Append(200);
doublyLinkedList.Append(300);
Console.WriteLine("Doubly linked list:");
doublyLinkedList.PrintList();

doublyLinkedList.InsertAfter(200, 250);  // Inserts 250 after 200
Console.WriteLine("\nDoubly linked list updated:");
doublyLinkedList.PrintList();


Console.WriteLine("\n\nDYNAMIC ARRAYS ----------------------------------------------------");

List<int> dynamicArray = new List<int>();
Console.WriteLine("Capacity: "+ dynamicArray.Capacity);

dynamicArray.Add(1);
Console.WriteLine("Capacity: "+ dynamicArray.Capacity);

dynamicArray.Add(2);
dynamicArray.Add(3);
dynamicArray.Add(2);
dynamicArray.Add(5);
Console.WriteLine("Capacity: "+ dynamicArray.Capacity);

// Access Elements O(1)
Console.WriteLine($"Element at index 1: {dynamicArray[1]}");

// Remove Element O(n)
dynamicArray.RemoveAt(1);

// Insert Element O(n)
dynamicArray.Insert(1, 20);

// Singly linked list implementation (move above usage, remove 'public' for script compatibility)
class SinglyNode
{
    public int Data;
    public SinglyNode Next;

    public SinglyNode(int data)
    {
        Data = data;
        Next = null;
    }
}

class SinglyLinkedList
{
    public SinglyNode Head;

    public void Append(int data)
    {
        var newNode = new SinglyNode(data);
        if (Head == null)
        {
            Head = newNode;
            return;
        }
        var current = Head;
        while (current.Next != null)
            current = current.Next;
        current.Next = newNode;
    }

    public void InsertAfter(int data, int newData)
    {
        var current = Head;
        while (current != null)
        {
            if (current.Data == data)
            {
                var newNode = new SinglyNode(newData);
                newNode.Next = current.Next;
                current.Next = newNode;
                return;
            }
            current = current.Next;
        }
        Console.WriteLine($"Node with data {data} not found.");
    }

    public void PrintList()
    {
        var current = Head;
        while (current != null)
        {
            string nextLocation = current.Next != null ? current.Next.GetHashCode().ToString() : "null";
            string currentLocation = current.GetHashCode().ToString();
            Console.Write($"[Data: {current.Data}, Current: {currentLocation}, Next: {nextLocation}]{(current.Next != null ? " -> " : "\n")}");
            current = current.Next;
        }
    }
}


class DoublyNode
{
    public int Data;
    public DoublyNode Next;
    public DoublyNode Prev;

    public DoublyNode(int data)
    {
        Data = data;
        Next = null;
        Prev = null;
    }
}

class DoublyLinkedList
{
    public DoublyNode Head;
    public DoublyNode Tail;

    public void Append(int data)
    {
        var newNode = new DoublyNode(data);
        if (Head == null)
        {
            Head = newNode;
            Tail = newNode;
            return;
        }
        Tail.Next = newNode;
        newNode.Prev = Tail;
        Tail = newNode;
    }

    public void InsertAfter(int data, int newData)
    {
        var current = Head;
        while (current != null)
        {
            if (current.Data == data)
            {
                var newNode = new DoublyNode(newData);
                newNode.Next = current.Next;
                newNode.Prev = current;
                if (current.Next != null)
                    current.Next.Prev = newNode;
                current.Next = newNode;
                if (Tail == current)
                    Tail = newNode;
                return;
            }
            current = current.Next;
        }
        Console.WriteLine($"Node with data {data} not found.");
    }

    public void PrintList()
    {
        var current = Head;
        while (current != null)
        {
            string prevLocation = current.Prev != null ? current.Prev.GetHashCode().ToString() : "null";
            string nextLocation = current.Next != null ? current.Next.GetHashCode().ToString() : "null";
            string currentLocation = current.GetHashCode().ToString();
            Console.Write($"[Data: {current.Data}, Prev: {prevLocation}, Current: {currentLocation}, Next: {nextLocation}]{(current.Next != null ? " <-> " : "\n")}");
            current = current.Next;
        }
    }
}
