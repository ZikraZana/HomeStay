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
            this.labelNama = new System.Windows.Forms.Label();
            this.labelTanggal = new System.Windows.Forms.Label();
            this.txtNamaTamu = new System.Windows.Forms.TextBox();
            this.dateCheckIn = new System.Windows.Forms.DateTimePicker();
            this.txtJumlahTamu = new System.Windows.Forms.TextBox();
            this.radioStandart = new System.Windows.Forms.RadioButton();
            this.labelJumlah = new System.Windows.Forms.Label();
            this.labelTipe = new System.Windows.Forms.Label();
            this.radioSuperior = new System.Windows.Forms.RadioButton();
            this.radioSuite = new System.Windows.Forms.RadioButton();
            this.dataGridReservasi = new System.Windows.Forms.DataGridView();
            this.ColumnNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnJumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTipe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupAction = new System.Windows.Forms.GroupBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.groupBoxForm = new System.Windows.Forms.GroupBox();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.comboFilter = new System.Windows.Forms.ComboBox();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.labelHalaman = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReservasi)).BeginInit();
            this.groupAction.SuspendLayout();
            this.groupBoxForm.SuspendLayout();
            this.groupBoxFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNama.Location = new System.Drawing.Point(1, 29);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(52, 18);
            this.labelNama.TabIndex = 0;
            this.labelNama.Text = "Nama";
            // 
            // labelTanggal
            // 
            this.labelTanggal.AutoSize = true;
            this.labelTanggal.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTanggal.Location = new System.Drawing.Point(1, 75);
            this.labelTanggal.Name = "labelTanggal";
            this.labelTanggal.Size = new System.Drawing.Size(140, 18);
            this.labelTanggal.TabIndex = 1;
            this.labelTanggal.Text = "Tanggal Check-In";
            // 
            // txtNamaTamu
            // 
            this.txtNamaTamu.Location = new System.Drawing.Point(148, 29);
            this.txtNamaTamu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNamaTamu.Name = "txtNamaTamu";
            this.txtNamaTamu.Size = new System.Drawing.Size(237, 26);
            this.txtNamaTamu.TabIndex = 3;
            this.txtNamaTamu.TextChanged += new System.EventHandler(this.txtNamaTamu_TextChanged);
            // 
            // dateCheckIn
            // 
            this.dateCheckIn.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCheckIn.Location = new System.Drawing.Point(148, 75);
            this.dateCheckIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateCheckIn.Name = "dateCheckIn";
            this.dateCheckIn.Size = new System.Drawing.Size(200, 26);
            this.dateCheckIn.TabIndex = 5;
            // 
            // txtJumlahTamu
            // 
            this.txtJumlahTamu.Location = new System.Drawing.Point(148, 113);
            this.txtJumlahTamu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtJumlahTamu.Name = "txtJumlahTamu";
            this.txtJumlahTamu.Size = new System.Drawing.Size(237, 26);
            this.txtJumlahTamu.TabIndex = 6;
            this.txtJumlahTamu.TextChanged += new System.EventHandler(this.txtJumlahTamu_TextChanged);
            // 
            // radioStandart
            // 
            this.radioStandart.AutoSize = true;
            this.radioStandart.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioStandart.Location = new System.Drawing.Point(148, 174);
            this.radioStandart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioStandart.Name = "radioStandart";
            this.radioStandart.Size = new System.Drawing.Size(205, 22);
            this.radioStandart.TabIndex = 7;
            this.radioStandart.TabStop = true;
            this.radioStandart.Text = "Standart Room (Max 3)";
            this.radioStandart.UseVisualStyleBackColor = true;
            // 
            // labelJumlah
            // 
            this.labelJumlah.AutoSize = true;
            this.labelJumlah.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJumlah.Location = new System.Drawing.Point(1, 115);
            this.labelJumlah.Name = "labelJumlah";
            this.labelJumlah.Size = new System.Drawing.Size(108, 18);
            this.labelJumlah.TabIndex = 2;
            this.labelJumlah.Text = "Jumlah Orang";
            this.labelJumlah.Click += new System.EventHandler(this.labelJumlah_Click);
            // 
            // labelTipe
            // 
            this.labelTipe.AutoSize = true;
            this.labelTipe.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipe.Location = new System.Drawing.Point(1, 174);
            this.labelTipe.Name = "labelTipe";
            this.labelTipe.Size = new System.Drawing.Size(93, 18);
            this.labelTipe.TabIndex = 8;
            this.labelTipe.Text = "Tipe Kamar";
            // 
            // radioSuperior
            // 
            this.radioSuperior.AutoSize = true;
            this.radioSuperior.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSuperior.Location = new System.Drawing.Point(148, 215);
            this.radioSuperior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioSuperior.Name = "radioSuperior";
            this.radioSuperior.Size = new System.Drawing.Size(205, 22);
            this.radioSuperior.TabIndex = 9;
            this.radioSuperior.TabStop = true;
            this.radioSuperior.Text = "Superior Room (Max 5)";
            this.radioSuperior.UseVisualStyleBackColor = true;
            // 
            // radioSuite
            // 
            this.radioSuite.AutoSize = true;
            this.radioSuite.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSuite.Location = new System.Drawing.Point(148, 259);
            this.radioSuite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioSuite.Name = "radioSuite";
            this.radioSuite.Size = new System.Drawing.Size(180, 22);
            this.radioSuite.TabIndex = 10;
            this.radioSuite.TabStop = true;
            this.radioSuite.Text = "Suite Room (Max 7)";
            this.radioSuite.UseVisualStyleBackColor = true;
            // 
            // dataGridReservasi
            // 
            this.dataGridReservasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReservasi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNama,
            this.ColumnTanggal,
            this.ColumnJumlah,
            this.ColumnTipe});
            this.dataGridReservasi.Location = new System.Drawing.Point(577, 78);
            this.dataGridReservasi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridReservasi.Name = "dataGridReservasi";
            this.dataGridReservasi.RowHeadersWidth = 62;
            this.dataGridReservasi.RowTemplate.Height = 28;
            this.dataGridReservasi.Size = new System.Drawing.Size(645, 361);
            this.dataGridReservasi.TabIndex = 11;
            this.dataGridReservasi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridReservasi_CellClick);
            // 
            // ColumnNama
            // 
            this.ColumnNama.HeaderText = "Nama Tamu";
            this.ColumnNama.MinimumWidth = 8;
            this.ColumnNama.Name = "ColumnNama";
            this.ColumnNama.Width = 150;
            // 
            // ColumnTanggal
            // 
            this.ColumnTanggal.HeaderText = "Tanggal Check-In";
            this.ColumnTanggal.MinimumWidth = 8;
            this.ColumnTanggal.Name = "ColumnTanggal";
            this.ColumnTanggal.Width = 150;
            // 
            // ColumnJumlah
            // 
            this.ColumnJumlah.HeaderText = "Jumlah Orang";
            this.ColumnJumlah.MinimumWidth = 8;
            this.ColumnJumlah.Name = "ColumnJumlah";
            this.ColumnJumlah.Width = 150;
            // 
            // ColumnTipe
            // 
            this.ColumnTipe.HeaderText = "Tipe Kamar";
            this.ColumnTipe.MinimumWidth = 8;
            this.ColumnTipe.Name = "ColumnTipe";
            this.ColumnTipe.Width = 150;
            // 
            // groupAction
            // 
            this.groupAction.Controls.Add(this.buttonClear);
            this.groupAction.Controls.Add(this.buttonPrint);
            this.groupAction.Controls.Add(this.buttonHapus);
            this.groupAction.Controls.Add(this.buttonEdit);
            this.groupAction.Controls.Add(this.buttonSimpan);
            this.groupAction.Location = new System.Drawing.Point(16, 431);
            this.groupAction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupAction.Name = "groupAction";
            this.groupAction.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupAction.Size = new System.Drawing.Size(541, 154);
            this.groupAction.TabIndex = 12;
            this.groupAction.TabStop = false;
            this.groupAction.Text = "Action";
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(391, 42);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(96, 35);
            this.buttonClear.TabIndex = 18;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.Location = new System.Drawing.Point(289, 42);
            this.buttonPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(96, 35);
            this.buttonPrint.TabIndex = 17;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            // 
            // buttonHapus
            // 
            this.buttonHapus.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHapus.Location = new System.Drawing.Point(187, 42);
            this.buttonHapus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(96, 35);
            this.buttonHapus.TabIndex = 15;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.UseVisualStyleBackColor = true;
            this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(85, 42);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(96, 35);
            this.buttonEdit.TabIndex = 14;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpan.Location = new System.Drawing.Point(148, 96);
            this.buttonSimpan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(273, 35);
            this.buttonSimpan.TabIndex = 13;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // groupBoxForm
            // 
            this.groupBoxForm.Controls.Add(this.txtJumlahTamu);
            this.groupBoxForm.Controls.Add(this.labelNama);
            this.groupBoxForm.Controls.Add(this.labelTanggal);
            this.groupBoxForm.Controls.Add(this.radioSuite);
            this.groupBoxForm.Controls.Add(this.labelJumlah);
            this.groupBoxForm.Controls.Add(this.radioSuperior);
            this.groupBoxForm.Controls.Add(this.txtNamaTamu);
            this.groupBoxForm.Controls.Add(this.labelTipe);
            this.groupBoxForm.Controls.Add(this.dateCheckIn);
            this.groupBoxForm.Controls.Add(this.radioStandart);
            this.groupBoxForm.Location = new System.Drawing.Point(16, 132);
            this.groupBoxForm.Name = "groupBoxForm";
            this.groupBoxForm.Size = new System.Drawing.Size(446, 294);
            this.groupBoxForm.TabIndex = 13;
            this.groupBoxForm.TabStop = false;
            this.groupBoxForm.Text = "Reservasi";
            // 
            // buttonPrev
            // 
            this.buttonPrev.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrev.Location = new System.Drawing.Point(577, 457);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(107, 36);
            this.buttonPrev.TabIndex = 14;
            this.buttonPrev.Text = "Prev";
            this.buttonPrev.UseVisualStyleBackColor = true;
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.Location = new System.Drawing.Point(690, 457);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(107, 36);
            this.buttonNext.TabIndex = 15;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            // 
            // comboFilter
            // 
            this.comboFilter.FormattingEnabled = true;
            this.comboFilter.Items.AddRange(new object[] {
            "Nama Tamu",
            "Tanggal",
            "Jumlah Orang",
            "Tipe Kamar"});
            this.comboFilter.Location = new System.Drawing.Point(6, 38);
            this.comboFilter.Name = "comboFilter";
            this.comboFilter.Size = new System.Drawing.Size(213, 28);
            this.comboFilter.TabIndex = 16;
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.Controls.Add(this.btnSearch);
            this.groupBoxFilter.Controls.Add(this.txtSearch);
            this.groupBoxFilter.Controls.Add(this.comboFilter);
            this.groupBoxFilter.Location = new System.Drawing.Point(16, 12);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Size = new System.Drawing.Size(442, 114);
            this.groupBoxFilter.TabIndex = 17;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Filter";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(6, 72);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(430, 36);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(225, 40);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(211, 26);
            this.txtSearch.TabIndex = 17;
            // 
            // labelHalaman
            // 
            this.labelHalaman.AutoSize = true;
            this.labelHalaman.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHalaman.Location = new System.Drawing.Point(1082, 457);
            this.labelHalaman.Name = "labelHalaman";
            this.labelHalaman.Size = new System.Drawing.Size(140, 18);
            this.labelHalaman.TabIndex = 18;
            this.labelHalaman.Text = "Halaman 1 dari 2";
            // 
            // FormReservasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 610);
            this.Controls.Add(this.labelHalaman);
            this.Controls.Add(this.groupBoxFilter);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.groupBoxForm);
            this.Controls.Add(this.groupAction);
            this.Controls.Add(this.dataGridReservasi);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormReservasi";
            this.Text = "FormReservasi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReservasi)).EndInit();
            this.groupAction.ResumeLayout(false);
            this.groupBoxForm.ResumeLayout(false);
            this.groupBoxForm.PerformLayout();
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelTanggal;
        private System.Windows.Forms.TextBox txtNamaTamu;
        private System.Windows.Forms.DateTimePicker dateCheckIn;
        private System.Windows.Forms.TextBox txtJumlahTamu;
        private System.Windows.Forms.RadioButton radioStandart;
        private System.Windows.Forms.Label labelJumlah;
        private System.Windows.Forms.Label labelTipe;
        private System.Windows.Forms.RadioButton radioSuperior;
        private System.Windows.Forms.RadioButton radioSuite;
        private System.Windows.Forms.DataGridView dataGridReservasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnJumlah;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTipe;
        private System.Windows.Forms.GroupBox groupAction;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.GroupBox groupBoxForm;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.ComboBox comboFilter;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label labelHalaman;
    }
}