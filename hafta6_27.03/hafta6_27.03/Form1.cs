using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta6_27._03
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //comboBox1.Items.Add("menu1");
            //comboBox1.Items.Add("menu2");
            //comboBox1.Items.Add("menu3");

            comboBox1.Items.AddRange(new object[]
            {
                "Mega King Menü (180 tl)",
                "Whooper Menü (150 tl)",
                "Chicken Royale Menü (160 tl)",
                "Big King Menü (140 tl)"
            });


            //comboBox2.Items.Add("Küçük boy menu");
            //comboBox2.Items.Add("Orta boy menu");
            //comboBox2.Items.Add("Büyük boy menu");

            comboBox2.Items.AddRange(new object[]
            {
                "Küçük",
                "Orta (+50 tl)",
                "Büyük (+70 tl)"
            });

            //listBox1.Items.Add("Su");
            //listBox1.Items.Add("Ayran +3 tl");
            //listBox1.Items.Add("Kola +5 tl");
            //listBox1.Items.Add("Ice tea +6 tl");
            //listBox1.Items.Add("Sprite +6 tl");

            listBox1.Items.AddRange(new object[]
            {
                "Su (10 tl)",
                "Ayran (30 tl)",
                "Kola (46 tl)",
                "Ice tea (45 tl)",
                "Sprite (46 tl)"
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tutar = 0;

            listBox2.Items.Clear();

            if (comboBox1.SelectedIndex == 0)
                tutar += 180;
            else if (comboBox1.SelectedIndex == 1)
                tutar += 150;
            else if (comboBox1.SelectedIndex == 2)
                tutar += 160;
            else if(comboBox1.SelectedIndex==3)
                tutar += 140;

            if (comboBox1.SelectedIndex >= 0)
                listBox2.Items.Add(comboBox1.SelectedItem);

            if (comboBox2.SelectedIndex == 1)
                tutar += 50;
            else if (comboBox2.SelectedIndex == 2)
                tutar += 70;

            if (comboBox2.SelectedIndex >= 0)
                listBox2.Items.Add(comboBox2.SelectedItem);

            if (listBox1.SelectedIndex == 0)
                tutar += 10;
            else if (listBox1.SelectedIndex == 1)
                tutar += 30;
            else if (listBox1.SelectedIndex == 3)
                tutar += 45;
            else if (listBox1.SelectedIndex == 2 || listBox1.SelectedIndex==4)
                tutar += 46;

            if (listBox1.SelectedIndex >= 0)
                listBox2.Items.Add(listBox1.SelectedItem);


            if (normalDilim.Checked)
            {
                tutar += 0;
                listBox2.Items.Add(normalDilim.Text);
            }
                
            else if (elmaDilim.Checked)
            {
                tutar += 20;
                listBox2.Items.Add(elmaDilim.Text);
            }


            string sos="";

            if (ketcap.Checked)
                sos += ketcap.Text + "-";
            if (mayonez.Checked)
                sos += mayonez.Text + "-";
            if (hardal.Checked)
            {
                tutar += 17;
                sos += hardal.Text + "-";
            }
            if(barbeku.Checked)
            {
                tutar += 20;
                sos += barbeku.Text + "-";
            }
            if(aciSos.Checked)
            {
                tutar += 15;
                sos += aciSos.Text + "-";
            }
            if(range.Checked)
            {
                tutar += 25;
                sos += range.Text + "-";
            }

            listBox2.Items.Add("Soslar: " + sos);

            textBox1.Text = tutar.ToString();

            MessageBox.Show("Siparişiniz alınmıştır");
                


        }

        
    }
}
