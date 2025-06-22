using System;

namespace Exercise4_FinancialForecasting
{
    class Program
    {
        static void Main(string[] args)
        {
            double initialValue = 1000;      // Starting investment
            double growthRate = 0.1;         // 10% growth per year
            int years = 5;                   // Forecasting for 5 years

            Console.WriteLine(" Financial Forecast using Recursion");
            Console.WriteLine($"Initial Value: ₹{initialValue}, Growth Rate: {growthRate * 100}%");

            double forecast = ForecastRecursive(initialValue, growthRate, years);
            Console.WriteLine($"Predicted Value after {years} years: ₹{forecast:F2}");

            Console.WriteLine("\n Time Complexity: O(n)");
            Console.WriteLine("To optimize, convert to iterative approach or use memoization for overlapping subproblems.");
        }

        // Recursive forecasting function
        static double ForecastRecursive(double value, double rate, int years)
        {
            if (years == 0)
                return value;
            return ForecastRecursive(value, rate, years - 1) * (1 + rate);
        }
    }
}
