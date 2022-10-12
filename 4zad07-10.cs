using System;
namespace Hello
{
    class Program
    {
        static void Main()
        {
            Console.Write("a = "); //программа просит пользователя ввести значение переменной вещественного типа
            double a = Convert.ToDouble(Console.ReadLine()); //вывод данных
            Console.Write("b = "); //программа просит пользователя ввести значение переменной вещественного типа
            double b = Convert.ToDouble(Console.ReadLine()); //вывод данных
            Console.WriteLine("{0:F2}+{1:F2}={2:F2}", a, b, a+b); // программа вычисляет введёные данные по формуле
            Console.WriteLine("Для продолжения нажмите нажмите любую клавишу..."); //Программа ждёт пока пользователь нажмёт  любую клавишу 
        }
    }