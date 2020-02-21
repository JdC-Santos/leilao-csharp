using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEILAO
{
    class Leilao
    {
        public string description { get; set; }
        public IList<Lance> Lances { get; set; }

        public Leilao(string description)
        {
            this.description = description;
            this.Lances = new List<Lance>();
        }

        public void Propoe(Lance lance)
        {
            Lances.Add(lance);
        }
    }
}
