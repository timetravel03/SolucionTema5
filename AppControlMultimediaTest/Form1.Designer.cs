namespace AppControlMultimediaTest
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnDirectorio = new System.Windows.Forms.Button();
            this.cbxIntervalo = new System.Windows.Forms.ComboBox();
            this.lblIntervalo = new System.Windows.Forms.Label();
            this.timerFotos = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerReproductor = new System.Windows.Forms.Timer(this.components);
            this.controlMultimedia1 = new SolucionTema5.ControlMultimedia();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDirectorio
            // 
            this.btnDirectorio.Location = new System.Drawing.Point(12, 12);
            this.btnDirectorio.Name = "btnDirectorio";
            this.btnDirectorio.Size = new System.Drawing.Size(141, 24);
            this.btnDirectorio.TabIndex = 0;
            this.btnDirectorio.Text = "Seccionar Directorio";
            this.btnDirectorio.UseVisualStyleBackColor = true;
            this.btnDirectorio.Click += new System.EventHandler(this.btnDirectorio_Click);
            // 
            // cbxIntervalo
            // 
            this.cbxIntervalo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIntervalo.FormattingEnabled = true;
            this.cbxIntervalo.Location = new System.Drawing.Point(12, 58);
            this.cbxIntervalo.Name = "cbxIntervalo";
            this.cbxIntervalo.Size = new System.Drawing.Size(141, 24);
            this.cbxIntervalo.TabIndex = 1;
            this.cbxIntervalo.SelectedIndexChanged += new System.EventHandler(this.cbxIntervalo_SelectedIndexChanged);
            // 
            // lblIntervalo
            // 
            this.lblIntervalo.AutoSize = true;
            this.lblIntervalo.Location = new System.Drawing.Point(12, 39);
            this.lblIntervalo.Name = "lblIntervalo";
            this.lblIntervalo.Size = new System.Drawing.Size(75, 16);
            this.lblIntervalo.TabIndex = 4;
            this.lblIntervalo.Text = "Intevalo (s):";
            // 
            // timerFotos
            // 
            this.timerFotos.Tick += new System.EventHandler(this.timerFotos_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(178, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(610, 426);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // timerReproductor
            // 
            this.timerReproductor.Tick += new System.EventHandler(this.timerReproductor_Tick);
            // 
            // controlMultimedia1
            // 
            this.controlMultimedia1.Location = new System.Drawing.Point(12, 378);
            this.controlMultimedia1.Minutos = 0;
            this.controlMultimedia1.Name = "controlMultimedia1";
            this.controlMultimedia1.Segundos = 0;
            this.controlMultimedia1.Size = new System.Drawing.Size(141, 60);
            this.controlMultimedia1.TabIndex = 3;
            this.controlMultimedia1.PlayClick += new System.EventHandler(this.controlMultimedia1_PlayClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblIntervalo);
            this.Controls.Add(this.controlMultimedia1);
            this.Controls.Add(this.cbxIntervalo);
            this.Controls.Add(this.btnDirectorio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Visor de Imágenes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDirectorio;
        private System.Windows.Forms.ComboBox cbxIntervalo;
        private SolucionTema5.ControlMultimedia controlMultimedia1;
        private System.Windows.Forms.Label lblIntervalo;
        private System.Windows.Forms.Timer timerFotos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerReproductor;
    }
}

