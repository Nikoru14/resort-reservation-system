
namespace ResortManagement
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnStaff = new Bunifu.Framework.UI.BunifuImageButton();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.btnClients = new Bunifu.Framework.UI.BunifuImageButton();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.btnReservations = new Bunifu.Framework.UI.BunifuImageButton();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.btnRooms = new Bunifu.Framework.UI.BunifuImageButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.pbxStaff = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblAccess = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReservations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblAccess);
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Controls.Add(this.bunifuTileButton1);
            this.panel1.Controls.Add(this.lblDateTime);
            this.panel1.Controls.Add(this.btnStaff);
            this.panel1.Controls.Add(this.gunaLabel4);
            this.panel1.Controls.Add(this.btnClients);
            this.panel1.Controls.Add(this.gunaLabel3);
            this.panel1.Controls.Add(this.btnReservations);
            this.panel1.Controls.Add(this.gunaLabel2);
            this.panel1.Controls.Add(this.btnRooms);
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Controls.Add(this.pbxStaff);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1316, 611);
            this.panel1.TabIndex = 0;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Nexa Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.lblUser.Location = new System.Drawing.Point(172, 15);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(90, 39);
            this.lblUser.TabIndex = 12;
            this.lblUser.Text = "User";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Nexa Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.lblWelcome.Location = new System.Drawing.Point(18, 15);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(159, 39);
            this.lblWelcome.TabIndex = 11;
            this.lblWelcome.Text = "Welcome";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.bunifuTileButton1.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.bunifuTileButton1.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Nexa Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton1.Image")));
            this.bunifuTileButton1.ImagePosition = 11;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 43;
            this.bunifuTileButton1.LabelText = "Log Out";
            this.bunifuTileButton1.Location = new System.Drawing.Point(1212, 509);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(8);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(104, 102);
            this.bunifuTileButton1.TabIndex = 10;
            this.bunifuTileButton1.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.Image = ((System.Drawing.Image)(resources.GetObject("btnStaff.Image")));
            this.btnStaff.ImageActive = null;
            this.btnStaff.Location = new System.Drawing.Point(1024, 200);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(270, 169);
            this.btnStaff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnStaff.TabIndex = 8;
            this.btnStaff.TabStop = false;
            this.btnStaff.Visible = false;
            this.btnStaff.Zoom = 10;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Nexa Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.gunaLabel4.Location = new System.Drawing.Point(1111, 372);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(97, 39);
            this.gunaLabel4.TabIndex = 7;
            this.gunaLabel4.Text = "Staff";
            this.gunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClients
            // 
            this.btnClients.Image = ((System.Drawing.Image)(resources.GetObject("btnClients.Image")));
            this.btnClients.ImageActive = null;
            this.btnClients.Location = new System.Drawing.Point(693, 200);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(270, 169);
            this.btnClients.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClients.TabIndex = 6;
            this.btnClients.TabStop = false;
            this.btnClients.Zoom = 10;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Nexa Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.gunaLabel3.Location = new System.Drawing.Point(769, 372);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(119, 39);
            this.gunaLabel3.TabIndex = 5;
            this.gunaLabel3.Text = "Clients";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReservations
            // 
            this.btnReservations.Image = ((System.Drawing.Image)(resources.GetObject("btnReservations.Image")));
            this.btnReservations.ImageActive = null;
            this.btnReservations.Location = new System.Drawing.Point(357, 200);
            this.btnReservations.Name = "btnReservations";
            this.btnReservations.Size = new System.Drawing.Size(270, 169);
            this.btnReservations.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnReservations.TabIndex = 4;
            this.btnReservations.TabStop = false;
            this.btnReservations.Zoom = 10;
            this.btnReservations.Click += new System.EventHandler(this.btnReservations_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Nexa Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.gunaLabel2.Location = new System.Drawing.Point(383, 372);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(218, 39);
            this.gunaLabel2.TabIndex = 3;
            this.gunaLabel2.Text = "Reservations";
            // 
            // btnRooms
            // 
            this.btnRooms.Image = ((System.Drawing.Image)(resources.GetObject("btnRooms.Image")));
            this.btnRooms.ImageActive = null;
            this.btnRooms.Location = new System.Drawing.Point(22, 200);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.Size = new System.Drawing.Size(270, 169);
            this.btnRooms.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRooms.TabIndex = 2;
            this.btnRooms.TabStop = false;
            this.btnRooms.Zoom = 10;
            this.btnRooms.Click += new System.EventHandler(this.btnRooms_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Nexa Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.gunaLabel1.Location = new System.Drawing.Point(80, 372);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(155, 39);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Cottages";
            // 
            // pbxStaff
            // 
            this.pbxStaff.BackColor = System.Drawing.Color.White;
            this.pbxStaff.Image = ((System.Drawing.Image)(resources.GetObject("pbxStaff.Image")));
            this.pbxStaff.Location = new System.Drawing.Point(1024, 200);
            this.pbxStaff.Name = "pbxStaff";
            this.pbxStaff.Size = new System.Drawing.Size(270, 169);
            this.pbxStaff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxStaff.TabIndex = 13;
            this.pbxStaff.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nexa Bold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(817, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yoyong and Dita\'s Resort Reservation System";
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.BackColor = System.Drawing.Color.Red;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.Font = new System.Drawing.Font("Nexa Bold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.White;
            this.lblExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblExit.Location = new System.Drawing.Point(1270, 0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(46, 46);
            this.lblExit.TabIndex = 2;
            this.lblExit.Text = "X";
            this.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Nexa Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.lblDateTime.Location = new System.Drawing.Point(931, 15);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(141, 23);
            this.lblDateTime.TabIndex = 9;
            this.lblDateTime.Text = "Date and Time";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAccess
            // 
            this.lblAccess.AutoSize = true;
            this.lblAccess.Font = new System.Drawing.Font("Nexa Bold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccess.ForeColor = System.Drawing.Color.Red;
            this.lblAccess.Location = new System.Drawing.Point(1058, 177);
            this.lblAccess.Name = "lblAccess";
            this.lblAccess.Size = new System.Drawing.Size(204, 20);
            this.lblAccess.TabIndex = 14;
            this.lblAccess.Text = "(Admin Access Required!)";
            this.lblAccess.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.ClientSize = new System.Drawing.Size(1316, 699);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReservations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblExit;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton btnStaff;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Bunifu.Framework.UI.BunifuImageButton btnClients;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Bunifu.Framework.UI.BunifuImageButton btnReservations;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Bunifu.Framework.UI.BunifuImageButton btnRooms;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.PictureBox pbxStaff;
        private System.Windows.Forms.Label lblAccess;
        private System.Windows.Forms.Label lblDateTime;
    }
}