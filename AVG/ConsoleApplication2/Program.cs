using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int yek, two, seh;
            int avg;
            int saltavalod;
            string hamid;
            Console.Write("please enter your name ");
            hamid = Console.ReadLine();
            Console.WriteLine("your name is "+hamid);
            Console.WriteLine("enter your birthday ");
            saltavalod = int.Parse(Console.ReadLine());
            Console.WriteLine("you born in " + saltavalod);
            Console.WriteLine("inter your first grade ");
            yek=int.Parse(Console.ReadLine());
            Console.WriteLine("inter your socand grade ");
            two = int.Parse(Console.ReadLine());
            Console.WriteLine("inter your third grade ");
            seh = int.Parse(Console.ReadLine());
            avg = (yek + two + seh) / 3;
            Console.WriteLine("your avg is " +avg);
            Console.ReadKey();
        }
    }
}
