using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2002218775
{
    public class Ensambladora
    {
        List<Carro> _Carros;

        Volante volante;
        Parabrisas parabrisas;
        Propietario propietario;
        TipoAuto tipoauto;

        public Ensambladora()
        {
            _Carros = new List<Carro>();

            volante = new Volante();
            propietario = new Propietario();
            parabrisas = new Parabrisas();
            tipoauto = new TipoAuto();

        }

        public void Agregar(Carro carro)
        {

            if (_Carros.Count == 6)
                return;

            




            //    _carros.Add(new Automovil(carro));
            //else
            //    _carros.Add(new Bus(carro));
        }

        //public void IniciarPersonalizacion(string carro)
        //{
        //    carros _carroPersonalizado = _carros.Find( c => c.carro == carro);

        //    Console.WriteLine("Personalizacion Inicieeewwffffada [{0}]", carro);
        //}


    }


   
}
