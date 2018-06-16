using System;

namespace _01.Padawan
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double lightsabersPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double moreSabers = countOfStudents + Math.Ceiling(countOfStudents * 0.10);
            double sabersTotalPrice = lightsabersPrice * moreSabers;
            double robesTotalPrice = robesPrice * countOfStudents;
            double beltTotalPrice = beltPrice * countOfStudents;


            for (int i = 1; i <= countOfStudents; i++)
            {
                if (i % 6 == 0)
                {
                    sabersTotalPrice -= beltPrice;
                }
            }

            double totalPrice = sabersTotalPrice + robesTotalPrice + beltTotalPrice;

            if (totalPrice <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {totalPrice-money:f2}lv more.");
            }
        }
    }
}
