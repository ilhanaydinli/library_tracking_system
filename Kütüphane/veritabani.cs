using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Kütüphane
{
    class veritabani
    {
        public SQLiteConnection baglanti = new SQLiteConnection("Data Source=db/kutuphane.db3");
    }
}
