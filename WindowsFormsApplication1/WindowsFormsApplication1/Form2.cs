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
    public partial class Form2 : Form
    {
        int indirimOranı;
        string tur;
        public int getIndirimOrani()
        {
            return indirimOranı;
        }
        public String getIndirimturu()
        {
            return tur;
        }

        public void setFilmAdı(String ad)
        {
            this.label2.Text = ad;
 
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            switch (index)
            {
                case 0:
                    indirimOranı = 30;
                    tur = "Öğrenci";
                    break;
                case 1:
                    indirimOranı = 10;
                    tur = "Öğretmen";
                    break;
                case 2:
                    indirimOranı = 15;
                    tur = "Emekli";
                    break;
                
            }

            this.Close();
        }

      
    }
}
