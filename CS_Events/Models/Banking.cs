using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Events.Models
{
    // 1. Define a delegate that will be used to declared event. This must be having return type as void

    public delegate void TransactionHandler(decimal amount);

    internal class Banking
    {
        private decimal _openingBalance;

        // 2. define event

        public event TransactionHandler OverBalance;

        public event TransactionHandler UnderBalance;


        public Banking(decimal opBal)
        {
            _openingBalance = opBal;
        }

        public void Deposit(decimal tramount)
        {
            _openingBalance += tramount;
            // 3. Raise event
            if (_openingBalance > 100000)
            {
                OverBalance(_openingBalance);
            }
        }
        public void Withdrawal(decimal tramount)
        {
            _openingBalance -= tramount;
            // 3. Raise Event
            if (_openingBalance < 5000)
            {
                UnderBalance(_openingBalance);
            }
        }

        public decimal GetNetBalance() 
        {
          return _openingBalance;
        }
    }

    internal class EventListener
    {
        Banking banking;
        /// <summary>
        /// 4. The Listener has subscription of the Bank
        /// This will listen to event(s) raised by the Bank class
        /// </summary>
        /// <param name="b"></param>
        public EventListener(Banking b)
        {
            banking = b;
            // 5. Listen to Event and generate notification

            banking.OverBalance += new TransactionHandler(OverBanalnaceNotifier);
            banking.UnderBalance +=  UnderBalanceNotifier;
        }

        private void UnderBalanceNotifier(decimal amount)
        {
            decimal lessAmount = 5000 - amount;
            Console.WriteLine($"Your current balance is Rs. {amount}/- which is Rs. {lessAmount}/- than Rs. 5000/- please maintain the min balance");
        }

        void OverBanalnaceNotifier(decimal amount)
        {
            decimal taxableAmount = amount - 100000;
            decimal tax = taxableAmount * Convert.ToDecimal(0.2);

            Console.WriteLine($"Dear Account Holder your current balance is Rs.{amount}/- which is Rs.{taxableAmount}/- more than Rs 100000. Please pay tax of Rs.{tax}/- else Mr. Modi will; catch you.");
        }
    }
}
