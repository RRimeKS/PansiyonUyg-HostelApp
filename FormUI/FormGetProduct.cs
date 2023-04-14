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
    public partial class FormGetProduct : Form
    {
        public FormGetProduct()
        {
            InitializeComponent();
        }
        void GetList()
        {
            DB db = new DB();
            string query = "Select * from stocks";
            var reader = new DB().Select(query);
            listView1.Items.Clear();
                while (reader.Read())
                {
                    ListViewItem add = new ListViewItem();
                    add.Text = reader["StockId"].ToString();
                    add.SubItems.Add(reader["ProductName"].ToString());
                    add.SubItems.Add(reader["ProductPrice"].ToString());
                    add.SubItems.Add(reader["ProductStock"].ToString());
                    add.SubItems.Add(reader["ProductCategory"].ToString());
                    listView1.Items.Add(add);
                }
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            GetList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DB dB = new DB();
            dB.Delete("Delete from stocks where ProductName='"+txtProductName.Text+"'");
            GetList();
            MessageBox.Show("Ürün silindi.");
        }
        int id =0;
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DB dB = new DB();
            string query = "Update stocks set ProductName='"+ txtProductName.Text + "', ProductPrice='"+ txtProductPrice.Text + "', ProductStock='"+ txtProductStock.Text + "', ProductCategory='"+ cmbCategory.Text + "' where StockId=" + id + "";
            dB.Update(query);
            GetList();
            MessageBox.Show("Ürün güncellendi.");
            
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtProductName.Text = "";
            txtProductPrice.Text = "";
            txtProductStock.Text = "";
            cmbCategory.Text = "";
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtProductName.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtProductPrice.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txtProductStock.Text = listView1.SelectedItems[0].SubItems[3].Text;
            cmbCategory.Text = listView1.SelectedItems[0].SubItems[4].Text;
        }
    }
}
