﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_19___OOP_MondoAnimale
{
    public abstract class AnimaleMarino : AnimaleAcquatico
    {
        public AnimaleMarino(String s)
        {
            super(s);
        }

        public String vive()
        {
            return "in mare";
        }

        public String chi_sei()
        {
            return "un animale marino";
        }
    }
}
