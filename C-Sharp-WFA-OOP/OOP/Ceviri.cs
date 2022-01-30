using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_WFA_OOP.OOP
{
    public class Ceviri
    {
        public double MmToCm(double Deger)
        {
            double Sonuc = Deger / 10;
            return Sonuc;
        }

        public double MmToMt(double Deger)
        {
            double Sonuc = Deger / 100;
            return Sonuc;
        }
    }
}
