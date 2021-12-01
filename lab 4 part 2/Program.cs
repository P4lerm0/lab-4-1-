using System;

namespace lab_4_part_2
{
    class Program
    {

        static double Method(double k)
        {
            double m = (k + 5) / 3;
            return m;
        }
        static double Rec(double k)
        {
            if (k == 1)
            {
                return Method (k);
            }
            else
            {
                return Method(k) + Rec(k - 1);
            }
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double m = Rec(n);

            Console.WriteLine(m);
            Console.ReadKey();
        }
    }
}
