using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEILAO
{
    class Lance
    {
        public Usuario user { get; private set; }
        public double valor { get; private set; }

        public Lance(Usuario user, double vl)
        {
            this.user = user;
            this.valor = vl;
        }
    }
}
