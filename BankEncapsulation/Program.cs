using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var edwardsaccount = new  bankAccount();
            
            Console.WriteLine("How much would you like to deposit?");
            
            var amountToDeposit = double.Parse(Console.ReadLine());
            
            edwardsaccount.Deposit(amountToDeposit);
            
            Console.WriteLine($"Thank you! Your balance is {edwardsaccount.GetBalance()}");
        }
    }
}