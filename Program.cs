using System;

namespace HoleForBalk
{
    // Пролезет ли брус со сторонами x, y, z в отверстие со сторонами a, b, если его разрешается поворачивать на 90 градусов?
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            double x, y;
            a = 2;
            b = 2;
            c = 1;
            x = 3;
            y = 4;
            if (x > a && y > b || x > b && y > a || x > a && y > c || x > c && y > a || x > c && y > b || x > b && y > c)
                Console.WriteLine("Брус пройдет\n");
            else Console.WriteLine("Брус не пройдет\n");
        }
    }
}
