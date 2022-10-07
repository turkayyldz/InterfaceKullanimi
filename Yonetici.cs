using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceKullanimi
{
   public  class Yonetici : Calisan
    {
        private int sorumluKisiSayisi;
        public Yonetici(int id , string isim , string soyisim , int sorumluKisiSayisi):base (id,isim,soyisim)
        {
            this.sorumluKisiSayisi = sorumluKisiSayisi;
        }
        public void zamYap(int ZamMiktari)
        {
            Console.WriteLine(getIsim() + " " + ZamMiktari + " " + " TL çalışanlara zam yapıyor....");
        }
    }
}
