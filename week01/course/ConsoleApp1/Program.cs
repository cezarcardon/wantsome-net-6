using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert the amount to be withdrawed" + Environment.NewLine + "The amount must be POSSITIVE and Multiple of 10");
            string line = Console.ReadLine();
            double amount = double.Parse(line);
            double sold = 200;
            double originalSold = sold;
            double standardWithdrawalTax = 0.05;
            int minimTax = 1;
            double withdrawalTaxToBePaid = 0;

            // Main Condition
            if (amount > 0 && amount <= sold && amount % 10 == 0)

            {   // Condition 1
                if (amount * standardWithdrawalTax >= minimTax)
                {
                    withdrawalTaxToBePaid = amount * standardWithdrawalTax;
                    Console.WriteLine($"Withdrawal tax to pe paid = {withdrawalTaxToBePaid}, calculated as per standard withdrawal tax");

                    sold = sold - amount - withdrawalTaxToBePaid;

                    // Condition 1.1
                    if (sold >= 0)
                    {
                        Console.WriteLine($"{amount} EUR widrawed from your account; New sold = {sold}");
                    }

                    else
                    {
                        sold = originalSold;
                        Console.WriteLine($"After applying our humber withdrawal tax, you DO NOT have sufficient funds. We are not fintech, you know?!?");
                    }
                }

                else
                {
                    withdrawalTaxToBePaid = minimTax;
                    Console.WriteLine($"Withdrawal tax to pe paid = {withdrawalTaxToBePaid}, calculated as per standard withdrawal tax");

                    sold = sold - amount - withdrawalTaxToBePaid;
                    Console.WriteLine($"New sold = {sold}");

                    // Condition 1.2
                    if (sold >= 0)
                    {
                        Console.WriteLine($"{amount} EUR widrawed from your account; New sold = {sold}");
                    }

                    else
                    {
                        sold = originalSold;
                        Console.WriteLine($"After applying our humber withdrawal tax of ONLY 1 EUR, you DO NOT have sufficient funds. We are not fintech, you know?!?");
                    }
                }
            }

            else
            {   // Condition 2
                if (amount <= 0)
                {
                    Console.WriteLine($"{amount} is NOT valid amount. Please insert a POSSITIVE amount MULTIPLE of 10.");
                }

                else
                {
                    // Condition 3
                    if (amount % 10 != 0)
                    {
                        Console.WriteLine($"{amount} is NOT valid amount. Please insert an amount MULTIPLE of 10.");
                    }

                    else // Amount > Sold
                    {
                        Console.WriteLine($"Insuficient funds. Please check your balance and try again");
                    }
                }
            }
        }
    }
}
