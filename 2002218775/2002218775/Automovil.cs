using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2002218775
{
    class Automovil: Carro
    {
        public TipoAuto _tipoAuto;
        Volante _volante;
        Parabrisas _parabrisas;
        Propietario _propietario;

        public Automovil(Volante volante, Parabrisas parabrisas, int numAsientos, Propietario propietario, TipoAuto tipoAuto)
        {
            TipoAuto = tipoAuto;
            /*volante= _volante;
           _parabrisas = parabrisas;
           _propietario = propietario;
           numAsiento = numAsientos;*/
        }

    }
    
}