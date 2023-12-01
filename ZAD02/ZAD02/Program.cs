using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD02
{
    internal class Program
    {
        class Noot
        {
            public static int[] price = new int[10];
            public static string[] name = new string[10], processor = new string[10], ram = new string[10], hdd = new string[10];
        }
        static void Main(string[] args)
        {
            int a = 0;
            Console.Write("Кол-во ноутов: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i != a; i++)
            {
                Console.Write("Name: "); Noot.name[i] = Convert.ToString(Console.ReadLine());
                Console.Write("Price: "); Noot.price[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Processor: "); Noot.processor[i] = Convert.ToString(Console.ReadLine());
                Console.Write("Ram: "); Noot.ram[i] = Convert.ToString(Console.ReadLine());
                Console.Write("HDD: "); Noot.hdd[i] = Convert.ToString(Console.ReadLine());
                Console.WriteLine("******************************************");
            }
            Console.WriteLine();
            Console.WriteLine("------------------------------------");
            int b = 0;
            b = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i != b; i++)
            {
                Console.WriteLine("Name: " + Noot.name[i]); 
                Console.WriteLine("Price: " + Noot.price[i]);
                Console.WriteLine("Processor: " + Noot.processor[i]);
                Console.WriteLine("Ram: " + Noot.ram[i]);
                Console.WriteLine("HDD: " + Noot.hdd[i]);
                Console.WriteLine("******************************************");
            }
        }
    }
}
