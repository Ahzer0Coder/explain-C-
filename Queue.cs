// namespace explain_C_
// {
//     /// <summary>A first-in, first-out queue implemented with a linked list.</summary>
//     public class Queue<T>
//     {
//         private sealed class Node
//         {
//             public T Value { get; }
//             public Node? Next { get; set; }

//             public Node(T value) => Value = value;
//         }

//         private Node? front;
//         private Node? rear;

//         public int Count { get; private set; }
//         public bool IsEmpty => Count == 0;

//         /// <summary>Adds an item to the back of the queue. O(1).</summary>
//         public void Enqueue(T item)
//         {
//             var node = new Node(item);
//             if (rear is null)
//                 front = node;
//             else
//                 rear.Next = node;

//             rear = node;
//             Count++;
//         }

//         /// <summary>Removes and returns the item at the front. Throws if empty.</summary>
//         public T Dequeue()
//         {
//             if (front is null)
//                 throw new InvalidOperationException("The queue is empty.");

//             T value = front.Value;
//             front = front.Next;
//             Count--;
//             if (front is null)
//                 rear = null;

//             return value;
//         }

//         /// <summary>Returns the front item without removing it. Throws if empty.</summary>
//         public T Peek()
//         {
//             if (front is null)
//                 throw new InvalidOperationException("The queue is empty.");

//             return front.Value;
//         }

//         public void Clear()
//         {
//             front = null;
//             rear = null;
//             Count = 0;
//         }
//     }
// }
