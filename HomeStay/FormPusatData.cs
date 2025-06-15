using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeStay
{
    public partial class FormPusatData: Form
    {

        int pageSize = 10; // Jumlah data per halaman
        int currentPage = 1; // Halaman saat ini
        int totalPages = 1; // Total halaman
        int totalRecords = 0; // Total data di database

        public FormPusatData()
        {
            InitializeComponent();
        }

        private void TampilkanDataDefault()
        {
            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnStr))
            {
                conn.Open();

                string countQuery = "SELECT Count(*) from pemesanan";
                MySqlCommand countCmd = new MySqlCommand(countQuery, conn);
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
                            p.id_resepsionis,
                            r.nama_resepsionis
                        FROM pemesanan p
                        JOIN kamar k ON p.id_kamar = k.id_kamar
                        JOIN resepsionis r ON p.id_resepsionis = r.id_resepsionis
                        ORDER BY p.id_pemesanan DESC
                        LIMIT @limit OFFSET @offset";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@limit", pageSize);
                cmd.Parameters.AddWithValue("@offset", offset);


                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridPusatData.DataSource = dt;

                dataGridPusatData.Columns["no_pemesanan"].HeaderText = "No. Pemesanan";
                dataGridPusatData.Columns["nama_resepsionis"].HeaderText = "Penanggung Jawab";
                dataGridPusatData.Columns["nama_tamu"].HeaderText = "Nama Tamu";
                dataGridPusatData.Columns["jumlah_tamu"].HeaderText = "Jumlah Orang";
                dataGridPusatData.Columns["tipe_kamar"].HeaderText = "Tipe Kamar";
                dataGridPusatData.Columns["tanggal_pemesanan"].HeaderText = "Tanggal Pemesanan";
                dataGridPusatData.Columns["tanggal_check_in"].HeaderText = "Tanggal Check-In";

                dataGridPusatData.Columns["id_pemesanan"].Visible = false;
                dataGridPusatData.Columns["id_resepsionis"].Visible = false;
                dataGridPusatData.Columns["id_kamar"].Visible = false;

                //display index untuk kolom
                dataGridPusatData.Columns["no_pemesanan"].DisplayIndex = 0;
                dataGridPusatData.Columns["nama_resepsionis"].DisplayIndex = 1;
                dataGridPusatData.Columns["nama_tamu"].DisplayIndex = 2;
                dataGridPusatData.Columns["jumlah_tamu"].DisplayIndex = 3;
                dataGridPusatData.Columns["tipe_kamar"].DisplayIndex = 4;
                dataGridPusatData.Columns["tanggal_pemesanan"].DisplayIndex = 5;
                dataGridPusatData.Columns["tanggal_check_in"].DisplayIndex = 6;

                labelPageInfo.Text = $"Halaman {currentPage} dari {totalPages}";
            }
        }

        private void FormPusatData_Load(object sender, EventArgs e)
        {
            currentPage = 1;
            TampilkanDataDefault();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormDashboard frm = new FormDashboard();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                TampilkanDataDefault();
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                TampilkanDataDefault();
            }
        }
    }
}
