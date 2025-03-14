
namespace ResortManagement
{
    partial class StaffInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffInfo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtbxPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnReset = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDelete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnEdit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAdd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtbxSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtbxUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtbxName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtbxStaffId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dgvStaffInfo = new Guna.UI.WinForms.GunaDataGridView();
            this.btnReturn = new Bunifu.Framework.UI.BunifuTileButton();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.cbxRoles = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbxRoles);
            this.panel1.Controls.Add(this.txtbxPassword);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtbxSearch);
            this.panel1.Controls.Add(this.txtbxUsername);
            this.panel1.Controls.Add(this.txtbxName);
            this.panel1.Controls.Add(this.txtbxStaffId);
            this.panel1.Controls.Add(this.dgvStaffInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 502);
            this.panel1.TabIndex = 1;
            // 
            // txtbxPassword
            // 
            this.txtbxPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtbxPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtbxPassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtbxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.txtbxPassword.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.txtbxPassword.HintText = "Staff Password";
            this.txtbxPassword.isPassword = false;
            this.txtbxPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.txtbxPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.txtbxPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.txtbxPassword.LineThickness = 3;
            this.txtbxPassword.Location = new System.Drawing.Point(46, 265);
            this.txtbxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxPassword.MaxLength = 32767;
            this.txtbxPassword.Name = "txtbxPassword";
            this.txtbxPassword.Size = new System.Drawing.Size(312, 37);
            this.txtbxPassword.TabIndex = 11;
            this.txtbxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnReset
            // 
            this.btnReset.Active = false;
            this.btnReset.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.BorderRadius = 0;
            this.btnReset.ButtonText = "";
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.DisabledColor = System.Drawing.Color.Gray;
            this.btnReset.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReset.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnReset.Iconimage")));
            this.btnReset.Iconimage_right = null;
            this.btnReset.Iconimage_right_Selected = null;
            this.btnReset.Iconimage_Selected = null;
            this.btnReset.IconMarginLeft = 0;
            this.btnReset.IconMarginRight = 0;
            this.btnReset.IconRightVisible = true;
            this.btnReset.IconRightZoom = 0D;
            this.btnReset.IconVisible = true;
            this.btnReset.IconZoom = 70D;
            this.btnReset.IsTab = false;
            this.btnReset.Location = new System.Drawing.Point(879, 21);
            this.btnReset.Name = "btnReset";
            this.btnReset.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btnReset.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnReset.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReset.selected = false;
            this.btnReset.Size = new System.Drawing.Size(39, 38);
            this.btnReset.TabIndex = 10;
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Textcolor = System.Drawing.Color.White;
            this.btnReset.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Active = false;
            this.btnSearch.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.BorderRadius = 0;
            this.btnSearch.ButtonText = "";
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.DisabledColor = System.Drawing.Color.Gray;
            this.btnSearch.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSearch.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSearch.Iconimage")));
            this.btnSearch.Iconimage_right = null;
            this.btnSearch.Iconimage_right_Selected = null;
            this.btnSearch.Iconimage_Selected = null;
            this.btnSearch.IconMarginLeft = 0;
            this.btnSearch.IconMarginRight = 0;
            this.btnSearch.IconRightVisible = true;
            this.btnSearch.IconRightZoom = 0D;
            this.btnSearch.IconVisible = true;
            this.btnSearch.IconZoom = 80D;
            this.btnSearch.IsTab = false;
            this.btnSearch.Location = new System.Drawing.Point(777, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btnSearch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSearch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSearch.selected = false;
            this.btnSearch.Size = new System.Drawing.Size(39, 38);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Textcolor = System.Drawing.Color.White;
            this.btnSearch.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ActiveBorderThickness = 1;
            this.btnDelete.ActiveCornerRadius = 20;
            this.btnDelete.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btnDelete.ActiveForecolor = System.Drawing.Color.White;
            this.btnDelete.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.ButtonText = "Delete";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btnDelete.IdleBorderThickness = 1;
            this.btnDelete.IdleCornerRadius = 20;
            this.btnDelete.IdleFillColor = System.Drawing.Color.White;
            this.btnDelete.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btnDelete.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btnDelete.Location = new System.Drawing.Point(265, 372);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 41);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ActiveBorderThickness = 1;
            this.btnEdit.ActiveCornerRadius = 20;
            this.btnEdit.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btnEdit.ActiveForecolor = System.Drawing.Color.White;
            this.btnEdit.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.ButtonText = "Edit";
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btnEdit.IdleBorderThickness = 1;
            this.btnEdit.IdleCornerRadius = 20;
            this.btnEdit.IdleFillColor = System.Drawing.Color.White;
            this.btnEdit.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btnEdit.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btnEdit.Location = new System.Drawing.Point(136, 372);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(119, 41);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ActiveBorderThickness = 1;
            this.btnAdd.ActiveCornerRadius = 20;
            this.btnAdd.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btnAdd.ActiveForecolor = System.Drawing.Color.White;
            this.btnAdd.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.ButtonText = "Add";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btnAdd.IdleBorderThickness = 1;
            this.btnAdd.IdleCornerRadius = 20;
            this.btnAdd.IdleFillColor = System.Drawing.Color.White;
            this.btnAdd.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btnAdd.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btnAdd.Location = new System.Drawing.Point(7, 372);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 41);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtbxSearch
            // 
            this.txtbxSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtbxSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtbxSearch.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtbxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.txtbxSearch.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.txtbxSearch.HintText = "Staff Name Search";
            this.txtbxSearch.isPassword = false;
            this.txtbxSearch.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.txtbxSearch.LineIdleColor = System.Drawing.Color.Gray;
            this.txtbxSearch.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.txtbxSearch.LineThickness = 3;
            this.txtbxSearch.Location = new System.Drawing.Point(457, 21);
            this.txtbxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxSearch.MaxLength = 32767;
            this.txtbxSearch.Name = "txtbxSearch";
            this.txtbxSearch.Size = new System.Drawing.Size(312, 37);
            this.txtbxSearch.TabIndex = 4;
            this.txtbxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtbxUsername
            // 
            this.txtbxUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtbxUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtbxUsername.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtbxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.txtbxUsername.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.txtbxUsername.HintText = "Staff Username";
            this.txtbxUsername.isPassword = false;
            this.txtbxUsername.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.txtbxUsername.LineIdleColor = System.Drawing.Color.Gray;
            this.txtbxUsername.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.txtbxUsername.LineThickness = 3;
            this.txtbxUsername.Location = new System.Drawing.Point(46, 181);
            this.txtbxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxUsername.MaxLength = 32767;
            this.txtbxUsername.Name = "txtbxUsername";
            this.txtbxUsername.Size = new System.Drawing.Size(312, 37);
            this.txtbxUsername.TabIndex = 3;
            this.txtbxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtbxName
            // 
            this.txtbxName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtbxName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtbxName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtbxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.txtbxName.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.txtbxName.HintText = "Staff Name";
            this.txtbxName.isPassword = false;
            this.txtbxName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.txtbxName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtbxName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.txtbxName.LineThickness = 3;
            this.txtbxName.Location = new System.Drawing.Point(46, 101);
            this.txtbxName.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxName.MaxLength = 32767;
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(312, 37);
            this.txtbxName.TabIndex = 2;
            this.txtbxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtbxStaffId
            // 
            this.txtbxStaffId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtbxStaffId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtbxStaffId.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtbxStaffId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxStaffId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxStaffId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.txtbxStaffId.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.txtbxStaffId.HintText = " Staff ID";
            this.txtbxStaffId.isPassword = false;
            this.txtbxStaffId.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.txtbxStaffId.LineIdleColor = System.Drawing.Color.Gray;
            this.txtbxStaffId.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.txtbxStaffId.LineThickness = 3;
            this.txtbxStaffId.Location = new System.Drawing.Point(46, 21);
            this.txtbxStaffId.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxStaffId.MaxLength = 32767;
            this.txtbxStaffId.Name = "txtbxStaffId";
            this.txtbxStaffId.Size = new System.Drawing.Size(312, 37);
            this.txtbxStaffId.TabIndex = 1;
            this.txtbxStaffId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dgvStaffInfo
            // 
            this.dgvStaffInfo.AllowUserToResizeColumns = false;
            this.dgvStaffInfo.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(239)))), ((int)(((byte)(212)))));
            this.dgvStaffInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvStaffInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStaffInfo.BackgroundColor = System.Drawing.Color.White;
            this.dgvStaffInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStaffInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvStaffInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStaffInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvStaffInfo.ColumnHeadersHeight = 20;
            this.dgvStaffInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(244)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(221)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStaffInfo.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvStaffInfo.EnableHeadersVisualStyles = false;
            this.dgvStaffInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(238)))), ((int)(((byte)(208)))));
            this.dgvStaffInfo.Location = new System.Drawing.Point(392, 65);
            this.dgvStaffInfo.Name = "dgvStaffInfo";
            this.dgvStaffInfo.ReadOnly = true;
            this.dgvStaffInfo.RowHeadersVisible = false;
            this.dgvStaffInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaffInfo.Size = new System.Drawing.Size(526, 425);
            this.dgvStaffInfo.TabIndex = 0;
            this.dgvStaffInfo.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Emerald;
            this.dgvStaffInfo.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(239)))), ((int)(((byte)(212)))));
            this.dgvStaffInfo.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvStaffInfo.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvStaffInfo.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvStaffInfo.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvStaffInfo.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvStaffInfo.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(238)))), ((int)(((byte)(208)))));
            this.dgvStaffInfo.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.dgvStaffInfo.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvStaffInfo.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvStaffInfo.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvStaffInfo.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStaffInfo.ThemeStyle.HeaderStyle.Height = 20;
            this.dgvStaffInfo.ThemeStyle.ReadOnly = true;
            this.dgvStaffInfo.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(244)))), ((int)(((byte)(226)))));
            this.dgvStaffInfo.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvStaffInfo.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvStaffInfo.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvStaffInfo.ThemeStyle.RowsStyle.Height = 22;
            this.dgvStaffInfo.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(221)))), ((int)(((byte)(160)))));
            this.dgvStaffInfo.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvStaffInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaffInfo_CellContentClick);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btnReturn.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btnReturn.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.Font = new System.Drawing.Font("Nexa Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.ImagePosition = 8;
            this.btnReturn.ImageZoom = 60;
            this.btnReturn.LabelPosition = 20;
            this.btnReturn.LabelText = "Return";
            this.btnReturn.Location = new System.Drawing.Point(0, 0);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(6);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 75);
            this.btnReturn.TabIndex = 15;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Nexa Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.White;
            this.lblDateTime.Location = new System.Drawing.Point(659, 57);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(110, 18);
            this.lblDateTime.TabIndex = 14;
            this.lblDateTime.Text = "Date and Time";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.BackColor = System.Drawing.Color.Red;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.Font = new System.Drawing.Font("Nexa Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.White;
            this.lblExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblExit.Location = new System.Drawing.Point(890, 0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(40, 39);
            this.lblExit.TabIndex = 13;
            this.lblExit.Text = "X";
            this.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nexa Bold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(299, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 46);
            this.label1.TabIndex = 12;
            this.label1.Text = "Staff Information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // cbxRoles
            // 
            this.cbxRoles.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.cbxRoles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.cbxRoles.FormattingEnabled = true;
            this.cbxRoles.Items.AddRange(new object[] {
            "Admin",
            "Employee"});
            this.cbxRoles.Location = new System.Drawing.Point(136, 325);
            this.cbxRoles.Name = "cbxRoles";
            this.cbxRoles.Size = new System.Drawing.Size(225, 27);
            this.cbxRoles.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Font = new System.Drawing.Font("Nexa Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(76, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 23);
            this.label5.TabIndex = 21;
            this.label5.Text = "Role:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StaffInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.ClientSize = new System.Drawing.Size(930, 580);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffInfo";
            this.Load += new System.EventHandler(this.StaffInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnReset;
        private Bunifu.Framework.UI.BunifuFlatButton btnSearch;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDelete;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEdit;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAdd;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtbxSearch;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtbxUsername;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtbxName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtbxStaffId;
        private Guna.UI.WinForms.GunaDataGridView dgvStaffInfo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtbxPassword;
        private Bunifu.Framework.UI.BunifuTileButton btnReturn;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.ComboBox cbxRoles;
        private System.Windows.Forms.Label label5;
    }
}