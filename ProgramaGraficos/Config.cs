using SolucionTema5;
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

namespace ProgramaGraficos
{
    public partial class Config : Form
    {
        public int numeroColumnas;
        public GraficoBarras.Representacion tipoGrafico;
        public int indiceColor;
        public Color[] colores;
        public Config()
        {
            InitializeComponent();
            rbBarras.Tag = GraficoBarras.Representacion.BARRAS;
            rbLineas.Tag = GraficoBarras.Representacion.LINEAS;
            rbBarras.CheckedChanged += new EventHandler(CheckedChanged);
            rbLineas.CheckedChanged += new EventHandler(CheckedChanged);
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            indiceColor = listColores.SelectedIndex;
            numeroColumnas = int.Parse(cbxCol.SelectedItem.ToString());
            foreach (RadioButton item in groupBox1.Controls)
            {
                if (item.Checked)
                {
                    tipoGrafico = (GraficoBarras.Representacion)item.Tag;
                }
            }

            DialogResult = DialogResult.OK;
        }

        private void Config_Load(object sender, EventArgs e)
        {
            if (tipoGrafico == GraficoBarras.Representacion.BARRAS)
            {
                rbBarras.Checked = true;
            }
            else
            {
                rbLineas.Checked = true;
            }

            for (int i = 0; i < colores.Length; i++)
            {
                listColores.Items.Add(colores[i].ToKnownColor().ToString());
            }

            listColores.SelectedIndex = indiceColor;

            cbxCol.SelectedIndex = numeroColumnas - 1;
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            listColores.Enabled = (GraficoBarras.Representacion)((RadioButton)sender).Tag == GraficoBarras.Representacion.LINEAS;
        }
    }
}
