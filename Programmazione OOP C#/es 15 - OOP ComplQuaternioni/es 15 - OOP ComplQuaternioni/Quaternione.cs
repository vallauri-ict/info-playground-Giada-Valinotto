﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_15___OOP_ComplQuaternioni
{
    class Quaternione : Complesso
    {
        private double immaginarioJ;
        private double immaginarioK;

        public Quaternione() : base()
        {

        }

        public void GetAttributes(double reale, double immaginario, double immaginarioJ, double immaginarioK)
        {
            reale = this.reale;
            immaginario = this.immaginario;
            immaginarioJ = this.immaginarioJ;
            immaginarioK = this.immaginarioK;
        }
    }
}
