using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    public class Omni : Investment
    {
        public Omni() 
        {

        }
        public Omni(Customer Owner)
        {
            this.Owner = Owner;
            withdrawFailFee = 10.0f;
            overdraft = 1000.0f;
        }
        public Omni(Customer Owner, float balance)
        {
            this.Owner = Owner;
            this.balance = balance;
            interestRate = 0.05f;
            overdraft = 1000.0f;
            withdrawFailFee = 20.0f;
        }
        public Omni(Customer Owner, float balance, float overdraft)
        {
            this.Owner = Owner;
            this.balance = balance;
            interestRate = 0.05f;
            this.overdraft = overdraft;
            withdrawFailFee = 20.0f;
        }
        public string LargeInterest()
        {
            if (balance > 1000.0f)
            {
                float interestGain = balance * interestRate;
                balance += interestGain;
                LastTransaction = "Interest %" + interestRate + " of $" + interestGain.ToString() + " has been added to the account for a total balance of $" + balance.ToString();
                return LastTransaction;
            }
            else
            {
                return "Not enough funds to gather interest";
            }
        }
    }
}
