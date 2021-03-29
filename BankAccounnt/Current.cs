﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounnt
{
    class Current:Account
    {
        public Current(string AccName, string AccNo, double balance): base(AccName, AccNo, balance) { }

        public override void Withdraw(double amount)
        {
            if (amount < Balance)
            {
                Balance -= amount;
                Console.WriteLine("Your account debited by {0} to self", amount);
                Transaction tr = new Transaction(this, this, amount, "Withdraw");
                base.addTransaction(tr);
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }

        public override void Transfer(Account acc, double amount)
        {
            if (amount < Balance)
            {
                Balance -= amount;
                acc.Balance += amount;
                Transaction tr = new Transaction(this, acc, amount, "Transfer");
                base.addTransaction(tr);
                Console.WriteLine("your account transfer by {0} to the account {1}({2})", amount, acc.AccName, acc.AccNo);
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }
    }
}
