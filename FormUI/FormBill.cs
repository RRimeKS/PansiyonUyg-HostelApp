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
    public partial class FormBill : Form
    {
        public FormBill()
        {
            InitializeComponent();
        }
        void GetList()
        {
            DB dB = new DB();
            string query = "Select * from Bills";
            var reader = new DB().Select(query);
            while (reader.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = reader["BillId"].ToString();
                add.SubItems.Add(reader["BillCategory"].ToString());
                add.SubItems.Add(reader["BillPrice"].ToString());
                add.SubItems.Add(reader["BillArrivalDate"].ToString());
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
            string query = "Delete from Bills where BillCategory='"+ cmbBill.Text + "'";
            dB.Delete(query);
            GetList();
            MessageBox.Show("Fatura silindi.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DB dB = new DB();
            string query = "Update Bills set BillCategory='" + cmbBill.Text + "' BillPrice='"+ txtPrice.Text+"', BillArrivalDate='"+dtpDateOfEntry.Value +"',";
            dB.Delete(query);
            GetList();
            MessageBox.Show("Fatura Güncellendi.");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbBill.Text = "";
            txtPrice.Text = "";
            dtpDateOfEntry.Text = "";
        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {

        }
    }
}
