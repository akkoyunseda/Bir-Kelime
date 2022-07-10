using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirKelime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        string[] harfler = new string[8];

        private void btngetir_Click(object sender, EventArgs e)
        {
            string[] dizi = { "A", "B", "C", "Ç", "D", "E", "F", "G", "Ğ", "H", "I", "İ", "J", "K", "L", "M", "N", "O", "Ö", "P", "R", "S", "Ş", "T", "U", "Ü", "V", "Y", "Z" };
            

           btnharf1.Text = dizi[rnd.Next(0, dizi.Length)];
           btnharf2.Text = dizi[rnd.Next(0, dizi.Length)];
           btnharf3.Text = dizi[rnd.Next(0, dizi.Length)];
           btnharf4.Text = dizi[rnd.Next(0, dizi.Length)];
           btnharf5.Text = dizi[rnd.Next(0, dizi.Length)];
           btnharf6.Text = dizi[rnd.Next(0, dizi.Length)];
           btnharf7.Text = dizi[rnd.Next(0, dizi.Length)];
           btnharf8.Text = dizi[rnd.Next(0, dizi.Length)];

            harfler[0] = btnharf1.Text;
            harfler[1] = btnharf2.Text;
            harfler[2] = btnharf3.Text;
            harfler[3] = btnharf4.Text;
            harfler[4] = btnharf5.Text;
            harfler[5] = btnharf6.Text;
            harfler[6] = btnharf7.Text;
            harfler[7] = btnharf8.Text;
           


           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] dizi = { "A", "B", "C", "D", "E", "F", "G", "Ğ", "H", "I", "İ", "J", "K", "L", "M", "N", "O", "Ö", "P", "R", "S", "Ş", "T", "U", "Ü", "V", "Y", "Z" };

            btnjoker.Text = dizi[rnd.Next(0, dizi.Length)];

           
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            string dosya_yolu = @"C:\Users\akkoy\Desktop\kelimeler.txt";
            string[] words = System.IO.File.ReadAllLines(dosya_yolu, Encoding.GetEncoding("windows-1254"));

           
        }
    }
}
