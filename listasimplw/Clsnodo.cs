using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listasimple
{
    internal class Clsnodo
    {
        public string nombreArchivo;
        public Clsnodo siguiente;

        public Clsnodo(string nombreArchivo)
        {
            this.nombreArchivo = nombreArchivo;
            this.siguiente = null;

        }
    }
}
