
namespace ResortManagement
{
    partial class Reservations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservations));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.numAdult = new Guna.UI.WinForms.GunaNumeric();
            this.label7 = new System.Windows.Forms.Label();
            this.numChild = new Guna.UI.WinForms.GunaNumeric();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbxPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxCottages = new System.Windows.Forms.ComboBox();
            this.cbxClientNames = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dpDateOut = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dpDateIn = new Bunifu.Framework.UI.BunifuDatepicker();
            this.btnReset = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDelete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnEdit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAdd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtbxSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtbxResId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dgvReservation = new Guna.UI.WinForms.GunaDataGridView();
            this.btnReturn = new Bunifu.Framework.UI.BunifuTileButton();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.numAdult);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.numChild);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtbxPrice);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbxCottages);
            this.panel1.Controls.Add(this.cbxClientNames);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dpDateOut);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dpDateIn);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtbxSearch);
            this.panel1.Controls.Add(this.txtbxResId);
            this.panel1.Controls.Add(this.dgvReservation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 502);
            this.panel1.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nexa Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label8.Location = new System.Drawing.Point(73, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 23);
            this.label8.TabIndex = 26;
            this.label8.Text = "Adult";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numAdult
            // 
            this.numAdult.BaseColor = System.Drawing.Color.White;
            this.numAdult.BorderColor = System.Drawing.Color.Silver;
            this.numAdult.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.numAdult.ButtonForeColor = System.Drawing.Color.White;
            this.numAdult.Font = new System.Drawing.Font("Nexa Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAdult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.numAdult.Location = new System.Drawing.Point(134, 169);
            this.numAdult.Maximum = ((long)(9999999));
            this.numAdult.Minimum = ((long)(0));
            this.numAdult.Name = "numAdult";
            this.numAdult.Size = new System.Drawing.Size(75, 30);
            this.numAdult.TabIndex = 25;
            this.numAdult.Value = ((long)(0));
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nexa Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.label7.Location = new System.Drawing.Point(224, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 23);
            this.label7.TabIndex = 24;
            this.label7.Text = "Child";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numChild
            // 
            this.numChild.BaseColor = System.Drawing.Color.White;
            this.numChild.BorderColor = System.Drawing.Color.Silver;
            this.numChild.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.numChild.ButtonForeColor = System.Drawing.Color.White;
            this.numChild.Font = new System.Drawing.Font("Nexa Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numChild.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.numChild.Location = new System.Drawing.Point(284, 169);
            this.numChild.Maximum = ((long)(9999999));
            this.numChild.Minimum = ((long)(0));
            this.numChild.Name = "numChild";
            this.numChild.Size = new System.Drawing.Size(75, 30);
            this.numChild.TabIndex = 23;
            this.numChild.Value = ((long)(0));
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nexa Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.label6.Location = new System.Drawing.Point(158, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 23);
            this.label6.TabIndex = 22;
            this.label6.Text = "Price:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtbxPrice
            // 
            this.txtbxPrice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtbxPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtbxPrice.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtbxPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxPrice.Enabled = false;
            this.txtbxPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.txtbxPrice.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.txtbxPrice.HintText = "";
            this.txtbxPrice.isPassword = false;
            this.txtbxPrice.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.txtbxPrice.LineIdleColor = System.Drawing.Color.Gray;
            this.txtbxPrice.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.txtbxPrice.LineThickness = 3;
            this.txtbxPrice.Location = new System.Drawing.Point(224, 373);
            this.txtbxPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxPrice.MaxLength = 32767;
            this.txtbxPrice.Name = "txtbxPrice";
            this.txtbxPrice.Size = new System.Drawing.Size(126, 37);
            this.txtbxPrice.TabIndex = 21;
            this.txtbxPrice.Text = "0";
            this.txtbxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nexa Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.label5.Location = new System.Drawing.Point(39, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "Cottage:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nexa Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.label4.Location = new System.Drawing.Point(58, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "Client:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxCottages
            // 
            this.cbxCottages.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.cbxCottages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.cbxCottages.FormattingEnabled = true;
            this.cbxCottages.Location = new System.Drawing.Point(134, 127);
            this.cbxCottages.Name = "cbxCottages";
            this.cbxCottages.Size = new System.Drawing.Size(225, 27);
            this.cbxCottages.TabIndex = 18;
            this.cbxCottages.Text = "Cottage Number";
            // 
            // cbxClientNames
            // 
            this.cbxClientNames.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.cbxClientNames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.cbxClientNames.FormattingEnabled = true;
            this.cbxClientNames.Location = new System.Drawing.Point(134, 81);
            this.cbxClientNames.Name = "cbxClientNames";
            this.cbxClientNames.Size = new System.Drawing.Size(225, 27);
            this.cbxClientNames.TabIndex = 17;
            this.cbxClientNames.Text = " Client Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nexa Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.label3.Location = new System.Drawing.Point(43, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Date Out:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dpDateOut
            // 
            this.dpDateOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.dpDateOut.BorderRadius = 0;
            this.dpDateOut.ForeColor = System.Drawing.Color.White;
            this.dpDateOut.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpDateOut.FormatCustom = null;
            this.dpDateOut.Location = new System.Drawing.Point(47, 309);
            this.dpDateOut.Name = "dpDateOut";
            this.dpDateOut.Size = new System.Drawing.Size(303, 36);
            this.dpDateOut.TabIndex = 15;
            this.dpDateOut.Value = new System.DateTime(2021, 6, 24, 13, 19, 25, 659);
            this.dpDateOut.onValueChanged += new System.EventHandler(this.dpDateOut_onValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nexa Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.label2.Location = new System.Drawing.Point(43, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Date In:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dpDateIn
            // 
            this.dpDateIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.dpDateIn.BorderRadius = 0;
            this.dpDateIn.ForeColor = System.Drawing.Color.White;
            this.dpDateIn.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpDateIn.FormatCustom = null;
            this.dpDateIn.Location = new System.Drawing.Point(47, 240);
            this.dpDateIn.Name = "dpDateIn";
            this.dpDateIn.Size = new System.Drawing.Size(303, 36);
            this.dpDateIn.TabIndex = 13;
            this.dpDateIn.Value = new System.DateTime(2021, 6, 24, 13, 19, 25, 659);
            this.dpDateIn.onValueChanged += new System.EventHandler(this.dpDateIn_onValueChanged);
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
            this.btnDelete.Location = new System.Drawing.Point(263, 433);
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
            this.btnEdit.Location = new System.Drawing.Point(134, 433);
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
            this.btnAdd.Location = new System.Drawing.Point(5, 433);
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
            this.txtbxSearch.HintText = "Reservation Search";
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
            // txtbxResId
            // 
            this.txtbxResId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtbxResId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtbxResId.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtbxResId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxResId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxResId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.txtbxResId.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.txtbxResId.HintText = "Reservation ID";
            this.txtbxResId.isPassword = false;
            this.txtbxResId.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.txtbxResId.LineIdleColor = System.Drawing.Color.Gray;
            this.txtbxResId.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.txtbxResId.LineThickness = 3;
            this.txtbxResId.Location = new System.Drawing.Point(47, 21);
            this.txtbxResId.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxResId.MaxLength = 32767;
            this.txtbxResId.Name = "txtbxResId";
            this.txtbxResId.Size = new System.Drawing.Size(312, 37);
            this.txtbxResId.TabIndex = 1;
            this.txtbxResId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dgvReservation
            // 
            this.dgvReservation.AllowUserToResizeColumns = false;
            this.dgvReservation.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(239)))), ((int)(((byte)(212)))));
            this.dgvReservation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvReservation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReservation.BackgroundColor = System.Drawing.Color.White;
            this.dgvReservation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReservation.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReservation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReservation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvReservation.ColumnHeadersHeight = 20;
            this.dgvReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(244)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(221)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReservation.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvReservation.EnableHeadersVisualStyles = false;
            this.dgvReservation.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(238)))), ((int)(((byte)(208)))));
            this.dgvReservation.Location = new System.Drawing.Point(392, 65);
            this.dgvReservation.Name = "dgvReservation";
            this.dgvReservation.ReadOnly = true;
            this.dgvReservation.RowHeadersVisible = false;
            this.dgvReservation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservation.Size = new System.Drawing.Size(526, 425);
            this.dgvReservation.TabIndex = 0;
            this.dgvReservation.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Emerald;
            this.dgvReservation.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(239)))), ((int)(((byte)(212)))));
            this.dgvReservation.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvReservation.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvReservation.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvReservation.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvReservation.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvReservation.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(238)))), ((int)(((byte)(208)))));
            this.dgvReservation.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.dgvReservation.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvReservation.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvReservation.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvReservation.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvReservation.ThemeStyle.HeaderStyle.Height = 20;
            this.dgvReservation.ThemeStyle.ReadOnly = true;
            this.dgvReservation.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(244)))), ((int)(((byte)(226)))));
            this.dgvReservation.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReservation.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvReservation.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvReservation.ThemeStyle.RowsStyle.Height = 22;
            this.dgvReservation.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(221)))), ((int)(((byte)(160)))));
            this.dgvReservation.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvReservation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservation_CellContentClick);
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
            this.btnReturn.TabIndex = 19;
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
            this.lblDateTime.TabIndex = 18;
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
            this.lblExit.TabIndex = 17;
            this.lblExit.Text = "X";
            this.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nexa Bold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(339, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 46);
            this.label1.TabIndex = 16;
            this.label1.Text = "Reservations";
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
            // Reservations
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
            this.Name = "Reservations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservations";
            this.Load += new System.EventHandler(this.Reservations_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).EndInit();
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
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtbxResId;
        private Guna.UI.WinForms.GunaDataGridView dgvReservation;
        private Bunifu.Framework.UI.BunifuTileButton btnReturn;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuDatepicker dpDateIn;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuDatepicker dpDateOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxCottages;
        private System.Windows.Forms.ComboBox cbxClientNames;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtbxPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaNumeric numAdult;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaNumeric numChild;
    }
}