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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        CustomerBLL customerBll = new CustomerBLL();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateofBirth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
                

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            dgCustomer.DataSource = customerBll.retrieveCustomer();
        }

        private void dgCustomer_Click(object sender, EventArgs e)
        {
            btnCaccount.Text = "UPDATE";
            int Customerid;
            int columnIndex = dgCustomer.CurrentCell.ColumnIndex;
            Customerid = int.Parse(dgCustomer.CurrentRow.Cells["Customerid"].Value.ToString());

            
            if (dgCustomer.CurrentRow.Cells[columnIndex].Value.ToString()=="Edit")
            {
                DataTable dataTable = customerBll.selectCustomer(Customerid);
                
                txtfname.Text = dataTable.Rows[0][0].ToString();
                txtlname.Text = dataTable.Rows[0][1].ToString();
                lblgender.Text = dataTable.Rows[0][2].ToString();
                dateofBirth.Text = dataTable.Rows[0][3].ToString();
                txtAddress.Text = dataTable.Rows[0][4].ToString();
                txtPhoneNumber.Text = dataTable.Rows[0][5].ToString();
                txtBalance.Text = dataTable.Rows[0][6].ToString();
               
            }

            else if(dgCustomer.CurrentRow.Cells[columnIndex].Value.ToString()=="Delete")
            {
                //displayInfo with interactive messagebox

                DialogResult confirmResult = MessageBox.Show("Are you sure to delete this row?", "confirm Delete?", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    customerBll.deleteCustomer(Customerid);
                    dgCustomer.DataSource = customerBll.retrieveCustomer();
                    MessageBox.Show("One row is deleted!!!!");
                }
                else
                {
                    MessageBox.Show("Any row is not deleted!!!!");
                }
            } 
        }

        private void btnCaccount_Click(object sender, EventArgs e)
        {
            //validation
            if (txtfname.Text == "")
            {
                MessageBox.Show("Enter your first name!!..");
                txtfname.Focus();
                return;
            }
            else if (txtlname.Text == "")
            {
                MessageBox.Show("Enter your last name!!..");
                txtlname.Focus();
                return;
            }
            else if (txtAddress.Text == "")
            {
                MessageBox.Show("enter your address!!!");
                txtAddress.Focus();
                return;
            }
            else if (txtPhoneNumber.Text == "")
            {
                MessageBox.Show("enter your phone numnber!!!");
                txtPhoneNumber.Focus();
                return;
            }
            else if (txtBalance.Text == "")
            {
                MessageBox.Show("you need to keep balance to open an account!!!");
                txtBalance.Focus();
                return;
            }
            else
            {
                string fname;
                string lname;
                char gender;
                string Dob;
                string Address;
                string Phonenumber;
                float Balance;
                int accountNo;
                int pinNo;

                fname = txtfname.Text;
                lname = txtlname.Text;

                if (rdobtnMale.Checked == true)
                {
                    gender = 'M';
                }
                else if (rdobtnFemale.Checked == true)
                {
                    gender = 'F';
                }
                else if (rdobtnOthers.Checked == true)
                {
                    gender = 'O';
                }
                else
                {
                    MessageBox.Show("please do not leave the gender section unchecked !!!");
                    return;
                }

                Dob = dateofBirth.Text;
                Address = txtAddress.Text;
                Phonenumber = txtPhoneNumber.Text;
                Balance = float.Parse(txtBalance.Text);

                accountNo = customerBll.generateAccountNo();
                pinNo = customerBll.generatePin();

                customerBll._fname = fname;
                customerBll._lname = lname;
                customerBll._gender = gender;
                customerBll._Dob = Dob;
                customerBll._Address = Address;
                customerBll._Phonenumber = Phonenumber;
                customerBll._Balance = Balance;
                customerBll._accountNo = accountNo;
                customerBll._pinNo = pinNo;


                //save code
                if (btnCaccount.Text == "CREATE ACCOUNT")
                {
                    customerBll.createAccount();

                    MessageBox.Show("Account number :" + accountNo + " and Pin number :" + pinNo);       
                    MessageBox.Show("Rows are inserted!!");

                    dgCustomer.DataSource = customerBll.retrieveCustomer();
                }

                //update code
                else if(btnCaccount.Text == "UPDATE")
                {
                   int Customerid = int.Parse(dgCustomer.CurrentRow.Cells["Customerid"].Value.ToString());



                    customerBll.updateCustomer(Customerid);
                    btnCaccount.Text = "CREATE ACCOUNT";
                    dgCustomer.DataSource = customerBll.retrieveCustomer();
                    txtfname.Focus();
                    return;
                }

            }

        }
    }
}
