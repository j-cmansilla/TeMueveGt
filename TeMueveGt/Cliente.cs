using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeMueveGt
{
    class Cliente
    {
        public Cliente(string nombre, int dPI, int telefono, string correo, string tipoDeAsiento)
        {
            Nombre = nombre;
            DPI = dPI;
            Telefono = telefono;
            Correo = correo;
            TipoDeAsiento = tipoDeAsiento;
        }

        public Cliente()
        {

        }

        public string Nombre { get; set; }
        public int DPI { get; set; }
        public int Telefono { get; set; }
        public string Correo { get; set; }
        public string TipoDeAsiento { get; set; }
    }
}
