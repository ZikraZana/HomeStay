﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;

namespace HomeStay
{
    public partial class FormLogin: Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username dan Password harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using(MySqlConnection conn = new MySqlConnection(DBConfig.ConnStr))
            {
                try
                {
                    conn.Open();
                    string query = "Select * from resepsionis where username = @username";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string hashFromDb = reader.GetString("password");
                        bool isValid = BCrypt.Net.BCrypt.Verify(password, hashFromDb);
                        if (isValid)
                        {
                            Session.id_resepsionis = reader.GetInt32("id_resepsionis");
                            Session.username = reader.GetString("username");
                            Session.nama_resepsionis = reader.GetString("nama_resepsionis");

                            // Login sukses 
                            MessageBox.Show("Login berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FormDashboard frm = new FormDashboard();
                            this.Hide(); 
                            frm.ShowDialog();
                            this.Close();
                            
                        }
                        else
                        {
                            // Password salah
                            MessageBox.Show("Password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        // Username tidak ditemukan
                        MessageBox.Show("Username tidak ditemukan!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Koneksi ke database gagal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void checkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPassword.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = false; // Tampilkan password
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true; // Sembunyikan password
            }
        }
    }
}
