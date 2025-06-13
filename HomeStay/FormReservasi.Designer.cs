namespace HomeStay
{
    partial class FormReservasi
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
            this.dataGridReservasi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNamaTamu = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtJumlahTamu = new Guna.UI2.WinForms.Guna2TextBox();
            this.datePemesanan = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.radioSuite = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radioStandart = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radioSuperior = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonPrev = new Guna.UI2.WinForms.Guna2Button();
            this.buttonNext = new Guna.UI2.WinForms.Guna2Button();
            this.labelPageInfo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateCheckIn = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.buttonEdit = new Guna.UI2.WinForms.Guna2Button();
            this.buttonHapus = new Guna.UI2.WinForms.Guna2Button();
            this.buttonClear = new Guna.UI2.WinForms.Guna2Button();
            this.buttonPrint = new Guna.UI2.WinForms.Guna2Button();
            this.buttonSimpan = new Guna.UI2.WinForms.Guna2Button();
            this.txtCari = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonCari = new Guna.UI2.WinForms.Guna2Button();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReservasi)).BeginInit();
            this.guna2ContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridReservasi
            // 
            this.dataGridReservasi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridReservasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReservasi.Location = new System.Drawing.Point(34, 171);
            this.dataGridReservasi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridReservasi.Name = "dataGridReservasi";
            this.dataGridReservasi.RowHeadersWidth = 62;
            this.dataGridReservasi.RowTemplate.Height = 28;
            this.dataGridReservasi.Size = new System.Drawing.Size(760, 308);
            this.dataGridReservasi.TabIndex = 11;
            this.dataGridReservasi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridReservasi_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 42);
            this.label1.TabIndex = 18;
            this.label1.Text = "Manajemen Data Tamu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 565);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nama Tamu";
            // 
            // txtNamaTamu
            // 
            this.txtNamaTamu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNamaTamu.DefaultText = "";
            this.txtNamaTamu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNamaTamu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNamaTamu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamaTamu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamaTamu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNamaTamu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaTamu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNamaTamu.Location = new System.Drawing.Point(40, 595);
            this.txtNamaTamu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNamaTamu.Name = "txtNamaTamu";
            this.txtNamaTamu.PlaceholderText = "";
            this.txtNamaTamu.SelectedText = "";
            this.txtNamaTamu.Size = new System.Drawing.Size(235, 37);
            this.txtNamaTamu.TabIndex = 22;
            // 
            // txtJumlahTamu
            // 
            this.txtJumlahTamu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtJumlahTamu.DefaultText = "";
            this.txtJumlahTamu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtJumlahTamu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtJumlahTamu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtJumlahTamu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtJumlahTamu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJumlahTamu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJumlahTamu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJumlahTamu.Location = new System.Drawing.Point(309, 595);
            this.txtJumlahTamu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtJumlahTamu.Name = "txtJumlahTamu";
            this.txtJumlahTamu.PlaceholderText = "";
            this.txtJumlahTamu.SelectedText = "";
            this.txtJumlahTamu.Size = new System.Drawing.Size(215, 37);
            this.txtJumlahTamu.TabIndex = 24;
            // 
            // datePemesanan
            // 
            this.datePemesanan.BackColor = System.Drawing.Color.White;
            this.datePemesanan.Checked = true;
            this.datePemesanan.FillColor = System.Drawing.Color.White;
            this.datePemesanan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.datePemesanan.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datePemesanan.Location = new System.Drawing.Point(39, 682);
            this.datePemesanan.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datePemesanan.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datePemesanan.Name = "datePemesanan";
            this.datePemesanan.Size = new System.Drawing.Size(236, 37);
            this.datePemesanan.TabIndex = 25;
            this.datePemesanan.Value = new System.DateTime(2025, 6, 13, 20, 35, 0, 130);
            // 
            // guna2ContainerControl1
            // 
            this.guna2ContainerControl1.BorderRadius = 10;
            this.guna2ContainerControl1.BorderThickness = 1;
            this.guna2ContainerControl1.Controls.Add(this.label1);
            this.guna2ContainerControl1.Location = new System.Drawing.Point(-5, 82);
            this.guna2ContainerControl1.Name = "guna2ContainerControl1";
            this.guna2ContainerControl1.Size = new System.Drawing.Size(870, 74);
            this.guna2ContainerControl1.TabIndex = 23;
            this.guna2ContainerControl1.Text = "guna2ContainerControl1";
            // 
            // radioSuite
            // 
            this.radioSuite.AutoSize = true;
            this.radioSuite.BackColor = System.Drawing.Color.Transparent;
            this.radioSuite.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioSuite.CheckedState.BorderThickness = 0;
            this.radioSuite.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioSuite.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioSuite.CheckedState.InnerOffset = -4;
            this.radioSuite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSuite.Location = new System.Drawing.Point(574, 702);
            this.radioSuite.Name = "radioSuite";
            this.radioSuite.Size = new System.Drawing.Size(150, 29);
            this.radioSuite.TabIndex = 32;
            this.radioSuite.Text = "Suite (max 7)";
            this.radioSuite.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioSuite.UncheckedState.BorderThickness = 2;
            this.radioSuite.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioSuite.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.radioSuite.UseVisualStyleBackColor = false;
            // 
            // radioStandart
            // 
            this.radioStandart.AutoSize = true;
            this.radioStandart.BackColor = System.Drawing.Color.Transparent;
            this.radioStandart.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioStandart.CheckedState.BorderThickness = 0;
            this.radioStandart.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioStandart.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioStandart.CheckedState.InnerOffset = -4;
            this.radioStandart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioStandart.Location = new System.Drawing.Point(574, 632);
            this.radioStandart.Name = "radioStandart";
            this.radioStandart.Size = new System.Drawing.Size(174, 29);
            this.radioStandart.TabIndex = 30;
            this.radioStandart.Text = "Standar (max 3)";
            this.radioStandart.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioStandart.UncheckedState.BorderThickness = 2;
            this.radioStandart.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioStandart.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.radioStandart.UseVisualStyleBackColor = false;
            // 
            // radioSuperior
            // 
            this.radioSuperior.AutoSize = true;
            this.radioSuperior.BackColor = System.Drawing.Color.Transparent;
            this.radioSuperior.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioSuperior.CheckedState.BorderThickness = 0;
            this.radioSuperior.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioSuperior.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioSuperior.CheckedState.InnerOffset = -4;
            this.radioSuperior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSuperior.Location = new System.Drawing.Point(574, 667);
            this.radioSuperior.Name = "radioSuperior";
            this.radioSuperior.Size = new System.Drawing.Size(179, 29);
            this.radioSuperior.TabIndex = 31;
            this.radioSuperior.Text = "Superior (max 5)";
            this.radioSuperior.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioSuperior.UncheckedState.BorderThickness = 2;
            this.radioSuperior.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioSuperior.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.radioSuperior.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SandyBrown;
            this.label3.Location = new System.Drawing.Point(93, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 54);
            this.label3.TabIndex = 19;
            this.label3.Text = "HomeStay";
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Image = global::HomeStay.Properties.Resources.building;
            this.pictureBoxIcon.Location = new System.Drawing.Point(37, 18);
            this.pictureBoxIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(50, 48);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIcon.TabIndex = 33;
            this.pictureBoxIcon.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(304, 565);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 25);
            this.label4.TabIndex = 34;
            this.label4.Text = "Jumlah Tamu";
            // 
            // buttonPrev
            // 
            this.buttonPrev.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonPrev.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonPrev.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonPrev.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonPrev.FillColor = System.Drawing.Color.White;
            this.buttonPrev.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonPrev.ForeColor = System.Drawing.Color.Black;
            this.buttonPrev.Location = new System.Drawing.Point(37, 501);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(103, 33);
            this.buttonPrev.TabIndex = 35;
            this.buttonPrev.Text = "Prev";
            // 
            // buttonNext
            // 
            this.buttonNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonNext.FillColor = System.Drawing.Color.White;
            this.buttonNext.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonNext.ForeColor = System.Drawing.Color.Black;
            this.buttonNext.Location = new System.Drawing.Point(169, 501);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(103, 33);
            this.buttonNext.TabIndex = 36;
            this.buttonNext.Text = "Next";
            // 
            // labelPageInfo
            // 
            this.labelPageInfo.AutoSize = true;
            this.labelPageInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelPageInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelPageInfo.Location = new System.Drawing.Point(623, 509);
            this.labelPageInfo.Name = "labelPageInfo";
            this.labelPageInfo.Size = new System.Drawing.Size(159, 25);
            this.labelPageInfo.TabIndex = 37;
            this.labelPageInfo.Text = "Halaman 1 dari 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 650);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 25);
            this.label6.TabIndex = 38;
            this.label6.Text = "Tanggal Pemasanan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(569, 595);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 25);
            this.label7.TabIndex = 39;
            this.label7.Text = "Tipe Kamar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(303, 650);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 25);
            this.label8.TabIndex = 41;
            this.label8.Text = "Tanggal Check-in";
            // 
            // dateCheckIn
            // 
            this.dateCheckIn.BackColor = System.Drawing.Color.White;
            this.dateCheckIn.Checked = true;
            this.dateCheckIn.FillColor = System.Drawing.Color.White;
            this.dateCheckIn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateCheckIn.Location = new System.Drawing.Point(308, 682);
            this.dateCheckIn.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateCheckIn.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateCheckIn.Name = "dateCheckIn";
            this.dateCheckIn.Size = new System.Drawing.Size(215, 37);
            this.dateCheckIn.TabIndex = 40;
            this.dateCheckIn.Value = new System.DateTime(2025, 6, 13, 20, 35, 0, 130);
            // 
            // buttonEdit
            // 
            this.buttonEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonEdit.FillColor = System.Drawing.Color.White;
            this.buttonEdit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonEdit.ForeColor = System.Drawing.Color.Black;
            this.buttonEdit.Location = new System.Drawing.Point(495, 812);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(103, 33);
            this.buttonEdit.TabIndex = 42;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonHapus
            // 
            this.buttonHapus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonHapus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonHapus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonHapus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonHapus.FillColor = System.Drawing.Color.White;
            this.buttonHapus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonHapus.ForeColor = System.Drawing.Color.Black;
            this.buttonHapus.Location = new System.Drawing.Point(704, 812);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(103, 33);
            this.buttonHapus.TabIndex = 43;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonClear.FillColor = System.Drawing.Color.White;
            this.buttonClear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonClear.ForeColor = System.Drawing.Color.Black;
            this.buttonClear.Location = new System.Drawing.Point(495, 851);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(103, 33);
            this.buttonClear.TabIndex = 44;
            this.buttonClear.Text = "Clear";
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonPrint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonPrint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonPrint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonPrint.FillColor = System.Drawing.Color.White;
            this.buttonPrint.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonPrint.ForeColor = System.Drawing.Color.Black;
            this.buttonPrint.Location = new System.Drawing.Point(704, 851);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(103, 33);
            this.buttonPrint.TabIndex = 45;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSimpan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSimpan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSimpan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSimpan.FillColor = System.Drawing.Color.White;
            this.buttonSimpan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonSimpan.ForeColor = System.Drawing.Color.Black;
            this.buttonSimpan.Location = new System.Drawing.Point(495, 770);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(312, 33);
            this.buttonSimpan.TabIndex = 46;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // txtCari
            // 
            this.txtCari.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCari.DefaultText = "";
            this.txtCari.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCari.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCari.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCari.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCari.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCari.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCari.Location = new System.Drawing.Point(127, 767);
            this.txtCari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCari.Name = "txtCari";
            this.txtCari.PlaceholderText = "";
            this.txtCari.SelectedText = "";
            this.txtCari.Size = new System.Drawing.Size(148, 37);
            this.txtCari.TabIndex = 48;
            // 
            // buttonCari
            // 
            this.buttonCari.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonCari.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonCari.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonCari.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonCari.FillColor = System.Drawing.Color.White;
            this.buttonCari.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonCari.ForeColor = System.Drawing.Color.Black;
            this.buttonCari.Location = new System.Drawing.Point(42, 812);
            this.buttonCari.Name = "buttonCari";
            this.buttonCari.Size = new System.Drawing.Size(233, 33);
            this.buttonCari.TabIndex = 49;
            this.buttonCari.Text = "Cari";
            this.buttonCari.Click += new System.EventHandler(this.buttonCari_Click);
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Items.AddRange(new object[] {
            "tipe_kamar",
            "nama_tamu",
            "tanggal_pemesanan",
            "tanggal_check_in",
            "jumlah_tamu"});
            this.comboBoxFilter.Location = new System.Drawing.Point(39, 770);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(81, 33);
            this.comboBoxFilter.TabIndex = 50;
            // 
            // FormReservasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(827, 925);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.buttonCari);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonHapus);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateCheckIn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelPageInfo);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBoxIcon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioSuite);
            this.Controls.Add(this.radioStandart);
            this.Controls.Add(this.radioSuperior);
            this.Controls.Add(this.datePemesanan);
            this.Controls.Add(this.txtJumlahTamu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNamaTamu);
            this.Controls.Add(this.dataGridReservasi);
            this.Controls.Add(this.guna2ContainerControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormReservasi";
            this.Text = "FormReservasi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReservasi)).EndInit();
            this.guna2ContainerControl1.ResumeLayout(false);
            this.guna2ContainerControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridReservasi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtNamaTamu;
        private Guna.UI2.WinForms.Guna2TextBox txtJumlahTamu;
        private Guna.UI2.WinForms.Guna2DateTimePicker datePemesanan;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        private Guna.UI2.WinForms.Guna2RadioButton radioSuite;
        private Guna.UI2.WinForms.Guna2RadioButton radioStandart;
        private Guna.UI2.WinForms.Guna2RadioButton radioSuperior;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button buttonPrev;
        private Guna.UI2.WinForms.Guna2Button buttonNext;
        private System.Windows.Forms.Label labelPageInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateCheckIn;
        private Guna.UI2.WinForms.Guna2Button buttonEdit;
        private Guna.UI2.WinForms.Guna2Button buttonHapus;
        private Guna.UI2.WinForms.Guna2Button buttonClear;
        private Guna.UI2.WinForms.Guna2Button buttonPrint;
        private Guna.UI2.WinForms.Guna2Button buttonSimpan;
        private Guna.UI2.WinForms.Guna2TextBox txtCari;
        private Guna.UI2.WinForms.Guna2Button buttonCari;
        private System.Windows.Forms.ComboBox comboBoxFilter;
    }
}