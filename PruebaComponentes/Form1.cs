using NuevosComponentes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaComponentes
{
    public partial class Form1 : Form// Ancho y pswchar
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Debug.WriteLine("Form1_Paint");
            //e.Graphics.DrawString("Hola Hola", this.Font, Brushes.BlueViolet, 10, 50);
            //e.Graphics.DrawLine(new Pen(Color.Green),10,50,100,100);

        }

        bool bandera = true;
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (bandera)
            {
                e.Graphics.DrawString("Mas texto", Font, Brushes.Blue, 10, 120);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //this.CreateGraphics().DrawString("Prueba de escritura de texto", this.Font, Brushes.BlueViolet, 10, 90);
            //this.CreateGraphics().DrawLine(new Pen(Color.Green), 10, 95, 100, 100);
            bandera = !bandera;
        }

        private void labelTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Text = "Letra: " + e.KeyChar;
        }

        private void buttonPos_Click(object sender, EventArgs e)
        {
            labelTextBox1.Posicion = (labelTextBox1.Posicion == LabelTextBox.EPosicion.IZQUIERDA) ? LabelTextBox.EPosicion.DERECHA : LabelTextBox.EPosicion.IZQUIERDA;
        }

        private void labelTextBox1_PosicionChanged(object sender, EventArgs e)
        {
            this.Text = labelTextBox1.Posicion.ToString();
        }

        private void labelTextBox1_SeparacionChanged(object sender, EventArgs e)
        {
            this.Text = "La separacion es ahora de " + labelTextBox1.Separacion;
        }

        private void buttonSep_Click(object sender, EventArgs e)
        {
            labelTextBox1.Separacion += 5;
            labelSepararAviso.Text = "";
        }

        private void labelTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            labelKeyUp.Text = "Se ha levantado la tecla " + e.KeyValue;
        }

        private void labelTextBox1_TxtChanged(object sender, EventArgs e)
        {
            labelTxtChanged.Text = labelTextBox1.TextTxt;
        }

        private void labelTxtChanged_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                labelTextBox1.Separacion -= 5;
            }
            catch (ArgumentOutOfRangeException)
            {
                labelSepararAviso.Text = "No se puede juntar más!";
            }

        }

        private void etiquetaAviso1_ClickEnMarca(object sender, MouseEventArgs e)
        {
            Console.WriteLine("Click en La Marca");
        }

        private void validateTextBox1_TextoCambiado(object sender, EventArgs e)
        {
            etiquetaAviso1.Text = validateTextBox1.Texto;
        }

        private void graficoBarras1_Load(object sender, EventArgs e)
        {

        }

        private void validateTextBoxExamen1_Load(object sender, EventArgs e)
        {

        }
    }
}
