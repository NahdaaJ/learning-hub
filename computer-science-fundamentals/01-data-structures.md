# What is a data structure?

- a named location that can be used to store and organise data
- e.g. family tree, arrays
- different data structures stores and organises data in different ways

# Stack

### What is a stack?

- LIFO data structure
- store objects into a sort of vertical tower
- use push to add to the top
- use pop to remove from the top

```csharp
var stack = new Stack<int>();
stack.Push(10);
stack.Push(20);
stack.Push(30);

Console.WriteLine($"Stack after pushes: {string.Join(", ", stack)}");
Console.WriteLine($"Popped item: {stack.Pop()}");
Console.WriteLine($"Stack after pop: {string.Join(", ", stack)}");
Console.WriteLine($"Top item (peek): {stack.Peek()}");
Console.WriteLine($"Stack after peek: {string.Join(", ", stack)}");
```

### Use Cases

- Undo-redo features of text editors
- moving back or foreward between browsing history
- backtracking algorithm

# Queues

### What is a queue?

- FIFO data structure,
- desgined for holding elements prior to processing,
- linear data structure
- `Enqueing` → adding the object to the tail of the queue
- `Dequeing` → removing the object from head of the queue

```csharp
var queue = new Queue<int>();
queue.Enqueue(10);
queue.Enqueue(20);
queue.Enqueue(30);

Console.WriteLine($"Queue after enqueues: {string.Join(", ", queue)}");
Console.WriteLine($"Dequeued item: {queue.Dequeue()}");
Console.WriteLine($"Queue after dequeue: {string.Join(", ", queue)}");
Console.WriteLine($"Front item (peek): {queue.Peek()}");
Console.WriteLine($"Queue after peek: {string.Join(", ", queue)}");
```

# Priority Queues

### What is a priority queue?

- FIFO data structure,
- higher priority objects are served first before objects with lower priority

```csharp
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
```

# Linked Lists

### Singly Linked Lists

Each node has an object and the location of the next object in line

- ezpz to remove nodes, ezpz to add nodes
- SUCKS for searching though, takes linear time (e.g. time taken = elements in list)

```csharp
var linkedList = new SinglyLinkedList();
linkedList.Append(10);
linkedList.Append(20);
linkedList.Append(30);
Console.WriteLine("Singly linked list:");
linkedList.PrintList();

// Singly linked list implementation (move above usage, remove 'public' for script compatibility)
class Node
{
    public int Data;
    public Node Next;

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

class SinglyLinkedList
{
    public Node Head;

    public void Append(int data)
    {
        var newNode = new Node(data);
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
```

### Doubly Linked Lists

Each node has an object and the location of the next object in line and the location of the object before

- ezpz to remove nodes, ezpz to add nodes
- can search from head to tail OR tail to head
- uses even more memory than a singly linked list

```csharp
var doublyLinkedList = new DoublyLinkedList();
doublyLinkedList.Append(100);
doublyLinkedList.Append(200);
doublyLinkedList.Append(300);
Console.WriteLine("Doubly linked list:");
doublyLinkedList.PrintList();

doublyLinkedList.InsertAfter(200, 250);  // Inserts 250 after 200
Console.WriteLine("\nDoubly linked list updated:");
doublyLinkedList.PrintList();

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
```

# Dynamic Arrays

An array with a resizable capacity. Also known as `List<T>` in C#.

If we need to add extra elements, we can increaase the capacity.

- Dynamic arrays have their own inner static arrays with a fixed size → once the inner static array reaches capacity →dynamic array will declare and instantiate a new static array with an increased capacity → the value that the capacity is increased by depends on the language used.
- The elements of the original inner static array is COPIED over to the new, bigger static array, replaces the old reference with a new one, and then the old array gets garbage-collected or freed.
- This copying is expensive (**O(n)**), but it doesn’t happen often. Most insertions are still **O(1) on average (amortized)**.
- Some languages will shrink if the usage drops a lot.
  - List in C#: also **doesn’t shrink automatically**, but has a method like `TrimExcess()` to manually shrink it.

### Advantages of Dynamic Arrays

- Random access of elements → O(1)
- Good locality of reference and data cache utilisation (theyre all contiguous, unlike linked lists where the memory locations are random so you jump around)
- Easy to insert/delete elements at the end

### Disadvantages of Dynamic Arrays

- Wastes more memory ( we may not always need all the extra room given)
- Shifting elements is time consuming O(n)
- Expanding/Shrinking the array is time consuming O(n)

```csharp
linkedList<int> dynamicArray = new List<int>();

dynamicArray.Add(1);
dynamicArray.Add(2);
dynamicArray.Add(3);

// Access Elements O(1)
Console.WriteLine($"Element at index 1: {dynamicArray[1]}");

// Remove Element O(n)
dynamicArray.RemoveAt(1);

// Insert Element O(n)
dynamicArray.Insert(1, 20);
```

In C#, the array starts with a capacity of 0. Then it goes to 4. After that it doubles, so it goes:

0 → 4 → 8 → 16 → 32 → 64 etc etc

# Final Comparison

| Data Structure           | Ordering principle                                  | How it stores data                               | Main operations                                         | Time complexity (average)                                              | When to use                                                            |
| ------------------------ | --------------------------------------------------- | ------------------------------------------------ | ------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| **Stack**                | LIFO (last in, first out)                           | Linear, like a tower                             | `Push`, `Pop`, `Peek`                                   | Push/Pop: O(1)                                                         | Undo/redo, backtracking, history navigation                            |
| **Queue**                | FIFO (first in, first out)                          | Linear, like a line                              | `Enqueue`, `Dequeue`, `Peek`                            | Enqueue/Dequeue: O(1)                                                  | Print queues, task scheduling, order processing                        |
| **Priority Queue**       | FIFO with priorities (higher priority served first) | Ordered by priority                              | `Enqueue` (with priority), `Dequeue` (highest priority) | Add/Remove: O(log n) typically                                         | CPU scheduling, pathfinding algorithms (Dijkstra, A\*), event handling |
| **Singly Linked List**   | Linear, only forward links                          | Each node points to the next node                | Append, Insert, Delete, Traverse                        | Append/Delete: O(1) if at head, Search: O(n)                           | When you need a lot of inserts/deletes but don’t need fast searching   |
| **Doubly Linked List**   | Linear, forward and backward links                  | Each node points to both next and previous nodes | Append, Insert, Delete, Traverse (both directions)      | Append/Delete: O(1) if at node, Search: O(n)                           | When you need to traverse both ways or remove nodes efficiently        |
| **Dynamic Array (List)** | Linear, contiguous memory                           | Backed by resizable static array                 | Add, Insert, Delete, Access                             | Access: O(1), Insert/Delete (middle): O(n), Add at end: O(1) amortised | When you need fast random access and mostly add/remove at the end      |

# Keywords

**`LIFO`** - last in, first out

**`FIFO`** - first in, first out

**`Enque`** - to add an item at the back (tail) of a queue

**`Dequeue`** → to remove an item from the front (head) of a queue.

**`Push`** → to add an item onto the top of a stack.

**`Pop`** → to remove the item on top of a stack.

**`Peek`** → to look at the current top (stack) or front (queue) item without removing it.

**`Amortised time complexity`** → when an operation has occasional expensive costs, but if you average it out over many operations, it still works out to be constant time (like adding to a dynamic array).

**`Random access`** → being able to access any element directly using its index in O(1) time (arrays and dynamic arrays have this, linked lists don’t).

**`Contiguous memory`** → elements are stored right next to each other in memory (arrays, dynamic arrays). This makes them fast to access and cache-friendly.
