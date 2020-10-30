using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_04___OOP_code_Queue
{
    public class singleton
    {
        public struct libro
        {
            public string titolo;
            public string auotre;
        }
        public string titolo, autore;
        private singleton(string titolo, string autore)
        {
            this.titolo = titolo;
            this.autore = autore;
        }
        private static singleton _instance = null;
        public static singleton GetInstance(string titolo, string autore)
        {
            if (_instance == null)
            {
                _instance = new singleton(titolo, autore);
            }
            else
            {
               _instance.titolo = titolo;
                _instance.autore = autore;
            }
            return _instance;
        }  
    }
}
