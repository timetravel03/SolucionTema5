using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolucionTema5
{
    public partial class ValidateTextBox : UserControl
    {
        private Pen pen;
        private bool ultimoCambioDeEvaluacion;

        [Category("Mis Propiedades")]
        [Description("Texto del textbox interno")]
        public string Texto
        {
            set
            {
                textBox1.Text = value;
            }
            get
            {
                return textBox1.Text;
            }
        }

        [Category("Mis Propiedades")]
        [Description("Accede al Multiline del textbox interno")]
        public bool Multilinea
        {
            set
            {
                textBox1.Multiline = value;
            }
            get
            {
                return textBox1.Multiline;
            }
        }

        [Category("Mis Eventos")]
        [Description("Se lanza cuando el texto de la textbox cambia")]
        public event EventHandler TextoCambiado;

        public enum eTipo
        {
            Numérico,
            Textual
        }

        private eTipo tipo;
        [Category("Mis Propiedades")]
        [Description("Tipo de dato que acepta el textbox")]
        public eTipo Tipo
        {
            set
            {
                tipo = value;
                textBox1_TextChanged(this, EventArgs.Empty);
                this.Refresh();
            }
            get
            {
                return tipo;
            }
        }

        public ValidateTextBox()
        {
            InitializeComponent();
            this.Height = this.textBox1.Height + 20;
            this.textBox1.Width = this.Width - 20;
            pen = new Pen(Color.Red, 5);
            ultimoCambioDeEvaluacion = false;
        }

        private void ValidateTextBox_SizeChanged(object sender, EventArgs e)
        {
            this.Height = this.textBox1.Height + 20;
            this.textBox1.Width = this.Width - 20;
        }

        private bool EsValido()
        {
            if (textBox1.Text.Trim() != "")
            {
                return Tipo == eTipo.Numérico ? int.TryParse(Texto.Trim(), out int n) : EvaluarTexto();
            } else
            {
                return false;
            }
        }

        private bool EvaluarTexto()
        {
            bool valido = true;
            foreach (char caracter in Texto)
            {
                if (!(char.IsLetter(caracter) || char.IsWhiteSpace(caracter)))
                {
                    valido = false;
                }
            }
            return valido;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            Graphics graphics = pe.Graphics;

            graphics.DrawRectangle(pen, new Rectangle(5, 5, textBox1.Width + 5, textBox1.Height + 5));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bool valido = EsValido();
            pen.Color = valido ? Color.Green : Color.Red;
            if (ultimoCambioDeEvaluacion != valido)
            {
                ultimoCambioDeEvaluacion = valido;
                this.Refresh();
            }
            TextoCambiado?.Invoke(sender, e);
        }
    }
}
