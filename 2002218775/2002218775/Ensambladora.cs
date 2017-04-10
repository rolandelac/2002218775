using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2002218775
{
    class Ensambladora
    {
        List<Carro> _carros;

        List<Volante> _volante;
        List<Parabrisas> _parabrisas;
        List<Llanta> _llanta;
        List<Asiento> _asiento;

        public Ensambladora()
        {
            _carros = new List<Carro>();

            _volante = new List<Volante>();
            _parabrisas=new List<Parabrisas>();
            _llanta = new List<Llanta>();
            _asiento = new List<Asiento>();

        }

        public void Agregar(string carro)
        {
         
            if (carro == "sedan")
                _carros.Add(new Automovil(carro));
            else
                _carros.Add(new Bus(carro));
        }

        public void IniciarPersonalizacion(string carro)
        {
            carros _carroPersonalizado = _carros.Find( c => c.carro == carro);

            Console.WriteLine("Personalizacion Iniciffffada [{0}]", carro);
        }


    }


   
}
