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
    public partial class DibujoAhorcado : Control// Ojo con param en funcion On
    {
        private Dictionary<int, Action> funcionesDibujo;
        private Graphics graphics;
        private int cuarto;
        Pen pen = new Pen(Color.Black);

        private int errores = 0;
        [Category("Mis Propiedades")]
        [Description("Numero de errores que se han cometido")]
        public int Errores
        {
            set
            {
                if (value <= 11 && value >= 0)
                {
                    errores = value;
                    OnCambiaError();
                    if (value == 11)
                    {
                        OnAhorcado();
                    }
                }
            }
            get
            {
                return errores;
            }
        }

        [Category("Mis Eventos")]
        [Description("Se produce cuando el número de errores cambia")]
        public event EventHandler CambiaError;
        protected void OnCambiaError()
        {
            CambiaError?.Invoke(this, EventArgs.Empty);
            this.Refresh();
        }

        [Category("Mis Eventos")]
        [Description("Se produce cuando se completa el dibujo")]
        public event EventHandler Ahorcado;
        protected void OnAhorcado()
        {
            Ahorcado?.Invoke(this, EventArgs.Empty);
        }

        public DibujoAhorcado()
        {
            InitializeComponent();

            funcionesDibujo = new Dictionary<int, Action>()
            {
                { 1, () => graphics.DrawLine(pen, new Point(((this.Width / 4) - 15), this.Height - 5), new Point((this.Width / 4) + 15, this.Height - 5)) }, //base
                { 2, () => graphics.DrawLine(pen, new Point((this.Width / 4), this.Height - 5), new Point((this.Width / 4), 5)) }, //palo
                { 3, () => graphics.DrawLine(pen, new Point((this.Width / 4), 5), new Point((int)(this.Width * 0.5), 5)) }, //parte superior
                { 4, () => graphics.DrawLine(pen, new Point((this.Width / 4), (int)(this.Height*0.2)), new Point((int)(this.Width * 0.4), 5)) }, //diagonal
                { 5, () => graphics.DrawLine(pen, new Point((int)(this.Width * 0.5), 5), new Point((int)(this.Width * 0.5), (int)(this.Height * 0.28))) }, //cuerda
                { 6, () => graphics.DrawEllipse(pen, new RectangleF((int)(this.Width * 0.452), (int)(this.Height * 0.28), (int)(this.Width * 0.1), (int)(this.Height * 0.1))) }, //cabeza
                { 7, () => graphics.DrawLine(pen, new Point((int)(this.Width * 0.5), (int)(this.Height * 0.38)), new Point((int)(this.Width * 0.5), (int)(this.Height * 0.6))) }, //torso
                { 8, () => graphics.DrawLine(pen, new Point((int)(this.Width * 0.5), (int)(this.Height*0.4)), new Point((int)(this.Width * 0.4), (this.Height/2))) }, //brazo izq
                { 9, () => graphics.DrawLine(pen, new Point((int)(this.Width * 0.5), (int)(this.Height*0.4)), new Point((int)(this.Width * 0.6), (this.Height/2))) }, //brazo der
                { 10, () => graphics.DrawLine(pen, new Point((int)(this.Width * 0.5),(int)(this.Height * 0.6)), new Point((int)(this.Width *0.4), (int)(this.Height * 0.8))) }, //pierna izq
                { 11, () => graphics.DrawLine(pen, new Point((int)(this.Width * 0.5),(int)(this.Height * 0.6)), new Point((int)(this.Width*0.6), (int)(this.Height * 0.8))) } //pierna der
            };
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            graphics = pe.Graphics;

            for (int i = 1; i <= errores; i++)
            {
                funcionesDibujo[i]();
            }
        }
    }
}
