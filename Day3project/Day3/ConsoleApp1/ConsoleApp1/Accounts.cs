using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Accounts
    {
        int Accountno;
        string Customerno;
        string AccountType;
        float amount=1000.00f;
        float balance;
       
        public void credit(float amt)
        {
            amount += amt;
            Console.WriteLine(amt + " Deposited");
            Console.WriteLine("Balance is " + amount);   

        }
        public void debit(float amt)
        {
            if (amount < amt)
            {
                Console.WriteLine("Insufficent balance");

            }
            else
            {
                amount -= amt;
                Console.WriteLine(amt + " with drawn");
                Console.WriteLine("Balance is"+amount);
            }
        }
        public Accounts()
        {
            Console.WriteLine("Enter Accountno");
            Accountno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter customerno ");
            Customerno = Console.ReadLine();
            Console.WriteLine("Enter Account type");
            AccountType = Console.ReadLine();

        }
        public void showdetails()
        {
            balance = amount;
           Console.WriteLine("account no is "+Accountno+" customer no is "+Customerno+" account type "+AccountType+" balance is "+balance);
        }
    }
}
