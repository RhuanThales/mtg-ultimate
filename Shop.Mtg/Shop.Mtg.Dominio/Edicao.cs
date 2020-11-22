using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Mtg.Dominio
{
    public class Edicao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public int Ano { get; set; }
        public virtual List<Carta> Cartas { get; set; }
    }
}
