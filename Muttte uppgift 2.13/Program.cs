using System;
// Mustafa uppgift 2.13 

namespace uppgift_2_13
{
    public class program
    {
        public static void Main()
        {

            Console.WriteLine("Lön för Mutteone");
            int Mutteone = int.Parse(Console.ReadLine());

            Console.WriteLine("Lön för Muttetvå");
            int Muttetwo = int.Parse(Console.ReadLine());

            Console.WriteLine("lön för Muttetre");
            int Muttetre = int.Parse(Console.ReadLine());

            Console.WriteLine("Mutteone" + Mutteone + "kr" + "Muttetwo" + Muttetwo + "kr" + "Muttetre" + Muttetre + "kr");

            Console.WriteLine((Mutteone + Muttetwo + Muttetre) / 3);
        }
    }
}