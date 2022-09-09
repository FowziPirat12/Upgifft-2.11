using System;
namespace Upgift_2._11
{
    class Program
    {
        static void Main(String[]args)
        {
            Console.WriteLine("Hur långt hoppade Alma och Elin mätt i meter?");
            string höjdText = Console.ReadLine();
            double höjd = double.Parse(höjdText);
            double skillnad = 1.30 - höjd;
            Console.WriteLine("Elin hoppade" + skillnad + "meter högre än Alma");
        }
    }
}
