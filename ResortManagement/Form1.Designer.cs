
namespace ResortManagement
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaGradientButton1 = new Guna.UI.WinForms.GunaGradientButton();
            this.txtbxPassword = new Guna.UI.WinForms.GunaTextBox();
            this.txtbxUsername = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.panel1.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.lblTitle.Location = new System.Drawing.Point(39, 41);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(255, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Resort Reservation System";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.gunaGroupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 425);
            this.panel1.TabIndex = 1;
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.gunaGradientButton1);
            this.gunaGroupBox1.Controls.Add(this.txtbxPassword);
            this.gunaGroupBox1.Controls.Add(this.txtbxUsername);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Location = new System.Drawing.Point(3, 104);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(327, 321);
            this.gunaGroupBox1.TabIndex = 3;
            this.gunaGroupBox1.Text = "Login";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaGradientButton1
            // 
            this.gunaGradientButton1.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton1.AnimationSpeed = 0.03F;
            this.gunaGradientButton1.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.gunaGradientButton1.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(250)))), ((int)(((byte)(148)))));
            this.gunaGradientButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaGradientButton1.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaGradientButton1.Image")));
            this.gunaGradientButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton1.Location = new System.Drawing.Point(83, 213);
            this.gunaGradientButton1.Name = "gunaGradientButton1";
            this.gunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(148)))));
            this.gunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(250)))), ((int)(((byte)(148)))));
            this.gunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.OnHoverImage = null;
            this.gunaGradientButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.Size = new System.Drawing.Size(160, 42);
            this.gunaGradientButton1.TabIndex = 4;
            this.gunaGradientButton1.Text = "LOGIN";
            this.gunaGradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaGradientButton1.Click += new System.EventHandler(this.gunaGradientButton1_Click);
            // 
            // txtbxPassword
            // 
            this.txtbxPassword.BaseColor = System.Drawing.Color.White;
            this.txtbxPassword.BorderColor = System.Drawing.Color.Silver;
            this.txtbxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.txtbxPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtbxPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtbxPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbxPassword.Location = new System.Drawing.Point(15, 145);
            this.txtbxPassword.Name = "txtbxPassword";
            this.txtbxPassword.PasswordChar = '\0';
            this.txtbxPassword.SelectedText = "";
            this.txtbxPassword.Size = new System.Drawing.Size(296, 30);
            this.txtbxPassword.TabIndex = 3;
            this.txtbxPassword.Text = "Password";
            this.txtbxPassword.TextChanged += new System.EventHandler(this.txtbxPassword_TextChanged);
            this.txtbxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbxPassword_KeyDown);
            // 
            // txtbxUsername
            // 
            this.txtbxUsername.BaseColor = System.Drawing.Color.White;
            this.txtbxUsername.BorderColor = System.Drawing.Color.Silver;
            this.txtbxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxUsername.FocusedBaseColor = System.Drawing.Color.White;
            this.txtbxUsername.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtbxUsername.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtbxUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbxUsername.Location = new System.Drawing.Point(15, 86);
            this.txtbxUsername.Name = "txtbxUsername";
            this.txtbxUsername.PasswordChar = '\0';
            this.txtbxUsername.SelectedText = "";
            this.txtbxUsername.Size = new System.Drawing.Size(296, 30);
            this.txtbxUsername.TabIndex = 2;
            this.txtbxUsername.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.label1.Location = new System.Drawing.Point(75, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yoyong and Dita\'s";
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Red;
            this.gunaLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(309, -6);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(28, 30);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "X";
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.ClientSize = new System.Drawing.Size(333, 450);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gunaGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton1;
        private Guna.UI.WinForms.GunaTextBox txtbxPassword;
        private Guna.UI.WinForms.GunaTextBox txtbxUsername;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}

