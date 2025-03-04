using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppControlMultimediaTest// Cambio carpetas mientras reproduce (carpeta vacia)
{
    public partial class Form1 : Form
    {
        private bool reprodiciendo = false;
        private string carpetaSeleccionada;
        List<FileInfo> archivos = new List<FileInfo>();
        int contadorFotos;
        public Form1()
        {
            InitializeComponent();

            for (int i = 1; i <= 20; i++)
            {
                cbxIntervalo.Items.Add(i);
            }
            cbxIntervalo.SelectedIndex = 0;
            controlMultimedia1.Enabled = false;
            //lblImage.Text = "Imagen";
            timerFotos.Interval = 1000;
            timerReproductor.Interval = 1000;
            contadorFotos = 0;
        }

        private void btnDirectorio_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
            {
                folderBrowser.Description = "Selecciona una carpeta:";
                DialogResult dr = folderBrowser.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    carpetaSeleccionada = folderBrowser.SelectedPath;
                    CargarImagenes();
                }
            }
        }

        private void CargarImagenes()
        {
            // reinicio de componentes
            archivos.Clear();
            timerFotos.Stop();
            timerReproductor.Stop();
            controlMultimedia1.Minutos = 0;
            controlMultimedia1.Segundos = 0;
            contadorFotos = 0;

            //carga de imagenes
            DirectoryInfo directoryInfo = new DirectoryInfo(carpetaSeleccionada);
            FileInfo[] pngFiles = directoryInfo.GetFiles("*.png", SearchOption.TopDirectoryOnly);
            FileInfo[] jpgFiles = directoryInfo.GetFiles("*.jpg", SearchOption.TopDirectoryOnly);
            FileInfo[] jpegFiles = directoryInfo.GetFiles("*.jpeg", SearchOption.TopDirectoryOnly);
            archivos.AddRange(pngFiles);
            archivos.AddRange(jpgFiles);
            archivos.AddRange(jpegFiles);
            if (archivos.Count != 0)
            {
                controlMultimedia1.Enabled = true;
                Image img = Image.FromFile(archivos[0].FullName);
                Bitmap bitmap = new Bitmap(img, new Size(pictureBox1.Width, pictureBox1.Height));
                pictureBox1.Image = bitmap;
                contadorFotos++;
            }
            else
            {
                pictureBox1.Image = null;
                controlMultimedia1.Enabled = false;
                MessageBox.Show("No hay imágenes compatibles en este directorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxIntervalo_SelectedIndexChanged(object sender, EventArgs e)
        {
            timerFotos.Interval = (cbxIntervalo.SelectedIndex + 1) * 1000;
        }

        private void timerFotos_Tick(object sender, EventArgs e)
        {
            if (contadorFotos >= archivos.Count - 1)
            {
                contadorFotos = 0;
            }
            else
            {
                contadorFotos++;
            }

            if (archivos.Count > 0)
            {
                string mypath = archivos[contadorFotos].FullName;
                Image img = Image.FromFile(mypath); //outofmemoryexception
                Bitmap bitmap = new Bitmap(img, new Size(pictureBox1.Width, pictureBox1.Height));
                pictureBox1.Image = bitmap;
            }
            Console.WriteLine(contadorFotos);
        }

        private void controlMultimedia1_PlayClick(object sender, EventArgs e)
        {
            //TODO arreglar
            timerFotos.Enabled = !timerFotos.Enabled;
            timerReproductor.Enabled = !timerReproductor.Enabled;
        }

        private void timerReproductor_Tick(object sender, EventArgs e)
        {
            controlMultimedia1.Segundos++;
        }
    }
}
