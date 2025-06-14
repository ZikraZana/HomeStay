﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HomeStay
{
    public partial class FormReservasi : Form
    {
        private int selectedId = -1;

        int pageSize = 5; // Jumlah data per halaman
        int currentPage = 1; // Halaman saat ini
        int totalPages = 1; // Total halaman
        int totalRecords = 0; // Total data di database

        bool isFiltered = false; // Menandakan apakah data sedang difilter

        public FormReservasi()
        {
            
            InitializeComponent();

        }

        private void FormReservasi_Load(object sender, EventArgs e)
        {
            currentPage = 1;
            isFiltered = false;
            datePemesanan.Value = DateTime.Now;
            dateCheckIn.Value = DateTime.Now;
            dateTimePickerFilter.Visible = false;
            TampilkanDataDefault();
        }

        /* ============================================================== Button & Click Area ============================================================== */
        private void buttonSimpan_Click(object sender, EventArgs e)
        {

            if (!validasi())
            {
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnStr))
            {
                try
                {
                    conn.Open();

                    // STEP 1: Ambil nomor pemesanan terakhir
                    string getLastQuery = "SELECT MAX(no_pemesanan) FROM pemesanan";
                    MySqlCommand getLastCmd = new MySqlCommand(getLastQuery, conn);
                    object result = getLastCmd.ExecuteScalar();

                    int nextNumber = 1;

                    if (result != DBNull.Value && result != null)
                    {
                        string lastNo = result.ToString(); // e.g., "PM-007"
                        if (lastNo.StartsWith("PM-"))
                        {
                            string numberPart = lastNo.Substring(3);
                            if (int.TryParse(numberPart, out int lastNumber))
                            {
                                nextNumber = lastNumber + 1;
                            }
                        }
                    }

                    string newNoPemesanan = "PM-" + nextNumber.ToString("D3");

                    string query = "INSERT INTO pemesanan (no_pemesanan, nama_tamu, tanggal_pemesanan, tanggal_check_in, jumlah_tamu, id_kamar, id_resepsionis) " + "VALUES (@no_pemesanan, @nama_tamu, @tanggal_pemesanan, @tanggal_check_in, @jumlah_tamu, @id_kamar, @id_resepsionis)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@no_pemesanan", newNoPemesanan);
                    cmd.Parameters.AddWithValue("@nama_tamu", txtNamaTamu.Text);
                    cmd.Parameters.AddWithValue("@tanggal_pemesanan", datePemesanan.Value);
                    cmd.Parameters.AddWithValue("@tanggal_check_in", dateCheckIn.Value);
                    cmd.Parameters.AddWithValue("@jumlah_tamu", txtJumlahTamu.Text);
                    string idKamar = "";

                    if (radioStandart.Checked)
                    {
                        idKamar = "1"; // ID kamar untuk Standart Room
                    }
                    else if (radioSuperior.Checked)
                    {
                        idKamar = "2"; // ID untuk Superior Room
                    }
                    else if (radioSuite.Checked)
                    {
                        idKamar = "3"; // ID untuk Suite Room
                    }
                    cmd.Parameters.AddWithValue("@id_kamar", idKamar);
                    cmd.Parameters.AddWithValue("@id_resepsionis", Session.id_resepsionis);
                   

                    cmd.ExecuteNonQuery();
                    TampilkanDataDefault();
                    ClearForm();
                    MessageBox.Show("Data pemesanan berhasil disimpan!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal simpan: " + ex.Message);
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Pilih data yang ingin diedit terlebih dahulu.");
                return;
            }

            if (!validasi())
            {
                return;
            }

            DialogResult result = MessageBox.Show("Yakin ingin mengubah data pemesanan ini?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnStr))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE pemesanan SET nama_tamu=@nama_tamu, tanggal_pemesanan=@tanggal_pemesanan, tanggal_check_in=@tanggal_check_in, jumlah_tamu=@jumlah_tamu, id_kamar=@id_kamar, id_resepsionis=@id_resepsionis WHERE id_pemesanan=@id_pemesanan";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nama_tamu", txtNamaTamu.Text);
                    cmd.Parameters.AddWithValue("@tanggal_pemesanan", datePemesanan.Value);
                    cmd.Parameters.AddWithValue("@tanggal_check_in", dateCheckIn.Value);
                    cmd.Parameters.AddWithValue("@jumlah_tamu", txtJumlahTamu.Text);
                    string idKamar = "";
                    if (radioStandart.Checked)
                    {
                        idKamar = "1"; // ID kamar untuk Standart Room
                    }
                    else if (radioSuperior.Checked)
                    {
                        idKamar = "2"; // ID untuk Superior Room
                    }
                    else if (radioSuite.Checked)
                    {
                        idKamar = "3"; // ID untuk Suite Room
                    }
                    cmd.Parameters.AddWithValue("@id_kamar", idKamar);
                    cmd.Parameters.AddWithValue("@id_resepsionis", Session.id_resepsionis);
                    cmd.Parameters.AddWithValue("@id_pemesanan", selectedId);
                    cmd.ExecuteNonQuery();
                    TampilkanDataDefault();
                    ClearForm();
                    MessageBox.Show("Data pemesanan berhasil diperbarui!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal update: " + ex.Message);
                }
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Pilih data yang ingin dihapus terlebih dahulu.");
                return;
            }

            DialogResult result = MessageBox.Show("Yakin ingin menghapus data pemesanan ini?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnStr))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM pemesanan WHERE id_pemesanan=@id_pemesanan";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id_pemesanan", selectedId);
                    cmd.ExecuteNonQuery();
                    TampilkanDataDefault();
                    ClearForm();
                    MessageBox.Show("Data pemesanan berhasil dihapus.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal hapus: " + ex.Message);
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            validasiFilter();
            currentPage = 1;
            isFiltered = true;
            TampilkanDataFiltered();
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                if (isFiltered)
                {
                    TampilkanDataFiltered();
                }
                else
                {
                    TampilkanDataDefault();
                }
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                if (isFiltered)
                {
                    TampilkanDataFiltered();
                }
                else
                {
                    TampilkanDataDefault();
                }
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            ClearForm();
            currentPage = 1;
            isFiltered = false;
            TampilkanDataDefault();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormDashboard frm = new FormDashboard();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void dataGridReservasi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // ganti ini!
            {
                object valueSelectedId = dataGridReservasi.Rows[e.RowIndex].Cells["id_pemesanan"].Value;
                selectedId = (valueSelectedId != null && valueSelectedId != DBNull.Value)
                    ? Convert.ToInt32(valueSelectedId)
                    : -1;

                txtNamaTamu.Text = dataGridReservasi.Rows[e.RowIndex].Cells["nama_tamu"].Value?.ToString() ?? "";
                txtJumlahTamu.Text = dataGridReservasi.Rows[e.RowIndex].Cells["jumlah_tamu"].Value?.ToString() ?? "";
                datePemesanan.Text = dataGridReservasi.Rows[e.RowIndex].Cells["tanggal_pemesanan"].Value?.ToString();
                dateCheckIn.Text = dataGridReservasi.Rows[e.RowIndex].Cells["tanggal_check_in"].Value?.ToString();
                int idKamar = Convert.ToInt32(dataGridReservasi.Rows[e.RowIndex].Cells["id_kamar"].Value);
                radioStandart.Checked = (idKamar == 1);
                radioSuperior.Checked = (idKamar == 2);
                radioSuite.Checked = (idKamar == 3);

                buttonSimpan.Enabled = false;

            }
        }





        /* ============================================================== Others ============================================================== */
        private void ClearForm()
        {
            txtNamaTamu.Clear();
            datePemesanan.Value = DateTime.Now;
            dateCheckIn.Value = DateTime.Now;
            txtJumlahTamu.Clear();
            radioStandart.Checked = false;
            radioSuperior.Checked = false;
            radioSuite.Checked = false;
            selectedId = -1;
            buttonSimpan.Enabled = true;
            comboBoxFilter.Text = "";
            txtCari.Clear();
            dateTimePickerFilter.Visible = false;
        }

        private bool validasi()
        {
            if (string.IsNullOrWhiteSpace(txtNamaTamu.Text))
            {
                MessageBox.Show("Nama Tamu tidak boleh kosong.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtJumlahTamu.Text) || !int.TryParse(txtJumlahTamu.Text, out _))
            {
                MessageBox.Show("Jumlah Tamu harus diisi dengan angka yang valid.");
                return false;
            }
            if (!radioStandart.Checked && !radioSuperior.Checked && !radioSuite.Checked)
            {
                MessageBox.Show("Pilih tipe kamar terlebih dahulu.");
                return false;
            }
            
            DateTime tanggalHariIni = DateTime.Now.Date;
            DateTime tglPemesanan = datePemesanan.Value.Date;
            DateTime tglCheckIn = dateCheckIn.Value.Date;

            if (tglPemesanan < tanggalHariIni)
            {
                MessageBox.Show("Tanggal Pemesanan tidak boleh sebelum hari ini.");
                return false;
            }

            if (tglCheckIn < tanggalHariIni)
            {
                MessageBox.Show("Tanggal Check-In tidak boleh sebelum hari ini.");
                return false;
            }

            if (tglCheckIn < tglPemesanan)
            {
                MessageBox.Show("Tanggal Check-In tidak boleh sebelum Tanggal Pemesanan.");
                return false;
            }
            return true;
        }

        private bool validasiFilter()
        {
            if (comboBoxFilter.SelectedItem == null && dateTimePickerFilter.Visible == false)
            {
                MessageBox.Show("Pilih kolom yang ingin difilter.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCari.Text) && dateTimePickerFilter.Visible == false)
            {
                MessageBox.Show("Masukkan keyword untuk pencarian.");
                return false;
            }

            return true;
        }

        private void TampilkanDataFiltered()
        {
            string kolom = comboBoxFilter.SelectedItem?.ToString();
            string keyword = txtCari.Text.Trim();

            string kolomDb = "nama_tamu"; // Default kolom pencarian
            bool isDateFilter = false;

            if (kolom == "Tanggal Pemesanan")
            {
                kolomDb = "tanggal_pemesanan";
                isDateFilter = true;
            }
            else if (kolom == "Tanggal Check-in")
            {
                kolomDb = "tanggal_check_in";
                isDateFilter = true;
            }
            else if (kolom == "Jumlah Tamu")
            {
                kolomDb = "jumlah_tamu";
            }
            else if (kolom == "Tipe Kamar")
            {
                kolomDb = "tipe_kamar";
            }
            else if (kolom == "Nomor Pemesanan")
            {
                kolomDb = "no_pemesanan";
            }

            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnStr))
            {
                conn.Open();

                string tableAlias = (kolomDb == "tipe_kamar") ? "k." : "p.";
                string filterCondition;
                MySqlCommand countCmd = new MySqlCommand();
                countCmd.Connection = conn;

                if (isDateFilter)
                {
                    filterCondition = $"{tableAlias}{kolomDb} = @tanggal";
                    countCmd.Parameters.AddWithValue("@tanggal", dateTimePickerFilter.Value.Date);
                }
                else
                {
                    filterCondition = $"{tableAlias}{kolomDb} LIKE @keyword";
                    countCmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                }

                countCmd.Parameters.AddWithValue("@id_resepsionis", Session.id_resepsionis);
                countCmd.CommandText = $@"
            SELECT COUNT(*) 
            FROM pemesanan p
            JOIN kamar k ON p.id_kamar = k.id_kamar
            WHERE {filterCondition} AND p.id_resepsionis = @id_resepsionis";

                totalRecords = Convert.ToInt32(countCmd.ExecuteScalar());
                totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);

                if (currentPage > totalPages) currentPage = totalPages;
                if (currentPage < 1) currentPage = 1;
                int offset = (currentPage - 1) * pageSize;

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@id_resepsionis", Session.id_resepsionis);
                cmd.Parameters.AddWithValue("@limit", pageSize);
                cmd.Parameters.AddWithValue("@offset", offset);

                if (isDateFilter)
                {
                    filterCondition = $"{tableAlias}{kolomDb} = @tanggal";
                    cmd.Parameters.AddWithValue("@tanggal", dateTimePickerFilter.Value.Date);
                }
                else
                {
                    filterCondition = $"{tableAlias}{kolomDb} LIKE @keyword";
                    cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                }

                cmd.CommandText = $@"
            SELECT 
                p.id_pemesanan,
                p.nama_tamu,
                p.tanggal_pemesanan,
                p.tanggal_check_in,
                p.jumlah_tamu,
                k.tipe_kamar,
                p.id_kamar,
                p.no_pemesanan,
                p.id_resepsionis
            FROM pemesanan p
            JOIN kamar k ON p.id_kamar = k.id_kamar
            WHERE {filterCondition} AND p.id_resepsionis = @id_resepsionis
            ORDER BY p.id_pemesanan DESC
            LIMIT @limit OFFSET @offset";

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridReservasi.DataSource = dt;

                dataGridReservasi.Columns["id_pemesanan"].Visible = false;
                dataGridReservasi.Columns["nama_tamu"].HeaderText = "Nama Tamu";
                dataGridReservasi.Columns["tanggal_pemesanan"].HeaderText = "Tanggal Pemesanan";
                dataGridReservasi.Columns["tanggal_check_in"].HeaderText = "Tanggal Check-In";
                dataGridReservasi.Columns["jumlah_tamu"].HeaderText = "Jumlah Orang";
                dataGridReservasi.Columns["tipe_kamar"].HeaderText = "Tipe Kamar";
                dataGridReservasi.Columns["no_pemesanan"].HeaderText = "No. Pemesanan";
                dataGridReservasi.Columns["id_resepsionis"].Visible = false;
                dataGridReservasi.Columns["id_kamar"].Visible = false;

                // Atur posisi kolom
                dataGridReservasi.Columns["no_pemesanan"].DisplayIndex = 0;
                dataGridReservasi.Columns["nama_tamu"].DisplayIndex = 1;
                dataGridReservasi.Columns["jumlah_tamu"].DisplayIndex = 2;
                dataGridReservasi.Columns["tipe_kamar"].DisplayIndex = 3;
                dataGridReservasi.Columns["tanggal_pemesanan"].DisplayIndex = 4;
                dataGridReservasi.Columns["tanggal_check_in"].DisplayIndex = 5;
                labelPageInfo.Text = $"Halaman {currentPage} dari {totalPages}";
            }
        }




        private void TampilkanDataDefault()
        {
            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnStr))
            {
                conn.Open();

                string countQuery = "SELECT Count(*) from pemesanan WHERE id_resepsionis = @id_resepsionis";

                MySqlCommand countCmd = new MySqlCommand(countQuery, conn);
                countCmd.Parameters.AddWithValue("@id_resepsionis", Session.id_resepsionis);
                totalRecords = Convert.ToInt32(countCmd.ExecuteScalar());

                totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
                if (currentPage > totalPages)
                {
                    currentPage = totalPages;
                }
                if (currentPage < 1)
                {
                    currentPage = 1;
                }

                int offset = (currentPage - 1) * pageSize;

                string query = @"
                        SELECT 
                            p.id_pemesanan,
                            p.nama_tamu,
                            p.tanggal_pemesanan,
                            p.tanggal_check_in,
                            p.jumlah_tamu,
                            k.tipe_kamar,
                            p.id_kamar,
                            p.no_pemesanan,
                            p.id_resepsionis
                        FROM pemesanan p
                        JOIN kamar k ON p.id_kamar = k.id_kamar
                        WHERE p.id_resepsionis = @id_resepsionis
                        ORDER BY p.id_pemesanan DESC
                        LIMIT @limit OFFSET @offset";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_resepsionis", Session.id_resepsionis);
                cmd.Parameters.AddWithValue("@limit", pageSize);
                cmd.Parameters.AddWithValue("@offset", offset);


                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridReservasi.DataSource = dt;

                dataGridReservasi.Columns["id_pemesanan"].Visible = false;
                dataGridReservasi.Columns["nama_tamu"].HeaderText = "Nama Tamu";
                dataGridReservasi.Columns["tanggal_pemesanan"].HeaderText = "Tanggal Pemesanan";
                dataGridReservasi.Columns["tanggal_check_in"].HeaderText = "Tanggal Check-In";
                dataGridReservasi.Columns["jumlah_tamu"].HeaderText = "Jumlah Orang";
                dataGridReservasi.Columns["tipe_kamar"].HeaderText = "Tipe Kamar";
                dataGridReservasi.Columns["no_pemesanan"].HeaderText = "No. Pemesanan";
                dataGridReservasi.Columns["id_resepsionis"].Visible = false;
                dataGridReservasi.Columns["id_kamar"].Visible = false;

                // Atur posisi kolom
                dataGridReservasi.Columns["no_pemesanan"].DisplayIndex = 0;
                dataGridReservasi.Columns["nama_tamu"].DisplayIndex = 1;
                dataGridReservasi.Columns["jumlah_tamu"].DisplayIndex = 2;
                dataGridReservasi.Columns["tipe_kamar"].DisplayIndex = 3;
                dataGridReservasi.Columns["tanggal_pemesanan"].DisplayIndex = 4;
                dataGridReservasi.Columns["tanggal_check_in"].DisplayIndex = 5;

                labelPageInfo.Text = $"Halaman {currentPage} dari {totalPages}";
            }
        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = comboBoxFilter.SelectedItem?.ToString();
            if (selected == "Tanggal Pemesanan" || selected == "Tanggal Check-in")
            {
                dateTimePickerFilter.Visible = true;
                txtCari.Visible = false;
            }
            else
            {
                dateTimePickerFilter.Visible = false;
                txtCari.Visible = true;
            }
        }
    }
}
