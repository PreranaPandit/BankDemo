using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myBank
{
    class DepositSlipBLL
    {
        private string date;
        private int accountNo;
        private float depositAmount;
        private int customerid;
        private string t_status;
        

        public DepositSlipBLL()
        {

        }

        public DepositSlipBLL(string date, int accountNo, float depositAmount, int customerid, string t_status)
        {
            this.date = date;
            this.accountNo = accountNo;
            this.depositAmount = depositAmount;
            this.customerid = customerid;
            this.t_status = t_status;
        }

        //getter ans setter

        public string _date
        {
            get { return date; }
            set { this.date = value; }
        }

        public int _accountNo
        {
            get { return accountNo; }
            set { this.accountNo = value; }
        }

        public float _depositAmount
        {
            get { return depositAmount;}
            set { this.depositAmount = value; }
        }

        public int _customerid
        {
            get { return customerid; }
            set { this.customerid = value; }
        }

        public string _t_status
        {
            get { return t_status; }
            set { this.t_status = value; }
        }


        DbConnection dbconnection = new DbConnection();

        public void depAmount()
        {
            string query;
            query = "update Customer set balance = balance +" + depositAmount + "where accountNo=" + accountNo;
            dbconnection.Manipulate(query);
        }

        public DataTable getCustomerDetails()
        {
            string query;
            query = "select fname+''+lname as 'CustomerName', address, phonenumber, balance from Customer where accountNo="+accountNo;
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
