using System;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Default;
            Console.OutputEncoding = System.Text.Encoding.Default;
            double a, b, c;
            Console.WriteLine("Введіть а=");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть b=");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть c=");
            c = Convert.ToDouble(Console.ReadLine());
            double D;
            Console.WriteLine($"{a}x^2+{b}x+{c}");
            D = Math.Pow(b,2) - 4 * a * c;
            if (D > 0)
            {
                double x1 =(-b+Math.Sqrt(D))/(2*a);
                double x2 =(-b-Math.Sqrt(D))/(2*a);
                Console.WriteLine($"Рівняння має два корені = {x1},{x2}");
            }
            if (D == 0)
            {
                double x = (-b) / 2 * a;
                Console.WriteLine($"Рівняння має один корінь = {x}");
            }
            if (D< 0)
            {
                Console.WriteLine("Рівняння не має коренів");
            }
        }
    }
}
