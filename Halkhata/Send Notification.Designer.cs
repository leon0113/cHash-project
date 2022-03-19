
namespace Halkhata
{
    partial class Send_Notification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Send_Notification));
            this.notification_send_listView = new System.Windows.Forms.ListView();
            this.gobackmenu_button = new System.Windows.Forms.Button();
            this.t_customer_phone_number_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.send_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // notification_send_listView
            // 
            this.notification_send_listView.BackColor = System.Drawing.Color.Silver;
            this.notification_send_listView.HideSelection = false;
            this.notification_send_listView.Location = new System.Drawing.Point(394, 131);
            this.notification_send_listView.Name = "notification_send_listView";
            this.notification_send_listView.Size = new System.Drawing.Size(479, 280);
            this.notification_send_listView.TabIndex = 129;
            this.notification_send_listView.UseCompatibleStateImageBehavior = false;
            // 
            // gobackmenu_button
            // 
            this.gobackmenu_button.BackColor = System.Drawing.Color.Firebrick;
            this.gobackmenu_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.gobackmenu_button.FlatAppearance.BorderSize = 2;
            this.gobackmenu_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gobackmenu_button.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gobackmenu_button.ForeColor = System.Drawing.Color.White;
            this.gobackmenu_button.Location = new System.Drawing.Point(707, 37);
            this.gobackmenu_button.Name = "gobackmenu_button";
            this.gobackmenu_button.Size = new System.Drawing.Size(166, 32);
            this.gobackmenu_button.TabIndex = 130;
            this.gobackmenu_button.Text = "Go Back To Main Menu";
            this.gobackmenu_button.UseVisualStyleBackColor = false;
            // 
            // t_customer_phone_number_textBox
            // 
            this.t_customer_phone_number_textBox.Location = new System.Drawing.Point(59, 131);
            this.t_customer_phone_number_textBox.Multiline = true;
            this.t_customer_phone_number_textBox.Name = "t_customer_phone_number_textBox";
            this.t_customer_phone_number_textBox.Size = new System.Drawing.Size(212, 28);
            this.t_customer_phone_number_textBox.TabIndex = 131;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(56, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 132;
            this.label2.Text = "Contact No :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(59, 208);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(256, 144);
            this.textBox1.TabIndex = 133;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(56, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 134;
            this.label1.Text = "Write Message :";
            // 
            // send_button
            // 
            this.send_button.BackColor = System.Drawing.Color.Gold;
            this.send_button.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.send_button.FlatAppearance.BorderSize = 2;
            this.send_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.send_button.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send_button.Location = new System.Drawing.Point(59, 379);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(166, 32);
            this.send_button.TabIndex = 135;
            this.send_button.Text = "Send Reminder";
            this.send_button.UseVisualStyleBackColor = false;
            // 
            // Send_Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(944, 531);
            this.Controls.Add(this.send_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.t_customer_phone_number_textBox);
            this.Controls.Add(this.gobackmenu_button);
            this.Controls.Add(this.notification_send_listView);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Send_Notification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send Notification";
            this.Load += new System.EventHandler(this.Send_Notificartion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView notification_send_listView;
        private System.Windows.Forms.Button gobackmenu_button;
        private System.Windows.Forms.TextBox t_customer_phone_number_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button send_button;
    }
}