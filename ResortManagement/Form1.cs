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
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nicholo\source\repos\HotelManagement\Database\HotelDb.mdf;Integrated Security=True;Connect Timeout=30");
        
        public Login()
        {
            InitializeComponent();
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void txtbxPassword_TextChanged(object sender, EventArgs e)
        {
            txtbxPassword.UseSystemPasswordChar = true;
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Role from tbl_staff where StaffUsername='"+txtbxUsername.Text+"' and StaffPassword='"+txtbxPassword.Text+"' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                
                Dashboard dashboard = new Dashboard();
                dashboard.SetUserLabel(dt.Rows[0][0].ToString());
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }
            con.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtbxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                gunaGradientButton1.PerformClick();
            }
        }
    }
}
