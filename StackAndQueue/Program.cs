using System;

namespace StackAndQueue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("Welcome to Stack and Queue Program");
            do
            {
                Console.WriteLine("1.Stack- Push Operation");
                Console.WriteLine("2.Stack-Peek and Pop Operation");
                Console.WriteLine("Enter your choice");
                choice = Convert.ToInt32(Console.ReadLine());
                Stack obj = new Stack();
                switch (choice)
                {
                    case 1:
                        obj.Push(70);
                        obj.Push(30);
                        obj.Push(56);
                        obj.Display();
                        break;
                    case 2:
                        obj.Push(70);
                        obj.Push(30);
                        obj.Push(56);
                        obj.Peek();
                        obj.Display();
                        obj.Pop();
                        obj.Display();
                        break;
                    default:
                        Console.WriteLine("Enter a valid input!");
                        break;
                }
            } while (choice != 3);
        }
    }
}

