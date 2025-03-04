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
    public partial class ControlMultimedia : UserControl//Sin timer. Minutos a 0 si >60. Solo una label. En seg resto 60
    {
        private int minutos;
        private int segundos;
        private bool reproduciendo;
        private Timer timer;
        public ControlMultimedia()
        {
            InitializeComponent();
            EscalarImagen(SolucionTema5.Properties.Resources.play);
            reproduciendo = false;
            this.Minutos = 0;
            this.Segundos = 0;
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(TimerTick);
        }

        private void EscalarImagen(Image img)
        {
            Image imagenOriginal = img;
            Image imagenEscalada = new Bitmap(imagenOriginal, new Size(btnPlay.Width - 10, btnPlay.Height - 10));
            btnPlay.Image = imagenEscalada;
        }

        public bool Reproduciendo
        {
            get
            {
                return reproduciendo;
            }
        }

        [Category("Apariencia")]
        [Description("Minutos asociados al control")]
        public int Minutos
        {
            set
            {
                if (value >= 0)
                {
                    if (value >= 60)
                    {
                        minutos = 0;
                    }
                    else
                    {
                        minutos = value;
                    }
                    lblTiempo.Text = minutos.ToString("D2") + ":" + segundos.ToString("D2");
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            get
            {
                return minutos;
            }
        }

        [Category("Apariencia")]
        [Description("Segundos asociados al control")]
        public int Segundos
        {
            set
            {
                if (value >= 0)
                {
                    if (value >= 60)
                    {
                        segundos = value % 60;
                        OnDesbordaTiempo(EventArgs.Empty);
                    }
                    else
                    {
                        segundos = value;
                    }
                    lblTiempo.Text = minutos.ToString("D2") + ":" + segundos.ToString("D2");
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            get
            {
                return segundos;
            }
        }

        [Category("Acción")]
        [Description("Se lanza cada vez que se pulsa el botón de reproducción")]
        public event EventHandler PlayClick;
        protected virtual void OnPlayClick(EventArgs e)
        {
            PlayClick?.Invoke(this, e);
            reproduciendo = !reproduciendo;
            EscalarImagen(reproduciendo ? SolucionTema5.Properties.Resources.pause : SolucionTema5.Properties.Resources.play);
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            OnPlayClick(EventArgs.Empty);
        }

        [Category("Comportamiento")]
        [Description("Se lanza cuando el valor es superior a 59")]
        public event EventHandler DesbordaTiempo;
        protected virtual void OnDesbordaTiempo(EventArgs e)
        {
            DesbordaTiempo?.Invoke(this, e);
            this.Minutos += 1;
        }
        private void TimerTick(object sender, EventArgs e)
        {
            this.Segundos += 1;
        }
    }
}
