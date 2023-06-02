using BelgeArsivYönetimSistemi.DOMAİN;
using BelgeArsivYönetimSistemi.SERVİCE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BelgeArsivYönetimSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new kullanıcıService()).kullanıcıKaydet(kAdTxt.Text, sifreTxt.Text, emailTxt.Text ,telefonTxt.Text, departmanTxt.Text, tcTxt.Text);
            kullanıcılarıGöster();
        }
        void kullanıcılarıGöster()
        {
            listBox1.Items.Clear();
            foreach( Kullanıcı k in (new kullanıcıService()).kullanıcılarıGetir())
            {
                listBox1.Items.Add(k);  
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kullanıcılarıGöster();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new kullanıcıService()).kullanıcıSil(((Kullanıcı)listBox1.SelectedItem).Id);
            kullanıcılarıGöster();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            (new evrakService()).evrakKaydet(eAdTxt.Text, KategoriTxt.Text, DetayTxt.Text, KTarihTxt.Text, KAlanAdTxt.Text, DolapNoTxt.Text, RafNoTxt.Text );
        }

        private void button9_Click(object sender, EventArgs e)
        {
            (new personelService()).personelKaydet(pAdTxt.Text, pSifreTxt.Text, pEmailTxt.Text, pTelefonTxt.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            (new emanetService()).emanetKaydet(eeAdTxt.Text, eaTarihTxt.Text, etTarihTxt.Text, etAAdTxt.Text, etATelTxt.Text, evKisiIdTxt.Text);
        }
        void emanetleriListele()
        {
            listBox2.Items.Clear(); 
            foreach(Emanet e in (new emanetService()).emanetleriListele())
            {
              listBox2.Items.Add(e);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            emanetleriListele();
        }
        void evraklarıtrhListele()
        {
            listBox3.Items.Clear();
            foreach(Evrak evrak in (new evrakService()).evraklarıtrhListele())
            {
                listBox3.Items.Add(evrak);
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            evraklarıtrhListele();
        }
    }
}
