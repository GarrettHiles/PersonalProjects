using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicBankApp
{
    public class BankAccount
    {
        private double Money = 0;
        private readonly string name;

        public BankAccount(double money, string name)
        {
            Money = money;
            this.name = name;
        }

        public void AddMoney(double amount)
        {
            Money = Money + amount;
            Console.WriteLine(" Added " + amount + " to the bank account of " + name);
        }

        public void Subtract(double Money)
        {
            this.Money -= Money;
        }

        public void getinfo()
        {
            Console.WriteLine(name + " has " + Money);
        }



    }
}
