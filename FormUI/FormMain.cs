using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormCustomerAdd frm = new FormCustomerAdd();
            frm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnListCustomer_Click(object sender, EventArgs e)
        {
            FormGetCustomer frm = new FormGetCustomer();
            frm.Show();
        }

        private void btnListRooms_Click(object sender, EventArgs e)
        {
            FormRooms frm = new FormRooms();
            frm.Show();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            FormAddEmployee formAddEmployee = new FormAddEmployee();
            formAddEmployee.Show();
        }

        private void btnListEmployee_Click(object sender, EventArgs e)
        {
            FormGetEmployee frm = new FormGetEmployee();
            frm.Show();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            FormAddProduct frm = new FormAddProduct();
            frm.Show();
        }

        private void btnListProduct_Click(object sender, EventArgs e)
        {
            FormGetProduct frm = new FormGetProduct();
            frm.Show();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            FormBill frm = new FormBill();
            frm.Show();
        }
    }
}
