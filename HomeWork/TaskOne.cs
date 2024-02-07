using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_8_Collection.HomeWork
{
    internal class TaskOne
    {
        public void RunTask_1()
        {
            Console.WriteLine("_______Create List______\n");
            List<int> GrList = CreateSortList();
            PrintList(GrList);

            Console.WriteLine("\n_______New list______");
            List<int> DelList = DeleteNumber(GrList);
            PrintList(DelList);
        }
        private static List<int> CreateSortList()
        {
            Random random = new Random();

            List<int> listInt = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                listInt.Add(random.Next(0, 99));
            }
            listInt.Sort();
            return listInt;
        }
        private static List<int> DeleteNumber(List<int> listInt)
        {
            List<int> listTemp = new List<int>();
            
            foreach (var item in listInt)
            {
                if (item < 25 || item > 50)
                {
                    listTemp.Add(item);
                }
            }
            return listTemp;
        }
        private static void PrintList(List<int> listInt)
        {
            foreach (var item in listInt)
            {
                Console.Write($" {item}");
            }
        }
    }
}
