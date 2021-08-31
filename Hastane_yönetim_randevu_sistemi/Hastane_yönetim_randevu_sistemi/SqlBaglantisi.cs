using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Hastane_yönetim_randevu_sistemi
{
    class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source = SCARFACE\\SQLEXPRESS; Initial Catalog = HastaneProje; Integrated Security = True");
            baglan.Open();
            return baglan;
        }
    }
}
