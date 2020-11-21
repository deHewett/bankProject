using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    public class Account
    {
        static int idCounter = 0;

        public int accountID { get; set; }
        public float balance { get; set; }
        public float overdraft { get; set; }
        public float withdrawFailFee { get; set; }
        public Customer Owner { get; set; }

        public string LastTransaction;

        public Account()
        {
            accountID = idCounter + 1;
            balance = 0.0f;
            overdraft = 0.0f;
            withdrawFailFee = 0.0f;
            idCounter++;
        }
        public Account(Customer Owner)
        {
            this.Owner = Owner;
            accountID = idCounter + 1;
            balance = 0.0f;
            overdraft = 0.0f;
            withdrawFailFee = 0.0f;
            idCounter++;
        }
        public Account(Customer Owner, float balance)
        {
            this.Owner = Owner;
            accountID = idCounter + 1;
            this.balance = balance;
            overdraft = 0.0f;
            withdrawFailFee = 0.0f;
            idCounter++;

        }
        public string displayLastTransaction()
        {
            return LastTransaction;
        }
        public string deposit(float depAmount)
        {
            balance += depAmount;
            LastTransaction = "$" + depAmount.ToString() + " has been deposited to account ID: " + accountID.ToString();
            return LastTransaction;
        }

        public string withdraw(float withdrawAmount)
        {
            if(balance + overdraft >= withdrawAmount)
            {
                balance -= withdrawAmount;
                if (balance < 0)
                {
                    overdraft += balance;
                    balance = 0;
                }
                LastTransaction = "$" + withdrawAmount.ToString() + " has been withdrawn to account ID: " + accountID.ToString();
                return LastTransaction;
            } else
            {
                if(Owner.CustomerType == "Staff")
                {
                    balance -= withdrawFailFee/2;
                } else
                {
                    balance -= withdrawFailFee;
                }
                LastTransaction = "Insufficient funds available to withdraw, a fee of $" + withdrawFailFee.ToString() + " has been deducted from the account";
                return LastTransaction;
            }
            
        }
    }
}
