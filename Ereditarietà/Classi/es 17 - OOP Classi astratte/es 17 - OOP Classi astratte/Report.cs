using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_17___OOP_Classi_astratte
{
    abstract class Report
    {
        protected abstract void printHeader();
        protected abstract void printBody();
        protected abstract void printFooter();
        public void print()
        {
            printHeader();
            printBody();
            printFooter();
        }
    }
}
