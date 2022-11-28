using System;

namespace lab1ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ex 11
                Folosind instructiunea “switch”, scrieti un program care citind de la tastatura un numar intreg va verifica urmatoarele
                “unu” daca numarul citit este 1
                “doi” daca numarul citit este 2
                “trei” daca numarul citit este 3
                “cinci” daca numarul citit este 5
                “opt” daca numarul citit este 8
                “neidentificat” pentru orice alt caz
             */

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
