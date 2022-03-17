using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_tabel
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Create();
        }

        public void Create()
        {
            SqlConnection con = null;
            try 
            {
                con = new SqlConnection("data source = (Sesuai dengan server name masing - masing) ;" +
                "database=ProdiTI;Integrated Securty = True");
                con.Open();

                SqlCommand cm = new SqlCommand("Create Table Mahasiswa (NIM Char(12) not null primary key, Nama Varchar(50), Alamat Varchar(50), Jenis_kelamin Varchar(5))", con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Create tabel berhasil");
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine("Error", e);
            }
            finally
            {
                con.Close();
            }

        }
    }

}
