using System;
namespace Hello
{
    class Program
    {
        static void Main()
        {
            Console.Write("a = "); //��������� ������ ������������ ������ �������� ���������� ������������� ����
            double a = Convert.ToDouble(Console.ReadLine()); //����� ������
            Console.Write("b = "); //��������� ������ ������������ ������ �������� ���������� ������������� ����
            double b = Convert.ToDouble(Console.ReadLine()); //����� ������
            Console.WriteLine("{0:F2}+{1:F2}={2:F2}", a, b, a+b); // ��������� ��������� ������� ������ �� �������
            Console.WriteLine("��� ����������� ������� ������� ����� �������..."); //��������� ��� ���� ������������ �����  ����� ������� 
        }
    }