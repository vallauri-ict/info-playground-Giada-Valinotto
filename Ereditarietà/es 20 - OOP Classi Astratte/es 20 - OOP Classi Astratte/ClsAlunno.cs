using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_20___OOP_Classi_Astratte
{
    class ClsAlunno : ClsPersona
    {
        #region attributi
        protected static int progressivo = 0;
        protected readonly string matricola;
        protected char classe;
        protected char sezione;
        protected string specializzazione;
        #endregion
    }
}
