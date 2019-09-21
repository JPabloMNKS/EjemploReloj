using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCE2Reloj
{
    public partial class RelojDigital : Form
    {
        int seg = 0, min = 0, hora = 0, min1 = 0, min2 = 0, hora1 = 0, hora2 = 0;

        // Reloj
        private void AbajoMin_Click(object sender, EventArgs e)
        {
            min--;
            if (min >= 10)
            {
                min1 = min / 10;
                min2 = min % 10;
                pictureBox4.Load("num_" + min1 + ".jpg");
                pictureBox5.Load("num_" + min2 + ".jpg");
            }
            else if (min < 0)
            {
                min = 59;
                min1 = min / 10;
                min2 = min % 10;
                pictureBox4.Load("num_" + min1 + ".jpg");
                pictureBox5.Load("num_" + min2 + ".jpg");
            }
            else if (min < 10)
            {
                min1 = 0;
                pictureBox4.Load("num_" + min1 + ".jpg");
                pictureBox5.Load("num_" + min + ".jpg");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "INICIO")
            {
                timer1.Enabled = true;
                button2.Text = "PARAR";
            }
            else
            {
                timer1.Enabled = false;
                button2.Text = "INICIO";
            }
        }

        private void ArribaMin_Click(object sender, EventArgs e)
        {
            min++;
            if (min > 59)
            {
                min = 0;
                pictureBox4.Load("num_" + min + ".jpg");
                pictureBox5.Load("num_" + min + ".jpg");
            }
            else if (min >= 10)
            {
                min1 = min / 10;
                min2 = min % 10;
                pictureBox4.Load("num_" + min1 + ".jpg");
                pictureBox5.Load("num_" + min2 + ".jpg");
            }
            else if (min < 10)
            {
                min1 = 0;
                pictureBox4.Load("num_" + min1 + ".jpg");
                pictureBox5.Load("num_" + min + ".jpg");
            }
        }

        private void AbajoHora_Click(object sender, EventArgs e)
        {
            hora--;
            if (hora >= 10)
            {
                hora1 = hora / 10;
                hora2 = hora % 10;
                pictureBox1.Load("num_" + hora1 + ".jpg");
                pictureBox2.Load("num_" + hora2 + ".jpg");
            }
            else if (hora < 0)
            {
                hora = 23;
                hora1 = hora / 10;
                hora2 = hora % 10;
                pictureBox1.Load("num_" + hora1 + ".jpg");
                pictureBox2.Load("num_" + hora2 + ".jpg");
            }
            else if (hora < 10)
            {
                hora1 = 0;
                pictureBox1.Load("num_" + hora1 + ".jpg");
                pictureBox2.Load("num_" + hora + ".jpg");
            }
        }

        private void ArribaHora_Click(object sender, EventArgs e)
        {
            hora = hora + 1;
            if (hora > 23)
            {
                hora = 0;
                pictureBox1.Load("num_" + hora + ".jpg");
                pictureBox2.Load("num_" + hora + ".jpg");
            }
            else if (hora >= 10)
            {
                hora1 = hora / 10;
                hora2 = hora % 10;
                pictureBox1.Load("num_" + hora1 + ".jpg");
                pictureBox2.Load("num_" + hora2 + ".jpg");
            }
            else if (hora < 10)
            {
                hora1 = 0;
                pictureBox1.Load("num_" + hora1 + ".jpg");
                pictureBox2.Load("num_" + hora + ".jpg");
            }

        }

        public RelojDigital()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (seg < 60)
            {
                if (seg % 2 == 0)
                {
                    punto.Visible = false;
                    seg++;
                }
                else
                {
                    punto.Visible = true;
                    seg++;
                }
            }

            else if (min < 59)
            {
                min++;
                seg = 0;

                if (min >= 10)
                {
                    min1 = min / 10;
                    min2 = min % 10;
                    pictureBox4.Load("num_" + min1 + ".jpg");
                    pictureBox5.Load("num_" + min2 + ".jpg");
                }
                else if (min < 10)
                {
                    min1 = 0;
                    pictureBox4.Load("num_" + min1 + ".jpg");
                    pictureBox5.Load("num_" + min + ".jpg");
                }
            }

            else if (hora < 23)
            {
                hora++;
                seg = 0;
                min = 0;
                min1 = 0;
                pictureBox4.Load("num_" + min1 + ".jpg");
                pictureBox5.Load("num_" + min + ".jpg");
                if (hora >= 10)
                {
                    hora1 = hora / 10;
                    hora2 = hora % 10;
                    pictureBox1.Load("num_" + hora1 + ".jpg");
                    pictureBox2.Load("num_" + hora2 + ".jpg");
                }
                else if (hora < 10)
                {
                    hora1 = 0;
                    pictureBox1.Load("num_" + hora1 + ".jpg");
                    pictureBox2.Load("num_" + hora + ".jpg");
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
                pictureBox1.Load("num_" + hora1 + ".jpg");
                pictureBox2.Load("num_" + hora2 + ".jpg");
                pictureBox4.Load("num_" + min1 + ".jpg");
                pictureBox5.Load("num_" + min2 + ".jpg");
            }

            Bitmap bmp;
            Graphics g;
            bmp = new Bitmap(200, 200);
            g = Graphics.FromImage(bmp);


            // Segundero
            handCoord = msCoord(seg, secHAND);
            g.DrawLine(new Pen(Color.Red, 1f), new Point(100, 100), new Point(handCoord[0], handCoord[1]));
            // Minutero
            handCoord = msCoord(min, minHAND);
            g.DrawLine(new Pen(Color.Black, 3f), new Point(100, 100), new Point(handCoord[0], handCoord[1]));
            // Hora
            handCoord = hrCoord(hora%12,min, hrHAND);
            g.DrawLine(new Pen(Color.Black, 5f), new Point(100, 100), new Point(handCoord[0], handCoord[1]));

            picVacio.Image = bmp;
            g.Dispose();
        }

        int[] handCoord = new int[2];
        int secHAND = 100, minHAND = 85, hrHAND = 65;


        //coord for minute and second hand
        private int[] msCoord(int val, int hlen)
        {
            int[] coord = new int[2];
            val *= 6;   //each minute and second make 6 degree

            if (val >= 0 && val <= 180)
            {
                coord[0] = 100 + (int)(hlen * Math.Sin(Math.PI * val / 180));
                coord[1] = 100 - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            else
            {
                coord[0] = 100 - (int)(hlen * -Math.Sin(Math.PI * val / 180));
                coord[1] = 100 - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            return coord;
        }

        //coord for hour hand
        private int[] hrCoord(int hval, int mval, int hlen)
        {
            int[] coord = new int[2];

            //each hour makes 30 degree
            //each min makes 0.5 degree
            int val = (int)((hval * 30) + (mval * 0.5));

            if (val >= 0 && val <= 180)
            {
                coord[0] = 100 + (int)(hlen * Math.Sin(Math.PI * val / 180));
                coord[1] = 100 - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            else
            {
                coord[0] = 100 - (int)(hlen * -Math.Sin(Math.PI * val / 180));
                coord[1] = 100 - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            return coord;
        }




        // CRONOMETRO
        bool encendidoCR = false;
        int segCR = 0, minCR = 0, horaCR = 0, vueltasCR = 0;

        private void PlayCR_Click(object sender, EventArgs e)
        {
            if(encendidoCR == false)
            {
                playCR.Load("pausebutton1.png");
                timer2.Enabled = true;
                encendidoCR = true;
            }
            else
            {
                playCR.Load("playbutton.png");
                timer2.Enabled = false;
                encendidoCR = false;
            }
        }
        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (segCR < 59)
            {
                segCR++;
                SegundoCR.Text = segCR.ToString();
            }else if (minCR < 59)
            {
                minCR++;
                segCR = 0;
                SegundoCR.Text = segCR.ToString();
                MinutoCR.Text = minCR.ToString();
            }else if (horaCR < 23)
            {
                horaCR++;
                minCR = 0;
                segCR = 0;
                SegundoCR.Text = segCR.ToString();
                MinutoCR.Text = minCR.ToString();
                HoraCR2.Text = horaCR.ToString();
            }
            else
            {
                minCR = 0;
                segCR = 0;
                horaCR = 0;
                SegundoCR.Text = segCR.ToString();
                MinutoCR.Text = minCR.ToString();
                HoraCR2.Text = horaCR.ToString();
            }
        }

        private void Reiniciar_Click(object sender, EventArgs e)
        {
            minCR = 0;
            segCR = 0;
            horaCR = 0;
            vueltasCR = 0;
            SegundoCR.Text = segCR.ToString();
            MinutoCR.Text = minCR.ToString();
            HoraCR2.Text = horaCR.ToString();
            playCR.Load("playbutton.png");
            vueltaTextCR.Text += "------------------\n";
            encendidoCR = false;
            timer2.Enabled = false;
        }

        private void Vuelta_Click(object sender, EventArgs e)
        {
            
            vueltaTextCR.Text += "Vuelta #"+ ++vueltasCR +"   "+ HoraCR2.Text +" : " + MinutoCR.Text +" : "+ SegundoCR.Text+"\n";
        }


        // Arrastrar ventana
        Boolean draggable;
        int mouseX;
        int mouseY;
        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            draggable = true;
            mouseX = Cursor.Position.X - this.Left;
            mouseY = Cursor.Position.Y - this.Top;
        }
        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(draggable == true)
            {
                this.Top = Cursor.Position.Y - mouseY;
                this.Left = Cursor.Position.X - mouseX;
            }
        }
        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            draggable = false;
        }

        // TEMPORIZADOR

        SoundPlayer mp = new SoundPlayer();

        int segTEM = 0, horitaTem= 0, minTem=0;

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        bool sonando = true;


        int xyz = -1;

        private void RelojAnalogico_Click(object sender, EventArgs e)
        {

        }

        bool pausado = false;
//        bool borrado = false;
        private void IniTEM_Click(object sender, EventArgs e)
        {
            if(iniTEM.Text == "INICIAR")
            {
                if(pausado == false)
                {
                    try { segTEM = int.Parse(textBoxSegundo.Text); }
                    catch { segTEM = 0; }
                    try { minTem = int.Parse(textBoxMinuto.Text); }
                    catch { minTem = 0; }
                    try { horitaTem = int.Parse(textBoxHora.Text); }
                    catch { horitaTem = 0; }
                }
                segundoTEM.Text = segTEM.ToString();
                minutoTem.Text = minTem.ToString();
                horaTem.Text = horitaTem.ToString();
                limpiarTextBox();
                pausado = true;

                if (segTEM == 0 && minTem ==0 && horitaTem == 0 && pausado == true)
                {
                    timerTEM.Enabled = true;
                    sonando = true;
                    iniTEM.Text = "PARAR";
                }
                else if (segTEM == 0 && minTem == 0 && horitaTem == 0 && pausado == false)
                {
                    sonando = false;
                }
                else
                {
                    timerTEM.Enabled = true;
                    sonando = true;
                    iniTEM.Text = "PARAR";
                }
            }
            else
            {
                timerTEM.Enabled = false;
                iniTEM.Text = "INICIAR";
            }
        }
        private void TimerTEM_Tick(object sender, EventArgs e)
        {
            if (segTEM > 0)
            {
                segTEM--;
                segundoTEM.Text = segTEM.ToString();
            }
            else if(minTem > 0)
            {
                segTEM = 59;
                minTem--;
                segundoTEM.Text = segTEM.ToString();
                minutoTem.Text = minTem.ToString();
            }
            else if(horitaTem >0)
            {
                segTEM = 59;
                minTem = 59;
                horitaTem--;
                segundoTEM.Text = segTEM.ToString();
                minutoTem.Text = minTem.ToString();
                horaTem.Text = horitaTem.ToString();
            }
            else 
            {
                segTEM--;
                apagarAlarma.Visible = true;
                sonarAlarma(segTEM);
            }
        }

        private void ApagarAlarma_Click(object sender, EventArgs e)
        {
            sonando = false;
            apagarAlarma.Visible = false;
            timerTEM.Enabled = false;
            mp.Stop();
            segTEM = 0;
            xyz = -1;
            iniTEM.Text = "INICIAR";
        }

        private void sonarAlarma(int a)
        {
            if(a == xyz && sonando == true)
            {
                apagarAlarma.Visible = true;
                mp.SoundLocation = "alarm.WAV";
                mp.Play();
                xyz -= 38;
            }
        }
        private void BorrarTEM_Click(object sender, EventArgs e)
        {
            segTEM = 0;
            minTem = 0;
            horitaTem = 0;
            segundoTEM.Text = segTEM.ToString();
            minutoTem.Text = minTem.ToString();
            horaTem.Text = horitaTem.ToString();
            pausado = false;
//            borrado = true;
//            sonando = false;
            limpiarTextBox();
        }
        private void limpiarTextBox()
        {
            textBoxHora.Clear();
            textBoxMinuto.Clear();
            textBoxSegundo.Clear();
        }

//      CONTEXT MENU STRIP - NOTIFY ICON
        private void EsconderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void MostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        //
        private void prueba()
        {
            Bitmap bmp;
            Graphics g;
            bmp = new Bitmap(200, 200);
            g = Graphics.FromImage(bmp);
            int minHAND = 110;
            int mm = 100;
            

            int fda =  (int)(100 * Math.Sin(Math.PI * seg*6 / 180));
            int fdaa =  (int)(100 * Math.Cos(Math.PI * seg*6 / 180));

            int px1 = picVacio.Width / 2;
            int py1 = picVacio.Height / 2;

        //    int x = int.Parse(txtBoxX.Text);
          //  int y = int.Parse(txtBoxY.Text);


            // Segundero
            g.DrawLine(new Pen(Color.Black, 1f), new Point(100, 100), new Point(fda,fdaa));
            // Minutero
            g.DrawLine(new Pen(Color.Black, 3f), new Point(100, 100), new Point(340, 80));
            // Hora
            g.DrawLine(new Pen(Color.Black, 5f), new Point(100, 100), new Point(50, 120));

            

            picVacio.Image = bmp;
            g.Dispose();
//            picHora.Location= (new Point(4, 4), new Point(32, 23));


 //           picHora.Location = new Point(x,y);
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            prueba();
        }

    }
}
