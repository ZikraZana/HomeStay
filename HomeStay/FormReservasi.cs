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

                    dataGridReservasi.Columns["nama_tamu"].HeaderText = "Nama";
                    dataGridReservasi.Columns["tanggal_pemesanan"].HeaderText = "Tanggal Check-In";
                    dataGridReservasi.Columns["jumlah_tamu"].HeaderText = "Jumlah Orang";
                    dataGridReservasi.Columns["id_kamar"].HeaderText = "Tipe Kamar";
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
            if (selectedId == -1) return;

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
                object valueSelectedId = dataGridReservasi.Rows[e.RowIndex].Cells["id"].Value;
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
                txtNamaTamu.Text = dataGridReservasi.Rows[e.RowIndex].Cells["nama_tamu"].Value?.ToString() ?? "";
                buttonSimpan.Enabled = false;
            }
        }

        private void txtNamaTamu_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            if (selectedId == -1) return;

            DialogResult result = MessageBox.Show("Yakin ingin menghapus data pemesanan ini?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) return;

            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnStr))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM pemesanan WHERE id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", selectedId);
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
    }
}
