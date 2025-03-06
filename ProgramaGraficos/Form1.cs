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
using System.Xml;

namespace ProgramaGraficos
{
    public partial class Form1 : Form
    {
        //TODO hacer filtros
        private OpenFileDialog fileDialog;
        private List<GraficoBarras> listaGraficas;

        //propiedades del form secundario
        private GraficoBarras.Representacion tipoGrafica;

        //propiedades "compartidas"
        private string rutaArchivo = $"{Environment.GetEnvironmentVariable("APPDATA")}\\config_gfx.txt";
        public Color colorSeleccionado;
        public int numeroColumnas;
        public GraficoBarras.Representacion tipoGrafico;
        public int indiceColor;
        public string tipoGfxCadena;
        public Color[] colores;

        public Form1()
        {
            InitializeComponent();
            fileDialog = new OpenFileDialog();
            listaGraficas = new List<GraficoBarras>();
            colores = new Color[] { Color.Black, Color.Aqua, Color.BlueViolet, Color.Red, Color.SeaGreen };
            CargarDatosDeConfiguracion();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileDialog.Multiselect = true;
            fileDialog.Filter = "XML (*.xml)|*.xml|All Files (*.*)|*.*";
            DialogResult dr = fileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                foreach (string item in fileDialog.FileNames)
                {
                    if (item.Contains(".xml")) // se podría hacer mejor...
                    {
                        GraficoBarras gfx = LectorXml(item);
                        listaGraficas.Add(gfx);
                    }
                }
                DistrubuidorGraficas();
            }
        }

        private void DistrubuidorGraficas()
        {
            int x = 30;
            int y = 30;
            for (int i = Controls.Count - 1; i >= 0; i--)
            {
                if (this.Controls[i] is GraficoBarras)
                {
                    this.Controls.Remove(this.Controls[i]);
                }
            }
            for (int i = 1; i <= listaGraficas.Count; i++)
            {
                GraficoBarras grafico = listaGraficas[i - 1];
                grafico.Height = 200;
                grafico.Width = 200;
                grafico.Location = new Point(x, y);
                grafico.Modo = GraficoBarras.Ejes.AUTOMATICO;
                grafico.TipoGrafica = tipoGrafico;
                grafico.ForeColor = colores[indiceColor];

                Label nombre = new Label();
                nombre.Text = grafico.Nombre;
                nombre.Location = new Point(grafico.Location.X, grafico.Location.Y + 10);
                nombre.AutoSize = true;

                this.Controls.Add(nombre);
                this.Controls.Add(grafico);

                if (i % numeroColumnas == 0)
                {
                    y += 210;
                    x = 20;
                }
                else
                {
                    x += 210;
                }
            }
        }

        private GraficoBarras LectorXml(string ruta)
        {
            try
            {
                List<double> datos = new List<double>();
                XmlDocument doc = new XmlDocument();
                doc.Load(ruta);
                // eje y -> elemento raiz : nombre -> atributo tipo raiz : eje x -> nombre nodos hijos : dato -> texto
                // permite rutas al estilo linux???
                XmlNodeList nodeList = doc.FirstChild.ChildNodes;
                string nombre = doc.FirstChild.Attributes.GetNamedItem("nombre").FirstChild.Value.Trim();
                string ejeY = doc.FirstChild.Name.Trim();
                string ejeX = doc.FirstChild.FirstChild.Name.Trim();
                for (int i = 0; i < nodeList.Count; i++)
                {
                    XmlNode node = nodeList[i];
                    // hay que coger el valor del primer hijo (nodo de texto) como en AD
                    datos.Add(double.Parse(node.FirstChild.Value.Trim()));
                }
                Console.WriteLine("Lectura XML finalizada");
                return new GraficoBarras(datos.ToArray(), nombre, ejeX, ejeY);
            }
            catch (IOException)
            {
                Console.WriteLine("Ooops... Error de IO");
                return null;
            }
            catch (FormatException)
            {
                Console.WriteLine("Error de lectura, alguno de lo valores no tiene el formato correcto");
                return null;
            }
        }

        private void configuraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Config conf = new Config();
            conf.colores = colores;
            conf.indiceColor = indiceColor;
            conf.numeroColumnas = numeroColumnas;
            conf.tipoGrafico = tipoGrafico;

            DialogResult dr = conf.ShowDialog();

            indiceColor = conf.indiceColor;
            numeroColumnas = conf.numeroColumnas;
            tipoGrafico = conf.tipoGrafico;
            colores = conf.colores;

            if (dr == DialogResult.OK)
            {
                for (int i = (this.Controls.Count) - (1); i >= 0; i--)
                {
                    if (this.Controls[i] is Label)
                    {
                        this.Controls.Remove(this.Controls[i]);
                    }
                }
                numeroColumnas = conf.numeroColumnas;
                foreach (GraficoBarras grafica in listaGraficas)
                {
                    grafica.TipoGrafica = tipoGrafico;
                    if (tipoGrafico == GraficoBarras.Representacion.LINEAS)
                    {
                        grafica.ForeColor = colores[indiceColor];
                    }
                }
                DistrubuidorGraficas();
            }
        }

        private void CargarDatosDeConfiguracion()
        {
            if (File.Exists(rutaArchivo))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(rutaArchivo))
                    {
                        numeroColumnas = int.Parse(sr.ReadLine());
                        indiceColor = int.Parse(sr.ReadLine());
                        colorSeleccionado = colores[indiceColor];
                        tipoGrafica = sr.ReadLine().Contains("BARRAS") ? GraficoBarras.Representacion.BARRAS : GraficoBarras.Representacion.LINEAS;
                    }
                }
                catch (IOException)
                {
                    Console.WriteLine("Error de IO en Lectura");
                }
            }
            else
            {
                ValoresPorDefecto();
            }
        }

        private void GuardarDatosDeConfiguracion()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(rutaArchivo, false))
                {
                    sw.WriteLine(numeroColumnas);
                    sw.WriteLine(indiceColor);
                    sw.WriteLine(tipoGrafica == GraficoBarras.Representacion.BARRAS ? "BARRAS" : "LINEAS");
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Error de IO en Escritura");
            }
        }

        private void ValoresPorDefecto()
        {
            colorSeleccionado = colores[0];
            indiceColor = 0;
            tipoGrafico = GraficoBarras.Representacion.BARRAS;
            numeroColumnas = 1;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            GuardarDatosDeConfiguracion();
        }
    }
}
