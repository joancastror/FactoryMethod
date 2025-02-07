using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BebidasEmbriagante oBebida = Creador.CreadorBebidas(Creador.VINO_TINTO);
            Console.WriteLine(oBebida.CuantoMeEmbriagaPorHora());
        }
    }
}
