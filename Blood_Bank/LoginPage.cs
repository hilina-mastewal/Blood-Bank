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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            this.Location = new System.Drawing.Point(200, 50);
        }


        private void btnSignIn_Click(object sender, EventArgs e)
        {
            Receptionist re = new Receptionist();
            re.userName = txtLusername.Text;
            re.password = txtLpwd.Text;
            var da = re.signIn();
                try
                {
                    da.Rows[0][0].ToString();
                    this.Hide();
                    MainPage mp = new MainPage();
                    mp.repID = int.Parse(da.Rows[0][0].ToString());
                    mp.nam = da.Rows[0][1].ToString();
                    mp.set();
                    mp.Show();
                    mp.Location = new System.Drawing.Point(200, 50);
                }
            
                catch
                {
                    this.txtLusername.BorderColor = Color.Firebrick;
                    this.txtLpwd.BorderColor = Color.Firebrick;
                }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var ca = new createaccount();
            ca.Show();
            ca.Location = new System.Drawing.Point(200, 50);
        }


        private void btnMexit_MouseEnter(object sender, EventArgs e)
        {
            btnLexit.BackColor = Color.FromArgb(201, 38, 38);
        }

        private void btnMexit_MouseLeave(object sender, EventArgs e)
        {
            btnLexit.BackColor = Color.Firebrick;
        }


        private void gunaImageButton2_MouseEnter(object sender, EventArgs e)
        {
           btnLmax.BackColor = Color.FromArgb(201, 38, 38);
        }

        private void gunaImageButton2_MouseLeave(object sender, EventArgs e)
        {
            btnLmax.BackColor = Color.Firebrick;
        }

        private void btnLmin_MouseEnter(object sender, EventArgs e)
        {
            btnLmin.BackColor = Color.FromArgb(201, 38, 38);
        }
        private void gunaImageButton1_MouseLeave(object sender, EventArgs e)
        {
            btnLmin.BackColor = Color.Firebrick;
        }

        private void btnLexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLmax_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.ClientSize = new System.Drawing.Size(1366, 738);
            this.Location = new System.Drawing.Point(0,0);
            this.panLlogin.BackgroundImage = global::Blood_Bank.Properties.Resources.bloodwall2;
            this.Show();
        }

        private void btnLmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.ClientSize = new System.Drawing.Size(886, 548);
            this.Location = new System.Drawing.Point(200,50);
            this.panLlogin.BackgroundImage = global::Blood_Bank.Properties.Resources.i01_bloodwall2;
            this.Show();
        }

        private void chLshowpwd_CheckedChanged(object sender, EventArgs e)
        {
            if (chLshowpwd.Checked == true)
                this.txtLpwd.UseSystemPasswordChar = false;
            else
                this.txtLpwd.UseSystemPasswordChar = true;
        }

        private void txtLusername_Click(object sender, EventArgs e)
        {
            this.txtLusername.BorderColor = Color.Snow;
            this.txtLpwd.BorderColor = Color.Snow;
        }
    }
}
