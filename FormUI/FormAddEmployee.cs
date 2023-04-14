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
    public partial class FormAddEmployee : Form
    {
        public FormAddEmployee()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string query = "Insert into Employees (EmployeeFirstName, EmployeeLastName, EmployeeGender, EmployeeTc, EmployeePhoneNumber, EmployeMail, EmployeePrice, EmployeeDateOfEntry) values " +
            "('"+ txtName.Text + "', '"+ txtLastName.Text + "', '"+ cmbBoxGender.Text + "', '"+ txtTc.Text + "', '"+ mskPhone.Text + "', '"+ txtMail.Text + "', '"+ txtPrice.Text + "', '"+ dtpDateOfEntry.Value + "')";
            DB dB = new DB();
            dB.Execute(query);
            MessageBox.Show("Çalışan kaydı yapıldı");
        }
    }
}
