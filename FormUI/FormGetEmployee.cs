using FormUI.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class FormGetEmployee : Form
    {
        public FormGetEmployee()
        {
            InitializeComponent();
        }
        void GetList()
        {
            listView1.Items.Clear();

            string query = "Select * from Employees";
            DB dB = new DB();
            var reader = new DB().Select(query);
            while (reader.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = reader["EmployeeId"].ToString();
                add.SubItems.Add(reader["EmployeeFirstName"].ToString());
                add.SubItems.Add(reader["EmployeeLastName"].ToString());
                add.SubItems.Add(reader["EmployeeGender"].ToString());
                add.SubItems.Add(reader["EmployeeTc"].ToString());
                add.SubItems.Add(reader["EmployeePhoneNumber"].ToString());
                add.SubItems.Add(reader["EmployeMail"].ToString());
                add.SubItems.Add(reader["EmployeePrice"].ToString());
                add.SubItems.Add(reader["EmployeeDateOfEntry"].ToString());
                listView1.Items.Add(add);

            }
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            GetList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DB dB = new DB();
            dB.Delete("Delete from Employees where EmployeeFirstName = '" + txtName.Text + "'");
            GetList();
            MessageBox.Show("Çalışan silindi.");
        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtName.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtLastName.Text = listView1.SelectedItems[0].SubItems[2].Text;
            cmbBoxGender.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtTc.Text = listView1.SelectedItems[0].SubItems[4].Text;
            mskPhone.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txtMail.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txtPrice.Text = listView1.SelectedItems[0].SubItems[7].Text;
            dtpDateOfEntry.Text = listView1.SelectedItems[0].SubItems[8].Text;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "Update Employees set EmployeeFirstName='" + txtName.Text + "', EmployeeLastName='" + txtLastName.Text + "', EmployeeGender='" + cmbBoxGender.Text + "', EmployeeTc='" + txtTc.Text + "', EmployeePhoneNumber='" + Convert.ToString(mskPhone.Text) + "', EmployeMail='" + txtMail.Text + "', EmployeePrice='" + Convert.ToDecimal(txtPrice.Text) + "', EmployeeDateOfEntry='" + dtpDateOfEntry.Value + "' where EmployeeId=" + id + "";
            DB dB = new DB();
            dB.Update(query);
            GetList();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtLastName.Text = "";
            cmbBoxGender.Text = "";
            txtTc.Text = "";
            mskPhone.Text = "";
            txtMail.Text = "";
            txtPrice.Text = "";
            dtpDateOfEntry.Text = "";
        }
    }
}
