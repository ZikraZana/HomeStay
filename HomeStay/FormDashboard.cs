using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeStay
{
    public partial class FormDashboard: Form
    {
        public FormDashboard()
        {
            InitializeComponent();
            labelWelcome.Text = $"Selamat datang, {Session.nama_resepsionis}!";
        }

        private void buttonMDT_Click(object sender, EventArgs e)
        {
            FormReservasi frm = new FormReservasi();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Hapus data session
            Session.Clear();

            // Tampilkan kembali form login
            FormLogin login = new FormLogin();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void buttonPDT_Click(object sender, EventArgs e)
        {
            FormPusatData frm = new FormPusatData();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }
}
