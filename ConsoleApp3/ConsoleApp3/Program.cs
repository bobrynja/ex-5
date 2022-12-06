using System;

namespace ConsoleApp3
{
    class Program
    {

        static double f(double x)
        {
            try
            {
                if (x < 1 && x > -1) return 1 / (x + 7) + Math.Log(1 - Math.Abs(x));
                else throw new Exception();
            }
            catch { throw; }
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите нижнюю границу: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите верхнюю границу: ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите шаг: ");
                double h = Convert.ToDouble(Console.ReadLine());
                if (a > b) Console.WriteLine("Нижняя граница не может быть больше верхней");
                else if (h == 0) Console.WriteLine("Шаг не может быть равен 0");
                else
                {
                    for (double x = a; x <= b; x += h)
                    {
                        try
                        {
                            Console.WriteLine("y({0:f2})={1:f4}", x, f(x));
                        }
                        catch { Console.WriteLine("y({0})=ошибка", x); }
                    }
                }
            }
            catch(FormatException) { Console.WriteLine("Неверный формат ввода данных"); }
            catch
            {
                Console.WriteLine("Неизвестная ошибка");
            }
        }
    }
}
