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
            this.labelNama.Location = new System.Drawing.Point(1, 23);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(44, 16);
            this.labelNama.TabIndex = 0;
            this.labelNama.Text = "Nama";
            // 
            // labelTanggal
            // 
            this.labelTanggal.AutoSize = true;
            this.labelTanggal.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTanggal.Location = new System.Drawing.Point(1, 60);
            this.labelTanggal.Name = "labelTanggal";
            this.labelTanggal.Size = new System.Drawing.Size(122, 16);
            this.labelTanggal.TabIndex = 1;
            this.labelTanggal.Text = "Tanggal Check-In";
            // 
            // txtNamaTamu
            // 
            this.txtNamaTamu.Location = new System.Drawing.Point(132, 23);
            this.txtNamaTamu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNamaTamu.Name = "txtNamaTamu";
            this.txtNamaTamu.Size = new System.Drawing.Size(211, 22);
            this.txtNamaTamu.TabIndex = 3;
            this.txtNamaTamu.TextChanged += new System.EventHandler(this.txtNamaTamu_TextChanged);
            // 
            // dateCheckIn
            // 
            this.dateCheckIn.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCheckIn.Location = new System.Drawing.Point(132, 60);
            this.dateCheckIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateCheckIn.Name = "dateCheckIn";
            this.dateCheckIn.Size = new System.Drawing.Size(178, 23);
            this.dateCheckIn.TabIndex = 5;
            // 
            // txtJumlahTamu
            // 
            this.txtJumlahTamu.Location = new System.Drawing.Point(132, 90);
            this.txtJumlahTamu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtJumlahTamu.Name = "txtJumlahTamu";
            this.txtJumlahTamu.Size = new System.Drawing.Size(211, 22);
            this.txtJumlahTamu.TabIndex = 6;
            this.txtJumlahTamu.TextChanged += new System.EventHandler(this.txtJumlahTamu_TextChanged);
            // 
            // radioStandart
            // 
            this.radioStandart.AutoSize = true;
            this.radioStandart.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioStandart.Location = new System.Drawing.Point(132, 139);
            this.radioStandart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioStandart.Name = "radioStandart";
            this.radioStandart.Size = new System.Drawing.Size(180, 20);
            this.radioStandart.TabIndex = 7;
            this.radioStandart.TabStop = true;
            this.radioStandart.Text = "Standart Room (Max 3)";
            this.radioStandart.UseVisualStyleBackColor = true;
            // 
            // labelJumlah
            // 
            this.labelJumlah.AutoSize = true;
            this.labelJumlah.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJumlah.Location = new System.Drawing.Point(1, 92);
            this.labelJumlah.Name = "labelJumlah";
            this.labelJumlah.Size = new System.Drawing.Size(94, 16);
            this.labelJumlah.TabIndex = 2;
            this.labelJumlah.Text = "Jumlah Orang";
            this.labelJumlah.Click += new System.EventHandler(this.labelJumlah_Click);
            // 
            // labelTipe
            // 
            this.labelTipe.AutoSize = true;
            this.labelTipe.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipe.Location = new System.Drawing.Point(1, 139);
            this.labelTipe.Name = "labelTipe";
            this.labelTipe.Size = new System.Drawing.Size(81, 16);
            this.labelTipe.TabIndex = 8;
            this.labelTipe.Text = "Tipe Kamar";
            // 
            // radioSuperior
            // 
            this.radioSuperior.AutoSize = true;
            this.radioSuperior.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSuperior.Location = new System.Drawing.Point(132, 172);
            this.radioSuperior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioSuperior.Name = "radioSuperior";
            this.radioSuperior.Size = new System.Drawing.Size(179, 20);
            this.radioSuperior.TabIndex = 9;
            this.radioSuperior.TabStop = true;
            this.radioSuperior.Text = "Superior Room (Max 5)";
            this.radioSuperior.UseVisualStyleBackColor = true;
            // 
            // radioSuite
            // 
            this.radioSuite.AutoSize = true;
            this.radioSuite.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSuite.Location = new System.Drawing.Point(132, 207);
            this.radioSuite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioSuite.Name = "radioSuite";
            this.radioSuite.Size = new System.Drawing.Size(156, 20);
            this.radioSuite.TabIndex = 10;
            this.radioSuite.TabStop = true;
            this.radioSuite.Text = "Suite Room (Max 7)";
            this.radioSuite.UseVisualStyleBackColor = true;
            // 
            // dataGridReservasi
            // 
            this.dataGridReservasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReservasi.Location = new System.Drawing.Point(513, 62);
            this.dataGridReservasi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridReservasi.Name = "dataGridReservasi";
            this.dataGridReservasi.RowHeadersWidth = 62;
            this.dataGridReservasi.RowTemplate.Height = 28;
            this.dataGridReservasi.Size = new System.Drawing.Size(573, 289);
            this.dataGridReservasi.TabIndex = 11;
            this.dataGridReservasi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridReservasi_CellClick);
            // 
            // groupAction
            // 
            this.groupAction.Controls.Add(this.buttonClear);
            this.groupAction.Controls.Add(this.buttonPrint);
            this.groupAction.Controls.Add(this.buttonHapus);
            this.groupAction.Controls.Add(this.buttonEdit);
            this.groupAction.Controls.Add(this.buttonSimpan);
            this.groupAction.Location = new System.Drawing.Point(14, 345);
            this.groupAction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupAction.Name = "groupAction";
            this.groupAction.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupAction.Size = new System.Drawing.Size(481, 123);
            this.groupAction.TabIndex = 12;
            this.groupAction.TabStop = false;
            this.groupAction.Text = "Action";
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(348, 34);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(85, 28);
            this.buttonClear.TabIndex = 18;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.Location = new System.Drawing.Point(257, 34);
            this.buttonPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(85, 28);
            this.buttonPrint.TabIndex = 17;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            // 
            // buttonHapus
            // 
            this.buttonHapus.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHapus.Location = new System.Drawing.Point(166, 34);
            this.buttonHapus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(85, 28);
            this.buttonHapus.TabIndex = 15;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.UseVisualStyleBackColor = true;
            this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(76, 34);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(85, 28);
            this.buttonEdit.TabIndex = 14;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpan.Location = new System.Drawing.Point(132, 77);
            this.buttonSimpan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(243, 28);
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
            this.groupBoxForm.Location = new System.Drawing.Point(14, 106);
            this.groupBoxForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxForm.Name = "groupBoxForm";
            this.groupBoxForm.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxForm.Size = new System.Drawing.Size(396, 235);
            this.groupBoxForm.TabIndex = 13;
            this.groupBoxForm.TabStop = false;
            this.groupBoxForm.Text = "Reservasi";
            // 
            // buttonPrev
            // 
            this.buttonPrev.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrev.Location = new System.Drawing.Point(513, 366);
            this.buttonPrev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(95, 29);
            this.buttonPrev.TabIndex = 14;
            this.buttonPrev.Text = "Prev";
            this.buttonPrev.UseVisualStyleBackColor = true;
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.Location = new System.Drawing.Point(613, 366);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(95, 29);
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
            this.comboFilter.Location = new System.Drawing.Point(5, 30);
            this.comboFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboFilter.Name = "comboFilter";
            this.comboFilter.Size = new System.Drawing.Size(190, 24);
            this.comboFilter.TabIndex = 16;
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.Controls.Add(this.btnSearch);
            this.groupBoxFilter.Controls.Add(this.txtSearch);
            this.groupBoxFilter.Controls.Add(this.comboFilter);
            this.groupBoxFilter.Location = new System.Drawing.Point(14, 10);
            this.groupBoxFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxFilter.Size = new System.Drawing.Size(393, 91);
            this.groupBoxFilter.TabIndex = 17;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Filter";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(5, 58);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(382, 29);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(200, 32);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(188, 22);
            this.txtSearch.TabIndex = 17;
            // 
            // labelHalaman
            // 
            this.labelHalaman.AutoSize = true;
            this.labelHalaman.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHalaman.Location = new System.Drawing.Point(962, 366);
            this.labelHalaman.Name = "labelHalaman";
            this.labelHalaman.Size = new System.Drawing.Size(118, 16);
            this.labelHalaman.TabIndex = 18;
            this.labelHalaman.Text = "Halaman 1 dari 2";
            // 
            // FormReservasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 488);
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