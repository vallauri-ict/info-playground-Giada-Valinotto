using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_01___Interfacce_base
{
    interface IDispAggiuntivo
    {
        int id
        {
            get;
            set;
        }
        bool status
        { // readonly Property
            get;
        }
        void connetti(string s);
        void disconnetti(string s);
    }
}
