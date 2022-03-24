using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionAvanzada1
{
    public delegate void ImprimirDelegado(string value);
    public class PlayingWithLists
    {
        public void EvenNumbers(List<int> lista)
        {
            List<int> evennumbers = new List<int>();
            evennumbers = lista.Where(x => x % 2 == 0).ToList();
            Console.WriteLine("the Even numbers are: ");
            foreach(int i in evennumbers)
            {
                Console.WriteLine(i);
            }
        }

        public void OddNumbers(List<int> lista)
        {
            List<int> oddnumbers = new List<int>();
            oddnumbers = lista.Where(x => x % 2 == 1).ToList();
            Console.WriteLine("the Odd numbers are: ");
            foreach (int i in oddnumbers)
            {
                Console.WriteLine(i);
            }
        }

        public void Ascending(List<int> lista)
        {
            var ordenados = lista.OrderBy(x => x).ToList();

            Console.WriteLine("Lista Ordenada Ascendente: ");
            foreach (int i in ordenados)
            {
                Console.WriteLine(i);
            }
        }

        public void Descending(List<int> lista)
        {
            var ordenados = lista.OrderByDescending(x => x).ToList();

            Console.WriteLine("Lista Ordenada Descendente: ");
            foreach (int i in ordenados)
            {
                Console.WriteLine(i);
            }
        }

        public void MultipleThree(List<int> lista)
        {
            var multiple3 = lista.Where(x => x % 3 == 0).ToList();

            Console.WriteLine("Lista de Multiplos de 3: ");
            foreach (int i in multiple3)
            {
                Console.WriteLine(i);
            }
        }

        public void EjemploDelegado()
        {
            ImprimirDelegado imprimir = new ImprimirDelegado(ImprimirString);
            imprimir("corriendo ejemplo de delegado normal");
        }

        public void ImprimirString(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        public void EjemploAction()
        {
            Action<string> impirmirAction = ImprimirString;
            impirmirAction("Imprimiendo el action");
        }

        public void EjemploFunc()
        {
            Func<string,string> impirmirFunc = v => $"el resultado es el {v}";
            Console.WriteLine(impirmirFunc("ejemplo de func"));
        }

        public void EjemploPredicate()
        {
            Predicate<int> impirmirPredicate = v => v == 99;
            Console.WriteLine("esto deberia de ser un TRUE: "+impirmirPredicate(99));
        }

        public void Minimum(List<int> lista)
        {
            var min = lista.Min(x => x);
            

            Console.WriteLine("El menor de los valores es:  ");
            
            Console.WriteLine(min);
        }

        public void Maximum(List<int> lista)
        {
            var max = lista.Max(x => x);


            Console.WriteLine("El mayor de los valores es:  ");

            Console.WriteLine(max);
        }

        public void Average(List<int> lista)
        {
            var ave = lista.Average(x => x);


            Console.WriteLine("El promedio de los valores es:  ");

            Console.WriteLine(ave);
        }

        public void RMS(List<int> lista)
        {
            double result = 0;
            Console.WriteLine("El RMS: ");
            foreach (int i in lista)
            {
                result += Math.Pow(i,2);
            }
            result /= lista.Count;
            Console.WriteLine(Math.Sqrt(result));
        }


    }
}
