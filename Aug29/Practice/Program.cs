using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    //class Stack
    //{
    //    private int[] ele;
    //    private int top;
    //    private int max;
    //    public Stack(int size)
    //    {
    //        ele = new int[size]; 
    //        top = -1;
    //        max = size;
    //    }

    //    public void push(int item)
    //    {
    //        if (top == max - 1)
    //        {
    //            Console.WriteLine("Stack Overflow");
    //            return;
    //        }
    //        else
    //        {
    //            ele[++top] = item;
    //        }
    //    }

    //    public int pop()
    //    {
    //        if (top == -1)
    //        {
    //            Console.WriteLine("Stack is Empty");
    //            return -1;
    //        }
    //        else
    //        {
    //            Console.WriteLine("{0} popped from stack ", ele[top]);
    //            return ele[top--];
    //        }
    //    }

    //    public int peek()
    //    {
    //        if (top == -1)
    //        {
    //            Console.WriteLine("Stack is Empty");
    //            return -1;
    //        }
    //        else
    //        {
    //            Console.WriteLine("{0} popped from stack ", ele[top]);
    //            return ele[top];
    //        }
    //    }

    //    public void printStack()
    //    {
    //        if (top == -1)
    //        {
    //            Console.WriteLine("Stack is Empty");
    //            return;
    //        }
    //        else
    //        {
    //            for (int i = 0; i <= top; i++)
    //            {
    //                Console.WriteLine("{0} pushed into stack", ele[i]);
    //            }
    //        }
    //    }
    //}


    //class Program
    //{
    //    static void Main()
    //    {
    //        Stack p = new Stack(5);

    //        p.push(10);
    //        p.push(20);
    //        p.push(30);
    //        p.printStack();
    //        p.pop();
    //    }
    //}

    //public class ListNode<T>
    //{
    //    private ListNode<T> next;
    //    private T item;

    //    public ListNode<T> Next
    //    {
    //        get { return next; }
    //        set { next = value; }
    //    }


    //    public T Item
    //    {
    //        get { return item; }
    //        set { item = value; }
    //    }

    //    /// <p name="item">

    //    public ListNode(T item)
    //    : this(item, null)
    //    {
    //    }


    //    /// <param name="item"></param>
    //    /// <p name="next"></param>

    //    public ListNode(T item, ListNode<T> next)
    //    {
    //        this.item = item;
    //        this.next = next;
    //    }


    //    public override string ToString()
    //    {
    //        if (item == null)
    //            return string.Empty;
    //        return item.ToString();
    //    }
    //}

    //q2
    //public class Queue
    //{
    //    private int front, rear, capacity;
    //    private int[] queue;

    //    public Queue(int c)
    //    {
    //        front = rear = 0;
    //        capacity = c;
    //        queue = new int[capacity];
    //    }

      
    //    public void queueEnqueue(int data)
    //    {
           
    //        if (capacity == rear)
    //        {
    //            Console.Write("\nQueue is full\n");
    //            return;
    //        }

         
    //        else
    //        {
    //            queue[rear] = data;
    //            rear++;
    //        }
    //        return;
    //    }

      
    //    public void queueDequeue()
    //    {
            
    //        if (front == rear)
    //        {
    //            Console.Write("\nQueue is empty\n");
    //            return;
    //        }

       
    //        else
    //        {
    //            for (int i = 0; i < rear - 1; i++)
    //            {
    //                queue[i] = queue[i + 1];
    //            }

    
    //            if (rear < capacity)
    //                queue[rear] = 0;

                
    //            rear--;
    //        }
    //        return;
    //    }

        
    //    public void queueDisplay()
    //    {
    //        int i;
    //        if (front == rear)
    //        {
    //            Console.Write("\nQueue is Empty\n");
    //            return;
    //        }

            
    //        for (i = front; i < rear; i++)
    //        {
    //            Console.Write(" {0} <-- ", queue[i]);
    //        }
    //        return;
    //    }

      
    //    public void queueFront()
    //    {
    //        if (front == rear)
    //        {
    //            Console.Write("\nQueue is Empty\n");
    //            return;
    //        }
    //        Console.Write("\nFront Element is: {0}", queue[front]);
    //        return;
    //    }
    //}

    //public class StaticQueuein
    //{

        
    //    public static void Main(String[] args)
    //    {
           
    //        Queue q = new Queue(4);

    //        q.queueDisplay();

            
    //        q.queueEnqueue(20);
    //        q.queueEnqueue(30);
    //        q.queueEnqueue(40);
    //        q.queueEnqueue(50);

            
    //        q.queueDisplay();

            
    //        q.queueEnqueue(60);

            
    //        q.queueDisplay();

    //        q.queueDequeue();
    //        q.queueDequeue();
    //        Console.Write("\n\nafter two node deletion\n\n");

            
    //        q.queueDisplay();

           
    //        q.queueFront();
    //    }
    //}

}
