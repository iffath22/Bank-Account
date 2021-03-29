using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounnt
{
    class Program
    {
        static void Main(string[] args)
        {
            Account Jothi = new Savings("Jothi", "001", 5000.0f);
            Account Nishat = new Current("Nishat", "002", 2000f);
            Account Moumita = new Fixed("Moumita", "003", 1000f, 2015, 10);
            
            Account ss = new SuperSavings("Iffat", "004", 100f);
            ss.Deposit(80);
            ss.ShowInfo();

            Account overdraft = new Overdraft("Jahan", "005", 1000f, 5000);
            overdraft.Transfer(ss, 5000);
            overdraft.Deposit(10000);
            overdraft.ShowInfo();
            overdraft.showAllTransaction();

            Customer customer = new Customer("Iffat Jahan");

            Nishat.Deposit(10000);
            Nishat.Transfer(Jothi, 5000);
            Nishat.showAllTransaction();

            Jothi.ShowInfo();
            Jothi.Deposit(2000f);
            Jothi.Transfer(Nishat, 4000);
            Jothi.Withdraw(3000);
            Jothi.showAllTransaction();

            
        }
    }
}
