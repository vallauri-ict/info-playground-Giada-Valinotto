using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es_20___OOP_Classi_Astratte
{
    sealed class ClsElenco
    {
        List<ClsAlunno> elenco;

        public ClsElenco()
        {
            elenco = new List<ClsAlunno>();
        }

        public void insersci(ClsAlunno a)
        {
            elenco.Add(a);
        }
        public void visualzzaDgv(DataGridView dgv)
        {
            dgv.DataSource = typeof(List<>);
            dgv.DataSource = elenco;
        }
        public int oreAzienda(string nomeA)
        {
            int oreTotAzienda = 0;
            foreach (ClsAlunno a in elenco)
            {
                if (a is ClsStagista)   //verifica se apartiene alla classe -> Se l'alunno è stagista o no 
                {
                    ClsStagista s = a as ClsStagista; //Converte oggetto di tipo padre in uno di tipo figlia
                    if (s.Azienda==nomeA)
                    {
                        oreTotAzienda += Convert.ToInt32(s.Ore);
                    }
                }
            }
            return oreTotAzienda;
        }

        public void cancella()
        {
            if (elenco.Count == 0)
                throw new Exception("Cancellazione negata, lista vuota");
            else
                elenco.RemoveAt(elenco.Count - 1);
        }

        public void cancellaAllaPos(int posizione)
        {
            posizione--;
            //Verfco l'esistenza dell'elemento 
            if (elenco.Count == 0)
                throw new Exception("Cancellazione negata, lista vuota");
            else if (posizione < 0 || posizione > elenco.Count - 1)
                throw new Exception("Cancellazione negata, posizione non valida");
            else
                elenco.RemoveAt(posizione);
        }
    }
}
