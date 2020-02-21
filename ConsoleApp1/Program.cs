using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEILAO
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario davi    = new Usuario("davi");
            Usuario jonatas = new Usuario("Jonatas");
            Usuario jdc     = new Usuario("jdc");

            Leilao leilao = new Leilao("Cubo Magico");
            leilao.Propoe(new Lance(davi,280.0));
            leilao.Propoe(new Lance(jonatas, 400.0));
            leilao.Propoe(new Lance(jdc, 500.0));

            Avaliador avaliador = new Avaliador();
            avaliador.Avalia(leilao);

            Console.WriteLine(avaliador.MaiorLance());
            Console.WriteLine(avaliador.MenorLance());

            Console.ReadKey();
        }
    }
}
