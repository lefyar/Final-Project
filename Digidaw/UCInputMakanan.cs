using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Digidaw
{
    public partial class UCInputMakanan : UserControl
    {
        private Dictionary<string, Makanan> daftarMakanan = new Dictionary<string, Makanan>()
        {
            { "Nasi Putih", new Makanan("Nasi Putih", 175, 3) },
            { "Ayam Goreng", new Makanan("Ayam Goreng", 250, 27) },
            { "Tempe Goreng", new Makanan("Tempe Goreng", 160, 8) },
            { "Telur Rebus", new Makanan("Telur Rebus", 78, 6) },
            { "Sayur Bayam", new Makanan("Sayur Bayam", 35, 2) }
        };

        public UCInputMakanan()
        {
            InitializeComponent();
            this.Load += UCInputMakanan_Load;
        }

        private void UCInputMakanan_Load(object sender, EventArgs e)
        {
            if (!AppState.SudahPunyaProfil)
            {
                MessageBox.Show("Anda harus mengisi profil terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            listViewMakanan.Items.Clear();

            listViewMakanan.Columns.Clear();
            listViewMakanan.Columns.Add("Makanan", 150);
            listViewMakanan.Columns.Add("Porsi", 70);
            listViewMakanan.Columns.Add("Kalori", 110);
            listViewMakanan.Columns.Add("Protein", 110);

            comboBoxMakanan.Items.Clear();
            foreach (var makanan in daftarMakanan)
            {
                comboBoxMakanan.Items.Add(makanan.Key);
            }

            comboBoxMakanan.SelectedIndex = 0;
            numericUpDownPorsi.Minimum = 1;
            numericUpDownPorsi.Value = 1;

            UpdateListViewMakanan();
            UpdateLabelDanProgress();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            string nama = comboBoxMakanan.SelectedItem?.ToString();
            int porsi = (int)numericUpDownPorsi.Value;

            if (string.IsNullOrEmpty(nama) || porsi <= 0 || !daftarMakanan.ContainsKey(nama))
            {
                MessageBox.Show("Data makanan tidak valid.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AppState.RiwayatMakanan.Add(new RiwayatMakanan
            {
                Nama = nama,
                Porsi = porsi,
                Tanggal = DateTime.Today
            });

            AppState.SaveData();
            UpdateListViewMakanan();
            UpdateLabelDanProgress();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Apakah anda ingin reset data makanan hari ini?", "Konfirmasi Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                AppState.RiwayatMakanan.RemoveAll(m => m.Tanggal == DateTime.Today);
                UpdateListViewMakanan();
                UpdateLabelDanProgress();
            }
        }

        private void UpdateListViewMakanan()
        {
            listViewMakanan.Items.Clear();
            var grupData = new Dictionary<string, (int porsi, int kalori, int protein)>();

            foreach (var item in AppState.RiwayatMakanan)
            {
                if (item.Tanggal == DateTime.Today && daftarMakanan.ContainsKey(item.Nama))
                {
                    var data = daftarMakanan[item.Nama];
                    int kal = data.KaloriPerPorsi * item.Porsi;
                    int pro = data.ProteinPerPorsi * item.Porsi;

                    if (!grupData.ContainsKey(item.Nama))
                        grupData[item.Nama] = (0, 0, 0);

                    var lama = grupData[item.Nama];
                    grupData[item.Nama] = (lama.porsi + item.Porsi, lama.kalori + kal, lama.protein + pro);
                }
            }

            foreach (var entry in grupData)
            {
                var item = new ListViewItem(entry.Key);
                item.SubItems.Add(entry.Value.porsi.ToString());
                item.SubItems.Add(entry.Value.kalori.ToString());
                item.SubItems.Add(entry.Value.protein.ToString());
                listViewMakanan.Items.Add(item);
            }
        }

        private void UpdateLabelDanProgress()
        {
            int totalKalori = 0;
            int totalProtein = 0;

            foreach (var item in AppState.RiwayatMakanan)
            {
                if (item.Tanggal == DateTime.Today && daftarMakanan.ContainsKey(item.Nama))
                {
                    var data = daftarMakanan[item.Nama];
                    totalKalori += data.KaloriPerPorsi * item.Porsi;
                    totalProtein += data.ProteinPerPorsi * item.Porsi;
                }
            }

            labelTotalKalori.Text = $"Total Kalori: {totalKalori}Kcal / {AppState.TargetKalori}Kcal";
            labelTotalProtein.Text = $"Total Protein: {totalProtein}g / {AppState.TargetProtein}g";

            progressBarKalori.Maximum = AppState.TargetKalori;
            progressBarKalori.Value = Math.Min(totalKalori, AppState.TargetKalori);

            progressBarProtein.Maximum = AppState.TargetProtein;
            progressBarProtein.Value = Math.Min(totalProtein, AppState.TargetProtein);
        }
    }
}
