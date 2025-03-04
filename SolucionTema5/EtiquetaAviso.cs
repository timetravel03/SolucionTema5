 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NuevosComponentes.LabelTextBox;

namespace SolucionTema5
{
    public partial class EtiquetaAviso : Control//Tipo Image, Propiedades para colores ini y fin, Revisar Nada. Refresh en imagen
    {
        int grosor = 0; //Grosor de las líneas de dibujo
        int offsetX = 0; //Desplazamiento a la derecha del texto
        int offsetY = 0; //Desplazamiento hacia abajo del texto
                         // Altura de fuente, usada como referencia en varias partes
        int h;

        private EMarca marca = EMarca.Nada;

        public enum EMarca
        {
            Nada, Cruz, Circulo, Imagen
        }

        public EtiquetaAviso()
        {
            InitializeComponent();
        }

        Color colorIni = Color.LightBlue;
        [Category("Appearence")]
        [Description("Color del inicio del gradiente")]
        public Color ColorIni
        {
            set
            {
                colorIni = value;
                this.Refresh();
            }
            get
            {
                return colorIni;
            }
        }

        Color colorFin = Color.Blue;
        [Category("Appearence")]
        [Description("Color del fin del gradiente")]
        public Color ColorFin
        {
            set
            {
                colorFin = value;
                this.Refresh();
            }
            get
            {
                return colorFin;
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Graphics g = pe.Graphics;
            h = this.Font.Height;
            //Esta propiedad provoca mejoras en la apariencia o en la eficiencia
            // a la hora de dibujar
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //Dependiendo del valor de la propiedad marca dibujamos una
            //Cruz o un Círculo

            // gradiente
            if (gradiente)
            {
                using (LinearGradientBrush lgb = new LinearGradientBrush(this.ClientRectangle, colorIni, colorFin, LinearGradientMode.Horizontal))
                {
                    g.FillRectangle(lgb, this.ClientRectangle);
                }
            }

            switch (Marca)
            {
                case EMarca.Circulo:
                    grosor = 20;
                    g.DrawEllipse(new Pen(Color.Green, grosor), grosor, grosor, h, h);
                    //g.DrawRectangle(new Pen(Color.Black, 1), grosor, grosor, h, h);
                    offsetX = h + grosor;
                    offsetY = grosor;
                    break;
                case EMarca.Cruz:
                    grosor = 3;
                    Pen lapiz = new Pen(Color.Red, grosor);
                    g.DrawLine(lapiz, grosor, grosor, h, h);
                    g.DrawLine(lapiz, h, grosor, grosor, h);
                    offsetX = h + grosor;
                    offsetY = grosor / 2;
                    lapiz.Dispose();
                    break;
                case EMarca.Imagen:
                    try
                    {
                        offsetX = Font.Height;
                        offsetY = 0;
                        g.DrawImage(imagenMarca, new Rectangle(2, 2, h, h));
                    }
                    catch (ArgumentException)
                    {
                        marca = EMarca.Nada;
                    }
                    break;
                case EMarca.Nada:
                    offsetX = 0;
                    offsetY = 0;
                    grosor = 0;
                    h = 0;
                    break;
            }

            //Finalmente pintamos el Texto; desplazado si fuera necesario
            SolidBrush b = new SolidBrush(this.ForeColor);
            g.DrawString(this.Text, this.Font, b, offsetX + grosor, offsetY);
            Size tam = g.MeasureString(this.Text, this.Font).ToSize();
            this.Size = new Size(tam.Width + offsetX + grosor, tam.Height + offsetY * 2);

            //g.DrawRectangle(new Pen(Color.Black, 1), 0, 0, (this.Width - 1), (this.Height - 1));
            b.Dispose();
        }



        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            this.Refresh();
        }

        [Category("Appearence")]
        [Description("Indica el tipo de marca que aparece junto al texto")]
        public EMarca Marca
        {
            set
            {
                if (Enum.IsDefined(typeof(EMarca), value))
                {
                    marca = value;
                    this.Refresh();
                }
                else
                {
                    throw new InvalidEnumArgumentException();
                }
            }
            get
            {
                return marca;
            }
        }

        private bool gradiente;
        [Category("Appearence")]
        [Description("Indica si aparece un gradiente")]
        public bool Gradiente
        {
            set
            {
                gradiente = value;
                this.Refresh();
            }
            get
            {
                return gradiente;
            }
        }

        private Image imagenMarca;
        [Category("Appearence")]
        [Description("Ruta a una imagen")]
        public Image ImagenMarca
        {
            set
            {
                imagenMarca = value;
                this.Refresh();
            }
            get
            {
                return imagenMarca;
            }
        }


        [Category("Action")]
        [Description("Se lanza cuando se hace clic en la marca")]
        public event MouseEventHandler ClickEnMarca;
        protected virtual void OnClickEnMarca(MouseEventArgs e)
        {
            int xTexto = grosor * 2 + h;
            if ((Marca != EMarca.Nada) && (e.X > grosor / 2) && (e.X < offsetX + grosor / 2) && (e.Y > grosor / 2) && (e.Y < offsetX + grosor / 2))
            {
                ClickEnMarca?.Invoke(this, e);
            }
        }
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            OnClickEnMarca(e);
        }
    }
}
