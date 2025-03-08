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
    public partial class Form1 : Form
    {
        private List<sFriki> frikis;
        public Form1()
        {
            InitializeComponent();
            frikis = new List<sFriki>();
            sFriki friki1 = new sFriki();
            friki1.Nombre = "Pedro";
            sFriki friki2 = new sFriki();
            friki2.Nombre = "Paco";
            sFriki friki3 = new sFriki();
            friki3.Nombre = "Mateo";
            sFriki friki4 = new sFriki();
            friki4.Nombre = "Peter";

            frikis.Add(friki1);
            frikis.Add(friki2);
            frikis.Add(friki3);
            frikis.Add(friki4);

            foreach (sFriki friki in frikis)
            {
                listBox1.Items.Add(friki.Nombre);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            for (int i = listBox1.Items.Count - 1; i >= 0; i--)
            {
                for (int j = 0; j < listBox1.SelectedIndices.Count; j++)
                {
                    if (i == listBox1.SelectedIndices[j])
                    {
                        listBox1.Items.RemoveAt(i);
                        frikis.RemoveAt(i);
                    }
                }
            }

            foreach (sFriki item in frikis)
            {
                Console.WriteLine(item.Nombre);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Form2 sec = new Form2();

            DialogResult dr = sec.ShowDialog();

        }
    }
}
