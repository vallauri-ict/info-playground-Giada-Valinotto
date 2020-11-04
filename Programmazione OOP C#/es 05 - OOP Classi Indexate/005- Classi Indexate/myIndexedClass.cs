using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005__Classi_Indexate
{
    class MyIndexedClass
    {
        private string[] element;

        public MyIndexedClass(int elementNumber)
        {
            element = new string[elementNumber];
            for (int i = 0; i < elementNumber; i++)
            {
                element[i] = "empty";
            }
        }
        //****ITERATORE****\\
        /*Metodo pubblico che restituisce una stringa
         richiamato al vect[1]="pippo2 nel Main*/
        public string this [int pos]
        {
            get
            {
                return element[pos];  //posizione nel vettore
            }
            set
            {
                element[pos] = value; //value = (nell'esempio pippo)
            }
        }

        public int returnLength()
        {
            return element.Length;
        }
    }
}
