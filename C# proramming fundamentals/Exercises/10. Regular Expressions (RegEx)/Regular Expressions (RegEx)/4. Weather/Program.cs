using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _4.Weather
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();
            Dictionary<string, Dictionary<double, string>> dict = new Dictionary<string, Dictionary<double, string>>();
            string pattern = @"([A-Z]{2})([0-9]+\.[0-9]{1,2})([A-Za-z]+)\|";

            while (text != "end")
            {
                MatchCollection matches = Regex.Matches(text, pattern);
                foreach (Match match in matches)
                {
                    string cityName = match.Groups[1].ToString();
                    double cityTemperature = double.Parse(match.Groups[2].Value);
                    string cityWeather = match.Groups[3].ToString();

                    if (dict.ContainsKey(cityName) == false)
                    {
                        Dictionary<double, string> helper = new Dictionary<double, string>();
                        helper.Add(cityTemperature, cityWeather);
                        dict.Add(cityName, helper);
                    }
                    else if (dict.ContainsKey(cityName))
                    {
                        dict[cityName].Clear();
                        dict[cityName][cityTemperature] = cityWeather;
                    }
                }
                text = Console.ReadLine();
            }
            foreach (var cityName in dict.OrderBy(x => x.Value.Keys.Average()))
            {
                foreach (var pair in cityName.Value)
                {
                    Console.WriteLine("{0} => {1} => {2}", cityName.Key, pair.Key, pair.Value);
                }
            }
        }
    }
}
