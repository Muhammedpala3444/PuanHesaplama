using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TYT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double tdogru, tyanlis,tnet,mdogru,myanlis,mnet,sdogru,syanlis,snet,fdogru,fyanlis,fnet;
            double sonuc;
            tdogru = Convert.ToDouble(textBox1.Text);
            tyanlis = Convert.ToDouble(textBox2.Text);
            mdogru = Convert.ToDouble(textBox4.Text);
            myanlis = Convert.ToDouble(textBox3.Text);
            sdogru = Convert.ToDouble(textBox6.Text);
            syanlis = Convert.ToDouble(textBox5.Text);
            fdogru = Convert.ToDouble(textBox8.Text);
            fyanlis = Convert.ToDouble(textBox7.Text);

            if (tyanlis>=1)
                {
                tyanlis = tyanlis * 0.25;
               
                    tdogru = tdogru - tyanlis;
                
                    textBox9.Text = tdogru.ToString();
                }
            else
            {
                textBox9.Text = tdogru.ToString();

            }
            if (myanlis >= 1)
            {
                myanlis = myanlis * 0.25;

                mdogru = mdogru - myanlis;

                textBox10.Text = mdogru.ToString();
            }
            else
            {
                textBox10.Text = mdogru.ToString();

            }
            if (syanlis >= 1)
            {
                syanlis = syanlis * 0.25;

                sdogru = sdogru - syanlis;

                textBox11.Text = sdogru.ToString();
            }
            else
            {
                textBox11.Text = sdogru.ToString();

            }
            if (fyanlis >= 1)
            {
                fyanlis = fyanlis * 0.25;

                fdogru = fdogru - fyanlis;

                textBox12.Text = fdogru.ToString();
            }
            else
            {
                textBox12.Text = fdogru.ToString();

            }
            tnet = Convert.ToDouble(textBox9.Text);
            mnet = Convert.ToDouble(textBox10.Text);
            snet = Convert.ToDouble(textBox11.Text);
            fnet = Convert.ToDouble(textBox12.Text);
            sonuc = 100.160 + (tnet * 1.999) + (snet * 1) + (mnet * 3.998) + (fnet * 2.999);
            label18.Text = sonuc.ToString();


        }
    }
}
