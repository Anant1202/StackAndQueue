using System;

namespace StackAndQueue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack and Queue Program");
            Stack obj = new Stack();
            obj.Push(70);
            obj.Push(30);
            obj.Push(56);
            obj.Display();
        }
    }
}

