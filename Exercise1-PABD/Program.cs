using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Exercise1_PABD
{
    class Program
    {
        public void CreateTabel()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=ZULFAAA;database=Exercise1;Integrated Security=TRUE");
                con.Open();

                SqlCommand ob = new SqlCommand("create table Nama_Obat(id_obat varchar(10) primary key," +
                    "nm_obat varchar(50), hrg_jual varchar(15), hrg_beli varchar(15), stts_obat char(1))", con);
                ob.ExecuteNonQuery();
                SqlCommand pt = new SqlCommand("create table Nama_Toko(id_toko varchar(15) primary key," +
                   "nm_toko varchar(20), almt_toko varchar(100), tlp_toko char(12))", con);
                pt.ExecuteNonQuery();
                SqlCommand pb = new SqlCommand("create table Pelanggan (id_plg char(3) primary key," +
                   "nm_plg varchar(30), jk_plg char(1), tlp_plg char(12), almt_plg varchar(100))", con);
                pb.ExecuteNonQuery();
                SqlCommand ts = new SqlCommand("create table Pegawai (id_user char(3) primary key," +
                  "nm_user varchar(30), pass_user char(8), stts_user char(1), id_obat varchar(10) foreign key references Nama_Obat(id_obat), id_toko varchar(15) foreign key references Nama_Toko(id_toko)," +
                  "id_plg char(3) foreign key references Pelanggan(id_plg))", con);
                ts.ExecuteNonQuery();

                Console.WriteLine("Tabel Berhasil Dibuat!!");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Perhatikan lagi ada yang salah!! " + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }
        public void InsertTabel()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=ZULFAAA;database=Exercise1;Integrated Security=TRUE");
                con.Open();

                SqlCommand ob1 = new SqlCommand("insert into Nama_Obat (id_obat, nm_obat, hrg_jual, hrg_beli, stts_obat)" +
                    "values('A01','Albumin','10.000', '15.000', 'M')", con);
                ob1.ExecuteNonQuery();
                SqlCommand ob2 = new SqlCommand("insert into Nama_Obat (id_obat, nm_obat, hrg_jual, hrg_beli, stts_obat)" +
                   "values('A02','Amoxicillin','20.000', '25.000', 'M')", con);
                ob2.ExecuteNonQuery();
                SqlCommand ob3 = new SqlCommand("insert into Nama_Obat (id_obat, nm_obat, hrg_jual, hrg_beli, stts_obat)" +
                   "values('A03','Arginine','30.000', '35.000', 'M')", con);
                ob3.ExecuteNonQuery();
                SqlCommand ob4 = new SqlCommand("insert into Nama_Obat (id_obat, nm_obat, hrg_jual, hrg_beli, stts_obat)" +
                   "values('A04','Ambroxol','40.000', '45.000', 'M')", con);
                ob4.ExecuteNonQuery();
                SqlCommand ob5 = new SqlCommand("insert into Nama_Obat (id_obat, nm_obat, hrg_jual, hrg_beli, stts_obat)" +
                   "values('A05','Acarbose','50.000', '55.000', 'M')", con);
                ob5.ExecuteNonQuery();

                SqlCommand pt1 = new SqlCommand("insert into Nama_Toko (id_toko, nm_toko, almt_toko, tlp_toko)" +
                    "values('B01','Apotek Momon','Bengkulu', '081377559034')", con);
                pt1.ExecuteNonQuery();

                SqlCommand pb1 = new SqlCommand("insert into Pelanggan (id_plg, nm_plg, jk_plg, tlp_plg, almt_plg)" +
                    "values('C01','Chika','P', '08755361918', 'Manna')", con);
                pb1.ExecuteNonQuery();
                SqlCommand pb2 = new SqlCommand("insert into Pelanggan (id_plg, nm_plg, jk_plg, tlp_plg, almt_plg)" +
                    "values('C02','Choky','L', '087553616234', 'Curup')", con);
                pb2.ExecuteNonQuery();
                SqlCommand pb3 = new SqlCommand("insert into Pelanggan (id_plg, nm_plg, jk_plg, tlp_plg, almt_plg)" +
                    "values('C03','Debay','P', '08755364645', 'Bintuhan')", con);
                pb3.ExecuteNonQuery();
                SqlCommand pb4 = new SqlCommand("insert into Pelanggan (id_plg, nm_plg, jk_plg, tlp_plg, almt_plg)" +
                    "values('C04','Icad','L', '08755362324', 'Bengkulu')", con);
                pb4.ExecuteNonQuery();
                SqlCommand pb5 = new SqlCommand("insert into Pelanggan (id_plg, nm_plg, jk_plg, tlp_plg, almt_plg)" +
                    "values('C05','Momon','P', '08755363344', 'Lebong')", con);
                pb5.ExecuteNonQuery();


                SqlCommand ts1 = new SqlCommand("insert into Pegawai (id_user, nm_user, pass_user, stts_user)" +
                    "values('D01','LALA','00002021','T')", con);
                ts1.ExecuteNonQuery();
                SqlCommand ts2 = new SqlCommand("insert into Pegawai (id_user, nm_user, pass_user, stts_user)" +
                     "values('D02','LULU','00002022','T')", con);
                ts2.ExecuteNonQuery();
                SqlCommand ts3 = new SqlCommand("insert into Pegawai (id_user, nm_user, pass_user, stts_user)" +
                    "values('D03','LOLO','00002023','T')", con);
                ts3.ExecuteNonQuery();
                SqlCommand ts4 = new SqlCommand("insert into Pegawai (id_user, nm_user, pass_user, stts_user)" +
                    "values('D04','LELE','00002024','T')", con);
                ts4.ExecuteNonQuery();
                SqlCommand ts5 = new SqlCommand("insert into Pegawai (id_user, nm_user, pass_user, stts_user)" +
                    "values('D05','LILI','00002025','T')", con);
                ts5.ExecuteNonQuery();
               
                Console.WriteLine("Sukses!!!");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Gagal Menginput data. " + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }
        public void TampilData()
        {
            while (true)
            {
                try
                {
                    int choose;
                    Console.WriteLine("Silahkan Pilih");
                    Console.WriteLine("==============");
                    Console.WriteLine("1. Membuat Tabel");
                    Console.WriteLine("2. Menginput Data");
                    Console.WriteLine("3. Keluar");
                    Console.Write("Pilih 1/2/3 = ");
                    choose = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(" ");

                    switch (choose)
                    {
                        case 1:
                            CreateTabel();
                            break;
                        case 2:
                            InsertTabel();
                            break;
                        default:
                            Console.WriteLine("Pilihan tidak tersedia");
                            break;


                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Silahkan pilih angka 1-3");
                }
            }
        }
        static void Main(string[] args)
        {
            Program z = new Program();
            z.TampilData();
        }
    }
}




