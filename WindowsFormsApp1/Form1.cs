using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int tutan = 0;
            int sayi1, sayi2, sayi3, sayi4, sayi5, sayi6 = 0;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            sayi3 = Convert.ToInt32(textBox3.Text);
            sayi4 = Convert.ToInt32(textBox4.Text);
            sayi5 = Convert.ToInt32(textBox5.Text);
            sayi6 = Convert.ToInt32(textBox6.Text);
            if (sayi1 < 0 || sayi1 >50 || sayi2 < 0 || sayi2 >50 || sayi3 < 0 || sayi3 >50 || sayi4 < 0 || sayi4 >50 || sayi5 < 0 || sayi5 > 50 || sayi6 < 0 || sayi6 > 50 )
            {
                MessageBox.Show("Lütfen 1-49 arası bir değer giriniz.");
            }
            else {

                Random r = new Random();
                int rastgele;
                int sayac = 0; //sayacı sıfıra eşitliyoruz.
                int[] sayilar = new int[6];  // 6 elemanlı dizi oluşturdum.
                while (sayac < 6)
                {
                    rastgele = r.Next(1, 50); //1 ile 49 arasında rastgele sayı üretidi.

                    if (Array.IndexOf(sayilar, rastgele) == -1)  //dizinin içinde aynı sayı yoksa
                    {
                        sayilar[sayac] = rastgele;
                        sayac++;
                    }

                }

                Array.Sort(sayilar);
                textBox7.Text = sayilar[0].ToString(); //Dizinin 1.elemanını label'a basar.
                textBox8.Text = sayilar[1].ToString(); 
                textBox9.Text = sayilar[2].ToString(); 
                textBox10.Text = sayilar[3].ToString(); 
                textBox11.Text = sayilar[4].ToString(); 
                textBox13.Text = sayilar[5].ToString(); 


                for (int i = 0; i < 6; i++) //GİRDİĞİMİZ DEĞERLER İLE RANDOM DEĞERLERİ KARŞILAŞTIRIYOR.
                {
                    if (textBox1.Text == sayilar[i].ToString())
                    {
                        tutan++;
                    }
                    else if (textBox2.Text == sayilar[i].ToString())
                    {
                        tutan++;
                    }
                    else if (textBox3.Text == sayilar[i].ToString())
                    {
                        tutan++;
                    }
                    else if (textBox4.Text == sayilar[i].ToString())
                    {
                        tutan++;
                    }
                    else if (textBox5.Text == sayilar[i].ToString())
                    {
                        tutan++;
                    }
                    else if (textBox6.Text == sayilar[i].ToString())
                    {
                        tutan++;
                    }
                }

                if (tutan >= 3) 
                {
                    MessageBox.Show("Kazandınız " + tutan.ToString() + " Tane Tutturdunuz.");
                }
                else
                {
                    MessageBox.Show("Kaybettiniz " + tutan + " Tane Tutturdunuz.");
                }

            }

            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
