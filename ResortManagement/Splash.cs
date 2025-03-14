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
    public partial class Splash : Form
    {
        int loadProgress = 0;
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loadProgress += 2;
            prgBSplash.Value = loadProgress;
            if (prgBSplash.Value == 100)
            {
                loadProgress = 0;
                timer1.Stop();
                Login login = new Login();
                login.Show();
                this.Hide();
            }

        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
