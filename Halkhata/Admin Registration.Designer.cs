﻿
namespace Halkhata
{
    partial class admin_registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_registration));
            this.Finish_button = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.a_passwordtextBox = new System.Windows.Forms.TextBox();
            this.a_emailtextBox = new System.Windows.Forms.TextBox();
            this.a_firstnametextBox = new System.Windows.Forms.TextBox();
            this.a_lastnametextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.admin_idtextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Finish_button
            // 
            this.Finish_button.BackColor = System.Drawing.Color.YellowGreen;
            this.Finish_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Finish_button.FlatAppearance.BorderSize = 2;
            this.Finish_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Finish_button.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Finish_button.Location = new System.Drawing.Point(653, 328);
            this.Finish_button.Name = "Finish_button";
            this.Finish_button.Size = new System.Drawing.Size(75, 32);
            this.Finish_button.TabIndex = 11;
            this.Finish_button.Text = "Finish";
            this.Finish_button.UseVisualStyleBackColor = false;
            this.Finish_button.Click += new System.EventHandler(this.Finish_button_Click_1);
            // 
            // Back_button
            // 
            this.Back_button.BackColor = System.Drawing.Color.YellowGreen;
            this.Back_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Back_button.FlatAppearance.BorderSize = 2;
            this.Back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_button.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_button.Location = new System.Drawing.Point(199, 328);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(75, 32);
            this.Back_button.TabIndex = 10;
            this.Back_button.Text = "Back";
            this.Back_button.UseVisualStyleBackColor = false;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(516, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(516, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Email or User Name :";
            // 
            // a_passwordtextBox
            // 
            this.a_passwordtextBox.Location = new System.Drawing.Point(516, 245);
            this.a_passwordtextBox.Multiline = true;
            this.a_passwordtextBox.Name = "a_passwordtextBox";
            this.a_passwordtextBox.Size = new System.Drawing.Size(212, 28);
            this.a_passwordtextBox.TabIndex = 6;
            // 
            // a_emailtextBox
            // 
            this.a_emailtextBox.Location = new System.Drawing.Point(516, 170);
            this.a_emailtextBox.Multiline = true;
            this.a_emailtextBox.Name = "a_emailtextBox";
            this.a_emailtextBox.Size = new System.Drawing.Size(212, 28);
            this.a_emailtextBox.TabIndex = 7;
            // 
            // a_firstnametextBox
            // 
            this.a_firstnametextBox.Location = new System.Drawing.Point(199, 170);
            this.a_firstnametextBox.Multiline = true;
            this.a_firstnametextBox.Name = "a_firstnametextBox";
            this.a_firstnametextBox.Size = new System.Drawing.Size(212, 28);
            this.a_firstnametextBox.TabIndex = 12;
            // 
            // a_lastnametextBox
            // 
            this.a_lastnametextBox.Location = new System.Drawing.Point(199, 245);
            this.a_lastnametextBox.Multiline = true;
            this.a_lastnametextBox.Name = "a_lastnametextBox";
            this.a_lastnametextBox.Size = new System.Drawing.Size(212, 28);
            this.a_lastnametextBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(194, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "First Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(196, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Last Name :";
            // 
            // admin_idtextBox
            // 
            this.admin_idtextBox.Location = new System.Drawing.Point(50, 68);
            this.admin_idtextBox.Multiline = true;
            this.admin_idtextBox.Name = "admin_idtextBox";
            this.admin_idtextBox.Size = new System.Drawing.Size(116, 25);
            this.admin_idtextBox.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(50, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Admin Id :";
            // 
            // admin_registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.admin_idtextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.a_lastnametextBox);
            this.Controls.Add(this.a_firstnametextBox);
            this.Controls.Add(this.Finish_button);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.a_passwordtextBox);
            this.Controls.Add(this.a_emailtextBox);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "admin_registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Finish_button;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox a_passwordtextBox;
        private System.Windows.Forms.TextBox a_emailtextBox;
        private System.Windows.Forms.TextBox a_firstnametextBox;
        private System.Windows.Forms.TextBox a_lastnametextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox admin_idtextBox;
        private System.Windows.Forms.Label label5;
    }
}