using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounnt
{
    class Transaction
    {
        private Account sender;
        private Account receiver;
        public double Amount { get; set; }
        public string AdditionalInfo { get; set; }

        public Transaction() { }

        public Transaction(Account sender, Account receiver, double amount, string additionalInfo)
        {
            this.sender = sender;
            this.receiver = receiver;
            AdditionalInfo = additionalInfo;
            Amount = amount;
        }

        public void showTransactions()
        {
            Console.Write("Transaction type: {0}\t ", AdditionalInfo);
            Console.Write("Amount: " + Amount);
            if (AdditionalInfo.ToLower().Equals("transfer"))
            {
                //Console.WriteLine("\tSender: {0}({1})", sender.AccName, sender.AccNo);
                Console.Write("\t To: {0}({1})", receiver.AccName, receiver.AccNo);
            }
            Console.WriteLine();
        }
        
    }
}
