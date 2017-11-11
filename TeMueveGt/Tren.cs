using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeMueveGt
{
    class Tren
    {
        public Vagon[] ListaVagones { get; set; }
        public int CantidadDeVagones { get; set; }
        public string Nombre { get; set; }
        public bool AsientosDeLujo { get; set; }
        public Tren(int cantidadDeVagones, string nombre, bool asientosDeLujo)
        {
            ListaVagones = new Vagon[cantidadDeVagones];
            CantidadDeVagones = cantidadDeVagones;
            AsientosDeLujo = asientosDeLujo;
            Nombre = nombre;
        }

        public int asientosDisponiblesTotales()
        {
            int asientosDisponibles = 0;
            for (int i = 0; i < ListaVagones.Length; i++)
            {
                asientosDisponibles = asientosDisponibles + ListaVagones[i].obtenerCantidadDeAsientosDisponibles();
            }
            return asientosDisponibles;
        }
    }
}
