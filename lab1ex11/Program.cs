using System;

namespace lab1ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Num = ");

            int num = int.Parse(Console.ReadLine());

            /*
  switch (num)
{
    case 1:
        str = "unu";
        break;
    case 2:
        str = "doi";
        break;
    case 3:
        str = "trei";
        break;
    case 5:
        str = "cinci";
        break;
    case 8:
        str = "opt";
        break;
    default:
        str = "neidentificat";
        break;
}
 */

            string str = num switch
            {
                1 => "unu",
                2 => "doi",
                3 => "trei",
                5 => "cinci",
                8 => "opt",
                _ => "neidentificat",
            };

            Console.WriteLine(str);
        }
    }
}
