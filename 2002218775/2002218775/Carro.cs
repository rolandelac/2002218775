﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2002218775
{
    public abstract class Carro
    {
        
        public string NumSerieMotor {get; set;}
        public string NumSerieChasis {get; set;}
        Volante _volante;
        Parabrisas _parabrisas;
        Propietario _propietario;


        public Carro(Volante volante, Parabrisas parabrisas, int numLlantas, int numAsientos, Propietario propietario, TipoCarro tipoCarro)
        {
            _volante = volante;
            _parabrisas = parabrisas;
            _propietario = propietario;
        }


    }
}
