using FormUI.Concrete;
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
    public partial class FormGetCustomer : Form
    {
        public FormGetCustomer()
        {
            InitializeComponent();
        }
        void GetList()
        {
            var reader = new DB().Select("Select * from Customers");
            listView1.Items.Clear();
            while (reader.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = reader["CustomerId"].ToString();
                add.SubItems.Add(reader["CustomerName"].ToString());
                add.SubItems.Add(reader["CustomerLastName"].ToString());
                add.SubItems.Add(reader["CustomerGender"].ToString());
                add.SubItems.Add(reader["CustomerTc"].ToString());
                add.SubItems.Add(reader["CustomerPhoneNumber"].ToString());
                add.SubItems.Add(reader["CustomerMail"].ToString());
                add.SubItems.Add(reader["CustomerRoomNumber"].ToString());
                add.SubItems.Add(reader["CustomerRoomPrice"].ToString());
                add.SubItems.Add(reader["CustomerDoE"].ToString());
                add.SubItems.Add(reader["CustomerDoO"].ToString());
                listView1.Items.Add(add);
            }
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            GetList();
        }
        int id = 0;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "Update Customers set CustomerName='"+txtName.Text+ "', CustomerLastName='"+txtLastName.Text+ "', CustomerGender='"+cmbBoxGender.Text+ "', CustomerTc='"+txtTc.Text+ "', CustomerPhoneNumber='"+mskPhoneNumber.Text+ "', CustomerMail='"+txtMail.Text+ "', CustomerRoomNumber='"+txtRoomNo.Text+ "', CustomerRoomPrice='"+txtRoomNo.Text+ "', CustomerDoE='"+dtpDoE.Text+ "', CustomerDoO='"+dtpDoO.Text+"' Where CustomerId=" + id + "";
            DB dB = new DB();
            dB.Update(query);
            MessageBox.Show("Müşteri Güncellendi");
            GetList();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtName.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtLastName.Text = listView1.SelectedItems[0].SubItems[2].Text;
            cmbBoxGender.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtTc.Text = listView1.SelectedItems[0].SubItems[4].Text;
            mskPhoneNumber.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txtMail.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txtRoomNo.Text = listView1.SelectedItems[0].SubItems[7].Text;
            txtPrice.Text = listView1.SelectedItems[0].SubItems[8].Text;
            dtpDoE.Text = listView1.SelectedItems[0].SubItems[9].Text;
            dtpDoO.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtLastName.Text = "";
            cmbBoxGender.Text = "";
            txtTc.Text = "";
            mskPhoneNumber.Text = "";
            txtMail.Text = "";
            txtRoomNo.Text = "";
            txtPrice.Text = "";
            dtpDoE.Text = "";
            dtpDoO.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DB dB = new DB();
            dB.Delete("delete from Customers where CustomerName='" + txtName.Text + "'");
            dB.Delete("delete from Rooms where RoomNumber='" + txtRoomNo.Text + "'");
            GetList();
        }
    }
}
