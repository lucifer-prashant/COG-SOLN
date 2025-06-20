using System;

class Program
{
    static void Main()
    {
        double currentValue = 1000;
        double growthRate = 0.10;
        int years = 5;

        Console.WriteLine("=== Financial Forecasting Tool ===\n");
        Console.WriteLine("Input Summary:");
        Console.WriteLine($"- Starting Value       : {currentValue:C}");
        Console.WriteLine($"- Annual Growth Rate   : {growthRate * 100}%");
        Console.WriteLine($"- Forecast Period      : {years} year(s)\n");

        double forecast = ForecastValueRecursive(currentValue, growthRate, years);

        Console.WriteLine("Forecast Result:");
        Console.WriteLine($"Predicted value after {years} years: {forecast:C}");
    }

    static double ForecastValueRecursive(double value, double rate, int years)
    {
        if (years == 0)
            return value;

        return ForecastValueRecursive(value * (1 + rate), rate, years - 1);
    }
}
