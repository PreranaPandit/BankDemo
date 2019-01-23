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
    public partial class Transactions : Form
    {
        public Transactions()
        {
            InitializeComponent();
        }

        TransactionsBLL tranBll = new TransactionsBLL();


        private void label2_Click(object sender, EventArgs e)
        {

        }

        Label lblB = new Label();
        private void btnBalance_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            Label lblBalance = new Label();
            lblBalance.Name = "lblBalance";
            lblBalance.Text = "Balance";
            lblBalance.Location = new Point(10, 100);
            lblBalance.BackColor = Color.Blue;
            lblBalance.ForeColor = Color.White;
            lblBalance.BorderStyle = BorderStyle.Fixed3D;
           
           
            lblB.Name = "lblB";
           
            lblB.Location = new Point(200, 100);
           



            panel1.Controls.Add(lblBalance);
            panel1.Controls.Add(lblB);


            DataTable dt = tranBll.selectBalance();

            if (dt.Rows.Count > 0)
            {
                lblB.Text = dt.Rows[0][0].ToString();
            }
            else
            {
                lblB.Text = "";
            }



        }

        TextBox txtaccountNo = new TextBox();
        Button button = new Button();
        private void Transactions_Load(object sender, EventArgs e)
        {

            Label label = new Label();
            label.Name = "lblaccountNo";
            label.Text = "accountNo";
            label.Location = new Point(5, 70);
            


            
            txtaccountNo.Name = "txtaccountNo";
         
            txtaccountNo.Location = new Point(100,70);
            txtaccountNo.Size = new Size(100, 20);
          

            Label label1 = new Label();
            label1.Name = "lblPinNo";
            label1.Text = "PinNo";
            label1.Location = new Point(5, 120);
            

           
            
          
            button.Name = "btnLogIn";
            button.Text = "LogIn";
            button.Location = new Point(100, 250);
            button.Size = new Size(100, 40);
            button.Click += new EventHandler(btnLogIn_Click);

            panel1.Controls.Add(txtaccountNo);
            
            panel1.Controls.Add(button);
            panel1.Controls.Add(label);
            panel1.Controls.Add(label1);


            btnBalance.Enabled = false;
            btnWithdraw.Enabled = false;
            btnReceipt.Enabled = false;
            btnConfirm.Enabled = false;
            btnDeny.Enabled = false;
            txtPinNo.Enabled = false;
           
        }

      
        
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (txtPinNo.Text.Length == 4)
            {
                tranBll._accountNo = int.Parse(txtaccountNo.Text.Trim());
                tranBll._pinNo = int.Parse(txtPinNo.Text.Trim());


                bool isValidUser = tranBll.checkUser();


                if (isValidUser)
                {

                    btnBalance.Enabled = true;
                    btnWithdraw.Enabled = true;
                    btnReceipt.Enabled = true;
                    btnConfirm.Enabled = true;
                    btnDeny.Enabled = true;
                }
                else
                {

                    MessageBox.Show("either accountNo or password is incorrect; please re-enter!!!");
                }
            }

            else

            {
                MessageBox.Show("Default Pin number");
                txtPinNo.Focus();
                return;
            }

            panel1.Controls.Clear();

            Label lblBalance = new Label();
            lblBalance.Name = "lblBalance";
            lblBalance.Text = "Balance";
            lblBalance.Location = new Point(10, 100);
            lblBalance.BackColor = Color.Blue;
            lblBalance.ForeColor = Color.White;
            lblBalance.BorderStyle = BorderStyle.Fixed3D;

            Label lblB = new Label();
            lblB.Name = "lblB";

            lblB.Location = new Point(200, 100);




            panel1.Controls.Add(lblBalance);
            panel1.Controls.Add(lblB);


            DataTable dt = tranBll.selectBalance();

            if (dt.Rows.Count > 0)
            {
                lblB.Text = dt.Rows[0][0].ToString();
            }
            else
            {
                lblB.Text = "";
            }




        }

        TextBox txtbalanceAmount = new TextBox();
        TextBox txtDraw = new TextBox();
        Button btnDraw = new Button();
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

        

            Label label = new Label();
            label.Name = "lblBalance";
            label.Text = "Withdraw Amount";
            label.Location = new Point(80, 100);

            txtbalanceAmount.Name = "txtbalanceAmount";

            txtbalanceAmount.Location = new Point(80, 150);
            txtbalanceAmount.Size = new Size(200, 200);


            txtDraw.Name = "txtWithdraw";
            
            txtDraw.Location = new Point(60, 200);
            txtDraw.Size = new Size(200, 200);


           
            btnDraw.Name = "btnDraw";
            btnDraw.Text = "Draw";
            btnDraw.Location = new Point(100,250);

            btnDraw.Click += new EventHandler(btnDraw_Click);

            panel1.Controls.Add(label);
         
            panel1.Controls.Add(txtDraw);
            panel1.Controls.Add(btnDraw);
            panel1.Controls.Add(txtbalanceAmount);


            txtDraw.Enabled = false;


            DataTable dt = tranBll.selectBalance();

            if (dt.Rows.Count > 0)
            {
                txtbalanceAmount.Text = dt.Rows[0][0].ToString();
            }
            else
            {
                lblB.Text = "";
            }

            txtbalanceAmount.Visible = false;
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Are you sure to withdraw amount from your account?  Is Yes please enter CONFIRM else please enter DENY!!!");


        }

        private void txtPinNo_TextChanged(object sender, EventArgs e)
        {
           
           
        }


        /*
          Keypad implementation begins, which permit numbers to be entered into the system at the 
        appropriate points in the program’s functioning, specifically at login or when withdrawing money.
        
            Pressing C clears the previously entered number. 
         Pressing A do nothing, for now for both pin number and withdrawal amount!!.*/


        private void btn7_Click(object sender, EventArgs e)
        {

            txtPinNo.Enabled = true;
            txtPinNo.Text = txtPinNo.Text + "7";
           
            txtDraw.Enabled = true;
            txtDraw.Text = txtDraw.Text + "7";

            txtdraw.Enabled = true;
            txtdraw.Text = txtdraw.Text + "7";


        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtPinNo.Enabled = true;
            txtPinNo.Text = txtPinNo.Text + "8";
            txtDraw.Enabled = true;
            txtDraw.Text = txtDraw.Text + "8";
            txtdraw.Enabled = true;
            txtdraw.Text = txtdraw.Text + "8";

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtPinNo.Enabled = true;
            txtPinNo.Text = txtPinNo.Text + "9";
            txtDraw.Enabled = true;
            txtDraw.Text = txtDraw.Text + "9";
            txtdraw.Enabled = true;
            txtdraw.Text = txtdraw.Text + "9";

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtPinNo.Enabled = true;
            txtPinNo.Text = txtPinNo.Text + "4";
          
            txtDraw.Enabled = true;
           
            txtDraw.Text = txtDraw.Text + "4";
            txtdraw.Enabled = true;
            txtdraw.Text = txtdraw.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtPinNo.Enabled = true;
            txtPinNo.Text = txtPinNo.Text + "5";
            txtDraw.Enabled = true;
            txtDraw.Text = txtDraw.Text + "5";
            txtdraw.Enabled = true;
            txtdraw.Text = txtdraw.Text + "5";

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtPinNo.Enabled = true;
            txtPinNo.Text = txtPinNo.Text + "6";
            txtDraw.Enabled = true;
            txtDraw.Text = txtDraw.Text + "6";
            txtdraw.Enabled = true;
            txtdraw.Text = txtdraw.Text + "6";

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtPinNo.Enabled = true;
            txtPinNo.Text = txtPinNo.Text + "1";
            txtDraw.Enabled = true;
            txtDraw.Text = txtDraw.Text + "1";
            txtdraw.Enabled = true;
            txtdraw.Text = txtdraw.Text + "1";

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtPinNo.Enabled = true;
            txtPinNo.Text = txtPinNo.Text + "2";
            txtDraw.Enabled = true;
            txtDraw.Text = txtDraw.Text + "2";
            txtdraw.Enabled = true;
            txtdraw.Text = txtdraw.Text + "2";

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtPinNo.Enabled = true;
            txtPinNo.Text = txtPinNo.Text + "3";
            txtDraw.Enabled = true;
            txtDraw.Text = txtDraw.Text + "3";
            txtdraw.Enabled = true;
            txtdraw.Text = txtdraw.Text + "3";
        }

        private void btnA_Click(object sender, EventArgs e)
        {
           
          
          
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtPinNo.Enabled = true;
            txtPinNo.Text = txtPinNo.Text + "0";
            txtDraw.Enabled = true;
            txtDraw.Text = txtDraw.Text + "0";
            txtdraw.Enabled = true;
            txtdraw.Text = txtdraw.Text + "0";
        }

        private void txtPinNo_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void btnPin_Click(object sender, EventArgs e)
        {
           
            }

        private void btnC_Click(object sender, EventArgs e)
        {
            //clears both pinno and withdrawal amount...
            if(txtPinNo.Enabled == true)
            {
                string PinNo = getSubString(txtPinNo.Text);
                txtPinNo.Text = PinNo;
                txtPinNo.Focus();
                return;
            }

           else if(txtDraw.Enabled == true)
            {
                string drawAmounts = getSubString(txtDraw.Text);
                txtDraw.Text = drawAmounts;
                txtDraw.Focus();
                return;
            }
            else if(txtdraw.Enabled == true)
            {
                string dAmount = getSubString(txtdraw.Text);
                txtdraw.Text = dAmount;
                txtdraw.Focus();
                return;
            }
           
        }



        public string getSubString(string stringValue)
        {
            stringValue = stringValue.Substring(0, stringValue.Length - 1);
            return stringValue;
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //for confirm withdrawal!!

           
            int accountNo;
            float balanceAmount;
            float drawAmount;
            string t_status;

            accountNo = int.Parse(txtaccountNo.Text);
            balanceAmount = float.Parse(txtbalanceAmount.Text);
            drawAmount = float.Parse(txtDraw.Text);

           
            tranBll._accountNo = accountNo;
            tranBll._balanceAmount = balanceAmount;
            tranBll._drawAmount = drawAmount;
           

            t_status = "Withdraw";



            if (drawAmount < balanceAmount)
            {
                DataTable dt = tranBll.getCustomerId();

                int customerid = int.Parse(dt.Rows[0][0].ToString());
                tranBll.withdrawAmount();
                tranBll.createTransaction(customerid, t_status, drawAmount);
                MessageBox.Show("Sucessfully withdrawed!!!!!.");
               
            }
            else
            {
                MessageBox.Show("Default balance!!; you don not have enough balance to withdraw!!!");
            }
           

        }

        private void btnDeny_Click(object sender, EventArgs e)
        {
           

            //displayInfo with interactive messagebox

            DialogResult confirmResult = MessageBox.Show("Are you sure to deny this transaction?", "confirm Delete?", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                btnBalance.Enabled = false;
                btnWithdraw.Enabled = false;
                btnReceipt.Enabled = false;
                btnConfirm.Enabled = false;
                btnDeny.Enabled = false;
                MessageBox.Show("You are not alowd to any of the transactions now; please exit!!!!");
            }
            else
            {
                MessageBox.Show("You are alowd to do transactions again.please proceed!!!!");
            }
        }

        TextBox txtdraw = new TextBox();
        private void btnReceipt_Click(object sender, EventArgs e)
        {
            TextBox txtbalanceAmount = new TextBox();
           
            Button btndraw = new Button();

            panel1.Controls.Clear();



            Label label = new Label();
            label.Name = "lblBalance";
            label.Text = "Withdraw Amount";
            label.Location = new Point(80, 100);

            txtbalanceAmount.Name = "txtbalanceAmount";

            txtbalanceAmount.Location = new Point(80, 150);
            txtbalanceAmount.Size = new Size(200, 200);


            txtdraw.Name = "txtWithdraw";

            txtdraw.Location = new Point(60, 200);
            txtdraw.Size = new Size(200, 200);



            btndraw.Name = "btnDraw";
            btndraw.Text = "Draw";
            btndraw.Location = new Point(100, 250);

            btndraw.Click += new EventHandler(btndraw_Click);

            panel1.Controls.Add(label);

            panel1.Controls.Add(txtdraw);
            panel1.Controls.Add(btndraw);
            panel1.Controls.Add(txtbalanceAmount);


            txtdraw.Enabled = false;


            DataTable dt = tranBll.selectBalance();

            if (dt.Rows.Count > 0)
            {
                txtbalanceAmount.Text = dt.Rows[0][0].ToString();
            }
            else
            {
                lblB.Text = "";
            }

            txtbalanceAmount.Visible = false;
        }

        private void btndraw_Click(object sender, EventArgs e)
        {


            panel1.Controls.Clear();

            Label label = new Label();
            label.Name = "lblReceipt";
            label.Text = "RECEIPT";
            label.Location = new Point(120, 20);

            panel1.Controls.Add(label);


            //FullName
            Label label1 = new Label();
            label1.Name = "lblFName";
            label1.Text = "FullName";
            label1.Location = new Point(5, 70);

            panel1.Controls.Add(label1);


            Label lblFullName = new Label();
            lblFullName.Name = "lblCustomerName";
            lblFullName.Location = new Point(150, 70);

            panel1.Controls.Add(lblFullName);

            //Address
            Label label2 = new Label();
            label2.Name = "lblAddrss";
            label2.Text = "Address";
            label2.Location = new Point(5, 100);

            panel1.Controls.Add(label2);

            Label lblAddress = new Label();
            lblAddress.Name = "lblAddress";
            lblAddress.Location = new Point(150, 100);

            panel1.Controls.Add(lblAddress);

            //PhoneNumber
            Label label3 = new Label();
            label3.Name = "lblPhone";
            label3.Text = "PhoneNumber";
            label3.Location = new Point(5, 130);

            panel1.Controls.Add(label3);

            Label lblPhoneNumber = new Label();
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Location = new Point(150, 130);

            panel1.Controls.Add(lblPhoneNumber);

            //Account Number
            Label label4 = new Label();
            label4.Name = "lblAccount";
            label4.Text = "AccountNumber";
            label4.Location = new Point(5, 160);

            panel1.Controls.Add(label4);

            Label lblAccountNumber = new Label();
            lblAccountNumber.Name = "lblAccountNumber";
            lblAccountNumber.Location = new Point(150, 160);

            panel1.Controls.Add(lblAccountNumber);

            //Total balance remained

            Label label6 = new Label();
            label6.Name = "lblTbalance";
            label6.Text = "Balance";
            label6.Location = new Point(5, 220);

            panel1.Controls.Add(label6);

            Label lblTotalBalance = new Label();
            lblTotalBalance.Name = "lblTotalBalance";
            lblTotalBalance.Location = new Point(150, 220);

            panel1.Controls.Add(lblTotalBalance);

            //Withdraw Amount
            Label label5 = new Label();
            label5.Name = "lblW";
            label5.Text = "Withdraw Amount";
            label5.Location = new Point(5, 190);

            panel1.Controls.Add(label5);

            Label lblDrawAmount = new Label();
            lblDrawAmount.Name = "lblDrawAmount";
            lblDrawAmount.Text = txtdraw.Text;
            lblDrawAmount.Location = new Point(150, 190);

            panel1.Controls.Add(lblDrawAmount);

           
          DataTable   dt = tranBll.getCustomerDetails();

            if (dt.Rows.Count > 0)
            {
                lblFullName.Text = dt.Rows[0][0].ToString();
                lblAddress.Text = dt.Rows[0][1].ToString();
                lblPhoneNumber.Text = dt.Rows[0][2].ToString();
                lblAccountNumber.Text = dt.Rows[0][3].ToString();
               
                lblTotalBalance.Text = dt.Rows[0][4].ToString();
                float drawAmount;
                string t_status;

                drawAmount = float.Parse(lblDrawAmount.Text);
                t_status = "WithDraw";

                tranBll._drawAmount = drawAmount;


                dt = tranBll.getCustomerId();

                int customerid = int.Parse(dt.Rows[0][0].ToString());

                tranBll.withdrawAmount();

                tranBll.createTransaction(customerid, t_status, drawAmount);
                MessageBox.Show("Sucessfully withdrawed!!!!!.");
              


            }
            else
            {
                lblFullName.Text = "";
                lblAddress.Text = "";
                lblPhoneNumber.Text = "";
                lblAccountNumber.Text = "";
                lblDrawAmount.Text = "";
                lblTotalBalance.Text = "";

            }

        }


       

        }
    }
    
    

