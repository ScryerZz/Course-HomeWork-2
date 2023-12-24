using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_HomeWork_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                int digit = 0;

                try
                {
                    Console.WriteLine("Какое число Вы хотите проверить на четность?");
                    digit = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Было введено некоректное число!");
                    Console.WriteLine("Нажмите Enter чтобы очистить консоль!");
                    Console.ReadLine();
                    continue;
                }

                if (digit % 2 == 0)
                {
                    Console.WriteLine($"Число {digit} является четным!");
                }
                else if (digit % 2 != 0)
                {
                    Console.WriteLine($"Число {digit} не четное!");
                }

                Console.WriteLine("Нажмите Enter чтобы очистить консоль");
                Console.ReadLine();
            }
        }
    }
}
