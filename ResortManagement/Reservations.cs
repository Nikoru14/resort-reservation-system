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
    public partial class Reservations : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nicholo\source\repos\HotelManagement\Database\HotelDb.mdf;Integrated Security=True;Connect Timeout=30");
        DateTime today;

        public Reservations()
        {
            InitializeComponent();
        }
        private void Populate()
        {
            con.Open();
            string query = "select * from tbl_reservations";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgvReservation.DataSource = ds.Tables[0];
            con.Close();
        }
        public void UpdateCottageStatus()
        {
            List<string> cottageNums = new List<string>();
            List<string> dateTimeIns = new List<string>();
            List<DateTime> dateTimeOuts = new List<DateTime>();
            con.Open();
            string query = "SELECT CottageNum, DateIn, DateOut FROM tbl_reservations;";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader sdr = command.ExecuteReader();
            
            while (sdr.Read())
            {
                cottageNums.Add(sdr.GetString(0));
                dateTimeIns.Add(sdr.GetString(1));
                dateTimeOuts.Add(DateTime.Parse(sdr.GetString(2)));
            }
            con.Close();
            for (int i = 0; i < 8; i++)
            {
                switch (i) 
                {
                    case 1:
                        for(int j = 0; j < cottageNums.Count; j++)
                        {
                            con.Open();
                            if (cottageNums[j] == "1" && dateTimeIns[j] == DateTime.Now.ToString("d"))
                            {
                                 
                                string state = "Unavailable";
                                query = "UPDATE tbl_cottages set cottageState = '" + state + "' where cottageId = " + 1 + ";";
                            }
                            else if(cottageNums[j] =="1" && dateTimeOuts[j] <= DateTime.Now)
                            {
                                string state = "Available";
                                query = "UPDATE tbl_cottages set cottageState = '" + state + "' where cottageId = " + 1 + ";";

                            }
                            SqlCommand command1 = new SqlCommand(query, con);
                            command1.ExecuteNonQuery();
                            con.Close();
                        }

                       break;
                    case 2:
                        for (int j = 0; j < cottageNums.Count; j++)
                        {
                            con.Open();
                            if (cottageNums[j] == "2" && dateTimeIns[j] == DateTime.Now.ToString("d"))
                            {

                                string state = "Unavailable";
                                query = "UPDATE tbl_cottages set cottageState = '" + state + "' where cottageId = " + 2 + ";";
                            }
                            else if(cottageNums[j] =="2" && dateTimeOuts[j] <= DateTime.Now)
                            {
                                string state = "Available";
                                query = "UPDATE tbl_cottages set cottageState = '" + state + "' where cottageId = " + 2 + ";";

                            }
                            SqlCommand command1 = new SqlCommand(query, con);
                            command1.ExecuteNonQuery();
                            con.Close();
                        }
                        break;
                    case 3:
                        for (int j = 0; j < cottageNums.Count; j++)
                        {
                            con.Open();
                            if (cottageNums[j] == "3" && dateTimeIns[j] == DateTime.Now.ToString("d"))
                            {

                                string state = "Unavailable";
                                query = "UPDATE tbl_cottages set cottageState = '" + state + "' where cottageId = " + 3 + ";";
                            }
                            else if(cottageNums[j] =="3" && dateTimeOuts[j] <= DateTime.Now)
                            {
                                string state = "Available";
                                query = "UPDATE tbl_cottages set cottageState = '" + state + "' where cottageId = " + 3 + ";";

                            }
                            SqlCommand command1 = new SqlCommand(query, con);
                            command1.ExecuteNonQuery();
                            con.Close();
                        }
                        break;
                    case 4:
                        for (int j = 0; j < cottageNums.Count; j++)
                        {
                            con.Open();
                            if (cottageNums[j] == "4" && dateTimeIns[j] == DateTime.Now.ToString("d"))
                            {

                                string state = "Unavailable";
                                query = "UPDATE tbl_cottages set cottageState = '" + state + "' where cottageId = " + 4 + ";";
                            }
                            else if (cottageNums[j] == "4" && dateTimeOuts[j] <= DateTime.Now)
                            {
                                string state = "Available";
                                query = "UPDATE tbl_cottages set cottageState = '" + state + "' where cottageId = " + 4 + ";";

                            }
                            SqlCommand command1 = new SqlCommand(query, con);
                            command1.ExecuteNonQuery();
                            con.Close();
                        }
                        break;
                    case 5:
                        for (int j = 0; j < cottageNums.Count; j++)
                        {
                            con.Open();
                            if (cottageNums[j] == "5" && dateTimeIns[j] == DateTime.Now.ToString("d"))
                            {

                                string state = "Unavailable";
                                query = "UPDATE tbl_cottages set cottageState = '" + state + "' where cottageId = " + 5 + ";";
                            }
                            else if (cottageNums[j] == "5" && dateTimeOuts[j] <= DateTime.Now)
                            {
                                string state = "Available";
                                query = "UPDATE tbl_cottages set cottageState = '" + state + "' where cottageId = " + 5 + ";";

                            }
                            SqlCommand command1 = new SqlCommand(query, con);
                            command1.ExecuteNonQuery();
                            con.Close();
                        }
                            break;
                    case 6:
                        for (int j = 0; j < cottageNums.Count; j++)
                        {
                            con.Open();
                            if (cottageNums[j] == "6" && dateTimeIns[j] == DateTime.Now.ToString("d"))
                            {

                                string state = "Unavailable";
                                query = "UPDATE tbl_cottages set cottageState = '" + state + "' where cottageId = " + 6 + ";";
                            }
                            else if (cottageNums[j] == "6" && dateTimeOuts[j] <= DateTime.Now)
                            {
                                string state = "Available";
                                query = "UPDATE tbl_cottages set cottageState = '" + state + "' where cottageId = " + 6 + ";";

                            }
                            SqlCommand command1 = new SqlCommand(query, con);
                            command1.ExecuteNonQuery();
                            con.Close();
                        }
                        break;
                    case 7:
                        for (int j = 0; j < cottageNums.Count; j++)
                        {
                            con.Open();
                            if (cottageNums[j] == "7" && dateTimeIns[j] == DateTime.Now.ToString("d"))
                            {

                                string state = "Unavailable";
                                query = "UPDATE tbl_cottages set cottageState = '" + state + "' where cottageId = " + 7 + ";";
                            }
                            else if(cottageNums[j] =="7" && dateTimeOuts[j] <= DateTime.Now)
                            {
                                string state = "Available";
                                query = "UPDATE tbl_cottages set cottageState = '" + state + "' where cottageId = " + 7 + ";";

                            }
                            SqlCommand command1 = new SqlCommand(query, con);
                            command1.ExecuteNonQuery();
                            con.Close();
                        }
                        break;
                }
            }

        }
        private void DeleteCottageRes()
        {
            con.Open();
            int cottageId = Convert.ToInt32(dgvReservation.SelectedRows[0].Cells[2].Value.ToString());
            string state = "Available";
            string query = "UPDATE tbl_cottages set cottageState = '" + state + "' where cottageId = " + cottageId + ";";
            SqlCommand command = new SqlCommand(query, con);
            command.ExecuteNonQuery();
            con.Close();
        }

        private void CalculatePrice()
        {
            int cottagePrice, childRate, adultRate, totalPrice;
            int noOfDays = -Convert.ToInt32((dpDateIn.Value - dpDateOut.Value).TotalDays);
            cottagePrice = 250;
            int res = DateTime.Compare(dpDateIn.Value, dpDateOut.Value);
            if (res == 0)
            {
                childRate = Convert.ToInt32(numChild.Value) * 30;
                adultRate = Convert.ToInt32(numAdult.Value) * 60;
            }
            else
            {
                childRate = (Convert.ToInt32(numChild.Value) * 60) * noOfDays;
                //childRate = ((Convert.ToInt32(numChild.Value) * 60) * noOfDays) + ((Convert.ToInt32(numChild.Value) * 30) * (noOfDays - 1));
                adultRate = (Convert.ToInt32(numAdult.Value) * 120) * noOfDays;
                //adultRate = ((Convert.ToInt32(numAdult.Value) * 120) * noOfDays) + ((Convert.ToInt32(numChild.Value) * 60)* (noOfDays - 1));
                if (cbxCottages.SelectedValue.ToString() == "6" || cbxCottages.SelectedValue.ToString() == "7")
                {
                    cottagePrice = 450;
                }
                
            }
            totalPrice = cottagePrice + childRate + adultRate;

            txtbxPrice.Text = Convert.ToString(totalPrice);
        }
        public void FillComboCottage()
        {
            con.Open();
            SqlCommand command = new SqlCommand("select cottageId from tbl_cottages", con);
            SqlDataReader sdr = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("cottageId", typeof(int));
            dt.Load(sdr);
            cbxCottages.ValueMember = "cottageId";
            cbxCottages.DataSource = dt;
            con.Close();
        } 
        public void FillComboClient()
        {
            con.Open();
            SqlCommand command = new SqlCommand("select ClientName from tbl_clients", con);
            SqlDataReader sdr = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ClientNane", typeof(string));
            dt.Load(sdr);
            cbxClientNames.ValueMember = "ClientName";
            cbxClientNames.DataSource = dt;
            con.Close();
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            string user = Dashboard.user;
            Dashboard dashboard = new Dashboard();
            dashboard.SetUserLabel(user);
            dashboard.Show();
            this.Hide();
        }

        private void Reservations_Load(object sender, EventArgs e)
        {
            today = DateTime.Now;
            dpDateIn.Value = today;
            dpDateOut.Value = today;
            timer1.Start();
            lblDateTime.Text = DateTime.Now.ToString("f");
            FillComboCottage();
            FillComboClient();
            Populate();
            UpdateCottageStatus();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("f");
            CalculatePrice();
        }

        private void dpDateIn_onValueChanged(object sender, EventArgs e)
        {
            int res = DateTime.Compare(dpDateIn.Value, today);
            if (res < 0)
            {
                MessageBox.Show("Wrong date of reservation");
            }
        }

        private void dpDateOut_onValueChanged(object sender, EventArgs e)
        {
            int res = DateTime.Compare(dpDateOut.Value, dpDateIn.Value);
            if (res < 0)
            {
                MessageBox.Show("Wrong date out, please check");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("insert into tbl_reservations values('" + txtbxResId.Text + "','" + cbxClientNames.SelectedValue.ToString() + "','" + cbxCottages.SelectedValue.ToString() + "','" + numAdult.Value.ToString() + "','" + numChild.Value.ToString() + "','" + dpDateIn.Value.ToString("d") + "','" + dpDateOut.Value.ToString("d") + "','" + txtbxPrice.Text + "')", con);
                command.ExecuteNonQuery();
                MessageBox.Show("Reservation Successfully Added!");
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
                if (txtbxResId.Text == "")
                {
                    MessageBox.Show("Please check reservation ID!");
                }
                else 
                {
                    con.Open();
                    string query = "delete from tbl_reservations where ResId = '" + txtbxResId.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Reservation Succesfully Deleted!");
                    con.Close();
                    DeleteCottageRes();
                    Populate();
                }
            }
            catch
            {
                MessageBox.Show("Opsss... Something went wrong! \nPlease double check the fields!");
            }
        }

        private void dgvReservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbxResId.Text = dgvReservation.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from tbl_reservations where ResId = '" + txtbxSearch.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgvReservation.DataSource = ds.Tables[0];
            con.Close();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Populate();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "UPDATE tbl_reservations set ClientName ='" + cbxClientNames.SelectedValue.ToString() + "', CottageNum ='" + cbxCottages.SelectedValue.ToString() + "', Adult ='" + numAdult.Value.ToString() + "', Children ='" + numChild.Value.ToString() + "', DateIn ='" + dpDateIn.Value.ToString("d") + "', DateOut ='" + dpDateOut.Value.ToString("d") + "', Price ='" + txtbxPrice.Text + "' where ResId = " + Convert.ToInt32(txtbxResId.Text) + ";";
                SqlCommand command = new SqlCommand(query, con);
                command.ExecuteNonQuery();
                MessageBox.Show("Reservation Successfully Edited!");
                con.Close();
                DeleteCottageRes();
                UpdateCottageStatus();
                Populate();
            }
            catch
            {
                MessageBox.Show("Opsss... Something went wrong! \nPlease double check the fields!");
            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
