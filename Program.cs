using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Collections in C#");
            //Calling Methods
            doListDemo();
            doStackDemo();
            doQueueDemo();
            doDictionaryDemo();
            doSetDemo();
            Console.ReadLine();

        }

        //List in Collections
        private static void doListDemo()
        {
            Console.WriteLine("\nIn doListDemo");
            //Creating List
            List<string> list = new List<string>();
            //Adding Object to the List
            list.Add("Ravi");
            list.Add("Vijay");
            list.Add("Ravi");
            list.Add("Ajay");

            //Iterating List Elements
            Console.WriteLine("\nIterating List elements");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        //Stack in Collections
        private static void doStackDemo()
        {
            Console.WriteLine("\nIn doStackDemo");
            //Creating Stack
            Stack<string> stack = new Stack<string>();
            stack.Push("Ayush");
            stack.Push("Garvit");
            stack.Push("Amit");
            stack.Push("Ashish");
            stack.Push("Garima");
            string pop = stack.Pop();

            //Iterating Stack Elements
            Console.WriteLine("\nIterating the stack elements:");
            foreach (var elements in stack)
            {
                Console.WriteLine(elements);
            }
            Console.WriteLine("\nPoped element: " + pop);
            Console.ReadLine();
        }

        //Queue in Collections
        private static void doQueueDemo()
        {
            Console.WriteLine("\nIn doQueueDemo");
            //Creating Queue
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Ayush");
            queue.Enqueue("Garvit");
            queue.Enqueue("Amit");
            queue.Enqueue("Ashish");
            queue.Enqueue("Garima");
            Console.WriteLine("\nHead:" + queue.Peek());
            Console.WriteLine("\nIterating the queue elements:");

            //Iterating Queue Elements
            foreach (var elements in queue)
            {
                Console.WriteLine(elements);
            }
            string deueue = queue.Dequeue();
            Console.WriteLine("\nDeueue element: " + deueue);

            Console.WriteLine("\nIterating the queue elements after dequeue one element:");
            //Iterating Queue elements using Enumerator
            Queue<string>.Enumerator enumerator = queue.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
            Console.ReadLine();
        }

        //Dictionary in Collections
        private static void doDictionaryDemo()
        {
            Console.WriteLine("\nIn doDictionaryDemo");
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "Amit");
            dictionary.Add(2, "Rahul");
            dictionary.Add(3, "Vijay");

            Console.WriteLine("\nAccess value using key(key=1):" + dictionary[1]);

            Console.WriteLine("\nIterating Dictionary:");
            foreach (var element in dictionary)
            {
                Console.WriteLine("Key = " + element.Key + " & Value = " + element.Value);
            }
            Console.ReadLine();
        }

        //Set in Collections
        private static void doSetDemo()
        {
            Console.WriteLine("\nIn doSetDemo");

            var set = new HashSet<string>();
            set.Add("Ravi");
            set.Add("Vijay");
            set.Add("Ravi");
            set.Add("Ajay");

            HashSet<string>.Enumerator enumerator = set.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
            Console.ReadLine();
        }
    }
}
