using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Wk4Ex1
{

    class CurrencyConverter
    {
        // Conversion Rates
        const double USD_TO_EUR = 0.96;
        const double USD_TO_JPY = 152.20;
        const double EUR_TO_JPY = 158.18;

        // Method to convert currency based on the given exchange rates
        static double ConvertCurrency(double amount, string fromCurrency, string toCurrency)
        {
            if (fromCurrency == "USD" && toCurrency == "EUR")
                return amount * USD_TO_EUR;
            else if (fromCurrency == "USD" && toCurrency == "JPY")
                return amount * USD_TO_JPY;
            else if (fromCurrency == "EUR" && toCurrency == "USD")
                return amount / USD_TO_EUR;
            else if (fromCurrency == "EUR" && toCurrency == "JPY")
                return amount * EUR_TO_JPY;
            else if (fromCurrency == "JPY" && toCurrency == "USD")
                return amount / USD_TO_JPY;
            else if (fromCurrency == "JPY" && toCurrency == "EUR")
                return amount / EUR_TO_JPY;
            else
                return -1; // Return -1 if the conversion is invalid
        }

        static void Main()
        {
            try
            {
                // Display a title for the user
                Console.WriteLine("Currency Converter");

                // Prompt user to enter the amount to be converted
                Console.Write("Enter amount: ");

                // Attempt to read user input and convert to a double
                double amount = Convert.ToDouble(Console.ReadLine());

                // Ask for the currency to convert from
                Console.Write("Enter currency to convert from (USD, EUR, JPY): ");
                string fromCurrency = Console.ReadLine().ToUpper(); // Convert input to uppercase for consistency

                // Ask for the currency to convert to
                Console.Write("Enter currency to convert to (USD, EUR, JPY): ");
                string toCurrency = Console.ReadLine().ToUpper(); // Convert input to uppercase for consistency

                // Perform the currency conversion
                double result = ConvertCurrency(amount, fromCurrency, toCurrency);

                // Display the result if conversion is valid, otherwise show an error message
                if (result != -1)
                    Console.WriteLine($"{amount} {fromCurrency} is equal to {result:F2} {toCurrency}");
                else
                    Console.WriteLine("Invalid currency selection. Please enter valid currency codes.");
            }
            catch (FormatException)
            {
                // Handle case where user enters invalid number format
                Console.WriteLine("Invalid input. Please enter a valid numeric value for the amount.");
            }
            catch (Exception ex)
            {
                // Catch any other unexpected errors and display the message
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
