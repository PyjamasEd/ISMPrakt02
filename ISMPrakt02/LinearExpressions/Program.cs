using System;

namespace LinearExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Default;
            Console.OutputEncoding = System.Text.Encoding.Default;
            double a, b, c, d, x, y, z, r;
            double q, w, e, t;
            Console.WriteLine("Введіть а=");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть b=");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть c=");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть d=");
            d = Convert.ToDouble(Console.ReadLine());
            x = ((a + 2 * b - c + d) / (c * d))+((a + b) / (c - d))-(Math.Pow(a,2)/Math.Pow(b,2));
            y = ((5 * (a + b) * (c - d)) / ((1.0 / 2.0) * c))+ (Math.Pow(d, 2) * ((Math.Pow(a, 2) - Math.Pow(b, 2)) / (b - a)));
            z = (Math.Pow(Math.Pow(x,2)-2*x,3)-4*(Math.Pow(x,4)+1)*(1-b))/(5*a+3*b);
            r = ((((1.0 / 2) * a) + ((3.0 / 4) * b) - (7.0 / 5)) / (3 * c + 1)) + (1 / (a - c));
            Console.WriteLine($"x = {x}\ny = {y}\nz = {z}\nr = {r}");
        }
    }
}
