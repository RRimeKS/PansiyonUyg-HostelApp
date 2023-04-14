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
    public partial class FormAddProduct : Form
    {
        public FormAddProduct()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DB dB = new DB();
            string query = "Insert into stocks (ProductName, ProductPrice, ProductStock, ProductCategory) values ('" + txtProductName.Text + "','" + Convert.ToDecimal(txtProductPrice.Text) + "', '" + txtProductStock.Text + "','" + cmbProductCategory.Text + "')";
            dB.Execute(query);
            MessageBox.Show("Ürün kaydı yapıldı");
            txtProductName.Text = "";
            txtProductPrice.Text = "";
            txtProductStock.Text = "";
            cmbProductCategory.Text = "";
        }
    }
}
