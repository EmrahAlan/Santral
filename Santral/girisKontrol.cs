using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Santral
{

   
    class girisKontrol
    {
        
        public bool Giris (string login,string pwd)
        {
            var db = new SantralDbEntities();
            var user = db.TblKullanici.FirstOrDefault(u => u.KullaniciAdi == login && u.Sifre == pwd);

            if (user != null)
            {
                return true;
            }

            return false;
        }
    }
}
