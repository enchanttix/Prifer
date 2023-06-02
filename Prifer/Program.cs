using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Prifer
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Dekod dekod = new Dekod();
            //Kod kod = new Kod();
            //int option;
            //while (true)
            //{
            //    int k = 0;
            //    Console.WriteLine("\n1 - Кодирование\n" +
            //    "2 - Декодирование\n");
            //    try
            //    {
            //        option = Convert.ToInt32(Console.ReadLine());
            //        switch (option)
            //        {
            //            case 1:
            //                kod.total();
            //                Console.WriteLine("перейдите в 2.txt");
            //                break;
            //            case 2:

            //                break;
            //            default:
            //                k++;
            //                break;
            //        }

            //    }
            //    catch
            //    {
            //        Console.WriteLine("bye");
            //    }
            //    if (k != 0)
            //    {
            //        break;
            //    }
            //}
            dekod.v();
            Console.ReadLine();
        }
    }
}
