namespace myBank
{
    partial class Customer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.rdobtnMale = new System.Windows.Forms.RadioButton();
            this.rdobtnFemale = new System.Windows.Forms.RadioButton();
            this.rdobtnOthers = new System.Windows.Forms.RadioButton();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.dateofBirth = new System.Windows.Forms.DateTimePicker();
            this.dgCustomer = new System.Windows.Forms.DataGridView();
            this.Customerid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCaccount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(31, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "fname";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(32, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "lname";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblgender.Location = new System.Drawing.Point(32, 144);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(66, 21);
            this.lblgender.TabIndex = 3;
            this.lblgender.Text = "gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(32, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dob";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(31, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(27, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "PhoneNumber";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(28, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Balance";
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(179, 72);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(200, 20);
            this.txtfname.TabIndex = 9;
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(179, 108);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(200, 20);
            this.txtlname.TabIndex = 10;
            // 
            // rdobtnMale
            // 
            this.rdobtnMale.AutoSize = true;
            this.rdobtnMale.Location = new System.Drawing.Point(179, 148);
            this.rdobtnMale.Name = "rdobtnMale";
            this.rdobtnMale.Size = new System.Drawing.Size(48, 17);
            this.rdobtnMale.TabIndex = 11;
            this.rdobtnMale.TabStop = true;
            this.rdobtnMale.Text = "Male";
            this.rdobtnMale.UseVisualStyleBackColor = true;
            // 
            // rdobtnFemale
            // 
            this.rdobtnFemale.AutoSize = true;
            this.rdobtnFemale.Location = new System.Drawing.Point(246, 148);
            this.rdobtnFemale.Name = "rdobtnFemale";
            this.rdobtnFemale.Size = new System.Drawing.Size(59, 17);
            this.rdobtnFemale.TabIndex = 12;
            this.rdobtnFemale.TabStop = true;
            this.rdobtnFemale.Text = "Female";
            this.rdobtnFemale.UseVisualStyleBackColor = true;
            // 
            // rdobtnOthers
            // 
            this.rdobtnOthers.AutoSize = true;
            this.rdobtnOthers.Location = new System.Drawing.Point(311, 148);
            this.rdobtnOthers.Name = "rdobtnOthers";
            this.rdobtnOthers.Size = new System.Drawing.Size(56, 17);
            this.rdobtnOthers.TabIndex = 13;
            this.rdobtnOthers.TabStop = true;
            this.rdobtnOthers.Text = "Others";
            this.rdobtnOthers.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(179, 213);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 20);
            this.txtAddress.TabIndex = 15;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(179, 288);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(200, 20);
            this.txtBalance.TabIndex = 17;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(179, 249);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(200, 20);
            this.txtPhoneNumber.TabIndex = 16;
            // 
            // dateofBirth
            // 
            this.dateofBirth.CustomFormat = "dd-MM-yyyy";
            this.dateofBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateofBirth.Location = new System.Drawing.Point(179, 178);
            this.dateofBirth.Name = "dateofBirth";
            this.dateofBirth.Size = new System.Drawing.Size(200, 20);
            this.dateofBirth.TabIndex = 20;
            this.dateofBirth.ValueChanged += new System.EventHandler(this.dateofBirth_ValueChanged);
            // 
            // dgCustomer
            // 
            this.dgCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Customerid,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column9,
            this.Column10,
            this.Edit,
            this.Delete});
            this.dgCustomer.Location = new System.Drawing.Point(-2, 397);
            this.dgCustomer.Name = "dgCustomer";
            this.dgCustomer.Size = new System.Drawing.Size(1145, 218);
            this.dgCustomer.TabIndex = 21;
            this.dgCustomer.Click += new System.EventHandler(this.dgCustomer_Click);
            // 
            // Customerid
            // 
            this.Customerid.DataPropertyName = "Customerid";
            this.Customerid.HeaderText = "Customerid";
            this.Customerid.Name = "Customerid";
            this.Customerid.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "fname";
            this.Column1.HeaderText = "fname";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "lname";
            this.Column2.HeaderText = "lname";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "gender";
            this.Column3.HeaderText = "gender";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Dob";
            this.Column4.HeaderText = "Dob";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Address";
            this.Column5.HeaderText = "Address";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "PhoneNumber";
            this.Column6.HeaderText = "PhoneNumber";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Balance";
            this.Column7.HeaderText = "Balance";
            this.Column7.Name = "Column7";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "accountNo";
            this.Column9.HeaderText = "accountNo";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "pinNo";
            this.Column10.HeaderText = "pinNo";
            this.Column10.Name = "Column10";
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.ToolTipText = "Edit";
            this.Edit.UseColumnTextForLinkValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.UseColumnTextForLinkValue = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(257, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 33);
            this.label1.TabIndex = 23;
            this.label1.Text = "ACCOUNT CREATE FORM";
            // 
            // btnCaccount
            // 
            this.btnCaccount.BackColor = System.Drawing.Color.MediumBlue;
            this.btnCaccount.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCaccount.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCaccount.Location = new System.Drawing.Point(454, 323);
            this.btnCaccount.Name = "btnCaccount";
            this.btnCaccount.Size = new System.Drawing.Size(253, 50);
            this.btnCaccount.TabIndex = 24;
            this.btnCaccount.Text = "CREATE ACCOUNT";
            this.btnCaccount.UseVisualStyleBackColor = false;
            this.btnCaccount.Click += new System.EventHandler(this.btnCaccount_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImage = global::myBank.Properties.Resources.paper_money_clipart;
            this.ClientSize = new System.Drawing.Size(1139, 616);
            this.Controls.Add(this.btnCaccount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgCustomer);
            this.Controls.Add(this.dateofBirth);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.rdobtnOthers);
            this.Controls.Add(this.rdobtnFemale);
            this.Controls.Add(this.rdobtnMale);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.RadioButton rdobtnMale;
        private System.Windows.Forms.RadioButton rdobtnFemale;
        private System.Windows.Forms.RadioButton rdobtnOthers;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.DateTimePicker dateofBirth;
        private System.Windows.Forms.DataGridView dgCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCaccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customerid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
    }
}

