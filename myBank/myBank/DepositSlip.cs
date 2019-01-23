using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myBank
{
    public partial class DepositSlip : Form
    {
        public DepositSlip()
        {
            InitializeComponent();
        }

        DepositSlipBLL depositBll = new DepositSlipBLL();

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            string date;
            int accountNo;
            float depositAmount;
          
           
            string t_status;
                
            date = datepick.Text;
            accountNo = int.Parse(txtAccountNumber.Text);
            depositAmount = float.Parse(txtDeposit.Text);
            

            depositBll._date = date;
            depositBll._accountNo = accountNo;
            depositBll._depositAmount = depositAmount;
           
            DataTable dt = depositBll.getCustomerId();

            int customerid = int.Parse(dt.Rows[0][0].ToString());

                t_status = "Deposit";

           
           
            depositBll.depAmount();
            depositBll.createTransaction(customerid, t_status, depositAmount);
            MessageBox.Show("Sucessfully deposited!!!!!.");
            this.Close();

        }

        private void txtAccountNumber_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtAccountNumber.Text))
            {
                depositBll._accountNo = int.Parse(txtAccountNumber.Text);
                DataTable dt = depositBll.getCustomerDetails();

                if(dt.Rows.Count > 0)
                {
                    lblCustomername.Text = dt.Rows[0][0].ToString();
                    lblAddress.Text = dt.Rows[0][1].ToString();
                    lblPhoneNumber.Text = dt.Rows[0][2].ToString();
                    lblBalance.Text = dt.Rows[0][3].ToString();
                }
                else
                {
                    lblCustomername.Text = "";
                    lblAddress.Text = "";
                    lblPhoneNumber.Text = "";
                    lblBalance.Text = "";

                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtDeposit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
