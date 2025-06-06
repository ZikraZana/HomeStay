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
            this.buttonReload = new System.Windows.Forms.Button();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonSimpan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReservasi)).BeginInit();
            this.groupAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Location = new System.Drawing.Point(36, 46);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(51, 20);
            this.labelNama.TabIndex = 0;
            this.labelNama.Text = "Nama";
            // 
            // labelTanggal
            // 
            this.labelTanggal.AutoSize = true;
            this.labelTanggal.Location = new System.Drawing.Point(36, 92);
            this.labelTanggal.Name = "labelTanggal";
            this.labelTanggal.Size = new System.Drawing.Size(134, 20);
            this.labelTanggal.TabIndex = 1;
            this.labelTanggal.Text = "Tanggal Check-In";
            // 
            // txtNamaTamu
            // 
            this.txtNamaTamu.Location = new System.Drawing.Point(183, 46);
            this.txtNamaTamu.Name = "txtNamaTamu";
            this.txtNamaTamu.Size = new System.Drawing.Size(237, 26);
            this.txtNamaTamu.TabIndex = 3;
            // 
            // dateCheckIn
            // 
            this.dateCheckIn.Location = new System.Drawing.Point(183, 92);
            this.dateCheckIn.Name = "dateCheckIn";
            this.dateCheckIn.Size = new System.Drawing.Size(200, 26);
            this.dateCheckIn.TabIndex = 5;
            // 
            // txtJumlahTamu
            // 
            this.txtJumlahTamu.Location = new System.Drawing.Point(183, 130);
            this.txtJumlahTamu.Name = "txtJumlahTamu";
            this.txtJumlahTamu.Size = new System.Drawing.Size(237, 26);
            this.txtJumlahTamu.TabIndex = 6;
            this.txtJumlahTamu.TextChanged += new System.EventHandler(this.txtJumlahTamu_TextChanged);
            // 
            // radioStandart
            // 
            this.radioStandart.AutoSize = true;
            this.radioStandart.Location = new System.Drawing.Point(183, 191);
            this.radioStandart.Name = "radioStandart";
            this.radioStandart.Size = new System.Drawing.Size(199, 24);
            this.radioStandart.TabIndex = 7;
            this.radioStandart.TabStop = true;
            this.radioStandart.Text = "Standart Room (Max 3)";
            this.radioStandart.UseVisualStyleBackColor = true;
            // 
            // labelJumlah
            // 
            this.labelJumlah.AutoSize = true;
            this.labelJumlah.Location = new System.Drawing.Point(36, 133);
            this.labelJumlah.Name = "labelJumlah";
            this.labelJumlah.Size = new System.Drawing.Size(108, 20);
            this.labelJumlah.TabIndex = 2;
            this.labelJumlah.Text = "Jumlah Orang";
            this.labelJumlah.Click += new System.EventHandler(this.labelJumlah_Click);
            // 
            // labelTipe
            // 
            this.labelTipe.AutoSize = true;
            this.labelTipe.Location = new System.Drawing.Point(36, 191);
            this.labelTipe.Name = "labelTipe";
            this.labelTipe.Size = new System.Drawing.Size(89, 20);
            this.labelTipe.TabIndex = 8;
            this.labelTipe.Text = "Tipe Kamar";
            // 
            // radioSuperior
            // 
            this.radioSuperior.AutoSize = true;
            this.radioSuperior.Location = new System.Drawing.Point(183, 233);
            this.radioSuperior.Name = "radioSuperior";
            this.radioSuperior.Size = new System.Drawing.Size(197, 24);
            this.radioSuperior.TabIndex = 9;
            this.radioSuperior.TabStop = true;
            this.radioSuperior.Text = "Superior Room (Max 5)";
            this.radioSuperior.UseVisualStyleBackColor = true;
            // 
            // radioSuite
            // 
            this.radioSuite.AutoSize = true;
            this.radioSuite.Location = new System.Drawing.Point(183, 276);
            this.radioSuite.Name = "radioSuite";
            this.radioSuite.Size = new System.Drawing.Size(174, 24);
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
            this.dataGridReservasi.Location = new System.Drawing.Point(475, 30);
            this.dataGridReservasi.Name = "dataGridReservasi";
            this.dataGridReservasi.RowHeadersWidth = 62;
            this.dataGridReservasi.RowTemplate.Height = 28;
            this.dataGridReservasi.Size = new System.Drawing.Size(512, 361);
            this.dataGridReservasi.TabIndex = 11;
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
            this.groupAction.Controls.Add(this.buttonReload);
            this.groupAction.Controls.Add(this.buttonHapus);
            this.groupAction.Controls.Add(this.buttonEdit);
            this.groupAction.Controls.Add(this.buttonSimpan);
            this.groupAction.Location = new System.Drawing.Point(12, 328);
            this.groupAction.Name = "groupAction";
            this.groupAction.Size = new System.Drawing.Size(445, 154);
            this.groupAction.TabIndex = 12;
            this.groupAction.TabStop = false;
            this.groupAction.Text = "Action";
            // 
            // buttonReload
            // 
            this.buttonReload.Location = new System.Drawing.Point(321, 40);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(96, 35);
            this.buttonReload.TabIndex = 16;
            this.buttonReload.Text = "Reload";
            this.buttonReload.UseVisualStyleBackColor = true;
            // 
            // buttonHapus
            // 
            this.buttonHapus.Location = new System.Drawing.Point(171, 40);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(96, 35);
            this.buttonHapus.TabIndex = 15;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(28, 40);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(96, 35);
            this.buttonEdit.TabIndex = 14;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Location = new System.Drawing.Point(80, 100);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(273, 35);
            this.buttonSimpan.TabIndex = 13;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            // 
            // FormReservasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 513);
            this.Controls.Add(this.groupAction);
            this.Controls.Add(this.dataGridReservasi);
            this.Controls.Add(this.radioSuite);
            this.Controls.Add(this.radioSuperior);
            this.Controls.Add(this.labelTipe);
            this.Controls.Add(this.radioStandart);
            this.Controls.Add(this.txtJumlahTamu);
            this.Controls.Add(this.dateCheckIn);
            this.Controls.Add(this.txtNamaTamu);
            this.Controls.Add(this.labelJumlah);
            this.Controls.Add(this.labelTanggal);
            this.Controls.Add(this.labelNama);
            this.Name = "FormReservasi";
            this.Text = "FormReservasi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReservasi)).EndInit();
            this.groupAction.ResumeLayout(false);
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
        private System.Windows.Forms.Button buttonReload;
    }
}