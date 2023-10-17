using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carpma_proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayi1, sayi2;

        int dogruSayisi = 0, yanlisSayisi = 0;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCevapVer_Click(object sender, EventArgs e)
        {
            int verilenCevap = Convert.ToInt32(txtCevap.Text);
            int cevap = sayi1 * sayi2;


            if (verilenCevap == cevap)
            {
                lblMesaj.Text = "Tebrikler...";
                dogruSayisi++;
            }
            else
            {
                lblMesaj.Text = "Cevabınız Hatalı!!!";
                yanlisSayisi++;

                listBox1.Items.Add(sayi1 + "X" + sayi2 + "=" + verilenCevap);

                MessageBox.Show("Doğru Cevap: " + cevap + " olmalı.");

            }

            txtSayi1.Text = "";
            txtSayi2.Text = "";
            txtCevap.Text = "";
            btnCevapVer.Enabled = false;
            btnYeni.Enabled = true;


            lblDogru.Text = "Doğru: " + dogruSayisi;
            lblYanlis.Text = "Yanlış: " + yanlisSayisi;



        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Random rnd=new Random();

            sayi1 = rnd.Next(5, 10);
            sayi2 = rnd.Next(5, 10);

            txtSayi1.Text=sayi1.ToString();
            txtSayi2.Text=sayi2.ToString();


            btnCevapVer.Enabled = true;
            btnYeni.Enabled = false;


        }
    }
}
