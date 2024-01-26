using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneMhrsProgramı
{
    class DbHelper
    {
        private static string _connectionString;
        public static void ReadSettings()
        {
            string yol = Path.Combine(Application.StartupPath, "connection.txt");
            _connectionString = File.ReadAllText(yol);
        }
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = _connectionString;
            try
            {
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu.\n{ex.Message}");
                return null;
            }
        }
        public static List<string> GetKategoriList()
        {
            var list = new List<string>();
            var conn = GetConnection();
            if (conn is null) return list;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select  Ad from Poliklinik order by Ad";
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                list.Add(dr["Ad"].ToString());
            }
            dr.Close();
            conn.Close();

            return list;
        }
        internal static void AddRandevu(Randevu Hastane)
        {
            var conn = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into Randevu (Ad, Soyad, Tarih, Aciklama,Doktor,Branş) values(@Ad, @Soyad, @Tarih, @Aciklama,@Doktor,@Branş)";
            cmd.Parameters.AddWithValue("@Ad", Hastane.Ad);
            cmd.Parameters.AddWithValue("@Soyad", Hastane.Soyad);
            cmd.Parameters.AddWithValue("@Tarih", Hastane.Tarih);
            cmd.Parameters.AddWithValue("@Aciklama", Hastane.Aciklama);
            cmd.Parameters.AddWithValue("@Doktor", Hastane.Doktor);
            cmd.Parameters.AddWithValue("@Branş", Hastane.Branş);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        internal static void AddHekim(Hekim hekim)
        {
            var conn = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into Hekim (Ad, Soyad, Branş) values(@Ad, @Soyad, @Branş)";
            cmd.Parameters.AddWithValue("@Ad", hekim.Ad);
            cmd.Parameters.AddWithValue("@Soyad", hekim.Soyad);
            cmd.Parameters.AddWithValue("@Branş", hekim.Branş);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static List<string> GetDoktorList(string branş)
        {
            var list = new List<string>();
            var conn = GetConnection();
            if (conn is null) return list;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = $"select * from Hekim where Branş='{branş}'";
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                var str = $"{dr["Ad"]} {dr["Soyad"]}";
                list.Add(str);

            }
            dr.Close();
            conn.Close();

            return list;
        }
        public static List<Randevu> GetRandevuList()
        {
            var list = new List<Randevu>();
            var conn = GetConnection();
            if (conn is null) return list;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select HastaId,Ad,Soyad,Branş,Tarih,Aciklama,Doktor from Randevu order by HastaId desc";

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                var Hastane = new Randevu()
                {
                    HastaId = Convert.ToInt32(dr["HastaId"]),
                    Ad = dr["Ad"].ToString(),
                    Soyad = dr["Soyad"].ToString(),
                    Branş = dr["Branş"].ToString(),
                    Tarih = Convert.ToDateTime(dr["Tarih"]),
                    Aciklama = dr["Aciklama"].ToString(),
                    Doktor = dr["Doktor"].ToString(),
                };
                list.Add(Hastane);
            }
            dr.Close();
            conn.Close();

            return list;

        }
        internal static void AddPoliklinik(Randevu randevu)
        {
            var conn = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into Poliklinik (Ad) values(@Ad)";
            cmd.Parameters.AddWithValue("@Ad", randevu.Ad);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
