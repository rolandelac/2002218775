using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2002218775
{
    class Bus:Carro
    {
        int numAsientos;
        public TipoBus _tipoBus;
    
        public Bus(int _numAsientos)
	    {
            numAsientos = _numAsientos;
	    }
    }
}
