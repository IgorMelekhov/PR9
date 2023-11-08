//Практическая работа номер 9
//Выполнил Мелехов И.В
//Составить массив вещественных чисел 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;

namespace RR9
{
    class Program
    {
        static void Main(string[] args)
        {
            double left;
            double right;
            while (true)
            {
                Console.Clear();
                Console.Write("Нажмите Y чтобы продолжить или N чтобы прекратить: ");
                bool flag = false;
                string select_key = Console.ReadLine();

                switch (select_key)
                {
                    case "Y":

                        try
                        {
                            try
                            {
                                Console.WriteLine("Здравствуйте\nПрактическая работа номер 9");
                                Console.Write("Введите левую гарницу случайных чисел=");
                                left = Convert.ToDouble(Console.ReadLine());
                                Console.Write("Введите правую границу случайных чисел=");
                                right = Convert.ToDouble(Console.ReadLine());
                                if (left == right)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Конечное и начальное значения одинаковы");
                                    flag = true;
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                }
                                try
                                {
                                    int i = 0;
                                    const int m = 15;
                                    Random rnd = new Random();//Создание массива с рандомными числами
                                    double[] array = new double[m];

                                    for (i = 0; i < m; i++)
                                    {
                                        array[i] = Math.Round(rnd.NextDouble() + left, 3);
                                        Console.WriteLine("\nМассив:{0}", string.Join(" ", array));
                                    }
                                    Array.Sort(array);//Сортировка значений по возрастанию
                                    Console.WriteLine("\nСортированный массив:{0}", string.Join(" ", array));
                                    for (i = 0; i < array.Length; i++)
                                    {
                                        array[i] *= 1000;
                                    }
                                    double min = array[0];
                                    int j = 14;
                                    for (i = 0; i < m; i++)
                                    {
                                        if (array[j] % 2 != 0)
                                        {
                                            array[j] = min;//проверка условия и в случае нечетности максимального значения замена его минимальным
                                            break;
                                        }
                                        else { array[j] = array[j--]; }
                                    }
                                    for (i = 0; i < array.Length; i++)
                                    {
                                        array[i] /= 1000;
                                    }
                                    Console.WriteLine("\nРезультирующий массив:{0}", string.Join(" ", array));
                                    Console.ReadLine();
                                }
                                catch (IndexOutOfRangeException ior)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(ior.Message);
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                }
                                break;
                            }

                            catch (FormatException fe)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(fe.Message);
                                Console.ForegroundColor = ConsoleColor.Gray;
                            }
                            Console.ReadLine();
                            break;
                        }catch (Exception ex)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(ex.Message);
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        break;
                    case "N":
                        Console.WriteLine("До свидания");
                        Thread.Sleep(2000);
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}


