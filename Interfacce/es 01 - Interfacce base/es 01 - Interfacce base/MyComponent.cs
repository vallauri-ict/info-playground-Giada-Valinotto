using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_01___Interfacce_base
{
    class MyComponent : IDispAggiuntivo
    {
        private int _id;
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        private bool _status;
        public bool status => throw new NotImplementedException();

        public void connetti(string s)
        {
            _status = true;
            id++;
            System.Windows.Forms.MessageBox.Show("Connesso da : " + s);
        }
        public void disconnetti(string s)
        {
            _status = false;
            System.Windows.Forms.MessageBox.Show("DIsconnesso da : " + s);
        }
        public void Stato()
        {
            if (status)
            {
                System.Windows.Forms.MessageBox.Show("Attualmente connesso con id "+id);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Non connesso");
            }
        }
    }
}
