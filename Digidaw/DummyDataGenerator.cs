using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Digidaw
{
    public static class DummyDataGenerator
    {
        public static void GenerateDummyData()
        {
            var dummyProfil = new UserProfile
            {
                Nama = "Reyfaldy",
                JenisKelamin = Gender.Lakilaki,
                Usia = 19,
                BeratBadan = 50,
                TinggiBadan = 175,
                Tujuan = TujuanGizi.Bulking
            };

            var dummyRiwayat = new List<RiwayatMakanan>();
            var makanan = new[] { "Nasi Putih", "Ayam Goreng", "Tempe Goreng", "Telur Rebus", "Sayur Bayam" };
            var rand = new Random();

            for (int i = 50; i >= 0; i--)
            {
                var tanggal = DateTime.Today.AddDays(-i);

                for (int j = 0; j < rand.Next(1, 4); j++)
                {
                    var nama = makanan[rand.Next(makanan.Length)];
                    var porsi = rand.Next(1, 3);
                    dummyRiwayat.Add(new RiwayatMakanan
                    {
                        Nama = nama,
                        Porsi = porsi,
                        Tanggal = tanggal
                    });
                }
            }

            var data = new appStateData
            {
                Profil = dummyProfil,
                RiwayatMakanan = dummyRiwayat
            };

            string json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(AppState.FilePath, json);
        }
    }

    public class appStateData
    {
        public UserProfile Profil { get; set; }
        public List<RiwayatMakanan> RiwayatMakanan { get; set; }
    }
}
