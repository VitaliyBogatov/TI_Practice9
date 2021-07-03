using System;

namespace Calculator
{
    public class BasicCalculator
    {
        public static T Add<T,U>(T x, U y)
        {
            dynamic dx = x, dy = y;
            return dx + dy;
        }
        public static T Substract<T,U>(T x, U y)
        {
            dynamic dx = x, dy = y;
            return dx - dy;
        }
        public static T Multiply<T, U>(T x, U y)
        {
            dynamic dx = x, dy = y;
            return dx * dy;
        }
        public static T Divide<T, U>(T x, U y)
        {
            try
            {
                dynamic dx = x, dy = y;
                return dx / dy;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
