using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_14___OOP_Persone_e_Studenti
{
    class Studente : Persona
    {
        public List<int> voti = new List<int>();
        
        public double Media()
        {
            int somma=0;
            foreach (var item in voti)
            {
                somma += item;
            }
            return (double)(somma / voti.Count());
        }
    }
}
