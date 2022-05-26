using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    //Queue follows FIFO(First In First Out)
    public class Queue
    {
        public Node front;    //delete an element
        public Node rear;     //insert an element
        //Enqueue means Insertion of element
        public void Enqueue(int data)
        {
            Node new_node = new Node(data);
            if (front == null)
            {
                rear = new_node;
                front = rear;
            }
            else
            {
                rear.next = new_node;
                rear=rear.next;
            }
        }
        //Dequeue-Used for deletion of head/front
        public void Dequeue()
        {
            if (front == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Node temp = front;
            front = front.next;
        }
        //For Priting or Display of Result
        public void Display()
        {
            if (front == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            Node temp = front;
            while(temp!= null)
            {
                Console.WriteLine("|"+temp.data+"|");
                temp = temp.next;
            }
        }
    }
}
