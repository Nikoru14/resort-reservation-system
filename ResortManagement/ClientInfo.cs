using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ResortManagement
{
    public partial class ClientInfo : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nicholo\source\repos\HotelManagement\Database\HotelDb.mdf;Integrated Security=True;Connect Timeout=30");
     
        private void Populate() 
        {
            con.Open();
            string query = "select * from tbl_clients";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgvClientInfo.DataSource = ds.Tables[0];
            con.Close();
        }

        public ClientInfo()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("f");
        }

        private void ClientInfo_Load(object sender, EventArgs e)
        {
            Populate();
            lblDateTime.Text = DateTime.Now.ToString("f");
            timer1.Start();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            string user = Dashboard.user;
            Dashboard dashboard = new Dashboard();
            dashboard.SetUserLabel(user);
            dashboard.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbxClientId.Text == "" || txtbxName.Text == "" || txtbxPhone.Text == "")
                {
                    MessageBox.Show("Please fill out the necessary fields!");
                }
                else
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("insert into tbl_clients values('" + txtbxClientId.Text + "','" + txtbxName.Text + "','" + txtbxPhone.Text + "','" + txtbxAddress.Text + "')", con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Client Successfully Added!");
                    con.Close();
                    Populate();
                }
            }
            catch
            {
                MessageBox.Show("Opsss... Something went wrong! \nPlease double check the fields!");
            }
        }

        private void dgvClientInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbxClientId.Text = dgvClientInfo.SelectedRows[0].Cells[0].Value.ToString();
            txtbxName.Text = dgvClientInfo.SelectedRows[0].Cells[1].Value.ToString();
            txtbxPhone.Text = dgvClientInfo.SelectedRows[0].Cells[2].Value.ToString();
            txtbxAddress.Text = dgvClientInfo.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "UPDATE tbl_clients set ClientName ='" + txtbxName.Text + "', ClientPhone ='" + txtbxPhone.Text + "', ClientAddress ='" + txtbxAddress.Text + "' where ClientId = " + Convert.ToInt32(txtbxClientId.Text) + ";";
                SqlCommand command = new SqlCommand(query, con);
                command.ExecuteNonQuery();
                MessageBox.Show("Client Successfully Edited!");
                con.Close();
                Populate();
            }
            catch
            {
                MessageBox.Show("Opsss... Something went wrong! \nPlease double check the fields!");
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "delete from tbl_clients where ClientId = '" + txtbxClientId.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Client Succesfully Deleted!");
                con.Close();
                Populate();
            }
            catch
            {
                MessageBox.Show("Opsss... Something went wrong! \nPlease double check the fields!");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from tbl_clients where ClientName = '"+txtbxSearch.Text+"' ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgvClientInfo.DataSource = ds.Tables[0];
            con.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Populate();
            txtbxClientId.Text = null;
            txtbxName.Text = null;
            txtbxPhone.Text = null;
            txtbxAddress.Text = null;
        }
    }
}
