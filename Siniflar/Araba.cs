using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar
{
    class Araba:ArabaDetay
    {
        public string renk;
        public int hiz;
        public double motor;
        public char durum;
        public int fiyat;
        private int yil; //erişemeyiz bunlara private ise
        private string marka;

        //istedigimiz formatta erişebilmek için bir erişim belirteyici tanımladık

        public int YIL
        {
            get { return yil; } 
            //geri deger döndürürz return ile
            set { yil = Math.Abs(value); }
            //abs mutlak degerdir yılın ın mutlagını aldık 
        }


        public string MARKASI
        {
            get { return marka; }
            set { marka = value.ToUpper(); }
            //gelen değerin hepsini büyük değere cevirdik
        }

    }
}
