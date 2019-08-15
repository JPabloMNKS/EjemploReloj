namespace TCE2Reloj
{
    partial class RelojDigital
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelojDigital));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinizar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.Reloj = new MetroFramework.Controls.MetroTabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.punto = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.abajoMin = new System.Windows.Forms.PictureBox();
            this.arribaMin = new System.Windows.Forms.PictureBox();
            this.abajoHora = new System.Windows.Forms.PictureBox();
            this.arribaHora = new System.Windows.Forms.PictureBox();
            this.picture = new System.Windows.Forms.PictureBox();
            this.Temporizador = new MetroFramework.Controls.MetroTabPage();
            this.apagarAlarma = new System.Windows.Forms.Button();
            this.segundoTEM = new System.Windows.Forms.Label();
            this.minutoTem = new System.Windows.Forms.Label();
            this.horaTem = new System.Windows.Forms.Label();
            this.borrarTEM = new System.Windows.Forms.Button();
            this.iniTEM = new System.Windows.Forms.Button();
            this.textBoxSegundo = new System.Windows.Forms.TextBox();
            this.textBoxMinuto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxHora = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cronometro = new MetroFramework.Controls.MetroTabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.playCR = new System.Windows.Forms.PictureBox();
            this.Vuelta = new System.Windows.Forms.Button();
            this.SegundoCR = new System.Windows.Forms.Label();
            this.MinutoCR = new System.Windows.Forms.Label();
            this.HoraCR = new System.Windows.Forms.Label();
            this.vueltaTextCR = new System.Windows.Forms.RichTextBox();
            this.Reiniciar = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timerTEM = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.Reloj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.punto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abajoMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arribaMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abajoHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arribaHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.Temporizador.SuspendLayout();
            this.Cronometro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playCR)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.btnMinizar);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 80);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseUp);
            // 
            // btnMinizar
            // 
            this.btnMinizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMinizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btnMinizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnMinizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinizar.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMinizar.Location = new System.Drawing.Point(640, 0);
            this.btnMinizar.Name = "btnMinizar";
            this.btnMinizar.Size = new System.Drawing.Size(80, 80);
            this.btnMinizar.TabIndex = 2;
            this.btnMinizar.Text = "-";
            this.btnMinizar.UseVisualStyleBackColor = true;
            this.btnMinizar.Click += new System.EventHandler(this.BtnMinizar_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(720, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 80);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.Reloj);
            this.metroTabControl1.Controls.Add(this.Temporizador);
            this.metroTabControl1.Controls.Add(this.Cronometro);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 80);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(800, 370);
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            // 
            // Reloj
            // 
            this.Reloj.Controls.Add(this.button2);
            this.Reloj.Controls.Add(this.punto);
            this.Reloj.Controls.Add(this.pictureBox5);
            this.Reloj.Controls.Add(this.pictureBox4);
            this.Reloj.Controls.Add(this.pictureBox2);
            this.Reloj.Controls.Add(this.pictureBox1);
            this.Reloj.Controls.Add(this.abajoMin);
            this.Reloj.Controls.Add(this.arribaMin);
            this.Reloj.Controls.Add(this.abajoHora);
            this.Reloj.Controls.Add(this.arribaHora);
            this.Reloj.Controls.Add(this.picture);
            this.Reloj.HorizontalScrollbarBarColor = true;
            this.Reloj.HorizontalScrollbarHighlightOnWheel = false;
            this.Reloj.HorizontalScrollbarSize = 10;
            this.Reloj.Location = new System.Drawing.Point(4, 38);
            this.Reloj.Name = "Reloj";
            this.Reloj.Size = new System.Drawing.Size(792, 328);
            this.Reloj.TabIndex = 0;
            this.Reloj.Text = "Reloj";
            this.Reloj.VerticalScrollbarBarColor = true;
            this.Reloj.VerticalScrollbarHighlightOnWheel = false;
            this.Reloj.VerticalScrollbarSize = 10;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Window;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(690, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 35);
            this.button2.TabIndex = 13;
            this.button2.Text = "INICIO";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // punto
            // 
            this.punto.Image = ((System.Drawing.Image)(resources.GetObject("punto.Image")));
            this.punto.Location = new System.Drawing.Point(371, 137);
            this.punto.Name = "punto";
            this.punto.Size = new System.Drawing.Size(20, 47);
            this.punto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.punto.TabIndex = 12;
            this.punto.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(468, 111);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(65, 100);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(397, 111);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(65, 100);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(300, 111);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(229, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // abajoMin
            // 
            this.abajoMin.Image = ((System.Drawing.Image)(resources.GetObject("abajoMin.Image")));
            this.abajoMin.Location = new System.Drawing.Point(601, 165);
            this.abajoMin.Name = "abajoMin";
            this.abajoMin.Size = new System.Drawing.Size(61, 61);
            this.abajoMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.abajoMin.TabIndex = 7;
            this.abajoMin.TabStop = false;
            this.abajoMin.Click += new System.EventHandler(this.AbajoMin_Click);
            // 
            // arribaMin
            // 
            this.arribaMin.Image = ((System.Drawing.Image)(resources.GetObject("arribaMin.Image")));
            this.arribaMin.Location = new System.Drawing.Point(601, 98);
            this.arribaMin.Name = "arribaMin";
            this.arribaMin.Size = new System.Drawing.Size(61, 61);
            this.arribaMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arribaMin.TabIndex = 6;
            this.arribaMin.TabStop = false;
            this.arribaMin.Click += new System.EventHandler(this.ArribaMin_Click);
            // 
            // abajoHora
            // 
            this.abajoHora.Image = ((System.Drawing.Image)(resources.GetObject("abajoHora.Image")));
            this.abajoHora.Location = new System.Drawing.Point(108, 164);
            this.abajoHora.Name = "abajoHora";
            this.abajoHora.Size = new System.Drawing.Size(60, 60);
            this.abajoHora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.abajoHora.TabIndex = 5;
            this.abajoHora.TabStop = false;
            this.abajoHora.Click += new System.EventHandler(this.AbajoHora_Click);
            // 
            // arribaHora
            // 
            this.arribaHora.Image = ((System.Drawing.Image)(resources.GetObject("arribaHora.Image")));
            this.arribaHora.Location = new System.Drawing.Point(108, 98);
            this.arribaHora.Name = "arribaHora";
            this.arribaHora.Size = new System.Drawing.Size(60, 60);
            this.arribaHora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arribaHora.TabIndex = 4;
            this.arribaHora.TabStop = false;
            this.arribaHora.Click += new System.EventHandler(this.ArribaHora_Click);
            // 
            // picture
            // 
            this.picture.Image = ((System.Drawing.Image)(resources.GetObject("picture.Image")));
            this.picture.Location = new System.Drawing.Point(18, 10);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(766, 305);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 3;
            this.picture.TabStop = false;
            // 
            // Temporizador
            // 
            this.Temporizador.Controls.Add(this.apagarAlarma);
            this.Temporizador.Controls.Add(this.segundoTEM);
            this.Temporizador.Controls.Add(this.minutoTem);
            this.Temporizador.Controls.Add(this.horaTem);
            this.Temporizador.Controls.Add(this.borrarTEM);
            this.Temporizador.Controls.Add(this.iniTEM);
            this.Temporizador.Controls.Add(this.textBoxSegundo);
            this.Temporizador.Controls.Add(this.textBoxMinuto);
            this.Temporizador.Controls.Add(this.label6);
            this.Temporizador.Controls.Add(this.label5);
            this.Temporizador.Controls.Add(this.textBoxHora);
            this.Temporizador.Controls.Add(this.label4);
            this.Temporizador.Controls.Add(this.label3);
            this.Temporizador.Controls.Add(this.label2);
            this.Temporizador.Controls.Add(this.label1);
            this.Temporizador.HorizontalScrollbarBarColor = true;
            this.Temporizador.HorizontalScrollbarHighlightOnWheel = false;
            this.Temporizador.HorizontalScrollbarSize = 10;
            this.Temporizador.Location = new System.Drawing.Point(4, 38);
            this.Temporizador.Name = "Temporizador";
            this.Temporizador.Size = new System.Drawing.Size(792, 328);
            this.Temporizador.TabIndex = 1;
            this.Temporizador.Text = "Temporizador";
            this.Temporizador.VerticalScrollbarBarColor = true;
            this.Temporizador.VerticalScrollbarHighlightOnWheel = false;
            this.Temporizador.VerticalScrollbarSize = 10;
            // 
            // apagarAlarma
            // 
            this.apagarAlarma.BackColor = System.Drawing.Color.Red;
            this.apagarAlarma.FlatAppearance.BorderSize = 0;
            this.apagarAlarma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.apagarAlarma.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apagarAlarma.ForeColor = System.Drawing.SystemColors.Window;
            this.apagarAlarma.Location = new System.Drawing.Point(589, 96);
            this.apagarAlarma.Name = "apagarAlarma";
            this.apagarAlarma.Size = new System.Drawing.Size(134, 62);
            this.apagarAlarma.TabIndex = 16;
            this.apagarAlarma.Text = "APAGAR ALARMA";
            this.apagarAlarma.UseVisualStyleBackColor = false;
            this.apagarAlarma.Visible = false;
            this.apagarAlarma.Click += new System.EventHandler(this.ApagarAlarma_Click);
            // 
            // segundoTEM
            // 
            this.segundoTEM.AutoSize = true;
            this.segundoTEM.BackColor = System.Drawing.SystemColors.Window;
            this.segundoTEM.Font = new System.Drawing.Font("MV Boli", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.segundoTEM.Location = new System.Drawing.Point(393, 56);
            this.segundoTEM.Name = "segundoTEM";
            this.segundoTEM.Size = new System.Drawing.Size(120, 125);
            this.segundoTEM.TabIndex = 15;
            this.segundoTEM.Text = "0";
            // 
            // minutoTem
            // 
            this.minutoTem.AutoSize = true;
            this.minutoTem.BackColor = System.Drawing.SystemColors.Window;
            this.minutoTem.Font = new System.Drawing.Font("MV Boli", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutoTem.Location = new System.Drawing.Point(225, 56);
            this.minutoTem.Name = "minutoTem";
            this.minutoTem.Size = new System.Drawing.Size(120, 125);
            this.minutoTem.TabIndex = 14;
            this.minutoTem.Text = "0";
            // 
            // horaTem
            // 
            this.horaTem.AutoSize = true;
            this.horaTem.BackColor = System.Drawing.SystemColors.Window;
            this.horaTem.Font = new System.Drawing.Font("MV Boli", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horaTem.Location = new System.Drawing.Point(70, 56);
            this.horaTem.Name = "horaTem";
            this.horaTem.Size = new System.Drawing.Size(120, 125);
            this.horaTem.TabIndex = 13;
            this.horaTem.Text = "0";
            // 
            // borrarTEM
            // 
            this.borrarTEM.BackColor = System.Drawing.SystemColors.Window;
            this.borrarTEM.FlatAppearance.BorderSize = 0;
            this.borrarTEM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrarTEM.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrarTEM.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.borrarTEM.Location = new System.Drawing.Point(631, 250);
            this.borrarTEM.Name = "borrarTEM";
            this.borrarTEM.Size = new System.Drawing.Size(106, 42);
            this.borrarTEM.TabIndex = 12;
            this.borrarTEM.Text = "BORRAR";
            this.borrarTEM.UseVisualStyleBackColor = false;
            this.borrarTEM.Click += new System.EventHandler(this.BorrarTEM_Click);
            // 
            // iniTEM
            // 
            this.iniTEM.BackColor = System.Drawing.SystemColors.Window;
            this.iniTEM.FlatAppearance.BorderSize = 0;
            this.iniTEM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iniTEM.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iniTEM.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.iniTEM.Location = new System.Drawing.Point(519, 250);
            this.iniTEM.Name = "iniTEM";
            this.iniTEM.Size = new System.Drawing.Size(106, 42);
            this.iniTEM.TabIndex = 11;
            this.iniTEM.Text = "INICIAR";
            this.iniTEM.UseVisualStyleBackColor = false;
            this.iniTEM.Click += new System.EventHandler(this.IniTEM_Click);
            // 
            // textBoxSegundo
            // 
            this.textBoxSegundo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSegundo.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSegundo.Location = new System.Drawing.Point(451, 258);
            this.textBoxSegundo.Name = "textBoxSegundo";
            this.textBoxSegundo.Size = new System.Drawing.Size(35, 24);
            this.textBoxSegundo.TabIndex = 7;
            this.textBoxSegundo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMinuto
            // 
            this.textBoxMinuto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMinuto.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMinuto.Location = new System.Drawing.Point(273, 258);
            this.textBoxMinuto.Name = "textBoxMinuto";
            this.textBoxMinuto.Size = new System.Drawing.Size(35, 24);
            this.textBoxMinuto.TabIndex = 6;
            this.textBoxMinuto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(445, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "_______";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(267, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "_______";
            // 
            // textBoxHora
            // 
            this.textBoxHora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxHora.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHora.Location = new System.Drawing.Point(125, 258);
            this.textBoxHora.Name = "textBoxHora";
            this.textBoxHora.Size = new System.Drawing.Size(35, 24);
            this.textBoxHora.TabIndex = 5;
            this.textBoxHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(118, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "_______";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(163, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "MINUTOS:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "SEGUNDOS:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "HORAS: ";
            // 
            // Cronometro
            // 
            this.Cronometro.Controls.Add(this.button3);
            this.Cronometro.Controls.Add(this.playCR);
            this.Cronometro.Controls.Add(this.Vuelta);
            this.Cronometro.Controls.Add(this.SegundoCR);
            this.Cronometro.Controls.Add(this.MinutoCR);
            this.Cronometro.Controls.Add(this.HoraCR);
            this.Cronometro.Controls.Add(this.vueltaTextCR);
            this.Cronometro.Controls.Add(this.Reiniciar);
            this.Cronometro.HorizontalScrollbarBarColor = true;
            this.Cronometro.HorizontalScrollbarHighlightOnWheel = false;
            this.Cronometro.HorizontalScrollbarSize = 10;
            this.Cronometro.Location = new System.Drawing.Point(4, 38);
            this.Cronometro.Name = "Cronometro";
            this.Cronometro.Size = new System.Drawing.Size(792, 328);
            this.Cronometro.TabIndex = 2;
            this.Cronometro.Text = "Cronometro";
            this.Cronometro.VerticalScrollbarBarColor = true;
            this.Cronometro.VerticalScrollbarHighlightOnWheel = false;
            this.Cronometro.VerticalScrollbarSize = 10;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Window;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button3.Location = new System.Drawing.Point(399, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 42);
            this.button3.TabIndex = 12;
            this.button3.Text = "Vueltas";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // playCR
            // 
            this.playCR.Image = ((System.Drawing.Image)(resources.GetObject("playCR.Image")));
            this.playCR.Location = new System.Drawing.Point(124, 155);
            this.playCR.Name = "playCR";
            this.playCR.Size = new System.Drawing.Size(100, 99);
            this.playCR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.playCR.TabIndex = 11;
            this.playCR.TabStop = false;
            this.playCR.Click += new System.EventHandler(this.PlayCR_Click);
            // 
            // Vuelta
            // 
            this.Vuelta.BackColor = System.Drawing.SystemColors.Window;
            this.Vuelta.FlatAppearance.BorderSize = 0;
            this.Vuelta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Vuelta.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vuelta.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Vuelta.Location = new System.Drawing.Point(210, 260);
            this.Vuelta.Name = "Vuelta";
            this.Vuelta.Size = new System.Drawing.Size(106, 42);
            this.Vuelta.TabIndex = 9;
            this.Vuelta.Text = "Vuelta";
            this.Vuelta.UseVisualStyleBackColor = false;
            this.Vuelta.Click += new System.EventHandler(this.Vuelta_Click);
            // 
            // SegundoCR
            // 
            this.SegundoCR.AutoSize = true;
            this.SegundoCR.BackColor = System.Drawing.SystemColors.Window;
            this.SegundoCR.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SegundoCR.Location = new System.Drawing.Point(225, 61);
            this.SegundoCR.Name = "SegundoCR";
            this.SegundoCR.Size = new System.Drawing.Size(61, 63);
            this.SegundoCR.TabIndex = 8;
            this.SegundoCR.Text = "0";
            // 
            // MinutoCR
            // 
            this.MinutoCR.AutoSize = true;
            this.MinutoCR.BackColor = System.Drawing.SystemColors.Window;
            this.MinutoCR.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinutoCR.Location = new System.Drawing.Point(147, 61);
            this.MinutoCR.Name = "MinutoCR";
            this.MinutoCR.Size = new System.Drawing.Size(61, 63);
            this.MinutoCR.TabIndex = 7;
            this.MinutoCR.Text = "0";
            // 
            // HoraCR
            // 
            this.HoraCR.AutoSize = true;
            this.HoraCR.BackColor = System.Drawing.SystemColors.Window;
            this.HoraCR.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoraCR.Location = new System.Drawing.Point(71, 61);
            this.HoraCR.Name = "HoraCR";
            this.HoraCR.Size = new System.Drawing.Size(61, 63);
            this.HoraCR.TabIndex = 6;
            this.HoraCR.Text = "0";
            // 
            // vueltaTextCR
            // 
            this.vueltaTextCR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vueltaTextCR.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vueltaTextCR.Location = new System.Drawing.Point(417, 61);
            this.vueltaTextCR.Name = "vueltaTextCR";
            this.vueltaTextCR.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.vueltaTextCR.Size = new System.Drawing.Size(225, 241);
            this.vueltaTextCR.TabIndex = 5;
            this.vueltaTextCR.Text = "";
            // 
            // Reiniciar
            // 
            this.Reiniciar.BackColor = System.Drawing.SystemColors.Window;
            this.Reiniciar.FlatAppearance.BorderSize = 0;
            this.Reiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reiniciar.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reiniciar.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Reiniciar.Location = new System.Drawing.Point(26, 260);
            this.Reiniciar.Name = "Reiniciar";
            this.Reiniciar.Size = new System.Drawing.Size(106, 42);
            this.Reiniciar.TabIndex = 2;
            this.Reiniciar.Text = "Reiniciar";
            this.Reiniciar.UseVisualStyleBackColor = false;
            this.Reiniciar.Click += new System.EventHandler(this.Reiniciar_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // timerTEM
            // 
            this.timerTEM.Tick += new System.EventHandler(this.TimerTEM_Tick);
            // 
            // RelojDigital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RelojDigital";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RelojDigital";
            this.panel1.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.Reloj.ResumeLayout(false);
            this.Reloj.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.punto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abajoMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arribaMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abajoHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arribaHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.Temporizador.ResumeLayout(false);
            this.Temporizador.PerformLayout();
            this.Cronometro.ResumeLayout(false);
            this.Cronometro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playCR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage Reloj;
        private MetroFramework.Controls.MetroTabPage Temporizador;
        private MetroFramework.Controls.MetroTabPage Cronometro;
        private System.Windows.Forms.PictureBox abajoMin;
        private System.Windows.Forms.PictureBox arribaMin;
        private System.Windows.Forms.PictureBox abajoHora;
        private System.Windows.Forms.PictureBox arribaHora;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.PictureBox punto;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Vuelta;
        private System.Windows.Forms.Label SegundoCR;
        private System.Windows.Forms.Label MinutoCR;
        private System.Windows.Forms.Label HoraCR;
        private System.Windows.Forms.RichTextBox vueltaTextCR;
        private System.Windows.Forms.Button Reiniciar;
        private System.Windows.Forms.PictureBox playCR;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxHora;
        private System.Windows.Forms.TextBox textBoxSegundo;
        private System.Windows.Forms.TextBox textBoxMinuto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button iniTEM;
        private System.Windows.Forms.Button borrarTEM;
        private System.Windows.Forms.Timer timerTEM;
        private System.Windows.Forms.Button apagarAlarma;
        private System.Windows.Forms.Label segundoTEM;
        private System.Windows.Forms.Label minutoTem;
        private System.Windows.Forms.Label horaTem;
        private System.Windows.Forms.Button btnMinizar;
    }
}