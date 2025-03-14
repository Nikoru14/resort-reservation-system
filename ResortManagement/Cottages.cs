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
    public partial class Cottages : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nicholo\source\repos\HotelManagement\Database\HotelDb.mdf;Integrated Security=True;Connect Timeout=30");
        Reservations reservation = new Reservations();

        public Cottages()
        {
            InitializeComponent();
        }
        public void CheckCottageState()
        {
            con.Open();
            string[] cottages = new string[7];
            PictureBox[] boxes = {pbxCottage01, pbxCottage02, pbxCottage03, pbxCottage04, pbxCottage05, pbxCottage06, pbxCottage07};
            string query = "SELECT cottageState FROM tbl_cottages;";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader sdr = command.ExecuteReader();
            int i = 0;
            while (sdr.Read())
            {
                cottages[i] = sdr.GetString(0);
                i++;
            }
            con.Close();
            for (int index = 0; index < boxes.Length; index++)
            {
                if (cottages[index] == "Available")
                {
                    boxes[index].BackColor = Color.FromArgb(0, 184, 148);
                }
                else
                {
                    boxes[index].BackColor = Color.Red;
                }
            }
        }

        private void Cottages_Load(object sender, EventArgs e)
        {
            reservation.UpdateCottageStatus();
            CheckCottageState();
            timer1.Start();
            lblDateTime.Text = DateTime.Now.ToString("f");
            
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("f");

        }

        private void btnReturn_Click_1(object sender, EventArgs e)
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
    }
}
