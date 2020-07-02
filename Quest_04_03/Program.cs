using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest_04_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Бросаются две игральные кости | Выберите вероятность того, что:");
            Console.WriteLine("а) сумма числа очков не превосходит N");
            Console.WriteLine("б) произведение числа очков не превосходит N");
            Console.WriteLine("в) произведение числа очков делится на N");

            string variant = Console.ReadLine();

            int NumberOnCube = 6;

            //int countСube = 2; // кол-во  кубиков [ne yasen smysl Count]

            int N = 0;

            int n, m;
            double P;
            //Variant A
            #region
            if (variant == "а")
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Введите N");
                        N = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        continue;
                    }
                }

                P = 0;
                // massiv A

                int[,] massivA = new int[NumberOnCube, NumberOnCube];


                n = 0;
                m = 0;

                for (int i = 1; i <= massivA.GetLength(1); i++)
                {
                    for (int j = 1; j <= massivA.GetLength(0); j++)
                    {
                        massivA[i - 1, j - 1] = i + j;
                        n++;

                        if (massivA[i - 1, j - 1] <= N)
                        {
                            m++;
                        }
                    }
                }

                P = (double)m / n;

                Console.WriteLine("\n Матрица возможных вариантов");



                for (int i = 0; i < massivA.GetLength(1); i++)
                {
                    for (int j = 0; j < massivA.GetLength(0); j++)
                    {
                        Console.Write(massivA[i, j] + " ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("n= " + n);

                Console.WriteLine("m= " + m + "\n");

                Console.WriteLine("Вероятность выпадения суммы числа очков " +
                    "которые  не превосходит " + N + " = " + Math.Round(P, 4) * 100 + "%");
            }
            #endregion
            // Variant Б
            #region
            if (variant == "б")
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Введите N");
                        N = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        continue;
                    }
                }

                P = 0;
                //massiv Б
                int[,] massivA = new int[NumberOnCube, NumberOnCube];


                n = 0;
                m = 0;

                for (int i = 1; i <= massivA.GetLength(1); i++)
                {
                    for (int j = 1; j <= massivA.GetLength(0); j++)
                    {
                        massivA[i - 1, j - 1] = i * j;
                        n++;

                        if (massivA[i - 1, j - 1] <= N)
                        {
                            m++;
                        }
                    }
                }

                P = (double)m / n;

                Console.WriteLine("\n Матрица возможных вариантов");



                for (int i = 0; i < massivA.GetLength(1); i++)
                {
                    for (int j = 0; j < massivA.GetLength(0); j++)
                    {
                        Console.Write(massivA[i, j] + " ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("n= " + n);

                Console.WriteLine("m= " + m + "\n");

                Console.WriteLine("Вероятность выпадения произведения чисел очков " +
                    "которые  не превосходит " + N + " = " + Math.Round(P, 4) * 100 + "%");
            }
            #endregion
            //Variant  B
            #region
            if (variant == "в")
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Введите N");
                        N = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        continue;
                    }
                }

                P = 0;
                // massiv B
                int[,] massivA = new int[NumberOnCube, NumberOnCube];


                n = 0;
                m = 0;

                for (int i = 1; i <= massivA.GetLength(1); i++)
                {
                    for (int j = 1; j <= massivA.GetLength(0); j++)
                    {
                        massivA[i - 1, j - 1] = (i * j) / N;
                        n++;

                        if (massivA[i - 1, j - 1] <= N)
                        {
                            m++;
                        }
                    }
                }

                P = (double)m / n;

                Console.WriteLine("\n Матрица возможных вариантов");

                for (int i = 0; i < massivA.GetLength(1); i++)
                {
                    for (int j = 0; j < massivA.GetLength(0); j++)
                    {
                        Console.Write(massivA[i, j] + " ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("n= " + n);

                Console.WriteLine("m= " + m + "\n");

                Console.WriteLine("Вероятность выпадения произведения чисел очков делющихся на N - " +
                     N + " = " + Math.Round(P, 4) * 100 + "%");
            }
            #endregion
            Console.ReadKey();
        }
    }
}
