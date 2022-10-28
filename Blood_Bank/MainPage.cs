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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            interChangePanel();
            this.panMhome.Show();
        }

        public int repID { set; get; }
        public string nam { set; get; }
     
        public void set ()
        {
            this.txtMname.Text = nam;
        }
          
        private void btnMexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMexit_MouseEnter(object sender, EventArgs e)
        {
            btnMexit.BackColor = Color.Red;
        }

        private void btnMexit_MouseLeave(object sender, EventArgs e)
        {
            btnMexit.BackColor = Color.Firebrick;
        }

        private void btnMlogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage lg = new LoginPage();
            lg.Show();
            lg.Location = new System.Drawing.Point(200, 50);
        }

        private void btnMaddDonor_Click(object sender, EventArgs e)
        {
            interChangePanel();
            this.panAddDonor.Show();
        }

        private void btnMhome_Click(object sender, EventArgs e)
        {
            interChangePanel();
            this.panMhome.Show();
        }

        private void btnDsubmit_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtDfirstName.Text) || string.IsNullOrEmpty(txtDfatherName.Text) || string.IsNullOrEmpty(txtDaddress.Text) || string.IsNullOrEmpty(txtDage.Text) || string.IsNullOrEmpty(txtDamountOfBlood.Text) || string.IsNullOrEmpty(cmbDbloodType.Text) || string.IsNullOrEmpty(cmbDgender.Text) || string.IsNullOrEmpty(cmbDPhonePrfix.Text)  || string.IsNullOrEmpty(txtDphoneNumber.Text))
            {
                MessageBox.Show("Please make sure you fill all the information needed!");
            }
            else
            {
                Donor don = new Donor();
                don.firstName = txtDfirstName.Text;
                don.lastName = txtDfatherName.Text;
                don.gender = char.Parse(cmbDgender.Text);
                don.age = int.Parse(txtDage.Text);
                don.address = txtDaddress.Text;
                don.fkReceptionistId = repID;
                don.phoneNumber =  cmbDPhonePrfix.Text +txtDphoneNumber.Text;
                don.qty = decimal.Parse(txtDamountOfBlood.Text);
                don.fkBloodId = cmbDbloodType.Text;
                int status =don.saveDonor();
                if (status > 0)
                {
                    clear_donor();
                    MessageBox.Show("Successfully Added");
                }
                else
                    MessageBox.Show("Please make sure you fill all the information needed!");
            }
        }
        public void clear_donor()
        {
            txtDaddress.Text = "";
            txtDaddress.Text = "";
            txtDage.Text = "";
            txtDamountOfBlood.Text = "";
            txtDfatherName.Text = "";
            txtDfirstName.Text = "";
            txtDphoneNumber.Text = "";
            cmbDbloodType.Text = null;
            cmbDgender.Text = null;
        }

        private void btnIback_Click(object sender, EventArgs e)
        {
            interChangePanel();
            this.panMdonerlist.Show();
        }

        private void btnMdonorList_Click(object sender, EventArgs e)
        {
            interChangePanel();
            this.panMdonerlist.Show();
        }

        private void interChangePanel()
        {
            this.PanImodifey.Hide();
            this.panOorderlist.Hide();
            this.panMhome.Hide();
            this.panAddDonor.Hide();
            this.panMdonerlist.Hide();
            this.panOIinfo.Hide();
            this.panCra.Hide();
        }

        private void btnMorderList_Click(object sender, EventArgs e)
        {
            interChangePanel();
            this.panOorderlist.Show();
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.ClientSize = new System.Drawing.Size(886, 548);
            this.Location = new System.Drawing.Point(200, 50);
            this.Show();
        }

        private void btnOIback_Click(object sender, EventArgs e)
        {
            interChangePanel();
            this.panOorderlist.Show();
        }
        private void btnDLsearch_Click(object sender, EventArgs e)
        {
            Donor don = new Donor();
            DataTable dt = don.getDonor(txtDLsearch.Text);
            if (dt != null)
                gridDLdonerlist.DataSource = dt;
        }

        public int donorID = 0;
        private void gridDLdonerlist_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            interChangePanel();
            PanImodifey.Show();
            if (e.RowIndex >= 0 && e != null)
            {
                DataGridViewRow row = gridDLdonerlist.Rows[e.RowIndex];
                donorID = int.Parse(row.Cells[0].Value.ToString());
                txtIfirstname.Text = row.Cells[1].Value.ToString();
                txtIfathername.Text = row.Cells[2].Value.ToString();
                txtIage.Text = row.Cells[3].Value.ToString();
                cmbIgender.SelectedItem = row.Cells[4].Value.ToString();
                cmbIpre.SelectedItem = "+251";
                txtIphone.Text = row.Cells[5].Value.ToString().Substring(4);
                txtIaddress.Text = row.Cells[6].Value.ToString();
                txtIamount.Text = row.Cells[8].Value.ToString();
                cmbIbloodtype.SelectedItem =row.Cells[9].Value.ToString();
            }
        }

        private void btnOLsearch_Click(object sender, EventArgs e)
        {
            Orders or = new Orders();
            DataTable dt = or.getOrders(txtOLsearch.Text);
            if (dt != null)
                gridOLorderlist.DataSource = dt;
        }

        
        private void gridOLorderlist_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            interChangePanel();
            this.panOIinfo.Show();
            if (e.RowIndex >= 0 && e != null)
            {
                DataGridViewRow row = gridOLorderlist.Rows[e.RowIndex];
                txtOIorderid.Text = row.Cells[0].Value.ToString();
                cmbOIbloodtype.SelectedItem = row.Cells[1].Value.ToString();
                txtOIbloodamount.Text = row.Cells[2].Value.ToString();
                txtOIdateoforder.Text = row.Cells[3].Value.ToString();
                cmbOIhospital.SelectedItem = row.Cells[4].Value.ToString();
                cmbOIbloodbank.SelectedItem = row.Cells[5].Value.ToString();
            }
        }

        private void btnMsummary_Click(object sender, EventArgs e)
        {
            interChangePanel();
            this.panCra.Show();
        }

        private void btnIupdate_Click(object sender, EventArgs e)
        {
            Donor don = new Donor();
            don.donorId = donorID;
            don.firstName = txtIfirstname.Text;
            don.lastName = txtIfathername.Text;
            don.gender = char.Parse(cmbIgender.Text);
            don.age = int.Parse(txtIage.Text);
            don.address = txtIaddress.Text;
            don.phoneNumber = cmbIpre.Text + txtIphone.Text;
            don.qty = decimal.Parse(txtIamount.Text);
            don.fkBloodId = cmbIbloodtype.Text;
            int status=don.updateDonor();
            if (status > 0)
            {
                clear_donor_update_panal();
                interChangePanel();
                panMdonerlist.Show();
                MessageBox.Show("succesfully Updated!"); 
            }
            else
                MessageBox.Show("Not successfully updated!");
        }

        public void clear_donor_update_panal()
        {
            txtIaddress.Text = null;
            txtIage.Text = null;
            txtIamount.Text= null;
            txtIfathername.Text = null;
            txtIfirstname.Text = null;
            txtIphone.Text = null;
            cmbIbloodtype.Text = null;
            cmbIgender.Text = null;
        }
        private void btnIdelete_Click(object sender, EventArgs e)
        {
            Donor don = new Donor();
            don.donorId = donorID;
            int status=don.deleteDonor();
            if (status > 0)
            {
                clear_donor_update_panal();
                MessageBox.Show("Sucessfully Deleted");
                interChangePanel();
                panMdonerlist.Show();
            }
            else
                MessageBox.Show("Not deleted");
        }

        private void btnOIupdate_Click(object sender, EventArgs e)
        {
            Orders or = new Orders();
            or.id =int.Parse(txtOIorderid.Text);
            or.bloodType = cmbOIbloodtype.Text;
            int status=or.updateOrders();
            if (status > 0)
            {
                MessageBox.Show("Successfully Update");
                interChangePanel();
                panOorderlist.Show();
            }
            else
                MessageBox.Show("Not Updated");
        }

        private void gunaImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.ClientSize = new System.Drawing.Size(1366, 738);
            this.Location = new System.Drawing.Point(0, 0);
            this.Show();
        }

        private void txtOLsearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnOLsearch_Click(sender,e);
        }

        private void txtDLsearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnDLsearch_Click(sender, e);
        }

        private void txtDphoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("please enter only numbers");
            }
        }

        private void txtDage_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtDphoneNumber_KeyPress(sender, e);
        }

        private void txtDamountOfBlood_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtDphoneNumber_KeyPress(sender, e);
        }

        private void btnCrystaldonor_Click(object sender, EventArgs e)
        {
            var Creport = new CrystalReport1();
            crystalReportViewer.ReportSource = null;
            crystalReportViewer.ReportSource = Creport;
        }

        private void btnCrystalorder_Click(object sender, EventArgs e)
        {
            var Creport = new CrystalReport2();
            crystalReportViewer.ReportSource = null;
            crystalReportViewer.ReportSource = Creport;
        }


        private void btnOIdelete_Click(object sender, EventArgs e)
        {
            Orders or=new Orders();
            or.id = int.Parse(txtOIorderid.Text);
            int status =or.deleteOrders();
            if (status > 0)
            {
                MessageBox.Show("Successfully Deleted");
                interChangePanel();
                panOorderlist.Show();
            }
            else
                MessageBox.Show("Not deleted");

        }
    }
}
