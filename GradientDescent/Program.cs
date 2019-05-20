using System;
using System.Collections.Generic;
namespace GradientMethods
{
    class MainClass
    {
        
        static double Function1(List<double> x) // n = 2
        {
            return Math.Pow((x[0] - 20), 2) + Math.Pow((x[0] - 2 * x[1]), 2);
        }

        static double Function2(List<double> x) // n = 2
        {
            return Math.Pow((2 * x[0] - x[1]), 2) + 3 * Math.Pow((x[1] - 2), 4);
        }

        static double Function3(List<double> x) // n = 2
        {
            return 100 * Math.Pow((x[1] - 2 * x[0]), 2) + Math.Pow((1 - x[0]), 2);
        }

        static double Function4(List<double> x) // n = 2
        {
            return x[0]*x[0] * Math.Sqrt(x[1]) + x[0]*x[1];
        }

        static double Function5(List<double> x) // n = 2
        {
            return Math.Pow((x[1] - Math.Pow(x[0], 2)), 2) + 2 * Math.Pow((1 - x[0]),2);               
        }

        static double Func111(List<double> x) // n = 1
        {
            return Math.Pow((x[0] * x[0] - 1), 3);
        }

        static double Funk123(List<double> x)
        {
            return Math.Pow((x[1] - x[0] * x[0]), 2) + Math.Pow((1 - x[0]), 2);
        }

        static double Funk1234(List<double> x)
        {
            return Math.Pow((x[0] + 10 * x[1]), 2) + 5 * Math.Pow((x[2] - x[3]), 2) + Math.Pow((x[1] - 2 * x[2]), 4) + 10 * Math.Pow((x[0] - x[3]), 4);
        }

        static double Funk12345(List<double> x)
        {
            return Math.Pow((x[0] * x[0] + x[1] - 11), 2) + Math.Pow((x[0] + x[1] * x[1] - 7), 2);
        }

        static double Funk123456(List<double> x)
        {
            return Math.Pow((x[0] - 2), 2) + 2 * Math.Pow((x[1] - 1), 2); 
        }

        static double Fun(List<double> x)
        {
            return Math.Pow(x[0] - 2, 2) + 1;
        }

        public static void Main(string[] args)
        {
            try
            {
                int iterAmount;
                double eps;

                Console.Write("Enter amount of variables: ");
                int variablesAmount = Convert.ToInt32(Console.ReadLine());



                int choise = 1;
                while (choise == 1)
                {
                    Console.Write("Enter accuracy of calculations: ");
                    eps = Convert.ToDouble(Console.ReadLine());
                    List<double> X0 = new List<double>();
                    Console.WriteLine("------ Enter initial point ------");
                    for (int i = 0; i < variablesAmount; i++)
                    {
                        Console.Write($"------ x{i + 1} = ");
                        X0.Add(Convert.ToDouble(Console.ReadLine()));
                    }

                    Console.WriteLine("============== RESULTS ==============");
                    //Console.WriteLine("Gradient Descent Method: ");
                    //iterAmount = 0;
                    //List<double> GDResult = new List<double>(GM.GradientDescent(Fun, X0, eps, ref iterAmount));

                    //Console.ForegroundColor = ConsoleColor.White;
                    //Console.BackgroundColor = ConsoleColor.DarkRed;
                    //Console.Write("M(");
                    //for (int i = 0; i < GDResult.Count - 1; i++)
                    //{
                    //    Console.Write($"{GDResult[i].ToString()},");
                    //}
                    //Console.Write($"{GDResult[GDResult.Count - 1]})");
                    //Console.ResetColor();

                    //Console.WriteLine($"\nF(M) = {Math.Round(Fun(GDResult), 10)}");

                    //Console.WriteLine($"Iterations amount: {iterAmount}");


                    //Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Newthons Method: ");
                    iterAmount = 0;
                    List<double> NMResult = GM.Newton(Function5, X0, eps, ref iterAmount);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("M(");
                    for (int i = 0; i < NMResult.Count - 1; i++)
                    {
                        Console.Write($"{NMResult[i].ToString()},");
                    }
                    Console.Write($"{NMResult[NMResult.Count - 1]})");
                    Console.ResetColor();

                    Console.WriteLine($"\nF(M) = {Math.Round(Function5(NMResult), 10)}");

                    Console.WriteLine($"Iterations amount: {iterAmount}");

                    Console.WriteLine("===================================================");
                    Console.WriteLine("Enter '1' to continue and enter annother button to exit.");
                    Console.Write(">>> ");
                    choise = Convert.ToInt32(Console.ReadLine());
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}
