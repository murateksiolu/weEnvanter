using DevExpress.XtraEditors;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using weEnvanter.Business.Services;
using weEnvanter.Business.Services.Interfaces;
using weEnvanter.Core.Helpers;
using weEnvanter.UI.Forms.AuthForms;

namespace weEnvanter.UI.Forms.SettingForms
{
    public partial class DatabaseConnectionForm : DevExpress.XtraEditors.XtraForm
    {
        public DatabaseConnectionForm()
        {
            InitializeComponent();
        }

        private void DatabaseConnectionForm_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["WeEnvanterConnection"]?.ConnectionString;

            if (string.IsNullOrEmpty(connectionString))
                return;

            // Server
            var server = GetValueFromConnectionString(connectionString, "Server");
            txtServer.Text = server;

            // Database
            var database = GetValueFromConnectionString(connectionString, "Database");
            txtDatabase.Text = database;

            // Kullanıcı Adı
            var userId = GetValueFromConnectionString(connectionString, "User Id");
            txtUsername.Text = userId;

            // Şifre
            var password = GetValueFromConnectionString(connectionString, "Password");
            txtPassword.Text = password;

            // Windows Authentication
            var trusted = GetValueFromConnectionString(connectionString, "Trusted_Connection");
            chkWindowsAuth.Checked = !string.IsNullOrEmpty(trusted) && trusted.ToLower() == "true";
        }
        private void chkWindowsAuth_CheckedChanged(object sender, EventArgs e)
        {
            if(chkWindowsAuth.Checked)
            {
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
            }
            else
            {
                txtUsername.Enabled = true;
                txtPassword.Enabled = true;
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string server = txtServer.Text;
            string database = txtDatabase.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            bool windowsAuth = chkWindowsAuth.Checked;

            try
            {
                // Önce veritabanı var mı kontrol et, yoksa oluştur
                ConfigHelper.EnsureDatabaseExists(server, database, username, password, windowsAuth);

                // Sonra bağlantıyı test et
                string connectionString;
                if (windowsAuth)
                    connectionString = $"Server={server};Database={database};Trusted_Connection=True;Connect Timeout=3;";
                else
                    connectionString = $"Server={server};Database={database};User Id={username};Password={password};Connect Timeout=3;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    MessageBox.Show("Bağlantı başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı başarısız!\n\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string server = txtServer.Text;
            string database = txtDatabase.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            bool windowsAuth = chkWindowsAuth.Checked;

            // Önce veritabanı var mı kontrol et, yoksa oluştur
            ConfigHelper.EnsureDatabaseExists(server, database, username, password, windowsAuth);

            // Sonra connection string'i oluştur ve kaydet
            string connectionString;
            if (windowsAuth)
                connectionString = $"Server={server};Database={database};Trusted_Connection=True;Connect Timeout=3;";
            else
                connectionString = $"Server={server};Database={database};User Id={username};Password={password};Connect Timeout=3;";

            ConfigHelper.UpdateConnectionString("WeEnvanterConnection", connectionString);

            MessageBox.Show("Bağlantı ayarları kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
            var _userService = Program.ServiceProvider.GetRequiredService<IUserService>();
            LoginForm loginForm = new LoginForm(_userService);
            loginForm.ShowDialog();
            this.Close();
        }

        // Yardımcı fonksiyon
        private string GetValueFromConnectionString(string connectionString, string key)
        {
            var parts = connectionString.Split(';');
            foreach (var part in parts)
            {
                var kv = part.Split('=');
                if (kv.Length == 2 && kv[0].Trim().ToLower() == key.ToLower())
                {
                    return kv[1].Trim();
                }
            }
            return string.Empty;
        }
    }
}