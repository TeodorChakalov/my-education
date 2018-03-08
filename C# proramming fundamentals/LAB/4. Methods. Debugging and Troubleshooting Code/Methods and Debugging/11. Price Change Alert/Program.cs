using System;

class PriceChangeAlert
{
    static void Main()
    {
        int numberOfPrices = int.Parse(Console.ReadLine());
        double threshold = double.Parse(Console.ReadLine());
        double price = double.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfPrices - 1; i++)
        {
            double currentPrice = double.Parse(Console.ReadLine());

            double difference = Percentage(price, currentPrice);
            bool isSignificantDifference = Difference(difference, threshold);
            string message = GetMessage(currentPrice, price, difference, isSignificantDifference);
            Console.WriteLine(message);
            price = currentPrice;
        }
    }

    private static string GetMessage(double currentPrice, double lastPrice, double difference, bool isSignificantDifference)
    {
        string result = "";
        if (difference == 0)
        {
            result = string.Format("NO CHANGE: {0}", currentPrice);
        }
        else if (!isSignificantDifference)
        {
            result = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
        }
        else if (isSignificantDifference && (difference > 0))
        {
            result = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
        }
        else if (isSignificantDifference && (difference < 0))
        {
            result = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);

        }
        return result;
    }

    private static bool Difference(double threshold, double price)
    {
        if (Math.Abs(threshold) >= price)
        {
            return true;
        }
        return false;
    }

    private static double Percentage(double lastPrice, double currentPrice)
    {
        double result = (currentPrice - lastPrice) / lastPrice;
        return result;
    }
}
