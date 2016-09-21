using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAssignment
{
    class Program
    {

        public static Random random = new Random();

        public static string randomName()
        {
            string[] names = new string[8] { "Dan Morain", "Emily Bell", "Carol Roche", "Ann Rose", "John Miller", "Greg Anderson", "Arthur McKinney", "Joann Fisher" };
            int randomIndex = Convert.ToInt32(random.NextDouble() * 7);
            return names[randomIndex];
        }

        public static int randomNumberInRange()
        {
            return Convert.ToInt32(random.NextDouble() * 20);
        }

        static void Main(string[] args)
        {
            Queue<string> myQueue = new Queue<string>();

            Dictionary<string, int> myDictionary = new Dictionary<string, int>();

            for (int iCount = 0; iCount < 100; iCount++)
            {
                myQueue.Enqueue(randomName());
            }

            while (myQueue.Count() > 0)
            {

                try
                {
                    myDictionary.Add(myQueue.Peek(), randomNumberInRange());
                }
                catch
                {
                    myDictionary[myQueue.Peek()] = +randomNumberInRange();
                }

                myQueue.Dequeue();

            }

            foreach (KeyValuePair<string, int> entry in myDictionary)
            {
                Console.WriteLine(entry.Key.ToString() + "\t\t" + entry.Value);
            }

            Console.Read();
        }
    }
}
