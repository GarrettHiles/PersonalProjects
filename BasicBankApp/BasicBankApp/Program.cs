using BasicBankApp;
using System;


namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount( money: 200, name: "Monkey D Luffy");
            BankAccount banksanji = new BankAccount(money: 50, name:"Vinsmoke Sanji");

            bankAccount.AddMoney(amount: 50);
            banksanji.AddMoney(amount: 2000);

            bankAccount.getinfo();
            banksanji.getinfo();

        }
    }
}
