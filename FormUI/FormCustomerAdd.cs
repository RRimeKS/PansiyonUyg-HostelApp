using FormUI.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class FormCustomerAdd : Form
    {
        public FormCustomerAdd()
        {
            InitializeComponent();
        }
        string connectionString = "****************************************************************************";
        private void btnSave_Click(object sender, EventArgs e)
        {
            DB con = new DB();
            string query = "Insert into Customers (CustomerName, CustomerLastName, CustomerGender, CustomerTc, CustomerPhoneNumber, CustomerMail ,CustomerRoomNumber, CustomerRoomPrice, CustomerDoE, CustomerDoO) Values " +
            "( '" + txtFirstName.Text + "', '" + txtLastName.Text + "', '" + cmbBoxCinsiyet.Text + "','" + txtTc.Text + "', '" + mskPhoneNumber.Text + "', '" + txtMail.Text + "', '" + txtRoomNumber.Text + "', '" + Convert.ToDecimal(txtPrice.Text) + "', '" + dtpDateOfEntry.Value + "', '" + dtpDateOfOut.Value + "')";
            con.Execute(query);
            string query2 = "Insert into Rooms (CustomerName, CustomerLastName, RoomNumber) values ('" + txtFirstName.Text + "','" + txtLastName.Text + "','" + txtRoomNumber.Text + "')";
            con.Execute(query2);
            MessageBox.Show("Müşteri kaydı yapıldı");
        }

        private void btn101_Click(object sender, EventArgs e)
        {
            txtRoomNumber.Text = "101";
        }

        private void btn102_Click(object sender, EventArgs e)
        {
            txtRoomNumber.Text = "102";
        }

        private void btn103_Click(object sender, EventArgs e)
        {
            txtRoomNumber.Text = "103";
        }

        private void btn104_Click(object sender, EventArgs e)
        {
            txtRoomNumber.Text = "104";
        }

        private void btn105_Click(object sender, EventArgs e)
        {
            txtRoomNumber.Text = "105";
        }

        private void btn106_Click(object sender, EventArgs e)
        {
            txtRoomNumber.Text = "106";
        }

        private void btn201_Click(object sender, EventArgs e)
        {
            txtRoomNumber.Text = "201";
        }

        private void btn202_Click(object sender, EventArgs e)
        {
            txtRoomNumber.Text = "202";
        }

        private void btn203_Click(object sender, EventArgs e)
        {
            txtRoomNumber.Text = "203";
        }

        private void FormCustomerAdd_Load(object sender, EventArgs e)
        {
            string query = "Select * from Rooms";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if ((reader["RoomNumber"].ToString()) == "101")
                    {
                        btn101.Text = reader["CustomerName"].ToString() + " " + reader["CustomerLastName"].ToString();
                        btn101.BackColor = Color.Red;
                        btn101.Enabled = false;
                    }
                }
                con.Close();
            }
            //Button102
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["RoomNumber"].ToString() == "102")
                    {
                        btn102.Text = reader["CustomerName"].ToString() + " " + reader["CustomerLastName"].ToString();
                        btn102.BackColor = Color.Red;
                        btn102.Enabled = false;
                    }

                }
                con.Close();
            }
            //Button103
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["RoomNumber"].ToString() == "103")
                    {
                        btn103.Text = reader["CustomerName"].ToString() + " " + reader["CustomerLastName"].ToString();
                        btn103.BackColor = Color.Red;
                        btn103.Enabled = false;
                    }
                }
                con.Close();
            }
            //Button104
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["RoomNumber"].ToString() == "104")
                    {
                        btn104.Text = reader["CustomerName"].ToString() + " " + reader["CustomerLastName"].ToString();
                        btn104.BackColor = Color.Red;
                        btn104.Enabled = false;
                    }
                }

                con.Close();
            }
            //Button105
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["RoomNumber"].ToString() == "105")
                    {
                        btn105.Text = reader["CustomerName"].ToString() + " " + reader["CustomerLastName"].ToString();
                        btn105.BackColor = Color.Red;
                        btn105.Enabled = false;
                    }
                }
                con.Close();
            }
            //Button106
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["RoomNumber"].ToString() == "106")
                    {
                        btn106.Text = reader["CustomerName"].ToString() + " " + reader["CustomerLastName"].ToString();
                        btn106.BackColor = Color.Red;
                        btn106.Enabled = false;
                    }
                }
                con.Close();
            }
            //Button201
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["RoomNumber"].ToString() == "201")
                    {
                        btn201.Text = reader["CustomerName"].ToString() + " " + reader["CustomerLastName"].ToString();
                        btn201.BackColor = Color.Red;
                        btn201.Enabled = false;
                    }
                }
                con.Close();
            }
            //Button202
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["RoomNumber"].ToString() == "202")
                    {
                        btn202.Text = reader["CustomerName"].ToString() + " " + reader["CustomerLastName"].ToString();
                        btn202.BackColor = Color.Red;
                        btn202.Enabled = false;
                    }
                }
                con.Close();
            }
            //Button203
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["RoomNumber"].ToString() == "203")
                    {
                        btn203.Text = reader["CustomerName"].ToString() + " " + reader["CustomerLastName"].ToString();
                        btn203.BackColor = Color.Red;
                        btn203.Enabled = false;
                    }
                }
                con.Close();
            }

        }
        private void dtpDateOfOut_ValueChanged(object sender, EventArgs e)
        {
            DateTime entry = Convert.ToDateTime(dtpDateOfEntry.Text);
            DateTime outt = Convert.ToDateTime(dtpDateOfOut.Text);
            TimeSpan diff = outt - entry;

            label12.Text = diff.TotalDays.ToString();
            double price = Convert.ToDouble(label12.Text) * 500;
            txtPrice.Text = price.ToString();
        }
    }
}
