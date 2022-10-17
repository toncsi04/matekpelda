
using System;

namespace matekcuccli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. feladat
            Console.WriteLine("Írd be 2 pont koordinátáit vesszővel elválasztva így: x1,y1,x2,y2");
            string be  = Console.ReadLine();
            string[] tomb = be.Split(',');
            double x1 = double.Parse(tomb[0]);
            double y1 = double.Parse(tomb[1]);
            double x2 = double.Parse(tomb[2]);
            double y2 = double.Parse(tomb[3]);
            double d = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            Console.WriteLine($"A 2 pont távolsága: {d}");
            //2.feladat
            Console.WriteLine("Írd be a háromszög 3 oldalának hosszát vesszővel elválasztva!");
            string adatok = Console.ReadLine();
            string[] haromszog = adatok.Split(',');
            double a = double.Parse(haromszog[0]);
            double b = double.Parse(haromszog[1]);
            double c = double.Parse(haromszog[2]);
            double s = (a + b + c) / 2;
            double t = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            Console.WriteLine($"A háromszög területe: {t}");
        }
    }
}
