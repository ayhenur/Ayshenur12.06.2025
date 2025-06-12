using System.Collections.Immutable;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace _9klasNur
{
    internal class BankAccound
    {
        private int id;
        private double balance;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public double Balance
        {
            get { return balance; }
        }
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
        }

        public void Withdraw(double amount)
        {
            if (amount < 0 && amount <= balance)
            {
                balance -= amount;
            }
        }

        public override string ToString()
        {
            return $"Account ID : {id} Balance: {balance:F2}"; 
                
        }


        public static void Main()
        {

            BankAccount acc = new BankAccound();
            acc.ID = 1;
            acc.Deposit(15);
            acc.Withdraw(5);
            Console.WriteLine(acc.ToString());

        }











































        }
    }
}
