using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounnt
{
    class Fixed : Account
    {
        public int openingYear { get; set; }
        public int fixedYear { get; set; }

        public Fixed(string accName, string accNo, double balance, int openingYear, int fixedYear): base(accName, accNo, balance)
        {
            this.openingYear = openingYear;
            this.fixedYear = fixedYear;
        }

        public override void Withdraw(double amount)
        {
            int today = DateTime.Now.Year;
            if(today-openingYear > fixedYear)
            {
                Balance -= amount;
                Transaction tr = new Transaction(this, this, amount, "Withdraw");
                base.addTransaction(tr);
            }
            else
            {
                Console.WriteLine("this account is not valid for withdrawn");
            }
        }

        public override void Transfer(Account acc, double amount)
        {
            int today = DateTime.Now.Year;
            if (today - openingYear > fixedYear)
            {
                Balance -= amount;
                acc.Balance += amount;
                Transaction tr = new Transaction(this, acc, amount, "Transfer");
                base.addTransaction(tr);
            }
            else
            {
                Console.WriteLine("this account is not valid for Transfer");
            }
        }
    }
}
