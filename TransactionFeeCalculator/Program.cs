using System;

namespace TransactionFeeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome to the Transaction Fee Calculator");

            Console.WriteLine("Please enter the amount you want to transfer");
            decimal amountToBeTransferred = Convert.ToDecimal(Console.ReadLine());

            decimal transactionFee = ComputeTransactionAmount(amountToBeTransferred);

            Console.WriteLine($"The transaction fee is: {transactionFee}");

            Console.ReadLine();
        }

        private static decimal ComputeTransactionAmount(decimal amountToBeTransferred)
        {
            return amountToBeTransferred;
        }
    }
}
