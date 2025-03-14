
namespace ResortManagement
{
    partial class ClientInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientInfo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReset = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDelete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnEdit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAdd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtbxSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtbxPhone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtbxName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtbxClientId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dgvClientInfo = new Guna.UI.WinForms.GunaDataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnReturn = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.txtbxAddress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtbxAddress);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtbxSearch);
            this.panel1.Controls.Add(this.txtbxPhone);
            this.panel1.Controls.Add(this.txtbxName);
            this.panel1.Controls.Add(this.txtbxClientId);
            this.panel1.Controls.Add(this.dgvClientInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 502);
            this.panel1.TabIndex = 0;
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
            this.txtbxSearch.HintText = "Client Name";
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
            // txtbxPhone
            // 
            this.txtbxPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtbxPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtbxPhone.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtbxPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxPhone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.txtbxPhone.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.txtbxPhone.HintText = "Phone Number";
            this.txtbxPhone.isPassword = false;
            this.txtbxPhone.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.txtbxPhone.LineIdleColor = System.Drawing.Color.Gray;
            this.txtbxPhone.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.txtbxPhone.LineThickness = 3;
            this.txtbxPhone.Location = new System.Drawing.Point(47, 233);
            this.txtbxPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxPhone.MaxLength = 32767;
            this.txtbxPhone.Name = "txtbxPhone";
            this.txtbxPhone.Size = new System.Drawing.Size(312, 37);
            this.txtbxPhone.TabIndex = 3;
            this.txtbxPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.txtbxName.HintText = "Client Name";
            this.txtbxName.isPassword = false;
            this.txtbxName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.txtbxName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtbxName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.txtbxName.LineThickness = 3;
            this.txtbxName.Location = new System.Drawing.Point(47, 153);
            this.txtbxName.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxName.MaxLength = 32767;
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(312, 37);
            this.txtbxName.TabIndex = 2;
            this.txtbxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtbxClientId
            // 
            this.txtbxClientId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtbxClientId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtbxClientId.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtbxClientId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxClientId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxClientId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.txtbxClientId.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.txtbxClientId.HintText = "Client ID";
            this.txtbxClientId.isPassword = false;
            this.txtbxClientId.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.txtbxClientId.LineIdleColor = System.Drawing.Color.Gray;
            this.txtbxClientId.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.txtbxClientId.LineThickness = 3;
            this.txtbxClientId.Location = new System.Drawing.Point(47, 73);
            this.txtbxClientId.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxClientId.MaxLength = 32767;
            this.txtbxClientId.Name = "txtbxClientId";
            this.txtbxClientId.Size = new System.Drawing.Size(312, 37);
            this.txtbxClientId.TabIndex = 1;
            this.txtbxClientId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dgvClientInfo
            // 
            this.dgvClientInfo.AllowUserToResizeColumns = false;
            this.dgvClientInfo.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(239)))), ((int)(((byte)(212)))));
            this.dgvClientInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientInfo.BackgroundColor = System.Drawing.Color.White;
            this.dgvClientInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvClientInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClientInfo.ColumnHeadersHeight = 20;
            this.dgvClientInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(244)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(221)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientInfo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClientInfo.EnableHeadersVisualStyles = false;
            this.dgvClientInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(238)))), ((int)(((byte)(208)))));
            this.dgvClientInfo.Location = new System.Drawing.Point(392, 65);
            this.dgvClientInfo.Name = "dgvClientInfo";
            this.dgvClientInfo.ReadOnly = true;
            this.dgvClientInfo.RowHeadersVisible = false;
            this.dgvClientInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientInfo.Size = new System.Drawing.Size(526, 425);
            this.dgvClientInfo.TabIndex = 0;
            this.dgvClientInfo.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Emerald;
            this.dgvClientInfo.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(239)))), ((int)(((byte)(212)))));
            this.dgvClientInfo.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvClientInfo.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvClientInfo.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvClientInfo.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvClientInfo.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvClientInfo.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(238)))), ((int)(((byte)(208)))));
            this.dgvClientInfo.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.dgvClientInfo.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvClientInfo.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvClientInfo.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvClientInfo.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvClientInfo.ThemeStyle.HeaderStyle.Height = 20;
            this.dgvClientInfo.ThemeStyle.ReadOnly = true;
            this.dgvClientInfo.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(244)))), ((int)(((byte)(226)))));
            this.dgvClientInfo.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvClientInfo.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvClientInfo.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvClientInfo.ThemeStyle.RowsStyle.Height = 22;
            this.dgvClientInfo.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(221)))), ((int)(((byte)(160)))));
            this.dgvClientInfo.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvClientInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientInfo_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nexa Bold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(299, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Client Information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblExit.TabIndex = 3;
            this.lblExit.Text = "X";
            this.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Nexa Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.White;
            this.lblDateTime.Location = new System.Drawing.Point(659, 57);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(110, 18);
            this.lblDateTime.TabIndex = 10;
            this.lblDateTime.Text = "Date and Time";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.btnReturn.TabIndex = 11;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // txtbxAddress
            // 
            this.txtbxAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtbxAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtbxAddress.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtbxAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxAddress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.txtbxAddress.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.txtbxAddress.HintText = "Address";
            this.txtbxAddress.isPassword = false;
            this.txtbxAddress.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.txtbxAddress.LineIdleColor = System.Drawing.Color.Gray;
            this.txtbxAddress.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.txtbxAddress.LineThickness = 3;
            this.txtbxAddress.Location = new System.Drawing.Point(47, 314);
            this.txtbxAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxAddress.MaxLength = 32767;
            this.txtbxAddress.Name = "txtbxAddress";
            this.txtbxAddress.Size = new System.Drawing.Size(312, 37);
            this.txtbxAddress.TabIndex = 11;
            this.txtbxAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ClientInfo
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
            this.Name = "ClientInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientInfo";
            this.Load += new System.EventHandler(this.ClientInfo_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblExit;
        private Guna.UI.WinForms.GunaDataGridView dgvClientInfo;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuTileButton btnReturn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtbxClientId;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtbxSearch;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtbxPhone;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtbxName;
        private Bunifu.Framework.UI.BunifuFlatButton btnSearch;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDelete;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEdit;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAdd;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton btnReset;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtbxAddress;
    }
}