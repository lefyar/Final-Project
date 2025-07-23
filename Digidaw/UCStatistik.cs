using System;
using System.Windows.Forms.DataVisualization.Charting;
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
    public partial class UCStatistik: UserControl
    {
        public UCStatistik()
        {
            InitializeComponent();
        }

        private void UCStatistik_Load(object sender, EventArgs e)
        {
            LoadChart();
        }

        private void LoadChart()
        {
            chartStatistik.Series.Clear();

            if (chartStatistik.ChartAreas.Count == 0)
                chartStatistik.ChartAreas.Add(new ChartArea());

            chartStatistik.ChartAreas[0].AxisX.Title = "Tanggal";
            chartStatistik.ChartAreas[0].AxisY.Title = "Jumlah (Kalori / Protein)";
            chartStatistik.ChartAreas[0].AxisX.Interval = 1;

            chartStatistik.Titles.Clear();
            chartStatistik.Titles.Add("Statistik Konsumsi Gizi");
            chartStatistik.Titles[0].Font = new Font("Segoe UI", 12, FontStyle.Bold);
            chartStatistik.Titles[0].ForeColor = Color.DarkSlateBlue;

            var kaloriSeries = new Series("Kalori")
            {
                ChartType = SeriesChartType.Line,
                Color = Color.Red,
                BorderWidth = 2,
                IsValueShownAsLabel = true,
                ToolTip = "Kalori: #VAL"
            };

            var proteinSeries = new Series("Protein")
            {
                ChartType = SeriesChartType.Line,
                Color = Color.Blue,
                BorderWidth = 2,
                IsValueShownAsLabel = true,
                ToolTip = "Protein: #VAL"
            };

            // Tentukan batas waktu berdasarkan radio
            DateTime? batasTanggal = null;
            if (radio7Hari.Checked)
                batasTanggal = DateTime.Today.AddDays(-6);
            else if (radio30Hari.Checked)
                batasTanggal = DateTime.Today.AddDays(-29);
            // radioSemua → batasTanggal tetap null

            var dataFilter = AppState.RiwayatMakanan
                .Where(m => !batasTanggal.HasValue || m.Tanggal >= batasTanggal.Value)
                .GroupBy(m => m.Tanggal.Date)
                .OrderBy(g => g.Key)
                .Select(g => new
                {
                    Tanggal = g.Key,
                    TotalKalori = g.Sum(x => AppState.DaftarMakanan.ContainsKey(x.Nama)
                        ? AppState.DaftarMakanan[x.Nama].KaloriPerPorsi * x.Porsi : 0),
                    TotalProtein = g.Sum(x => AppState.DaftarMakanan.ContainsKey(x.Nama)
                        ? AppState.DaftarMakanan[x.Nama].ProteinPerPorsi * x.Porsi : 0)
                });

            foreach (var data in dataFilter)
            {
                string tanggal = data.Tanggal.ToShortDateString();
                kaloriSeries.Points.AddXY(tanggal, data.TotalKalori);
                proteinSeries.Points.AddXY(tanggal, data.TotalProtein);
            }

            chartStatistik.Series.Add(kaloriSeries);
            chartStatistik.Series.Add(proteinSeries);
        }


        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            if (radio30Hari.Checked || radio7Hari.Checked || radioSemua.Checked)
            {
                LoadChart();
            }
            else
            {
                MessageBox.Show("Pilih rentang waktu terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void radio7Hari_CheckedChanged(object sender, EventArgs e)
        {
            LoadChart();
        }

        private void radio30Hari_CheckedChanged(object sender, EventArgs e)
        {
            LoadChart();
        }

        private void radioSemua_CheckedChanged(object sender, EventArgs e)
        {
            LoadChart();
        }

        private void buttonGenerateDummy_Click(object sender, EventArgs e)
        {
            DummyDataGenerator.GenerateDummyData();
            MessageBox.Show("Dummy data berhasil dibuat!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AppState.LoadData();
            Form1 mainForm = this.FindForm() as Form1;
            mainForm?.UpdateWelcomeMessage();
        }
    }
}
