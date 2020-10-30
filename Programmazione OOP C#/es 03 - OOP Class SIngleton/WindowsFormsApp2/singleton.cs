using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class singleton
    {
        public int val=0;
        private static singleton instance = null;
        
        private singleton()
        {

        }
        public singleton(int val)
        {
            this.val = val;
        }
        public static singleton GetSingleton(int valore)
        {
            if (instance==null)
            {
                instance = new singleton(valore);
            }
            else
            {
                instance.val = valore;
            }
            return instance;
        }
    }
}
