using System;

namespace Circle
{
    class CircleDiameter
    {
        static void Main(string[] args)
        {
            CircleDiameter obj = new CircleDiameter();
            Console.Write("Enter a radius: ");
            double rad;
            rad = obj.getCircleDiamter(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("The diameter is: " + rad);
        }
        private double getCircleDiamter(double radius)
        {
            double diameter = radius * 2;
            return diameter;
        }
        }
    }

