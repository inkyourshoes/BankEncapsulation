using System;

namespace BankEncapsulation;

public class bankAccount77


{
   

    private double balance = 0;

    //encapsulation
    public void Deposit(double amount)
    {
        balance = amount;
    }

    public string GetBalance()
    {
        return $"${balance}";
    }

}