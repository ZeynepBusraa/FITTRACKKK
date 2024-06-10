using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitTrack
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            KullaniciTb.Text = "";
            SifreTb.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(KullaniciTb.Text=="" || SifreTb.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            } else if (KullaniciTb.Text=="Admin" && SifreTb.Text =="1234")
            {
                Anasayfa anasayfa = new Anasayfa();
                anasayfa.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
