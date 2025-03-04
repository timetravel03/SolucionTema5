using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NuevosComponentes
{
    public partial class LabelTextBox : UserControl
    {
        public enum EPosicion
        {
            IZQUIERDA, DERECHA
        }

        private EPosicion posicion = EPosicion.IZQUIERDA;

        [Category("Appearance")]
        [Description("Indica si la Label se sitúa a la IZQUIERDA o DERECHA del Textbox")]

        public EPosicion Posicion
        {
            get { return posicion; }
            set
            {
                if (Enum.IsDefined(typeof(EPosicion), value))
                {
                    posicion = value;
                    recolocar();
                    OnPosicionChanged(EventArgs.Empty);
                }
                else
                {
                    throw new InvalidEnumArgumentException();
                }
            }
        }

        // Separación entre la label y el textbox
        private int separacion = 0;

        [Category("Mis Propiedades")]
        [Description("Pixeles de separación entre Label y Textbox")]
        public int Separacion
        {
            set
            {
                if (value >= 0)
                {
                    separacion = value;
                    recolocar();
                    OnSeparacionChanged(EventArgs.Empty);
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            get
            {
                return separacion;
            }
        }

        [Category("Mis Propiedades")]
        [Description("Texto asociado a la Label del control")]
        public string TextLbl
        {
            set
            {
                lbl.Text = value;
                recolocar();
            }
            get
            {
                return lbl.Text;
            }
        }

        [Category("Mis Propiedades")]
        [Description("Texto asociado al TextBox del control")]
        public string TextTxt
        {
            set
            {
                txt.Text = value;
            }
            get
            {
                return txt.Text;
            }
        }

        void recolocar()
        {
            switch (posicion)
            {
                case EPosicion.IZQUIERDA:
                    //Establecemos posición del componente lbl
                    lbl.Location = new Point(0, 0);
                    // Establecemos posición componente txt
                    this.Width = lbl.Width + txt.Width + Separacion;
                    txt.Location = new Point(lbl.Width + Separacion, 0);
                    //Establecemos ancho del Textbox
                    //(la label tiene ancho por autosize)
                    //txt.Width = this.Width - lbl.Width - Separacion;
                    //Establecemos altura del componente
                    this.Height = Math.Max(txt.Height, lbl.Height);
                    break;
                case EPosicion.DERECHA:
                    //Establecemos posición del componente txt
                    txt.Location = new Point(0, 0);
                    this.Width = lbl.Width + txt.Width + Separacion;
                    //Establecemos ancho del Textbox
                    //txt.Width = this.Width - lbl.Width - Separacion;
                    //Establecemos posición del componente lbl
                    lbl.Location = new Point(txt.Width + Separacion, 0);
                    //Establecemos altura del componente (Puede sacarse del switch)
                    this.Height = Math.Max(txt.Height, lbl.Height);
                    break;
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            recolocar();
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        [Category("La propiedad cambió")]
        [Description("Se lanza cuando la propiedad Separación cambia")]
        public event System.EventHandler SeparacionChanged;

        protected virtual void OnSeparacionChanged(EventArgs e)
        {
            SeparacionChanged?.Invoke(this, e);
            this.Refresh();
        }


        [Category("La propiedad cambió")]
        [Description("Se lanza cuando la propiedad Posición cambia")]
        public event System.EventHandler PosicionChanged;

        protected virtual void OnPosicionChanged(EventArgs e)
        {
            if (PosicionChanged != null)
            {
                PosicionChanged(this, e);
            }
        }

        public LabelTextBox()
        {
            InitializeComponent();
            TextLbl = Name;
            TextTxt = "";
            recolocar();
            txt.KeyPress += new KeyPressEventHandler(txt_KeyPress);
            txt.KeyUp += new KeyEventHandler(txt_KeyUp);
        }

        private void txt_KeyUp(object sender, KeyEventArgs e)
        {
            this.OnKeyUp(e);
        }

        [Category("La propiedad cambió")]
        [Description("Se lanza cuando el texto del textbox cambia")]
        public event System.EventHandler TxtChanged;

        protected virtual void OnTxtChanged(EventArgs e)
        {
            TxtChanged?.Invoke(this, e);
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            OnTxtChanged(EventArgs.Empty);
        }

        [Category("Appearance")]
        [Description("Indica si el texto de la textbox se escribe como una contraseña")]
        public char PswChr
        {
            set
            {
                txt.PasswordChar = value;
            }
            get
            {
                return txt.PasswordChar;
            }
        }

        [Category("Appearence")]
        [Description("Indica si se debe subrayar el texto de la etiqueta")]
        public bool Subrayado
        {
            set
            {
                subrayado = value;
                this.Refresh();
            }
            get
            {
                return subrayado;
            }
        }
        private bool subrayado;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (Subrayado)
            {
                e.Graphics.DrawLine(new Pen(Color.Black, 1), lbl.Left, lbl.Height + 1, lbl.Right, lbl.Height + 1);
            }
        }
    }
}
