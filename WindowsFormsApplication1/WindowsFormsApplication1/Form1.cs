using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        String filmAdı;
        int oran;
        String tur;

        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBox1.Text = "25 TL";   
           
            textBox1.Enabled = false;
            this.filmAdı = listBox1.SelectedItem.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            
            frm2.setFilmAdı(this.filmAdı);
            frm2.ShowDialog();
                this.oran=frm2.getIndirimOrani();
                this.tur = frm2.getIndirimturu();
                double indirim = oran * (25.0 / 100);
                double fiyat = 25 - indirim;
                textBox1.Text = fiyat.ToString() + "TL";
                this.label3.Text = "Uygulanan İndirim Türü : "+tur;
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tebrikler," + filmAdı.ToUpper() + "filmine bilet aldiniz !");
        }

 
    }
}
