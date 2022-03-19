
namespace Halkhata
{
    partial class Transaction_Data
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transaction_Data));
            this.gobackmenu_button = new System.Windows.Forms.Button();
            this.transaction_data_listView = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.gobackmenu_button.TabIndex = 21;
            this.gobackmenu_button.Text = "Go Back To Main Menu";
            this.gobackmenu_button.UseVisualStyleBackColor = false;
            this.gobackmenu_button.Click += new System.EventHandler(this.gobackmenu_button_Click);
            // 
            // transaction_data_listView
            // 
            this.transaction_data_listView.BackColor = System.Drawing.Color.Silver;
            this.transaction_data_listView.HideSelection = false;
            this.transaction_data_listView.Location = new System.Drawing.Point(52, 155);
            this.transaction_data_listView.Name = "transaction_data_listView";
            this.transaction_data_listView.Size = new System.Drawing.Size(835, 296);
            this.transaction_data_listView.TabIndex = 129;
            this.transaction_data_listView.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(49, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 24);
            this.label4.TabIndex = 130;
            this.label4.Text = "Customer Transaction Data :\r\n\r\n\r\n";
            // 
            // Transaction_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.transaction_data_listView);
            this.Controls.Add(this.gobackmenu_button);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Transaction_Data";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction Data";
            this.Load += new System.EventHandler(this.Transaction_Data_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button gobackmenu_button;
        private System.Windows.Forms.ListView transaction_data_listView;
        private System.Windows.Forms.Label label4;
    }
}