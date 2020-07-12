using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System;

namespace TransactionFeeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true)
                .Build();

            StartProgram(config);
        }

        private static void StartProgram(IConfiguration config)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome to the Transaction Fee Calculator");

            Console.WriteLine("Please enter the amount you want to transfer. Amount must be greater than 0!");
            decimal amountToBeTransferred = VerifyInput(Console.ReadLine());

            if (amountToBeTransferred == 0)
            {
                Console.WriteLine("Input is invalid. Please try again");
                return;
            }
            decimal transactionFee = ComputeTransactionAmount(amountToBeTransferred, config);

            Console.WriteLine($"The transaction fee is: {transactionFee}");

            Console.ReadLine();
        }

        private static decimal VerifyInput(string input)
        {
            decimal decimalValueOfInput = 0;
            decimal.TryParse(input, out decimalValueOfInput);
            return decimalValueOfInput;
        }

        private static decimal ComputeTransactionAmount(decimal amountToBeTransferred, IConfiguration config)
        {
            var fees = config.GetSection("fees").Value;

            return amountToBeTransferred;
        }
    }
}
