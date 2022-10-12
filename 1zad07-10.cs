using System;
namespace restless
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.Write("a = "); //программа просит пользователя ввести значение переменной вещественного типа
            a = Convert.ToDouble(Console.ReadLine()); //вывод переменной
            Console.Write("b = "); //программа просит пользователя ввести значение переменной вещественного типа
            b = Convert.ToDouble(Console.ReadLine()); //вывод переменной
            Console.Write("c = "); //программа просит пользователя ввести значение переменной вещественного типа
            c = Convert.ToDouble(Console.ReadLine()); //вывод переменной
            Console.WriteLine($"({a:0.00}+{b:0.00})+{c:0.00}={a:0.00}+({b:0.00}+{c:0.00})"); // программа вычисляет
            Console.WriteLine("Для продолжения нажмите нажмите любую клавишу..."); //Программа ждёт пока пользователь нажмёт  любую клавишу 
        }
        
    }
}