using System;

namespace Temperature_YMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert an integer value");
            int inputNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please indicate what the number represents:" + Environment.NewLine + "1 Celsius degree temperature" + Environment.NewLine + "2 Fahrenheit degree temperature" + Environment.NewLine + "3 Number days");
            string inputOption = Console.ReadLine();

            Console.WriteLine("User selected option: {0}", inputOption);
            double convertedDegrees = 0;

            switch (inputOption)
            {
                case "1":
                    convertedDegrees = (inputNumber * 9 / 5) + 32;
                    string output = $"{inputNumber} degrees CELSIUS is {String.Format("{0:0.00}", convertedDegrees)} degrees FAHRENHEIT";
                    Console.WriteLine(output);
                    break;

                case "2":
                    convertedDegrees = (inputNumber - 32) * 5 / 9;
                    output = $"{inputNumber} degrees FAHRENHEIT is {String.Format("{0:0.00}", convertedDegrees)} degrees CELSIUS";
                    Console.WriteLine(output);
                    break;

                case "3":
                    // create variable type double noDays in order to use the method Math.Truncate, which require a double as output
                    double noDays = inputNumber;

                    // use Math.Truncate to extract the integer part of a double (e.g. extract 5 from 5.4767)
                    double noYears = Math.Truncate(noDays / 365);

                    // take the rest of days after extracting the no. of year(s) and then use again Math.Truncate to extract the months
                    double noMonths = Math.Truncate((noDays % 365) / 30);

                    // determine the remaining number of days after extracting the no. of years and months
                    double remainingDays = Math.Truncate((noDays % 365) % 30);

                    Console.WriteLine($"Estimated duration is {noYears} year(s), {noMonths} month(s) and {remainingDays} day(s)");
                    break;

                default:
                    Console.WriteLine("Please insert one of the above listed options");
                    break;

            }
        }
    }
}