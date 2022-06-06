using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_12._01_KullanıcıTanımlama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] dizi = new string[4];

        private void girişbtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                if (ıdtxt.Text == dizi[i] && şifretxt.Text== dizi[i+1])
                {
                    label1.Visible = false;
                    label2.Visible = false;
                    ıdtxt.Visible = false;
                    şifretxt.Visible = false;
                    girişbtn.Visible = false;
                    yenibtn.Visible = false;
                    label3.Visible = true;
                    çıkışbtn.Visible = true;
                    MessageBox.Show("Giriş Başarılı..");
                    ıdtxt.Clear();
                    şifretxt.Clear();
                    break;
                }
                else if(ıdtxt.Text == dizi[i+2] && şifretxt.Text == dizi[i + 3])
                {
                    label1.Visible = false;
                    label2.Visible = false;
                    ıdtxt.Visible = false;
                    şifretxt.Visible = false;
                    girişbtn.Visible = false;
                    yenibtn.Visible = false;
                    label3.Visible = true;
                    çıkışbtn.Visible = true;
                    MessageBox.Show("Giriş Başarılı..");
                    ıdtxt.Clear();
                    şifretxt.Clear();
                    break;
                }
                else
                {
                    girişbtn.Visible = false;
                    yenibtn.Visible = true;
                    ıdtxt.Clear();
                    şifretxt.Clear();
                    MessageBox.Show("Böyle bir kullanıcı yoktur.\nKullanıcı oluşturunuz.");
                    break;
                }
            }
        }
        byte a=0;
        private void yenibtn_Click(object sender, EventArgs e)
        {
            if (a>=3)
            {
                MessageBox.Show("Kullanıcı Limiti Bitmiştir....");
                yenibtn.Visible = false;
                girişbtn.Visible = true;
                ıdtxt.Clear();
                şifretxt.Clear();
            }
            else
            {
                dizi[a] = ıdtxt.Text;
                a++;
                dizi[a] = şifretxt.Text;
                a++;
                MessageBox.Show("Kullanıcı Oluşturuldu...");
                girişbtn.Visible = true;
                yenibtn.Visible = false;
                ıdtxt.Clear();
                şifretxt.Clear();
            }
        }

        private void şifretxt_TextChanged(object sender, EventArgs e)
        {
            //şifretxt.PasswordChar = '*';
        }

        private void ıdtxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void çıkışbtn_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            ıdtxt.Visible = true;
            şifretxt.Visible = true;
            girişbtn.Visible = true;
            yenibtn.Visible = true;
            label3.Visible = false;
            çıkışbtn.Visible = false;
            yenibtn.Visible = false;
        }
    }
}
