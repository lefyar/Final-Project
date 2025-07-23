using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Digidaw
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            AppState.LoadData();
            if (AppState.SudahPunyaProfil)
            {
                labelWelcome.Text = $"Selamat datang, {AppState.Profil.Nama}.";
            }
            LoadUserControl(new UCInputMakanan());
        }

        private void LoadUserControl(UserControl uc)
        {
            panelContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelContent.Controls.Add(uc);
        }

        public void UpdateWelcomeMessage()
        {

            labelWelcome.Text = $"Welcome, {AppState.Profil.Nama}.";
        }

        public void ResetWelcomeMessage()
        {
            labelWelcome.Text = "Digital Daily Of Awareness";
        }

        private void btnFormInput_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UCInputMakanan());
        }

        private void btnStatistik_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UCStatistik());
        }

        private void btnPengaturan_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UCPengaturan());
        }

        private void btnFormInput_Enter(object sender, EventArgs e)
        {
            btnFormInput.BackColor = System.Drawing.Color.DarkOliveGreen;
            btnFormInput.Font = new System.Drawing.Font(btnFormInput.Font, System.Drawing.FontStyle.Bold);

            btnStatistik.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnStatistik.Font = new System.Drawing.Font(btnStatistik.Font, System.Drawing.FontStyle.Regular);

            btnPengaturan.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnPengaturan.Font = new System.Drawing.Font(btnPengaturan.Font, System.Drawing.FontStyle.Regular);
        }

        private void btnStatistik_Enter(object sender, EventArgs e)
        {
            btnStatistik.BackColor = System.Drawing.Color.DarkOliveGreen;
            btnStatistik.Font = new System.Drawing.Font(btnStatistik.Font, System.Drawing.FontStyle.Bold);

            btnFormInput.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnFormInput.Font = new System.Drawing.Font(btnFormInput.Font, System.Drawing.FontStyle.Regular);

            btnPengaturan.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnPengaturan.Font = new System.Drawing.Font(btnPengaturan.Font, System.Drawing.FontStyle.Regular);
        }

        private void btnPengaturan_Enter(object sender, EventArgs e)
        {
            btnPengaturan.BackColor = System.Drawing.Color.DarkOliveGreen;
            btnPengaturan.Font = new System.Drawing.Font(btnPengaturan.Font, System.Drawing.FontStyle.Bold);

            btnFormInput.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnFormInput.Font = new System.Drawing.Font(btnFormInput.Font, System.Drawing.FontStyle.Regular);

            btnStatistik.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnStatistik.Font = new System.Drawing.Font(btnStatistik.Font, System.Drawing.FontStyle.Regular);
        }

        private void timerJam_Tick(object sender, EventArgs e)
        {
            labelJam.Text = DateTime.Now.ToString("dddd, dd MMM yyyy - HH:mm:ss");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            AppState.SaveData();
        }
    }
}
