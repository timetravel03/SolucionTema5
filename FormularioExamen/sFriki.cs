using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularioExamen
{
    internal struct sFriki
    {
        public enum eAficion { Manga, SciFi, RPG, Fantasia, Terror, Tecnologia }
        public enum eSexo { Hombre, Mujer }

        public string Nombre;
        public int Edad;
        public eAficion Aficion;
        public eSexo Sexo;
        public eSexo SexoOpuesto;
        public string Foto;
    }
}
