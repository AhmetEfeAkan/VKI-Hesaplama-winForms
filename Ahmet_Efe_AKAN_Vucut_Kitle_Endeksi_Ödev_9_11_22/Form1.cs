using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vucut_Kitle_Endeksi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                float agirlik, boy, VKİ;
                agirlik = Convert.ToSingle(textBox1.Text);
                boy = Convert.ToSingle(mstextBox2.Text);
                VKİ = agirlik / (boy * boy);
                labelVKI.Text = VKİ.ToString();
                if (VKİ < 18.5 )
                {
                    labelDRM.Text = "Zayıf";
                    labelVKI.ForeColor = Color.Red;
                    labelDRM.ForeColor = Color.Red;
                }
                else if (VKİ >= 18.5 && VKİ < 24.9)
                {
                    labelDRM.Text = "Normal";
                    labelVKI.ForeColor = Color.Lime;
                    labelDRM.ForeColor = Color.Lime;
                }
                else if (VKİ >= 24.9 && VKİ < 29.9)
                {
                    labelDRM.Text = "Kilolu";
                    labelVKI.ForeColor = Color.Orange;
                    labelDRM.ForeColor = Color.Orange;
                }
                else if (VKİ >= 29.9 && VKİ < 35)
                {
                    labelDRM.Text = "Obez";
                    labelVKI.ForeColor = Color.Red;
                    labelDRM.ForeColor = Color.Red;
                }
                else if (VKİ >= 35)
                {
                    labelDRM.Text = "Ciddi Obez";
                    labelVKI.ForeColor = Color.DarkRed;
                    labelDRM.ForeColor = Color.DarkRed;
                }
                else if(agirlik<=0&&boy<=0)
                {
                    labelVKI.Text = "Hatalı Giriş";
                    labelDRM.Text = "Hatalı Giriş";
                    labelVKI.ForeColor = Color.White;
                    labelDRM.ForeColor = Color.White;
                    MessageBox.Show("Lütfen Girdiğiniz Kütle/Boy Değerlerini\nKontrol Ediniz.", "Vücut Kütle İndeksi");
                }
                
            }
            catch
            {
                MessageBox.Show("Lütfen Girdiğiniz Kütle/Boy Değerlerini\nKontrol Ediniz.", "Vücut Kütle İndeksi");
            }
    }
    }
}
