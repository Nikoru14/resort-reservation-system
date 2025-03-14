using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResortManagement
{
    public partial class Dashboard : Form
    {
        public static string user;
        public Dashboard()
        {
            InitializeComponent();
        }

        public void SetUserLabel(string user)
        {
            lblUser.Text = user;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("F");
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
            timer1.Stop();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            if (lblUser.Text == "Admin")
            {
                btnStaff.Visible = true;
                lblAccess.Visible = false;
                pbxStaff.Visible = false;
                user = "Admin";
            }
            else if (lblUser.Text == "Employee")
            {
                btnStaff.Visible = false;
                lblAccess.Visible = true;
                pbxStaff.Visible = true;
                user = "Employee";

            }

            lblUser.Text = user;
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            ClientInfo clientInfo = new ClientInfo();
            clientInfo.Show();
            this.Hide();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            StaffInfo staffInfo = new StaffInfo();
            staffInfo.Show();
            this.Hide();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            Cottages cottages = new Cottages();
            cottages.Show();
            this.Hide();
        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
            Reservations reservations = new Reservations();
            reservations.Show();
            this.Hide();
        }
    }
}
