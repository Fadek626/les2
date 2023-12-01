using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Money.rub = Convert.ToInt32(Console.ReadLine());
            Money.koop = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Money.rub+"руб. "+Money.koop+"коп.");
            Console.ReadLine();
        }
    }
}
