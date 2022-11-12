using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Login()
        {
            if (Username_textBox1.Text == "Admin")
            {
                if (Password_textBox2.Text == "admin")
                {
                    passError_Lbl.Visible = false;
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                }
                else
                {
                    passError_Lbl.Visible = true;
                }
                nameError_Lbl.Visible = false;
            }
            else
            {
                nameError_Lbl.Visible = true;
            }
        }
        private void Login_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void Login_btn1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_btn1_Click_1(object sender, EventArgs e)
        {
            Login();
        }
    }
}
