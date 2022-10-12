using System;
namespace Hello
{
    class Program
    {
        static void Main()
        {
            Console.Write("a = "); //программа просит пользователя ввести значение переменной вещественного типа
            int a = int.Parse(Console.ReadLine()); //вывод данных
            Console.Write("b = "); //вывод данных
            int b = int.Parse(Console.ReadLine()); //программа просит пользователя ввести значение переменной вещественного типа
            Console.WriteLine("{0}*{1}={2}", a, b, a * b); // программа вычисляет введёные данные по формуле
            Console.WriteLine("Для продолжения нажмите нажмите любую клавишу..."); //Программа ждёт пока пользователь нажмёт  любую клавишу 
        }
    }
}