using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankProject
{
    public partial class Form1 : Form
    {
        public ArrayList Customers;
        public Customer[] CustArray;
        public Account activeEveryday;
        public Investment activeInvest;
        public Omni activeOmni;

        public Form1()
        {
            InitializeComponent();

            Customers = new ArrayList();
            Customer regCust = new Customer("Joe", "Bloggs", 123456789, "jbloggs@gmail.com", "Customer");
            Customer staffCust = new Customer("Andy", "Stafferson", 0214853984, "astafferson@outlook.com", "Staff");
            Customers.Add(regCust);
            Customers.Add(staffCust);
            CustArray = new Customer[2];
            CustArray[0] = (Customer)Customers[0];
            CustArray[1] = (Customer)Customers[1];
            CustArray[0].createEveryday(100.0f);
            CustArray[1].createEveryday(1000.0f);
            CustArray[0].createInvestment(1000.0f);
            CustArray[1].createInvestment(10000.0f);
            CustArray[0].createOmni(10000.0f);
            CustArray[1].createOmni(100000.0f);
            customerCombo.Items.Add(CustArray[0].FirstName + " " + CustArray[0].LastName);
            customerCombo.Items.Add(CustArray[1].FirstName + " " + CustArray[1].LastName);
            
        }

        public  void customerCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string customer = customerCombo.SelectedItem.ToString();
            // switch case for scalability. Adding future countries easier etc
            switch (customer)
            {
                case "Joe Bloggs":
                    accountsCombo.Items.Clear();
                    accountsCombo.Items.AddRange(CustArray[0].Accounts.ToArray());
                    break;
                case "Andy Stafferson":
                    accountsCombo.Items.Clear();
                    accountsCombo.Items.AddRange(CustArray[1].Accounts.ToArray());
                    break;
            }
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine(accountsCombo.SelectedItem.GetType());
            if (accountsCombo.SelectedItem.GetType() == typeof(BankProject.Account))
            {
                activeEveryday = (Account)accountsCombo.SelectedItem;
                outputBox.Text += (activeEveryday.deposit((float)transactionAmount.Value)) + "\r\n";

            } 
            else if (accountsCombo.SelectedItem.GetType() == typeof(BankProject.Investment))
            {
                activeInvest = (Investment)accountsCombo.SelectedItem;
                outputBox.Text += (activeInvest.deposit((float)transactionAmount.Value)) + "\r\n";
            }
            else if (accountsCombo.SelectedItem.GetType() == typeof(BankProject.Omni))
            {
                activeOmni = (Omni)accountsCombo.SelectedItem;
                outputBox.Text += (activeOmni.deposit((float)transactionAmount.Value)) + "\r\n";
            } else
            {
                outputBox.Text += "Please select a valid account. \r\n";
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            if (accountsCombo.SelectedItem.GetType() == typeof(BankProject.Account))
            {
                activeEveryday = (Account)accountsCombo.SelectedItem;
                outputBox.Text += (activeEveryday.withdraw((float)transactionAmount.Value)) + "\r\n";

            }
            else if (accountsCombo.SelectedItem.GetType() == typeof(BankProject.Investment))
            {
                activeInvest = (Investment)accountsCombo.SelectedItem;
                outputBox.Text += (activeInvest.withdraw((float)transactionAmount.Value)) + "\r\n";
            }
            else if (accountsCombo.SelectedItem.GetType() == typeof(BankProject.Omni))
            {
                activeOmni = (Omni)accountsCombo.SelectedItem;
                outputBox.Text += (activeOmni.withdraw((float)transactionAmount.Value)) + "\r\n";
            }
            else
            {
                outputBox.Text += "Please select a valid account. \r\n";
            }
        }

        private void balanceBtn_Click(object sender, EventArgs e)
        {
            if (accountsCombo.SelectedItem.GetType() == typeof(BankProject.Account))
            {
                activeEveryday = (Account)accountsCombo.SelectedItem;
                outputBox.Text += "Balance: $" + activeEveryday.balance + "\r\n";

            }
            else if (accountsCombo.SelectedItem.GetType() == typeof(BankProject.Investment))
            {
                activeInvest = (Investment)accountsCombo.SelectedItem;
                outputBox.Text += "Balance: $" + activeInvest.balance + "\r\n";
            }
            else if (accountsCombo.SelectedItem.GetType() == typeof(BankProject.Omni))
            {
                activeOmni = (Omni)accountsCombo.SelectedItem;
                outputBox.Text += "Balance: $" + activeOmni.balance + "\r\n";
            }
            else
            {
                outputBox.Text += "Please select a valid account. \r\n";
            }
        }

        private void lastTransactionBtn_Click(object sender, EventArgs e)
        {
            if (accountsCombo.SelectedItem.GetType() == typeof(BankProject.Account))
            {
                activeEveryday = (Account)accountsCombo.SelectedItem;
                outputBox.Text += "The last transaction for this account: " + activeEveryday.LastTransaction +  "\r\n";

            }
            else if (accountsCombo.SelectedItem.GetType() == typeof(BankProject.Investment))
            {
                activeInvest = (Investment)accountsCombo.SelectedItem;
                outputBox.Text += "The last transaction for this account: " + activeInvest.LastTransaction + "\r\n";
            }
            else if (accountsCombo.SelectedItem.GetType() == typeof(BankProject.Omni))
            {
                activeOmni = (Omni)accountsCombo.SelectedItem;
                outputBox.Text += "The last transaction for this account: " + activeOmni.LastTransaction + "\r\n";
            }
            else
            {
                outputBox.Text += "Please select a valid account. \r\n";
            }
        }

        private void calculateInterestBtn_Click(object sender, EventArgs e)
        {
            if (accountsCombo.SelectedItem.GetType() == typeof(BankProject.Investment))
            {
                activeInvest = (Investment)accountsCombo.SelectedItem;
                outputBox.Text += activeInvest.scalingInterest() + "\r\n";
            }
            else if (accountsCombo.SelectedItem.GetType() == typeof(BankProject.Omni))
            {
                activeOmni = (Omni)accountsCombo.SelectedItem;
                outputBox.Text += activeOmni.LargeInterest() + "\r\n";
            }
            else
            {
                outputBox.Text += "Please select a valid account. \r\n";
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            outputBox.Text = "";
        }
    }
}
