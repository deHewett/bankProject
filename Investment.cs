using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    public class Investment: Account
    {
        public float interestRate = 0.02f;
        public Investment() { }
        public Investment(Customer Owner)
        {
            withdrawFailFee = 10.0f;
            this.Owner = Owner;
        }
        public Investment(Customer Owner, float balance)
        {
            withdrawFailFee = 10.0f;
            this.balance = balance;
            this.Owner = Owner;
        }

        public string scalingInterest()
        {
            float interestGain = balance * interestRate;
            balance += interestGain;
            LastTransaction = "Interest %" + interestRate + " of $" + interestGain.ToString() + " has been added to the account for a total balance of $" + balance.ToString();
            interestRate += 0.005f;
            return LastTransaction;
        }
    }
}
