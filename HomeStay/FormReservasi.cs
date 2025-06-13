using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HomeStay
{
    public partial class FormReservasi: Form
    {
        private int selectedId = -1;
        private void LoadData()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM pemesanan";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    
                    adapter.Fill(dt);
                    dataGridReservasi.DataSource = dt;

                    dataGridReservasi.Columns["id_pemesanan"].HeaderText = "id_pemesanan";
                    dataGridReservasi.Columns["id_pemesanan"].Visible = false;

                    dataGridReservasi.Columns["nama_tamu"].HeaderText = "Nama Tamu";
                    dataGridReservasi.Columns["tanggal_pemesanan"].HeaderText = "Tanggal Check-In";
                    dataGridReservasi.Columns["jumlah_tamu"].HeaderText = "Jumlah Orang";
                    dataGridReservasi.Columns["id_kamar"].HeaderText = "Tipe Kamar (ID)";
                    dataGridReservasi.Columns["no_pemesanan"].HeaderText = "No. Pemesanan";
                    dataGridReservasi.Columns["id_resepsionis"].Visible=false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error load data: " + ex.Message);
                }
        }
    }
        

        public FormReservasi()
        {
            InitializeComponent();
            LoadData();
        }

        private void ClearForm()
        {
            txtNamaTamu.Clear();
            dateCheckIn.Value = DateTime.Now;
            txtJumlahTamu.Clear();
            radioStandart.Checked = false;
            radioSuperior.Checked = false;
            radioSuite.Checked = false;
            selectedId = -1;
            buttonSimpan.Enabled = true;
        }

        private void txtJumlahTamu_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelJumlah_Click(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Pilih data yang ingin diedit terlebih dahulu.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnStr))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE pemesanan SET nama_tamu=@nama_tamu, tanggal_pemesanan=@tanggal_pemesanan, jumlah_tamu=@jumlah_tamu, id_kamar=@id_kamar, id_resepsionis=@id_resepsionis WHERE id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nama_tamu", txtNamaTamu.Text);
                    cmd.Parameters.AddWithValue("@tanggal_pemesanan", dateCheckIn.Value);
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
                    cmd.Parameters.AddWithValue("@id_resepsionis", 1);
                    cmd.Parameters.AddWithValue("@id_pemesanan", selectedId);
                    cmd.ExecuteNonQuery();
                    LoadData();
                    ClearForm();
                    MessageBox.Show("Data pemesanan berhasil diperbarui!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal update: " + ex.Message);
                }
            }
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnStr))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO pemesanan (nama_tamu, tanggal_pemesanan, jumlah_tamu, id_kamar, id_resepsionis) " + "VALUES (@nama_tamu, @tanggal_pemesanan, @jumlah_tamu, @id_kamar, @id_resepsionis)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nama_tamu", txtNamaTamu.Text);
                    cmd.Parameters.AddWithValue("@tanggal_pemesanan", dateCheckIn.Value);
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
                    cmd.Parameters.AddWithValue("@id_resepsionis", 1);
                    cmd.ExecuteNonQuery();
                    LoadData();
                    ClearForm();
                    MessageBox.Show("Data pemesanan berhasil disimpan!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal simpan: " + ex.Message);
                }
            }
        }

        private void dataGridReservasi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0)
            { 
                object valueSelectedId = dataGridReservasi.Rows[e.RowIndex].Cells["id_pemesanan"].Value;
                selectedId = (valueSelectedId != null && valueSelectedId != DBNull.Value)
                    ? Convert.ToInt32(valueSelectedId) 
                    : -1;

                txtNamaTamu.Text = dataGridReservasi.Rows[e.RowIndex].Cells["nama_tamu"].Value?.ToString() ?? "";
                if (dataGridReservasi.Rows[e.RowIndex].Cells["tanggal_pemesanan"].Value != DBNull.Value)
                {
                    dateCheckIn.Value = Convert.ToDateTime(dataGridReservasi.Rows[e.RowIndex].Cells["tanggal_pemesanan"].Value);
                }
                else
                { 
                    dateCheckIn.Value = DateTime.Now;
                }
                txtJumlahTamu.Text = dataGridReservasi.Rows[e.RowIndex].Cells["jumlah_tamu"].Value?.ToString() ?? "";
                if (dataGridReservasi.Rows[e.RowIndex].Cells["id_kamar"].Value != DBNull.Value)
                {
                    string idKamarFromGrid = dataGridReservasi.Rows[e.RowIndex].Cells["id_kamar"].Value.ToString();
                    radioStandart.Checked = (idKamarFromGrid == "1");
                    radioSuperior.Checked = (idKamarFromGrid == "2");
                    radioSuite.Checked = (idKamarFromGrid == "3");
                }
                else
                {
                    radioStandart.Checked = false;
                    radioSuperior.Checked = false;
                    radioSuite.Checked = false;
                }
                buttonSimpan.Enabled = false;
            }
        }

        private void txtNamaTamu_TextChanged(object sender, EventArgs e)
        {

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
                    LoadData();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            TampilkanDataFiltered();
        }

        private void TampilkanDataFiltered()
        {
            string kolom = "Nama Tamu"; 
            if (comboFilter.SelectedItem != null)
            {
                kolom = comboFilter.SelectedItem.ToString();
            }
            else
            {
                if (comboFilter.Items.Count > 0)
                {
                    comboFilter.SelectedIndex = 0;
                    kolom = comboFilter.SelectedItem.ToString();
                }
            }

            string keyword = btnSearch.Text.Trim(); 

            string kolomDb = "";

            switch (kolom)
            {
                case "Nama Tamu":
                    kolomDb = "nama_tamu";
                    break;
                case "Jumlah Orang":
                    kolomDb = "jumlah_tamu";
                    break;
                case "No. Pemesanan":
                    kolomDb = "no_pemesanan";
                    break;
                case "Tanggal Check-In":
                    kolomDb = "tanggal_pemesanan";
                    break;
                case "Tipe Kamar":
                    kolomDb = "id_kamar"; 
                    break;
                default:
                    kolomDb = "nama_tamu";
                    break;
            }

            string query;
            if (string.IsNullOrEmpty(keyword))
            {
                query = "SELECT * FROM pemesanan ORDER BY id_pemesanan DESC";
            }
            else
            {
                if (string.IsNullOrEmpty(kolomDb))
                {
                    MessageBox.Show("Kolom filter tidak valid. Menampilkan semua data.");
                    query = "SELECT * FROM pemesanan ORDER BY id_pemesanan DESC";
                }
                else
                {
                    query = $"SELECT * FROM pemesanan WHERE {kolomDb} LIKE @keyword ORDER BY id_pemesanan DESC";
                }
            }


            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnStr))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(keyword) && !string.IsNullOrEmpty(kolomDb))
                        {
                            cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                        }

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        da.Fill(dt);
                        dataGridReservasi.DataSource = dt;

                        dataGridReservasi.Columns["id_pemesanan"].HeaderText = "ID Pemesanan";
                        dataGridReservasi.Columns["id_pemesanan"].Visible = false;

                        dataGridReservasi.Columns["nama_tamu"].HeaderText = "Nama Tamu";
                        dataGridReservasi.Columns["tanggal_pemesanan"].HeaderText = "Tanggal Check-In";
                        dataGridReservasi.Columns["jumlah_tamu"].HeaderText = "Jumlah Orang";
                        dataGridReservasi.Columns["id_kamar"].HeaderText = "Tipe Kamar (ID)";
                        dataGridReservasi.Columns["no_pemesanan"].HeaderText = "No. Pemesanan";
                        dataGridReservasi.Columns["id_resepsionis"].Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saat memfilter data: " + ex.Message);
                }
            }
        }
    }
}
