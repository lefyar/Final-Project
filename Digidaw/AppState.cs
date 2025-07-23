using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;

namespace Digidaw
{
    public enum Gender
    {
        Lakilaki,
        Perempuan
    }

    public enum TujuanGizi
    {
        Bulking,
        Maintain,
        Cutting
    }

    public class UserProfile
    {
        public string Nama { get; set; }
        public Gender JenisKelamin { get; set; }
        public int Usia { get; set; }
        public float BeratBadan { get; set; }
        public float TinggiBadan { get; set; }
        public TujuanGizi Tujuan { get; set; }

        public bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(Nama) && BeratBadan > 10 && TinggiBadan > 10 && Usia > 0;
        }
    }



    public static class AppState
    {
        public static Dictionary<string, Makanan> DaftarMakanan = new Dictionary<string, Makanan>()
        {
            { "Nasi Putih", new Makanan("Nasi Putih", 175, 3) },
            { "Ayam Goreng", new Makanan("Ayam Goreng", 250, 27) },
            { "Tempe Goreng", new Makanan("Tempe Goreng", 160, 8) },
            { "Telur Rebus", new Makanan("Telur Rebus", 78, 6) },
            { "Sayur Bayam", new Makanan("Sayur Bayam", 35, 2) }
        };

        public static UserProfile Profil { get; set; } = new UserProfile();
        public static bool SudahPunyaProfil => Profil.IsValid();
        public static readonly string FilePath = "data.json";


        public static List<RiwayatMakanan> RiwayatMakanan { get; set; } = new List<RiwayatMakanan>();

        public static int TargetKalori { get; set; } = 2000;
        public static int TargetProtein { get; set; } = 60;

        public static void SaveData()
        {
            var data = new AppStateData
            {
                Profil = Profil,
                RiwayatMakanan = RiwayatMakanan
            };

            string json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, json);
        }

        public static void LoadData()
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                var data = JsonSerializer.Deserialize<AppStateData>(json);
                if (data != null)
                {
                    Profil = data.Profil ?? new UserProfile();
                    RiwayatMakanan = data.RiwayatMakanan ?? new List<RiwayatMakanan>();
                    HitungTarget();
                }
            }
        }

        public static void HitungTarget()
        {
            if (!Profil.IsValid()) return;

            double bmr = 0;

            if (Profil.JenisKelamin == Gender.Lakilaki)
            {
                bmr = 10 * Profil.BeratBadan + 6.25 * Profil.TinggiBadan - 5 * Profil.Usia + 5;
            }
            else
            {
                bmr = 10 * Profil.BeratBadan + 6.25 * Profil.TinggiBadan - 5 * Profil.Usia - 161;
            }

            switch (Profil.Tujuan)
            {
                case TujuanGizi.Bulking:
                    bmr *= 1.2;
                    break;
                case TujuanGizi.Cutting:
                    bmr *= 0.8;
                    break;
                default:
                    break;
            }

            TargetKalori = (int)Math.Round(bmr);
            TargetProtein = (int)Math.Round(Profil.BeratBadan * 1.8);
        }

        public static void TambahMakanan(string nama, int porsi, DateTime tanggal)
        {
            var existing = RiwayatMakanan.FirstOrDefault(m => m.Nama == nama && m.Tanggal == tanggal);
            if (existing != null)
            {
                existing.Porsi += porsi;
            }
            else
            {
                RiwayatMakanan.Add(new RiwayatMakanan
                {
                    Nama = nama,
                    Porsi = porsi,
                    Tanggal = tanggal
                });
            }
        }

        public static void ResetRiwayat()
        {
            RiwayatMakanan.Clear();
        }
    }

    public class AppStateData
    {
        public UserProfile Profil { get; set; }
        public List<RiwayatMakanan> RiwayatMakanan { get; set; }
    }

    public class RiwayatMakanan
    {
        public string Nama { get; set; }
        public int Porsi { get; set; }
        public DateTime Tanggal { get; set; }
    }
}
