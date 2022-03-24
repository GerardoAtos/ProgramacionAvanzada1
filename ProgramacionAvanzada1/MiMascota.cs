using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionAvanzada1
{
    public class MiMascota : Perro
    {
        public void ImprimirMensajeMascota(List<Perro> listaPerro)
        {
            Console.WriteLine($"mi mascota es un perrito {listaPerro.GetType().ToString()}");
        }
    }
}
