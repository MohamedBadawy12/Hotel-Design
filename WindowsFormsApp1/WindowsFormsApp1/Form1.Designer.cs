﻿
namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.passError_Lbl = new System.Windows.Forms.Label();
            this.nameError_Lbl = new System.Windows.Forms.Label();
            this.Password_textBox2 = new System.Windows.Forms.TextBox();
            this.Username_textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Login_btn1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(521, 422);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(407, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // passError_Lbl
            // 
            this.passError_Lbl.AutoSize = true;
            this.passError_Lbl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.passError_Lbl.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.passError_Lbl.ForeColor = System.Drawing.Color.Red;
            this.passError_Lbl.Location = new System.Drawing.Point(482, 240);
            this.passError_Lbl.Name = "passError_Lbl";
            this.passError_Lbl.Size = new System.Drawing.Size(17, 17);
            this.passError_Lbl.TabIndex = 29;
            this.passError_Lbl.Text = "*";
            this.passError_Lbl.Visible = false;
            // 
            // nameError_Lbl
            // 
            this.nameError_Lbl.AutoSize = true;
            this.nameError_Lbl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nameError_Lbl.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.nameError_Lbl.ForeColor = System.Drawing.Color.Red;
            this.nameError_Lbl.Location = new System.Drawing.Point(482, 155);
            this.nameError_Lbl.Name = "nameError_Lbl";
            this.nameError_Lbl.Size = new System.Drawing.Size(17, 17);
            this.nameError_Lbl.TabIndex = 28;
            this.nameError_Lbl.Text = "*";
            this.nameError_Lbl.Visible = false;
            // 
            // Password_textBox2
            // 
            this.Password_textBox2.Location = new System.Drawing.Point(271, 238);
            this.Password_textBox2.Multiline = true;
            this.Password_textBox2.Name = "Password_textBox2";
            this.Password_textBox2.PasswordChar = '*';
            this.Password_textBox2.Size = new System.Drawing.Size(205, 24);
            this.Password_textBox2.TabIndex = 26;
            // 
            // Username_textBox1
            // 
            this.Username_textBox1.Location = new System.Drawing.Point(271, 154);
            this.Username_textBox1.Multiline = true;
            this.Username_textBox1.Name = "Username_textBox1";
            this.Username_textBox1.Size = new System.Drawing.Size(205, 24);
            this.Username_textBox1.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(184, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(178, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "UserName";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(135, 136);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(146, 233);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(37, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 32;
            this.pictureBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Script MT Bold", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label3.Location = new System.Drawing.Point(159, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 46);
            this.label3.TabIndex = 33;
            this.label3.Text = "LiaLina Hotel";
            // 
            // Login_btn1
            // 
            this.Login_btn1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Login_btn1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.Login_btn1.Location = new System.Drawing.Point(293, 293);
            this.Login_btn1.Name = "Login_btn1";
            this.Login_btn1.Size = new System.Drawing.Size(87, 32);
            this.Login_btn1.TabIndex = 34;
            this.Login_btn1.Text = "Login";
            this.Login_btn1.UseVisualStyleBackColor = false;
            this.Login_btn1.Click += new System.EventHandler(this.Login_btn1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 422);
            this.Controls.Add(this.Login_btn1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.passError_Lbl);
            this.Controls.Add(this.nameError_Lbl);
            this.Controls.Add(this.Password_textBox2);
            this.Controls.Add(this.Username_textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label passError_Lbl;
        private System.Windows.Forms.Label nameError_Lbl;
        private System.Windows.Forms.TextBox Password_textBox2;
        private System.Windows.Forms.TextBox Username_textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Login_btn1;
    }
}

