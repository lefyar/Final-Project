using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digidaw
{
    public partial class UCPengaturan: UserControl
    {
        public UCPengaturan()
        {
            InitializeComponent();
        }

        private void UCPengaturan_Load(object sender, EventArgs e)
        {
            comboBoxTujuan.Items.AddRange(Enum.GetNames(typeof(TujuanGizi)));

            if (AppState.SudahPunyaProfil)
            {
                textBoxNama.Text = AppState.Profil.Nama;
                if (AppState.Profil.JenisKelamin == Gender.Lakilaki)
                {
                    radioLakilaki.Checked = true;
                }
                else
                {
                    radioPerempuan.Checked = true;
                }

                comboBoxTujuan.SelectedIndex = (int)AppState.Profil.Tujuan;

                numericUpDownUsia.Value = AppState.Profil.Usia;
                numericUpDownBB.Value = (decimal)AppState.Profil.BeratBadan;
                numericUpDownTB.Value = (decimal)AppState.Profil.TinggiBadan;
            }
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            Gender gender = radioLakilaki.Checked ? Gender.Lakilaki : Gender.Perempuan;

            UserProfile profil = new UserProfile
            {
                Nama = textBoxNama.Text.Trim(),
                JenisKelamin = gender,
                BeratBadan = (float)numericUpDownBB.Value,
                TinggiBadan = (float)numericUpDownTB.Value,
                Usia = (int)numericUpDownUsia.Value,
                Tujuan = (TujuanGizi)Enum.Parse(typeof(TujuanGizi), comboBoxTujuan.SelectedItem.ToString())
            };

            Form1 mainForm = this.FindForm() as Form1;
            mainForm?.UpdateWelcomeMessage();

            if (!profil.IsValid())
            {
                MessageBox.Show("Data profil tidak valid. Pastikan semua field terisi dengan benar.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AppState.Profil = profil;
            AppState.HitungTarget();
            AppState.SaveData();

            
            labelStatus.Font = new Font(labelStatus.Font, FontStyle.Bold);
            labelStatus.Text = $"Disimpan! Kalori: {AppState.TargetKalori}Kcal | Protein: {AppState.TargetProtein}g";
        }

        private void buttonResetData_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Yakin ingin reset semua data?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                AppState.ResetRiwayat();
                File.Delete(AppState.FilePath);
                AppState.Profil = new UserProfile();
                AppState.SaveData();
                AppState.TargetKalori = 2000;
                AppState.TargetProtein = 60;
                MessageBox.Show("Semua data telah direset.");

                textBoxNama.Text = "";
                radioLakilaki.Checked = true;
                radioPerempuan.Checked = false;

                comboBoxTujuan.SelectedIndex = -1;
                numericUpDownUsia.Value = 0;
                numericUpDownBB.Value = 0;
                numericUpDownTB.Value = 0;

                Form1 mainForm = this.FindForm() as Form1;
                mainForm?.ResetWelcomeMessage();
            }
        }
    }
}
