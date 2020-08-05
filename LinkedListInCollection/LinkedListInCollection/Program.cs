using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListInCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> lList = new LinkedList<string>(new string[] { "quick", "fox", "the", "lazy" });
            foreach (var i in lList)
            {
                Console.WriteLine(i);
            }
            lList.AddFirst("the ");
            foreach (var j in lList)
            {
                Console.WriteLine(j);
            }
            var l = lList.AddLast("fox");
            foreach (var k in lList)
            {
                Console.WriteLine(k);
            }
            lList.AddAfter(lList.Find("quick"), "brown");
            foreach (var k in lList)
            {
                Console.WriteLine(k);
            }
            lList.AddBefore(lList.FindLast("the"), "over");
            foreach (var k in lList)
            {
                Console.WriteLine(k);
            }
            lList.AddBefore(lList.Find("over"), "jumps");
            foreach (var k in lList)
            {
                Console.Write(k);
            }
            Console.Read();
        }
    }
}
