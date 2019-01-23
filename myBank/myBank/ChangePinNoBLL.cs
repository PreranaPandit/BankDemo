using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myBank
{
    class ChangePinNoBLL
    {
        private int accountNo;
        private int oldPin;
        private int newPin;
        private int confirmPin;

        public ChangePinNoBLL()
        {

        }

        public ChangePinNoBLL(int accountNo, int oldPin, int newPin, int confirmPin)
        {
            this.accountNo = accountNo;
            this.oldPin = oldPin;
            this.newPin = newPin;
            this.confirmPin = confirmPin;
                
        }

        public int _accountNo
        {
            get { return accountNo; }
            set { this.accountNo = value; }
        }
        public int _oldPin
        {
            get { return oldPin; }
            set { this.oldPin = value; }
        }
        public int _newPin
        {
            get { return newPin; }
            set { this.newPin = value; }
        }
        public int _confirmPin
        {
            get { return confirmPin;}
            set { this.confirmPin = value; }
        }

        //dbconection
        DbConnection dbconnection = new DbConnection();


        //update code for changing pin number
        public void updatePinNo(int oldPin)
        {
            string query;
            query = "Update Customer set pinNo='" + confirmPin + "' where pinNo = " + oldPin;
            dbconnection.Manipulate(query);
        }



    }
}
