using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba123
{
    class Persona
    {
        private int _id;
        private string? _nombre;
        private string? _apellido;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public String Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public String Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public ICollection<Telefono>? Telefonos { get; set; }
    }
}
