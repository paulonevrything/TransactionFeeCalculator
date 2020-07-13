using System;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Options;

namespace TransactionFeeCalculator
{
    public class App
    {
        private readonly IConfiguration _config;
        private readonly Fees _fees;

        public App(IOptions<Fees> options, IConfiguration config)
        {
            _fees = options.Value;
            _config = config;
        }

        public void StartProgram()
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
            decimal transactionFee = ComputeTransactionAmount(amountToBeTransferred);

            Console.WriteLine($"The transaction fee is: {transactionFee}");

            Console.ReadLine();
        }

        private decimal VerifyInput(string input)
        {
            decimal decimalValueOfInput = 0;
            decimal.TryParse(input, out decimalValueOfInput);
            return decimalValueOfInput;
        }

        private decimal ComputeTransactionAmount(decimal amountToBeTransferred)
        {
            var fees = _config.GetSection("test").Value;

            return amountToBeTransferred;
        }
    }

    public class Fees
    {
        public FeesConfig[] FeesCon { get; set; }
    }

    public class FeesConfig
    {
        public decimal minAmount { get; set; }
        public decimal maxAmount { get; set; }
        public decimal feeAmount { get; set; }
    }
}
