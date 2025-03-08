namespace FormularioExamen
{
    partial class Form2
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
            this.validateTextBoxExamen1 = new ExamenEjemplo.ValidateTextBoxExamen();
            this.validateTextBoxExamen2 = new ExamenEjemplo.ValidateTextBoxExamen();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxAficiones = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.gbOpuesto = new System.Windows.Forms.GroupBox();
            this.rbMujer = new System.Windows.Forms.RadioButton();
            this.rbHombre = new System.Windows.Forms.RadioButton();
            this.rbMujerOp = new System.Windows.Forms.RadioButton();
            this.rbHombreOp = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbSexo.SuspendLayout();
            this.gbOpuesto.SuspendLayout();
            this.SuspendLayout();
            // 
            // validateTextBoxExamen1
            // 
            this.validateTextBoxExamen1.Location = new System.Drawing.Point(12, 31);
            this.validateTextBoxExamen1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.validateTextBoxExamen1.Multilinea = false;
            this.validateTextBoxExamen1.Name = "validateTextBoxExamen1";
            this.validateTextBoxExamen1.Size = new System.Drawing.Size(122, 42);
            this.validateTextBoxExamen1.TabIndex = 0;
            this.validateTextBoxExamen1.Texto = "";
            this.validateTextBoxExamen1.Tipo = ExamenEjemplo.ValidateTextBoxExamen.eTipo.TEXTUAL;
            // 
            // validateTextBoxExamen2
            // 
            this.validateTextBoxExamen2.Location = new System.Drawing.Point(12, 93);
            this.validateTextBoxExamen2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.validateTextBoxExamen2.Multilinea = false;
            this.validateTextBoxExamen2.Name = "validateTextBoxExamen2";
            this.validateTextBoxExamen2.Size = new System.Drawing.Size(122, 42);
            this.validateTextBoxExamen2.TabIndex = 1;
            this.validateTextBoxExamen2.Texto = "";
            this.validateTextBoxExamen2.Tipo = ExamenEjemplo.ValidateTextBoxExamen.eTipo.NUMERICO;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Edad";
            // 
            // cbxAficiones
            // 
            this.cbxAficiones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAficiones.FormattingEnabled = true;
            this.cbxAficiones.Location = new System.Drawing.Point(158, 32);
            this.cbxAficiones.Name = "cbxAficiones";
            this.cbxAficiones.Size = new System.Drawing.Size(121, 24);
            this.cbxAficiones.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Afición";
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.rbHombre);
            this.gbSexo.Controls.Add(this.rbMujer);
            this.gbSexo.Location = new System.Drawing.Point(158, 93);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(200, 100);
            this.gbSexo.TabIndex = 6;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo";
            // 
            // gbOpuesto
            // 
            this.gbOpuesto.Controls.Add(this.rbHombreOp);
            this.gbOpuesto.Controls.Add(this.rbMujerOp);
            this.gbOpuesto.Location = new System.Drawing.Point(158, 209);
            this.gbOpuesto.Name = "gbOpuesto";
            this.gbOpuesto.Size = new System.Drawing.Size(200, 100);
            this.gbOpuesto.TabIndex = 7;
            this.gbOpuesto.TabStop = false;
            this.gbOpuesto.Text = "Sexo Opuesto";
            // 
            // rbMujer
            // 
            this.rbMujer.AutoSize = true;
            this.rbMujer.Location = new System.Drawing.Point(6, 31);
            this.rbMujer.Name = "rbMujer";
            this.rbMujer.Size = new System.Drawing.Size(61, 20);
            this.rbMujer.TabIndex = 0;
            this.rbMujer.TabStop = true;
            this.rbMujer.Text = "Mujer";
            this.rbMujer.UseVisualStyleBackColor = true;
            // 
            // rbHombre
            // 
            this.rbHombre.AutoSize = true;
            this.rbHombre.Location = new System.Drawing.Point(6, 57);
            this.rbHombre.Name = "rbHombre";
            this.rbHombre.Size = new System.Drawing.Size(77, 20);
            this.rbHombre.TabIndex = 1;
            this.rbHombre.TabStop = true;
            this.rbHombre.Text = "Hombre";
            this.rbHombre.UseVisualStyleBackColor = true;
            // 
            // rbMujerOp
            // 
            this.rbMujerOp.AutoSize = true;
            this.rbMujerOp.Location = new System.Drawing.Point(6, 31);
            this.rbMujerOp.Name = "rbMujerOp";
            this.rbMujerOp.Size = new System.Drawing.Size(61, 20);
            this.rbMujerOp.TabIndex = 2;
            this.rbMujerOp.TabStop = true;
            this.rbMujerOp.Text = "Mujer";
            this.rbMujerOp.UseVisualStyleBackColor = true;
            // 
            // rbHombreOp
            // 
            this.rbHombreOp.AutoSize = true;
            this.rbHombreOp.Location = new System.Drawing.Point(6, 57);
            this.rbHombreOp.Name = "rbHombreOp";
            this.rbHombreOp.Size = new System.Drawing.Size(77, 20);
            this.rbHombreOp.TabIndex = 3;
            this.rbHombreOp.TabStop = true;
            this.rbHombreOp.Text = "Hombre";
            this.rbHombreOp.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(372, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Foto";
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(478, 30);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 10;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(16, 390);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(114, 390);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gbOpuesto);
            this.Controls.Add(this.gbSexo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxAficiones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.validateTextBoxExamen2);
            this.Controls.Add(this.validateTextBoxExamen1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.gbOpuesto.ResumeLayout(false);
            this.gbOpuesto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ExamenEjemplo.ValidateTextBoxExamen validateTextBoxExamen1;
        private ExamenEjemplo.ValidateTextBoxExamen validateTextBoxExamen2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxAficiones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.RadioButton rbHombre;
        private System.Windows.Forms.RadioButton rbMujer;
        private System.Windows.Forms.GroupBox gbOpuesto;
        private System.Windows.Forms.RadioButton rbHombreOp;
        private System.Windows.Forms.RadioButton rbMujerOp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}