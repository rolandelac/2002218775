using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2002218775
{
    class Program
    {
        static void Main(string[] args)
        {
            var carro1 = "sedan";
            var carro2 = "pickup";
            var carro3 = "coupe";
            var carro4 = "hatchback";

            var carro5 = "publico";
            var carro6 = "privado";

            var ensambladora = new Ensambladora();

            ensambladora.Agregar(carro1);
            ensambladora.Agregar(carro2);
            ensambladora.Agregar(carro3);
            ensambladora.Agregar(carro4);

            ensambladora.Agregar(carro5);
            ensambladora.Agregar(carro6);



            ensambladora.IniciarPersonalizacion(carro1);
            ensambladora.FinalizarPersonalizacion(carro1);

            ensambladora.IniciarPersonalizacion(carro2);
            ensambladora.FinalizarPersonalizacion(carro2);

            ensambladora.IniciarPersonalizacion(carro3);
            ensambladora.FinalizarPersonalizacion(carro3);

            ensambladora.IniciarPersonalizacion(carro4);
            ensambladora.FinalizarPersonalizacion(carro4);

            ensambladora.IniciarPersonalizacion(carro5);
            ensambladora.FinalizarPersonalizacion(carro5);
        }   
    }
}
