using System;
using System.Collections;
using System.Collections.Generic;

namespace Codding_Challange
{
    public class ImplementingQueueWithStack
    {
      
        static Stack<int> Stack1 { get; set; }
        static Stack<int> Stack2 { get; set; }
        static ImplementingQueueWithStack()
        {
            Stack1 = new Stack<int>();
            Stack2 = new Stack<int>();
        }

        public static void Enqueue(int x)
        {
            Stack1.Push(x);
        }
        public static void Dequeue()
        {
            while(Stack1.Count > 1)
            {
                var element = Stack1.Pop();
                Stack2.Push(element);
            }
            var dequed = Stack1.Pop();
            Console.WriteLine("Dequed element: {0}", dequed);
            while (Stack2.Count > 0)
            {
                var element = Stack2.Pop();
                Stack1.Push(element);
            }
        }
        public static void Print()
        {
            while (Stack1.Count > 0)
            {
                var element = Stack1.Pop();
                Stack2.Push(element);
            }
            Console.WriteLine("Element at the head of the queue: {0}",Stack2.Peek());
            while (Stack2.Count > 0)
            {
                var element = Stack2.Pop();
                Stack1.Push(element);
            }
        }
        /*
        public static void Main(string[] args)
        {
            
            string firstInput;
            Console.Write("Enter number of operation: ");
            firstInput = Console.ReadLine();

            int numberOfOperation = Convert.ToInt32(firstInput);
            Console.WriteLine("Your input: {0}", numberOfOperation);

            //var init = new ImplementingQueueWithStack();
            while (numberOfOperation > 0)
            {
                string nextOperation = Console.ReadLine();
                var arr = nextOperation.Split(" ");
                if(arr.Length > 1)
                {
                    if (arr[0] == "1")
                    {
                        var input = Convert.ToInt32(arr[1]);
                        Enqueue(input);
                        Console.WriteLine("Your input to the queue: {0}", input);
                    }
                       
                }
                else
                {
                    if (arr[0] == "2")
                        Dequeue();
                    else if (arr[0] == "3")
                        Print();
                }
                numberOfOperation--;
            }

        }
        */
    }
}
