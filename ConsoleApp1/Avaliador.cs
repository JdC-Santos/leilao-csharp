using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEILAO
{
    class Avaliador
    {
        private double menor = Double.MaxValue;
        private double maior = Double.MinValue;

        public void Avalia(Leilao leilao)
        {
            foreach (var lance in leilao.Lances)
            {
                if (lance.valor > maior)
                {
                    maior = lance.valor;
                }else if (lance.valor < menor)
                {
                    menor = lance.valor;
                }
            }
        }

        public double MaiorLance()
        {
            return this.maior;
        }

        public double MenorLance()
        {
            return this.menor;
        }
    }
}
