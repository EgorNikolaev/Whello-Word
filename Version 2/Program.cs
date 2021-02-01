using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Word
{
    class Program
    {
        static void Rand() 
        {
            Random rand = new Random();
            int val = rand.Next(1, 101);
            Console.WriteLine(val);
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Helo Word");
             Rand();
            Console.ReadKey();
        }
    }
}
