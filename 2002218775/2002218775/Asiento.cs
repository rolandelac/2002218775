﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2002218775
{
    class Asiento
    {
        private Cinturon _cinturon;
        public String NumSerie { get; set; }

        public Asiento()
        {
            _cinturon = new Cinturon();
        }

    }
}
