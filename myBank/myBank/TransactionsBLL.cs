using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myBank
{
    class TransactionsBLL
    {
        private int accountNo;
        private int pinNo;
        private float Balance;
        private float drawAmount;
        private float balanceAmount;
        private int customerid;
        private string t_status;
      

        public TransactionsBLL()
        {

        }

        public TransactionsBLL(int accountNo, int pinNo, float Balance, float drawAmount, float balanceAmount, int customerid, string t_status, string stringValue)
        {
            
            this.accountNo = accountNo;
            this.pinNo = pinNo;
            this.Balance = Balance;
            this.drawAmount = drawAmount;
            this.balanceAmount = balanceAmount;
            this.customerid = customerid;
            this.t_status = t_status;
           

        }


        public int _accountNo
        {
            get { return accountNo; }
            set { this.accountNo = value; }
        }
        public int _pinNo
        {
            get { return pinNo; }
            set { this.pinNo = value; }
        }
        public float _Balance
        {
            get { return Balance; }
            set { this.Balance = value; }
        }
        public float _drawAmount
        {
            get { return drawAmount; }
            set { this.drawAmount = value; }
        }
        public float _balanceAmount
        {
            get { return balanceAmount; }
            set { this.balanceAmount = value; }
        }


        DbConnection dbconnection = new DbConnection();

        public bool checkUser()
        {
            string query;
            query = "select accountNo from Customer where accountNo = '" + accountNo + "' and pinNo = '" + pinNo + "'";
            DataTable dt = dbconnection.Retrieve(query);

            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable selectBalance()
        {
            string query;
            query = "select balance from Customer where accountNo = "+ accountNo;
            DataTable dt = dbconnection.Retrieve(query);
            return dt;
        }

        public void withdrawAmount()
        {
            string query;
            query = "update Customer set balance = balance -" + drawAmount + "where accountNo=" + accountNo;
            dbconnection.Manipulate(query);
        }


       


        public DataTable getCustomerDetails()
        {
            string query;
            query = "select fname+''+lname as 'CustomerName', address, phonenumber, accountNo, balance from Customer where accountNo=" + accountNo;
            DataTable dt = dbconnection.Retrieve(query);
            return dt;

        }


        public void createTransaction(int customerid, string t_status, float depositAmount)
        {
            string query;
            query = "insert into Transactions(customerid,t_status,amount)values('" + customerid + "','" + t_status + "','" + depositAmount + "')";
            dbconnection.Manipulate(query);
        }

        public DataTable getCustomerId()
        {
            string query;
            query = "select customerid from Customer where accountNo=" + accountNo;
            DataTable dt = dbconnection.Retrieve(query);
            return dt;

        }

       


    }
}
