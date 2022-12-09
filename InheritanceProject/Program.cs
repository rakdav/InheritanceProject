using System;

namespace InheritanceProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите координату x:");
            double x=double.Parse(Console.ReadLine());
            Console.Write("Введите координату y:");
            double y = double.Parse(Console.ReadLine());
            Console.Write("Введите радиус окружности:");
            double radius = double.Parse(Console.ReadLine());
            Circle circle=new Circle(x,y,radius);
            if (circle.InCircle()) Console.WriteLine("Лежит внутри окружности");
            else Console.WriteLine("Не лежит внутри окружности");
        }
    }
}
