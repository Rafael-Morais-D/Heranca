using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public class Reptil : Animal
    {
        public bool PossuiVeneno { get; set; }

        public Reptil(string nome, string especie, bool possuiVeneno)
        {
            Nome = nome;
            Especie = especie;
            PossuiVeneno = possuiVeneno;
        }

        public void BotarOvo()
        {
            Console.WriteLine($"Animal {Nome} da espécie {Especie} botando ovo!");
            Console.WriteLine(PossuiVeneno ? $"{Nome} é venenoso, cuidado!": $"{Nome} não é venenoso.");
        }
    }
}
