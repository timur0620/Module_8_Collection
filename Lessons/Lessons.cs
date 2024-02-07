using Module_7_Class.HomeWork.HomeWork.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Module_8_Collection.Lessons
{
    internal class Lessons
    {
        private void ListCollection()
        {
            List<int> list = new List<int>() {1, 2, 3, 4 };
            list.Add(1);
            list.AddRange(list);
            list.Sort();
            list.Remove(0);
        }
        private void DictionaryCollection()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("Name", "SomeName");
            dict.Add("LastName", "SomeLastName");
            //KeyValuePair<string, string>

            foreach (KeyValuePair<string, string> item in dict)
            {
                Console.WriteLine(item);
                string str =  dict["Name"];
            }
        }
        private void QueueCollection() 
        {
            Queue<int> list = new Queue<int>();
            list.Enqueue(1);
            list.Enqueue(2);
            list.Enqueue(3);
            list.Enqueue(4);
        }
        private void StackCollection()
        {
            Stack<int> list = new Stack<int>();
            list.Push(1);
            list.Push(2);
            list.Push(3);
            list.Push(4);
        }
        private void HashCollection()
        {
            HashSet<int> list = new HashSet<int>(new int[] {1, 2, 3, 4, 5});
        }
        private static void XMLSerialize()
        {
            Worker worker = new Worker(1,DateTime.Now, "NAme", 10, 180, DateTime.Now, "SomePlace" );

            //worker.SerializeWorkerXML(worker, worker.GetPath());
            worker.DESerializeWorkerXML(worker.GetPath());
        }

    }
}
