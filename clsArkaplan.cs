using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjeFinal
{
    class clsArkaplan
    {
        public static System.Drawing.Bitmap bg ;
        SqlConnection baglanti = new SqlConnection("Data Source=EMRE\\SQLEXPRESS;Initial Catalog=cafe;Integrated Security=True");
        public void arkaplan()
        {
            SqlCommand cek = new SqlCommand("SELECT IMAGE FROM arkaplan WHERE ID='1'", baglanti);
            baglanti.Open();
            SqlDataReader reader = cek.ExecuteReader();
            while (reader.Read())
            {
                var d = reader["IMAGE"].ToString();
                if (d == "1")
                    bg = Properties.Resources.Background1;
                else if (d == "2")
                    bg = Properties.Resources.Background2;
                else if (d == "3")
                    bg = Properties.Resources.Background3;
                else if (d == "4")
                    bg = Properties.Resources.Background4;
                else if (d == "5")
                    bg = Properties.Resources.Background5;
            }
            baglanti.Close();
        }
    }
}
