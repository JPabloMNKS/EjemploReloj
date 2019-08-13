using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCE2Reloj
{
    public partial class Form1 : Form
    {
        int seg = 0, min = 0, hora = 0, min1=0, min2=0,hora1=0,hora2=0;

        private void BajarMinuto(object sender, EventArgs e)
        {
            min--;
            if (min >= 10)
            {
                min1 = min / 10;
                min2 = min % 10;
                pictureBox4.Load("digito_" + min1 + ".gif");
                pictureBox5.Load("digito_" + min2 + ".gif");
            }
            else if (min < 0)
            {
                min = 59;
                min1 = min / 10;
                min2 = min % 10;
                pictureBox4.Load("digito_" + min1 + ".gif");
                pictureBox5.Load("digito_" + min2 + ".gif");
            }
            else if (min < 10)
            {
                min1 = 0;
                pictureBox4.Load("digito_" + min1 + ".gif");
                pictureBox5.Load("digito_" + min + ".gif");
            }
        }

        private void SubirMinuto(object sender, EventArgs e)
        {
            min++;
            if (min > 59)
            {
                min = 0;
                pictureBox4.Load("digito_" + min + ".gif");
                pictureBox5.Load("digito_" + min + ".gif");
            }
            else if (min >= 10)
            {
                min1 = min / 10;
                min2 = min % 10;
                pictureBox4.Load("digito_" + min1 + ".gif");
                pictureBox5.Load("digito_" + min2 + ".gif");
            }
            else if (min < 10)
            {
                min1 = 0;
                pictureBox4.Load("digito_" + min1 + ".gif");
                pictureBox5.Load("digito_" + min + ".gif");
            }
        }

        private void BajarHora(object sender, EventArgs e)
        {
            hora--;
            if (hora >= 10)
            {
                hora1 = hora / 10;
                hora2 = hora % 10;
                pictureBox1.Load("digito_" + hora1 + ".gif");
                pictureBox2.Load("digito_" + hora2 + ".gif");
            }
            else if (hora < 0)
            {
                hora = 23;
                hora1 = hora / 10;
                hora2 = hora % 10;
                pictureBox1.Load("digito_" + hora1 + ".gif");
                pictureBox2.Load("digito_" + hora2 + ".gif");
            }
            else if (hora < 10)
            {
                hora1 = 0;
                pictureBox1.Load("digito_" + hora1 + ".gif");
                pictureBox2.Load("digito_" + hora + ".gif");
            }

        }

        private void SubirHora(object sender, EventArgs e)
        {
            hora = hora + 1;
            if (hora > 23)
            {
                hora = 0;
                pictureBox1.Load("digito_" + hora + ".gif");
                pictureBox2.Load("digito_" + hora + ".gif");
            }
            else if (hora >= 10)
            {
                hora1 = hora / 10;
                hora2 = hora % 10;
                pictureBox1.Load("digito_" + hora1 + ".gif");
                pictureBox2.Load("digito_" + hora2 + ".gif");
            }
            else if (hora < 10)
            {
                hora1 = 0;
                pictureBox1.Load("digito_" + hora1 + ".gif");
                pictureBox2.Load("digito_" + hora + ".gif");
            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "INICIO")
            {
                timer1.Enabled = true;
                button5.Text = "PARAR";
            }
            else
            {
                timer1.Enabled = false;
                button5.Text = "INICIO";
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (seg < 60)
            {
                if(seg %2 == 0)
                {
                    pictureBox3.Visible = false;
                    seg++;
                }
                else
                {
                    pictureBox3.Visible = true;
                    seg++;
                }
            }

            else if (min < 59)
            {
                min++;
                seg = 0;

                if(min >= 10)
                {
                    min1 = min / 10;
                    min2 = min % 10;
                    pictureBox4.Load("digito_" + min1 + ".gif");
                    pictureBox5.Load("digito_" + min2 + ".gif");
                }
                else if(min<10)
                {
                    min1 = 0;
                    pictureBox4.Load("digito_" + min1 + ".gif");
                    pictureBox5.Load("digito_" + min + ".gif");
                }
            }

            else if (hora < 23)
            {
                hora++;
                seg = 0;
                min = 0;
                min1 = 0;
                pictureBox4.Load("digito_" + min1 + ".gif");
                pictureBox5.Load("digito_" + min + ".gif");
                if (hora >= 10)
                {
                    hora1 = hora / 10;
                    hora2 = hora % 10;
                    pictureBox1.Load("digito_" + hora1 + ".gif");
                    pictureBox2.Load("digito_" + hora2 + ".gif");
                }
                else if(hora <10)
                {
                    hora1 = 0;
                    pictureBox1.Load("digito_" + hora1 + ".gif");
                    pictureBox2.Load("digito_" + hora + ".gif");
                }
            }
            else
            {
                hora = 0;
                hora1 = 0;
                hora2 = 0;
                min = 0;
                min1 = 0;
                min2 = 0;
                seg = 0;
                pictureBox1.Load("digito_" + hora1 + ".gif");
                pictureBox2.Load("digito_" + hora2 + ".gif");
                pictureBox4.Load("digito_" + min1 + ".gif");
                pictureBox5.Load("digito_" + min2 + ".gif");

            }
        }
    }
}
