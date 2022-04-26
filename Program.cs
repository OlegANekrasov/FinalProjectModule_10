using System;

namespace FinalProjectModule_10
{
    class Program
    {
        static ILogger Logger { get; set; }

        static void Main(string[] args)
        {
            Logger = new Logger();
            var miniCalculator = new MiniCalculator(Logger);

            Console.WriteLine("Сумма двух чисел... ");
            try
            {
                Console.Write("Введите первое число: ");
                double v1 = ValueInput();

                Console.Write("Введите второе число: ");
                double v2 = ValueInput();

                miniCalculator.Sum(v1, v2);
            }
            catch (FormatException e)
            {
                miniCalculator.Error($"Тип исключения: {e.GetType()}, Ошибка: {e.Message}");
            }
            catch (OverflowException e)
            {
                miniCalculator.Error($"Тип исключения: {e.GetType()}, Ошибка: {e.Message}");
            }
            catch (Exception e)
            {
                miniCalculator.Error($"Тип исключения: {e.GetType()}, Ошибка: {e.Message}");
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nПрограмма завершена!");
            }
            Console.ReadKey();
        }

        static double ValueInput()
        {
            string str = Console.ReadLine();
            double result = double.Parse(str);

            return result;
        }
    }
}
