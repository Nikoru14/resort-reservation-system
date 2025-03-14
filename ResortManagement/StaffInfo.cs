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
    public partial class StaffInfo : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nicholo\source\repos\HotelManagement\Database\HotelDb.mdf;Integrated Security=True;Connect Timeout=30");
        
        public StaffInfo()
        {
            InitializeComponent();
        }
        private void Populate()
        {
            con.Open();
            string query = "select * from tbl_staff";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgvStaffInfo.DataSource = ds.Tables[0];
            con.Close();
        }
        private void StaffInfo_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblDateTime.Text = DateTime.Now.ToString("f");
            Populate();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            string user = Dashboard.user;
            Dashboard dashboard = new Dashboard();
            dashboard.SetUserLabel(user);
            dashboard.Show();
            this.Hide();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("f");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbxName.Text == "" || txtbxStaffId.Text == "" || txtbxUsername.Text == "" || txtbxPassword.Text == "" || cbxRoles.Text == "")
                {
                    MessageBox.Show("Please fill out the necesssary fields");
                }
                else
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("insert into tbl_staff values('" + txtbxStaffId.Text + "','" + txtbxName.Text + "','" + txtbxUsername.Text + "','" + txtbxPassword.Text + "','" + cbxRoles.SelectedItem.ToString() + "')", con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Staff Successfully Added!");
                    con.Close();
                    Populate();
                }
            }
            catch
            {
                MessageBox.Show("Opsss... Something went wrong! \nPlease double check the fields!");
            }
        }

        private void dgvStaffInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbxStaffId.Text = dgvStaffInfo.SelectedRows[0].Cells[0].Value.ToString();
            txtbxName.Text = dgvStaffInfo.SelectedRows[0].Cells[1].Value.ToString();
            txtbxUsername.Text = dgvStaffInfo.SelectedRows[0].Cells[2].Value.ToString();
            txtbxPassword.Text = dgvStaffInfo.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbxStaffId.Text == "1")
                {
                    MessageBox.Show("Can't delete default Admin account!");
                }
                else
                {
                    con.Open();
                    string query = "delete from tbl_staff where StaffId = '" + txtbxStaffId.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff Succesfully Deleted!");
                    con.Close();
                    Populate();
                }
            }
            catch
            {
                MessageBox.Show("Opsss... Something went wrong! \nPlease double check the fields!");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Populate();
            txtbxStaffId.Text = "";
            txtbxName.Text = "";
            txtbxUsername.Text = "";
            txtbxPassword.Text = "";
            txtbxSearch.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbxStaffId.Text == "1")
                {
                    con.Open();
                    string role = "Admin";
                    string query = "UPDATE tbl_staff set StaffName ='" + txtbxName.Text + "', StaffUsername ='" + txtbxUsername.Text + "', StaffPassword ='" + txtbxPassword.Text + "', Role ='" + role + "' where StaffId = " + txtbxStaffId.Text + ";";
                    SqlCommand command = new SqlCommand(query, con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Default Admin Successfully Edited!");
                    con.Close();
                    Populate();
                }
                else
                {
                    con.Open();
                    string query = "UPDATE tbl_staff set StaffName ='" + txtbxName.Text + "', StaffUsername ='" + txtbxUsername.Text + "', StaffPassword ='" + txtbxPassword.Text + "', Role ='" + cbxRoles.SelectedItem.ToString() + "' where StaffId = " + txtbxStaffId.Text + ";";
                    SqlCommand command = new SqlCommand(query, con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Staff Successfully Edited!");
                    con.Close();
                    Populate();
                }
            }
            catch
            {
                MessageBox.Show("Opsss... Something went wrong! \nPlease double check the fields!");
            }
        }

    

        private void btnSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from tbl_staff where StaffName = '"+txtbxSearch.Text+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgvStaffInfo.DataSource = ds.Tables[0];
            con.Close();
        }
    }
}
