namespace myBank
{
    partial class ChangePinNo
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOldPin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnChangePin = new System.Windows.Forms.Button();
            this.txtNewPin = new System.Windows.Forms.TextBox();
            this.txtConfirmPin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Account Number";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(232, 51);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(154, 20);
            this.txtAccountNumber.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Old Pin Number";
            // 
            // txtOldPin
            // 
            this.txtOldPin.Location = new System.Drawing.Point(232, 101);
            this.txtOldPin.Name = "txtOldPin";
            this.txtOldPin.Size = new System.Drawing.Size(154, 20);
            this.txtOldPin.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "New Pin Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Confirm Pin Number";
            // 
            // btnChangePin
            // 
            this.btnChangePin.BackColor = System.Drawing.Color.Blue;
            this.btnChangePin.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnChangePin.Location = new System.Drawing.Point(155, 295);
            this.btnChangePin.Name = "btnChangePin";
            this.btnChangePin.Size = new System.Drawing.Size(176, 53);
            this.btnChangePin.TabIndex = 6;
            this.btnChangePin.Text = "Change PinNo";
            this.btnChangePin.UseVisualStyleBackColor = false;
            this.btnChangePin.Click += new System.EventHandler(this.btnChangePin_Click);
            // 
            // txtNewPin
            // 
            this.txtNewPin.Location = new System.Drawing.Point(232, 157);
            this.txtNewPin.Name = "txtNewPin";
            this.txtNewPin.Size = new System.Drawing.Size(154, 20);
            this.txtNewPin.TabIndex = 7;
            // 
            // txtConfirmPin
            // 
            this.txtConfirmPin.Location = new System.Drawing.Point(232, 215);
            this.txtConfirmPin.Name = "txtConfirmPin";
            this.txtConfirmPin.Size = new System.Drawing.Size(154, 20);
            this.txtConfirmPin.TabIndex = 8;
            // 
            // ChangePinNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::myBank.Properties.Resources.paper_money_clipart;
            this.ClientSize = new System.Drawing.Size(419, 360);
            this.Controls.Add(this.txtConfirmPin);
            this.Controls.Add(this.txtNewPin);
            this.Controls.Add(this.btnChangePin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOldPin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.label1);
            this.Name = "ChangePinNo";
            this.Text = "ChangePinNo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOldPin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnChangePin;
        private System.Windows.Forms.TextBox txtNewPin;
        private System.Windows.Forms.TextBox txtConfirmPin;
    }
}