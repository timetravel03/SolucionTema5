using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenEjemplo
{
    public partial class ValidateTextBoxExamen : UserControl
    {
        public enum eTipo { NUMERICO, TEXTUAL }

        private Color penColor;
        private eTipo tipo;

        public ValidateTextBoxExamen()
        {
            InitializeComponent();
            this.Height = textBox.Height + 20;
            textBox.Width = this.Width - 20;
            penColor = Color.Red;
        }

        [Category("Mis Propiedades")]
        [Description("Texto del textbox interno")]
        public string Texto
        {
            set
            {
                textBox.Text = value;
            }

            get
            {
                return textBox.Text;
            }
        }

        [Category("Mis Propiedades")]
        [Description("Propiedad multilínea del textbox")]
        public bool Multilinea
        {
            set
            {
                textBox.Multiline = value;
            }

            get
            {
                return textBox.Multiline;
            }
        }

        [Category("Mis Propiedades")]
        [Description("Tipo de dato que admite el textbox")]
        public eTipo Tipo
        {
            set
            {
                tipo = value;
                this.Refresh();
            }

            get
            {
                return tipo;
            }
        }

        private bool comprobar()
        {
            return (int.TryParse(Texto.Trim(), out int resultado) && Tipo == eTipo.NUMERICO) || (Array.TrueForAll(Texto.ToCharArray(), IsLetterOrWhiteSpace) && Tipo == eTipo.TEXTUAL);
        }

        private bool IsLetterOrWhiteSpace(char c)
        {
            return (Char.IsLetter(c) || Char.IsWhiteSpace(c));
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Graphics graphics = pe.Graphics;



            // nota importante, es que es logico, pero el alto y el ancho del rectangulo son longitudes no posiciones, por lo tanto si hago ancho-5 desde x=5 se sale del control, asi que ya que tener el cuenta la posicion inicial
            graphics.DrawRectangle(new Pen(penColor), 5, 5, this.Width - 10, this.Height - 10);
        }

        private void ValidateTextBoxExamen_Resize(object sender, EventArgs e)
        {
            this.Height = textBox.Height + 20;
            textBox.Width = this.Width - 20;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            OnCambiaTexto(sender, e);
            penColor = comprobar() ? Color.Green : Color.Red;
            this.Refresh();
        }

        [Category("Mis Eventos")]
        [Description("Se Produce cuando hay un cambio en el textbox")]
        public event EventHandler CambiaTexto;
        protected void OnCambiaTexto(object sender, EventArgs e)
        {
            CambiaTexto?.Invoke(sender, e);
        }
    }
}
