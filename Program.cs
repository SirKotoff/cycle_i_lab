using System;


namespace cycle_i_lab
{
    class Program
    {
        //Котюков Александр 20 вариант Лабораторная работа Итерационные циклы 

        static double F(double x)
        {
            return (Math.Pow(x, 3) - Math.Pow(2 * x, 2) - Math.Pow(0.2, x) + 0.5);
        }




        static double Search(double a, double b, double eps)
        {
            double c = 0;
            while ((b - a) / 2 > eps)
            {


                c = (a + b) / 2;
                if (F(a) * F(c) > 0)
                {
                    a = c;
                }
                else
                {
                    b = c;
                }



            }
            return c;

        }



        static void Main(string[] args)
        {


            Console.WriteLine("По заданию [-2;0]");
            double x = 0;
            Console.WriteLine("Введите число A");
            double A = Convert.ToDouble(Console.ReadLine()); // начальная точка
            Console.WriteLine("Введите число B");
            double B = Convert.ToDouble(Console.ReadLine()); // конечная точка
            Console.WriteLine("Введите точность");
            double eps = Convert.ToDouble(Console.ReadLine()); // точность
            x = Search(A, B, eps);
            Console.WriteLine(x.ToString());

            Console.ReadKey();

        }


    }
}
