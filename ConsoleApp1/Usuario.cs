using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEILAO
{
    class Usuario
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public Usuario(string name): this(0, name)
        {
        }

        public Usuario(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
