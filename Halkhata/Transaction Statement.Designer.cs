
namespace Halkhata
{
    partial class TransactionStatement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionStatement));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.t_customer_phone_number_textBox = new System.Windows.Forms.TextBox();
            this.t_customer_NametextBox = new System.Windows.Forms.TextBox();
            this.purchasetextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.record_statement_button = new System.Windows.Forms.Button();
            this.gobackmenu_button = new System.Windows.Forms.Button();
            this.paymenttextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTransactionID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(197, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Contact No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(197, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Name :";
            // 
            // t_customer_phone_number_textBox
            // 
            this.t_customer_phone_number_textBox.Location = new System.Drawing.Point(200, 283);
            this.t_customer_phone_number_textBox.Multiline = true;
            this.t_customer_phone_number_textBox.Name = "t_customer_phone_number_textBox";
            this.t_customer_phone_number_textBox.Size = new System.Drawing.Size(212, 28);
            this.t_customer_phone_number_textBox.TabIndex = 21;
            // 
            // t_customer_NametextBox
            // 
            this.t_customer_NametextBox.Location = new System.Drawing.Point(200, 202);
            this.t_customer_NametextBox.Multiline = true;
            this.t_customer_NametextBox.Name = "t_customer_NametextBox";
            this.t_customer_NametextBox.Size = new System.Drawing.Size(212, 28);
            this.t_customer_NametextBox.TabIndex = 19;
            // 
            // purchasetextBox
            // 
            this.purchasetextBox.Location = new System.Drawing.Point(525, 202);
            this.purchasetextBox.Multiline = true;
            this.purchasetextBox.Name = "purchasetextBox";
            this.purchasetextBox.Size = new System.Drawing.Size(212, 28);
            this.purchasetextBox.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(522, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 26;
            this.label4.Text = "Today\'s Purchase :";
            // 
            // record_statement_button
            // 
            this.record_statement_button.BackColor = System.Drawing.Color.Gold;
            this.record_statement_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.record_statement_button.FlatAppearance.BorderSize = 2;
            this.record_statement_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.record_statement_button.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.record_statement_button.Location = new System.Drawing.Point(386, 378);
            this.record_statement_button.Name = "record_statement_button";
            this.record_statement_button.Size = new System.Drawing.Size(166, 32);
            this.record_statement_button.TabIndex = 27;
            this.record_statement_button.Text = "Record";
            this.record_statement_button.UseVisualStyleBackColor = false;
            this.record_statement_button.Click += new System.EventHandler(this.record_statement_button_Click);
            // 
            // gobackmenu_button
            // 
            this.gobackmenu_button.BackColor = System.Drawing.Color.Firebrick;
            this.gobackmenu_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gobackmenu_button.FlatAppearance.BorderSize = 2;
            this.gobackmenu_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gobackmenu_button.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gobackmenu_button.ForeColor = System.Drawing.Color.White;
            this.gobackmenu_button.Location = new System.Drawing.Point(707, 37);
            this.gobackmenu_button.Name = "gobackmenu_button";
            this.gobackmenu_button.Size = new System.Drawing.Size(180, 30);
            this.gobackmenu_button.TabIndex = 28;
            this.gobackmenu_button.Text = "Go Back To Main Menu";
            this.gobackmenu_button.UseVisualStyleBackColor = false;
            this.gobackmenu_button.Click += new System.EventHandler(this.gobackmenu_button_Click);
            // 
            // paymenttextBox
            // 
            this.paymenttextBox.Location = new System.Drawing.Point(525, 283);
            this.paymenttextBox.Multiline = true;
            this.paymenttextBox.Name = "paymenttextBox";
            this.paymenttextBox.Size = new System.Drawing.Size(212, 28);
            this.paymenttextBox.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(522, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Payment :";
            // 
            // textBoxTransactionID
            // 
            this.textBoxTransactionID.Location = new System.Drawing.Point(60, 39);
            this.textBoxTransactionID.Multiline = true;
            this.textBoxTransactionID.Name = "textBoxTransactionID";
            this.textBoxTransactionID.Size = new System.Drawing.Size(141, 28);
            this.textBoxTransactionID.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(57, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 15);
            this.label5.TabIndex = 32;
            this.label5.Text = "Transaction Id:";
            // 
            // TransactionStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(944, 531);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTransactionID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paymenttextBox);
            this.Controls.Add(this.gobackmenu_button);
            this.Controls.Add(this.record_statement_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.purchasetextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.t_customer_phone_number_textBox);
            this.Controls.Add(this.t_customer_NametextBox);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TransactionStatement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction Statement";
            this.Load += new System.EventHandler(this.TransactionStatement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox t_customer_phone_number_textBox;
        private System.Windows.Forms.TextBox t_customer_NametextBox;
        private System.Windows.Forms.TextBox purchasetextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button record_statement_button;
        private System.Windows.Forms.Button gobackmenu_button;
        private System.Windows.Forms.TextBox paymenttextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTransactionID;
        private System.Windows.Forms.Label label5;
    }
}