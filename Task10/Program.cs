using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            Corner corner;
            do
            {
                Console.WriteLine("Введите данные");
                int g = Convert.ToInt32(Console.ReadLine());
                int m = Convert.ToInt32(Console.ReadLine());
                int s = Convert.ToInt32(Console.ReadLine());

                corner = new Corner(g, m, s);
            }
            while (corner.isCorrect == false);

            double resultRadians = corner.ToRadians();
            Console.WriteLine(resultRadians);
            Console.ReadKey();


        }
    }
}
