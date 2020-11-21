using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    public class Customer
    {
        static int customerIDCounter = 0;
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string CustomerType { get; set; }
        public ArrayList Accounts;
        public Customer()
        {
            CustomerID = customerIDCounter + 1;
            FirstName = "Joe";
            LastName = "Bloggs";
            PhoneNumber = 123456789;
            EmailAddress = "jbloggs@gmail.com";
            CustomerType = "Customer";
            Accounts = new ArrayList();

        }
        public Customer(string FirstName, string LastName, 
            int PhoneNumber, string EmailAddress, string CustomerType)
        {
            CustomerID = customerIDCounter + 1;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.PhoneNumber = PhoneNumber;
            this.EmailAddress = EmailAddress;
            this.CustomerType = CustomerType;
            Accounts = new ArrayList();
        }

        public void createEveryday()
        {
            Accounts.Add(new Account(this));
        }
        public void createEveryday(float balance)
        {
            Accounts.Add(new Account(this, balance));
        }
        public void createInvestment()
        {
            Accounts.Add(new Investment(this));
        }
        public void createInvestment(float balance)
        {
            Accounts.Add(new Investment(this, balance));
        }
        public void createOmni()
        {
            Accounts.Add(new Omni(this));
        }
        public void createOmni(float balance)
        {
            Accounts.Add(new Omni(this, balance));
        }
        public void createOmni(float balance, float overdraft)
        {
            Accounts.Add(new Omni(this, balance, overdraft));
        }
    }
}
