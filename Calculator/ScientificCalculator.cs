using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    public class ScientificCalculator : BasicCalculator
    {
        public static T Add<T>(params T[] numbers)
        {
            dynamic result = numbers[0];
            if (numbers.Length == 1)
            {
                return result;
            }

            for (int i = 1; i < numbers.Length; i++)
            {
                result += numbers[i];
            }
            return result;
        }

        public static T Substract<T>(params T[] numbers)
        {
            dynamic result = numbers[0];
            if (numbers.Length == 1)
            {
                return result;
            }

            for (int i = 1; i < numbers.Length; i++)
            {
                result -= numbers[i];
            }
            return result;
        }

        public static double Square(double x)
        {
            dynamic dx = x;
            return Math.Sqrt(dx);
        }
        public static T Pow<T, U>(T x, U y)
        {
            dynamic dx = x, dy = y;
            return Math.Pow(dx, dy);
        }
    }
}
