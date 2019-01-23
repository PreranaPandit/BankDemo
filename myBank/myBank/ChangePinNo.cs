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
    public partial class ChangePinNo : Form
    {
        public ChangePinNo()
        {
            InitializeComponent();
        }

        ChangePinNoBLL pinBll = new ChangePinNoBLL();
        private void btnChangePin_Click(object sender, EventArgs e)
        {

            if (txtAccountNumber.Text == "")
            {
                MessageBox.Show("Enter your account number!!!");
                txtAccountNumber.Focus();
                return;
            }
            else if (txtOldPin.Text == "")
            {
                MessageBox.Show("Please enter your old pin number!!");
                txtOldPin.Focus();
                return;
            }
            else if (txtNewPin.Text == "")
            {
                MessageBox.Show("Please enter new pinumber!!!");
                txtNewPin.Focus();
                return;
            }
            else if(txtConfirmPin.Text == "")
            {
                MessageBox.Show("Please confirm your new pin number!!");
                txtConfirmPin.Focus();
                return;
            }
            else
            {
                int accountNo;
                int oldPin;
                int newPin;
                int confirmPin;

                accountNo = int.Parse(txtAccountNumber.Text);
                oldPin = int.Parse(txtOldPin.Text);
                newPin = int.Parse(txtNewPin.Text);
                confirmPin = int.Parse(txtConfirmPin.Text);

                pinBll._accountNo = accountNo;
                pinBll._oldPin = oldPin;
                pinBll._newPin = newPin;
                pinBll._confirmPin = confirmPin;

                pinBll.updatePinNo(oldPin);
                MessageBox.Show("Pin number is succesfully changed!!!!!.");
                this.Close();

            }
        }
    }
}
