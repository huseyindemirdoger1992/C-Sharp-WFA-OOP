using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_WFA_OOP.OOP
{
    public class Matematik : Ceviri
    {
        public double Topla(double S1, double S2)
        {
            double Sonuc = S1 + S2;
            return Sonuc;
        }

        public double Fark(double S1, double S2)
        {
            double Sonuc = S1 - S2;
            return Sonuc;
        }

        public double Carp(double S1, double S2)
        {
            double Sonuc = S1 * S2;
            return Sonuc;
        }

        public double Bol(double S1, double S2)
        {
            double Sonuc = S1 / S2;
            return Sonuc;
        }


    }
}
