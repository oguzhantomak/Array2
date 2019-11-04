using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOrnek1_Click(object sender, EventArgs e)
        {
            //İçeriğine sizin karar vereceğiniz bir sayısal dizi oluşturun ve bu dizinin en küçük - en büyük elmanını Mbox ile gösterin.
            
            int[] dizi = { 52,36,15,42,1,25,38,79};
            Array.Sort(dizi);
            MessageBox.Show($"Dizinin ilk elemanı: {dizi[0]}\nDizinin son elemanı: {dizi[dizi.Length-1]}");

        }
        string[] kayitlar = new string[0];
        private void BtnElemanEkle_Click(object sender, EventArgs e)
        {
            //Textboxtan girilen veri "kayıtlar" adlı diziye eklesin. Her yeni  kayıtta dizinin boyutu bir arttırılsın. Eleman eklendikten hemen sonra ise aşağıdaki formatta kayıt listbox'ta gösterilsin.
            //Format -> Eleman - ElemanIndex


            //string veri = textBox1.Text;
            //Array.Resize(ref kayitlar, adet);

            //kayitlar[index] = veri;
            //adet++;
            //index++;

            //listBox1.Items.Add($"{veri} - {index}");


            Array.Resize(ref kayitlar, kayitlar.Length + 1);
            kayitlar[kayitlar.Length - 1] = textBox1.Text;
            listBox1.Items.Add($"{kayitlar[kayitlar.Length - 1]} - {kayitlar.Length - 1}");

            
        }
    }
}
