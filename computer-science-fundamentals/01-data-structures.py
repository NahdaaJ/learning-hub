# STACKS
# In Python, we can use a list to implement a stack.
# A stack follows the Last In First Out (LIFO) principle.
print("STACKS ----------------------------------------------------")

stack = []
stack.append(1)
stack.append(2)
stack.append(3)

print("Initial stack:", stack)
print("Popped item:", stack.pop())
print("Stack after pop:", stack)
print("Is stack empty?", len(stack) == 0)

# Peek at the top item without removing it
top_item = stack[-1]
print("Top of stack:", top_item)


# QUEUES
# In Python, we can use collections.deque to implement a queue.
print("\n\nQUEUES ----------------------------------------------------")

from collections import deque
queue = deque()
queue.append(1)
queue.append(2)
queue.append(3)
print("Initial queue:", list(queue))
print("Dequeued item:", queue.popleft())
print("Queue after dequeue:", list(queue))
print("Is queue empty?", len(queue) == 0)

# PRIORITY QUEUES
# In Python, we can use the heapq module to implement a priority queue.
print("\n\nPRIORITY QUEUES ----------------------------------------------------")
import heapq

priority_queue = []
heapq.heappush(priority_queue, 2)
heapq.heappush(priority_queue, 5)
heapq.heappush(priority_queue, 1)
heapq.heappush(priority_queue, 6)
heapq.heappush(priority_queue, 3)

print("Initial priority queue:", priority_queue)
print("Dequeued item:", heapq.heappop(priority_queue))
print("Priority queue after dequeue:", priority_queue)
print("Is priority queue empty?", len(priority_queue) == 0)

# Next up: Linked Lists