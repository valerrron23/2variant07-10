using System;
namespace restless
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.Write("a = "); //��������� ������ ������������ ������ �������� ���������� ������������� ����
            a = Convert.ToDouble(Console.ReadLine()); //����� ����������
            Console.Write("b = "); //��������� ������ ������������ ������ �������� ���������� ������������� ����
            b = Convert.ToDouble(Console.ReadLine()); //����� ����������
            Console.Write("c = "); //��������� ������ ������������ ������ �������� ���������� ������������� ����
            c = Convert.ToDouble(Console.ReadLine()); //����� ����������
            Console.WriteLine($"({a:0.00}+{b:0.00})+{c:0.00}={a:0.00}+({b:0.00}+{c:0.00})"); // ��������� ���������
            Console.WriteLine("��� ����������� ������� ������� ����� �������..."); //��������� ��� ���� ������������ �����  ����� ������� 
        }
        
    }
}