using System;

/// <summary>A Queue class.</summary>
/// <typeparam name="T">The type contained in the Queue.</typeparam>
class Queue<T>
{
    /// <summary>The first mode (head) in the Queue.</summary>
    /// <value>gets/sets the head Node.</value>
    public Node head { get; set; }

    /// <summary>The last node (tail) in the Queue.</summary>
    /// <value>gets/sets the tail Node.</value>
    public Node tail { get; set; }

    /// <summary>The number of nodes in the Queue.</summary>
    /// <value>gets/sets the count int.</value>
    public int count { get; set; }

    /// <summary>Get the type that Queue contains.</summary>
    /// <returns>The type in Queue.</returns>
    public Type CheckType()
    {
        return typeof(T);
    }

    /// <summary>Adds a value to the end of the Queue.</summary>
    /// <param name="value">The value to append.</param>
    public void Enqueue(T value)
    {
        count++;

        if (head == null)
        {
            head = new Node(value);
            tail = head;
            return;
        }

        tail.next = new Node(value);
        tail = tail.next;
        return;
    }

    /// <summary>Dequeues the first element in the Queue.</summary>
    /// <returns>The value of the element removed from the queue, or the default value.</returns>
    public T Dequeue()
    {
        if (count == 0)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }

        count--;

        T ret = head.value;
        head = head.next;

        return (ret);
    }

    /// <summary>Gets the first value in the Queue without removing it.</summary>
    /// <returns>The value at the head of the Queue.</returns>
    public T Peek()
    {
        if (count == 0)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        return (head.value);
    }

    /// <summary>Prints all the values in the Queue.</summary>
    public void Print()
    {
        if (count == 0)
        {
            Console.WriteLine("Queue is empty");
            return;
        }

        Node on = head;

        while (on != null)
        {
            Console.WriteLine(on.value);
            on = on.next;
        }
    }

    /// <summary>Concatenates all values in the Queue, only if the Queue is of type String or Char.</summary>
    public string Concatenate()
    {
        if (count == 0)
        {
            Console.WriteLine("Queue is empty");
            return;
        }
        if (typeof(T) != typeof(String) && typeof(T) != typeof(Char))
        {
            Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
            return null;
        }
        string ret = "";
        Node on = head;

        while (on != null)
        {
            if (typeof(T) == typeof(string) && ret != "")
                ret += " ";
            ret += on.next;
            on = on.next;
        }
        return (ret);
    }

    /// <summary>Gets the number of items in the Queue.</summary>
    /// <returns>The number of items in the Queue.</returns>
    public int Count()
    {
        return this.count;
    }

    /// <summary>A node to store data for the Queue.</summary>
    public class Node
    {
        /// <summary>The value that the node contains.</summary>
        /// <value>The value property gets/sets the value property of type T.</value>
        public T value { get; set; }

        /// <summary>The next node in the linked list.</summary>
        /// <value>The next property gets/sets the next property of type Node.</value>
        public Node next { get; set; }

        public Node(T value)
        {
            this.value = value;
            this.next = null;
        }
    }
}