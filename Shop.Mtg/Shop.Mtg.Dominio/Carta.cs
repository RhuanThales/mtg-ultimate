using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Mtg.Dominio
{
    public class Carta
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CustoMana { get; set; }
        public int CustoManaConvertido { get; set; }
        public string Tipo { get; set; }
        public bool Lendaria { get; set; }
        public string SubTipoA { get; set; }
        public string SubTipoB { get; set; }
        public string Raridade { get; set; }
        public string Descricao { get; set; }
        public int Poder { get; set; }
        public int Resistencia { get; set; }
        public string Edicao { get; set; }
    }
}
