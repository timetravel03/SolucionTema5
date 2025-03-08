using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioExamen
{
    public partial class Form2 : Form
    {
        public string rutaFoto;
        //public 
        public Form2()
        {
            InitializeComponent();
            string[] aficiones = Enum.GetNames(typeof(sFriki.eAficion));
            foreach (string item in aficiones)
            {
                cbxAficiones.Items.Add(item);
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Todos los Archivos (*.*)|*.*|JPG (*.jpg)|*.jpg";
            DialogResult dr = fileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                textBox1.Text = fileDialog.FileName;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            rutaFoto = textBox1.Text;
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
