using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_8_Collection.HomeWork
{
    internal class TaskThree
    {
        public void RunTaskThree()
        {
            HashSet<int> listHash = new HashSet<int>(new int[] { 1, 2, 3, 4, 5, 6 });

            while (true)
            {
                foreach (int i in listHash)
                {
                    Console.Write($" {i}");
                }
                Console.WriteLine("\nAdd number\n" +
                                  "\nPress * if you want finish\n");

                string num = Console.ReadLine();

                if (num.Equals("*")) 
                {
                    break;
                }
                if (listHash.Contains(int.Parse(num))) 
                {
                    Console.WriteLine("\nNumber exist\n");
                    continue;
                }
                listHash.Add(int.Parse(num));
            }
        }
    }   
}
