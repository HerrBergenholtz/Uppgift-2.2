using System;

namespace Uppgift_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur långt hoppade Elin i meter?");
            float elin = float.Parse(Console.ReadLine());
            Console.WriteLine("Hur långt hoppade Alma i meter?");
            float alma = float.Parse(Console.ReadLine());

            float elinvinst = elin - alma;
            Console.WriteLine("Elin hoppade " + elinvinst + " meter längre än Alma");

            Console.ReadKey();
        }
    }
}