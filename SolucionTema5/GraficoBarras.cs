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
    public partial class GraficoBarras : UserControl
    {
        private double[] valores;
        private double valorMaximoY;
        public enum Ejes { MANUAL, AUTOMATICO }
        public enum Representacion { BARRAS, LINEAS }

        private Ejes modo;
        private Representacion tipoGrafica;

        private float intervaloY;
        private float intervaloX;

        private Brush[] brochas;
        private int contadorBrochas;
        public GraficoBarras()
        {
            //valores = new List<double>();
            valores = new double[] { 7, 5, 6, 2, 6, 12, 2, 5, 1, 2, 6, 9 };
            InitializeComponent();
            valorMaximoY = valores.Max(); // tiene que ser igual a la altura
            brochas = new Brush[] { Brushes.LightGreen, Brushes.LightBlue, Brushes.Khaki };
            contadorBrochas = 0;
            intervaloY = (this.Height) / 10;
            intervaloX = (this.Width) / valores.Length;
        }

        [Category("Mis Propiedades")]
        [Description("Cambia el modo de representacion de la gráfica en funcion de normalizar con respecto al valor máximo o no")]
        public Ejes Modo
        {
            set
            {
                modo = value;
                this.Refresh();
            }
            get
            {
                return modo;
            }
        }

        [Category("Mis Propiedades")]
        [Description("Cambia la representacion de los datos de un grafico de barras a uno de lineas")]
        public Representacion TipoGrafica
        {
            set
            {
                tipoGrafica = value;
                this.Refresh();
            }
            get
            {
                return tipoGrafica;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphics = e.Graphics;
            contadorBrochas = 0;
            float contadorX = 0;
            float contadorY = this.Height;
            

            //graphics.DrawLine(new Pen(this.ForeColor), 0, this.Height, intervaloX, (float)(intervaloY * valores[0]));

            if (TipoGrafica == Representacion.BARRAS)
            {
                DibujarBarras(graphics);
            }
            else
            {
                DibujarLineas(graphics);
            }

            // Dibujar marcas en el eje Y
            while (contadorY >= 0)
            {
                graphics.DrawLine(Pens.Black, 0, contadorY, 10, contadorY);
                contadorY -= intervaloY;
            }

            // Dibujar ejes
            graphics.DrawLine(Pens.Black, 0, 0, 0, this.Height);
            graphics.DrawLine(new Pen(Color.Black, 3), 0, this.Height, this.Width, this.Height);

            // Etiquetas de ejes
            graphics.DrawString("Eje X", this.Font, Brushes.Black, new PointF(this.Width - 50, this.Height - 30));
            graphics.TranslateTransform(35, 0);
            graphics.RotateTransform(90);
            graphics.DrawString("Eje Y", this.Font, Brushes.Black, new PointF(35, 0));
            graphics.ResetTransform();
        }

        private void GraficoBarras_Load(object sender, EventArgs e)
        {
            GraficoBarras_Resize(sender, e);
            this.Refresh();
        }

        private void GraficoBarras_Resize(object sender, EventArgs e)
        {
            intervaloY = (this.Height) / 10;
            intervaloX = (this.Width) / valores.Length;
            this.Refresh();
        }

        private void DibujarLineas(Graphics graphics)
        {
            float contadorX = 0;
            float contadorY = this.Height;
            for (int i = 0; i < valores.Length; i++)
            {
                if (Modo == Ejes.MANUAL)
                {
                    graphics.DrawLine(new Pen(this.ForeColor), contadorX, contadorY, (contadorX + intervaloX), (float)(this.Height - (intervaloY * valores[i])));
                    contadorY = (float)(this.Height - (intervaloY * valores[i]));
                }
                else
                {
                    graphics.DrawLine(new Pen(this.ForeColor), contadorX, contadorY, (contadorX + intervaloX), this.Height - (float)(this.Height * (valores[i] / valorMaximoY)));
                    contadorY = this.Height - (float)(this.Height * (valores[i] / valorMaximoY));
                }
                contadorX += intervaloX;

                //Marcas eje x
                graphics.DrawLine(Pens.Black, contadorX, this.Height, contadorX, this.Height - 10);
            }
        }

        private void DibujarBarras(Graphics graphics)
        {
            float contadorX = 0;
            float contadorY = this.Height;
            // Dibujar barras
            for (int i = 0; i < valores.Length; i++)
            {
                // Rectángulo
                Rectangle rect = new Rectangle();
                rect.Width = (int)intervaloX;
                if (Modo == Ejes.AUTOMATICO)
                {
                    rect.Height = (int)(this.Height * (valores[i] / valorMaximoY));
                }
                else
                {
                    rect.Height = (int)(valores[i] * intervaloY);
                }
                rect.X = (int)contadorX;
                rect.Y = this.Height - rect.Height;

                // Dibujar
                if (rect.Height <= this.Height)
                {
                    graphics.FillRectangle(brochas[contadorBrochas], rect);
                    graphics.DrawRectangle(Pens.Black, rect);
                }
                else
                {
                    graphics.FillRectangle(Brushes.Red, rect);
                    graphics.DrawRectangle(Pens.Black, rect);
                }

                //Marcas eje x
                //graphics.DrawLine(Pens.Black, contadorX - (intervaloX / 2), this.Height, contadorX - (intervaloX / 2), this.Height - 10);

                // Cambiar brocha (color)
                contadorBrochas = contadorBrochas < 2 ? contadorBrochas + 1 : 0;
                contadorX += intervaloX;
            }
        }
    }
}
