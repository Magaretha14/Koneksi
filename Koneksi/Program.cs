using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Koneksi
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Connecting();
        }

        public void Connecting()
        {
            using (
                SqlConnection conn = new SqlConnection("data source=LAPTOP-N3UNMQ7P;database=ProdiTI;user ID=sa;Password=Puput1414")
            )
            {
                conn.Open();
                Console.WriteLine("Berhasil terhubung ke database");
            }
        }
    }
}
