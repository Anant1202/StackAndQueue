using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    //Stack follows LIFO(Last In First Out)
    public class Stack
    {
        //Creating a node top
        public Node top;
        //Push will add value 
        public void Push(int data)
        {
            Node new_node = new Node(data);
            if (top != null)
            {
                new_node.next = top;
            }
            top = new_node;
            Console.WriteLine("New Node {0} is added ", new_node.data);
        }
        //For Printing or Display of Result
        public void Display()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Node temp = top;
            while (temp != null)
            {
                Console.WriteLine("|" + temp.data + "|");
                temp = temp.next;
            }
        }
    }
}    
    