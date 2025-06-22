using System;

namespace Exercise7_Forecast
{
    static class Forecast
    {
        public static double FutureValue(double pv, double rate, int yrs) =>
            yrs == 0 ? pv : FutureValue(pv * (1 + rate), rate, yrs - 1);                
        public static double FutureValueIter(double pv, double rate, int yrs)
        {
            double v = pv; for (int i = 0; i < yrs; i++) v *= 1 + rate; return v;
        }
    }

    class Program
    {
        static void Main()
        {
            double fv = Forecast.FutureValueIter(10000, 0.08, 5);
            Console.WriteLine($"Future value (Rs.10 000, 8%, 5 yrs) = {fv:C}");
        }
    }
}
