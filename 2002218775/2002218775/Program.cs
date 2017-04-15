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
            Ensambladora ensambladora = new Ensambladora();
            Parabrisas parabrisas = new Parabrisas();
            Volante volante = new Volante();
            Propietario propietario = new Propietario();
            volante.NumSerie = "volante-";
            parabrisas.NumSerie = "para-";
            propietario.DNI = "";

            var a = TipoCarro.automovil;
            var a1 = a.ToString();
            var name = (TipoCarro)Enum.Parse(typeof(TipoCarro), a1);

            Carro carros= new Carro();

            carros.NumSerieChasis = Console.ReadLine();
            ensambladora.Agregar(carros);
        }   
    }
}
