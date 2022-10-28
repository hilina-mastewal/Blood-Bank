using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank
{
    public partial class createaccount : Form
    {
        public createaccount()
        {
            InitializeComponent();
        }


        private void createaccount_Load(object sender, EventArgs e)
        {
            panelCreateAccount.BackColor = Color.FromArgb(120, 100, 0, 0);  
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var lg = new LoginPage();
            lg.Show();
            lg.Location = new System.Drawing.Point(200, 50);
        }

        private void txtCconfirm_Leave(object sender, EventArgs e)
        {

            if (txtCpwd.Text.CompareTo(txtCconfirm.Text) != 0)
            {
                txtCpwd.Clear();
                txtCconfirm.Clear();
                txtCpwd.Focus();
                txtCpwd.BorderColor = Color.Red;
                txtCconfirm.BorderColor = Color.Red;
            }
            else
            {
                txtCpwd.BorderColor = Color.FromArgb(213, 218, 223);
                txtCconfirm.BorderColor = Color.FromArgb(213, 218, 223);
            }
        }

        private void btnCsubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCfirstname.Text) || string.IsNullOrEmpty(txtCfirstname.Text) || string.IsNullOrEmpty(txtCaddress.Text) || string.IsNullOrEmpty(txtCphonenum.Text) || string.IsNullOrEmpty(txtCpwd.Text) || string.IsNullOrEmpty(txtCconfirm.Text) || string.IsNullOrEmpty(cbCcombo.Text) || string.IsNullOrEmpty(txtCusername.Text) )
            {
                MessageBox.Show("insert complete data");
            }
            else
            {
                Receptionist re = new Receptionist();
                re.firstName = txtCfirstname.Text;
                re.lastName = txtClastname.Text;
                re.password = txtCpwd.Text;
                re.userName = txtCusername.Text;
                re.phoneNumber = txtCphonenum.Text;
                re.address = txtCaddress.Text;
                re.fkBloodBank = cbCcombo.SelectedIndex + 1;
                re.signUp();
            }
        }

        private void txtCphonenum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("please enter only numbers");
            }
        }

        private void gunaImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.ClientSize = new System.Drawing.Size(1366, 738);
            this.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.BackgroundImage = global::Blood_Bank.Properties.Resources.bloodwall2;
            this.Show();
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.ClientSize = new System.Drawing.Size(886, 548);
            this.Location = new System.Drawing.Point(200, 50);
            this.guna2Panel1.BackgroundImage = global::Blood_Bank.Properties.Resources.i01_bloodwall2;
            this.Show();
        }

        private void btnMexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtCpwd_Click(object sender, EventArgs e)
        {
            txtCpwd.BorderColor = Color.FromArgb(213, 218, 223);
            txtCconfirm.BorderColor = Color.FromArgb(213, 218, 223);
        }


        private void btnMexit_MouseEnter(object sender, EventArgs e)
        {
            btnMexit.BackColor = Color.Red;
        }

        private void gunaImageButton2_MouseEnter(object sender, EventArgs e)
        {
            gunaImageButton2.BackColor = Color.Red;
        }

        private void gunaImageButton1_MouseEnter(object sender, EventArgs e)
        {
            gunaImageButton1.BackColor = Color.Red;
        }

        private void btnMexit_MouseLeave(object sender, EventArgs e)
        {
            btnMexit.BackColor = Color.Firebrick;
        }

        private void gunaImageButton2_MouseLeave(object sender, EventArgs e)
        {
            gunaImageButton2.BackColor = Color.Firebrick;
        }

        private void gunaImageButton1_MouseLeave(object sender, EventArgs e)
        {
            gunaImageButton1.BackColor = Color.Firebrick;
        }

        private void txtCconfirm_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
