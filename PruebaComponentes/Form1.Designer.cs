namespace PruebaComponentes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.buttonPos = new System.Windows.Forms.Button();
            this.buttonSep = new System.Windows.Forms.Button();
            this.labelKeyUp = new System.Windows.Forms.Label();
            this.labelTxtChanged = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.labelSepararAviso = new System.Windows.Forms.Label();
            this.graficoBarras1 = new SolucionTema5.GraficoBarras();
            this.validateTextBox1 = new SolucionTema5.ValidateTextBox();
            this.dibujoAhorcado1 = new SolucionTema5.DibujoAhorcado();
            this.controlMultimedia1 = new SolucionTema5.ControlMultimedia();
            this.etiquetaAviso1 = new SolucionTema5.EtiquetaAviso();
            this.labelTextBox1 = new NuevosComponentes.LabelTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 109);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonPos
            // 
            this.buttonPos.Location = new System.Drawing.Point(12, 11);
            this.buttonPos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPos.Name = "buttonPos";
            this.buttonPos.Size = new System.Drawing.Size(135, 32);
            this.buttonPos.TabIndex = 2;
            this.buttonPos.Text = "Cambio Posicion";
            this.buttonPos.UseVisualStyleBackColor = true;
            this.buttonPos.UseWaitCursor = true;
            this.buttonPos.Click += new System.EventHandler(this.buttonPos_Click);
            // 
            // buttonSep
            // 
            this.buttonSep.Location = new System.Drawing.Point(12, 49);
            this.buttonSep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSep.Name = "buttonSep";
            this.buttonSep.Size = new System.Drawing.Size(75, 23);
            this.buttonSep.TabIndex = 3;
            this.buttonSep.Text = "Separar +";
            this.buttonSep.UseVisualStyleBackColor = true;
            this.buttonSep.UseWaitCursor = true;
            this.buttonSep.Click += new System.EventHandler(this.buttonSep_Click);
            // 
            // labelKeyUp
            // 
            this.labelKeyUp.AutoSize = true;
            this.labelKeyUp.Location = new System.Drawing.Point(121, 91);
            this.labelKeyUp.Name = "labelKeyUp";
            this.labelKeyUp.Size = new System.Drawing.Size(44, 16);
            this.labelKeyUp.TabIndex = 4;
            this.labelKeyUp.Text = "label1";
            this.labelKeyUp.UseWaitCursor = true;
            // 
            // labelTxtChanged
            // 
            this.labelTxtChanged.AutoSize = true;
            this.labelTxtChanged.Location = new System.Drawing.Point(12, 91);
            this.labelTxtChanged.Name = "labelTxtChanged";
            this.labelTxtChanged.Size = new System.Drawing.Size(44, 16);
            this.labelTxtChanged.TabIndex = 5;
            this.labelTxtChanged.Text = "label1";
            this.labelTxtChanged.UseWaitCursor = true;
            this.labelTxtChanged.Click += new System.EventHandler(this.labelTxtChanged_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 49);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Juntar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.UseWaitCursor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelSepararAviso
            // 
            this.labelSepararAviso.AutoSize = true;
            this.labelSepararAviso.Location = new System.Drawing.Point(71, 91);
            this.labelSepararAviso.Name = "labelSepararAviso";
            this.labelSepararAviso.Size = new System.Drawing.Size(44, 16);
            this.labelSepararAviso.TabIndex = 7;
            this.labelSepararAviso.Text = "label1";
            this.labelSepararAviso.UseWaitCursor = true;
            // 
            // graficoBarras1
            // 
            this.graficoBarras1.EjeX = "X";
            this.graficoBarras1.EjeY = "F(X)";
            this.graficoBarras1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.graficoBarras1.Location = new System.Drawing.Point(307, 68);
            this.graficoBarras1.Modo = SolucionTema5.GraficoBarras.Ejes.AUTOMATICO;
            this.graficoBarras1.Name = "graficoBarras1";
            this.graficoBarras1.Nombre = null;
            this.graficoBarras1.Size = new System.Drawing.Size(463, 370);
            this.graficoBarras1.TabIndex = 12;
            this.graficoBarras1.TipoGrafica = SolucionTema5.GraficoBarras.Representacion.BARRAS;
            this.graficoBarras1.UseWaitCursor = true;
            this.graficoBarras1.Valores = new double[] {
        50D,
        24D,
        6D,
        2D,
        6D,
        12D,
        2D,
        5D,
        1D,
        2D,
        6D,
        9D,
        7D,
        14D,
        21D,
        14D,
        3D};
            // 
            // validateTextBox1
            // 
            this.validateTextBox1.Location = new System.Drawing.Point(364, 11);
            this.validateTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.validateTextBox1.Multilinea = false;
            this.validateTextBox1.Name = "validateTextBox1";
            this.validateTextBox1.Size = new System.Drawing.Size(180, 42);
            this.validateTextBox1.TabIndex = 11;
            this.validateTextBox1.Texto = "3";
            this.validateTextBox1.Tipo = SolucionTema5.ValidateTextBox.eTipo.Numérico;
            this.validateTextBox1.UseWaitCursor = true;
            // 
            // dibujoAhorcado1
            // 
            this.dibujoAhorcado1.Errores = 11;
            this.dibujoAhorcado1.Location = new System.Drawing.Point(11, 136);
            this.dibujoAhorcado1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dibujoAhorcado1.Name = "dibujoAhorcado1";
            this.dibujoAhorcado1.Size = new System.Drawing.Size(332, 306);
            this.dibujoAhorcado1.TabIndex = 10;
            this.dibujoAhorcado1.Text = "dibujoAhorcado1";
            this.dibujoAhorcado1.UseWaitCursor = true;
            // 
            // controlMultimedia1
            // 
            this.controlMultimedia1.Location = new System.Drawing.Point(174, 42);
            this.controlMultimedia1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.controlMultimedia1.Minutos = 0;
            this.controlMultimedia1.Name = "controlMultimedia1";
            this.controlMultimedia1.Segundos = 50;
            this.controlMultimedia1.Size = new System.Drawing.Size(145, 60);
            this.controlMultimedia1.TabIndex = 9;
            this.controlMultimedia1.UseWaitCursor = true;
            // 
            // etiquetaAviso1
            // 
            this.etiquetaAviso1.ColorFin = System.Drawing.Color.Blue;
            this.etiquetaAviso1.ColorIni = System.Drawing.Color.LightBlue;
            this.etiquetaAviso1.Gradiente = true;
            this.etiquetaAviso1.ImagenMarca = null;
            this.etiquetaAviso1.Location = new System.Drawing.Point(93, 116);
            this.etiquetaAviso1.Marca = SolucionTema5.EtiquetaAviso.EMarca.Nada;
            this.etiquetaAviso1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.etiquetaAviso1.Name = "etiquetaAviso1";
            this.etiquetaAviso1.Size = new System.Drawing.Size(92, 16);
            this.etiquetaAviso1.TabIndex = 8;
            this.etiquetaAviso1.Text = "etiquetaAviso1";
            this.etiquetaAviso1.UseWaitCursor = true;
            // 
            // labelTextBox1
            // 
            this.labelTextBox1.Location = new System.Drawing.Point(153, 16);
            this.labelTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelTextBox1.Name = "labelTextBox1";
            this.labelTextBox1.Posicion = NuevosComponentes.LabelTextBox.EPosicion.IZQUIERDA;
            this.labelTextBox1.PswChr = '\0';
            this.labelTextBox1.Separacion = 0;
            this.labelTextBox1.Size = new System.Drawing.Size(190, 22);
            this.labelTextBox1.Subrayado = true;
            this.labelTextBox1.TabIndex = 0;
            this.labelTextBox1.TextLbl = "LabelTextBox";
            this.labelTextBox1.TextTxt = "";
            this.labelTextBox1.UseWaitCursor = true;
            this.labelTextBox1.SeparacionChanged += new System.EventHandler(this.labelTextBox1_SeparacionChanged);
            this.labelTextBox1.PosicionChanged += new System.EventHandler(this.labelTextBox1_PosicionChanged);
            this.labelTextBox1.TxtChanged += new System.EventHandler(this.labelTextBox1_TxtChanged);
            this.labelTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.labelTextBox1_KeyPress);
            this.labelTextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.labelTextBox1_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(782, 450);
            this.Controls.Add(this.graficoBarras1);
            this.Controls.Add(this.validateTextBox1);
            this.Controls.Add(this.dibujoAhorcado1);
            this.Controls.Add(this.controlMultimedia1);
            this.Controls.Add(this.etiquetaAviso1);
            this.Controls.Add(this.labelSepararAviso);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelTxtChanged);
            this.Controls.Add(this.labelKeyUp);
            this.Controls.Add(this.buttonSep);
            this.Controls.Add(this.buttonPos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelTextBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.UseWaitCursor = true;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NuevosComponentes.LabelTextBox labelTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonPos;
        private System.Windows.Forms.Button buttonSep;
        private System.Windows.Forms.Label labelKeyUp;
        private System.Windows.Forms.Label labelTxtChanged;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelSepararAviso;
        private SolucionTema5.EtiquetaAviso etiquetaAviso1;
        private SolucionTema5.ControlMultimedia controlMultimedia1;
        private SolucionTema5.DibujoAhorcado dibujoAhorcado1;
        private SolucionTema5.ValidateTextBox validateTextBox1;
        private SolucionTema5.GraficoBarras graficoBarras1;
    }
}

