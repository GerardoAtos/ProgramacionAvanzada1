using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionAvanzada1
{
    public class MiMascota2 : Gato
    {

        public void ImprimirMensajeMascota(List<Gato> listaGato)
        {
            Console.WriteLine($"mi mascota es un gatito {listaGato.GetType().ToString()}");
        }
    }
}
