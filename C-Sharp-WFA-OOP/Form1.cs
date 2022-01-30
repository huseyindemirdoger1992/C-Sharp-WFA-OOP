using C_Sharp_WFA_OOP.OOP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_WFA_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // public her yerden erişilebilinir demek
        public void Mal() // Sadece Çağır ve işlem yapsın...
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
        }

        // private sadece kendi class'ı içinden ulaşılabileceği anlamına gelmektedir. Yani buradan başka yerde çalışmaz.
        private int Toplama(int S1, int S2) // Parametre(içerisine değer vermek) ver ve işleyip sana sonuç dönsün.
        {
            int Sonuc = S1 + S2;
            return Sonuc;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Değer döndürmeyen metot kullanımı
            // Mal();

            // Değer döndüren metot kullanınmı
            // textBox3.Text = Toplama(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();

            // Nesneden referans alma işlemi
            Matematik m = new Matematik();

            // Referans alınmış nesne üzerinden değer döndüren metot kullanınmı
            // textBox3.Text = m.Bol(double.Parse(textBox1.Text), double.Parse(textBox2.Text)).ToString();

            // Referans alınmış nesneye miras verilmiştir. O nesneden mirasa erişip değer döndüren metot kullandık.
            // textBox2.Text = m.MmToMt(double.Parse(textBox1.Text)).ToString();

        }
    }
}
