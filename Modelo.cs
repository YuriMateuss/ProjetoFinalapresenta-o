using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProejtoFinalPEOOFabricantedeVeiculos
{
    public class Modelo
    {
        internal object preco;

        public int Id { get; set; }
        public string ModeloC { get; set; }
        public int Preco { get; set; }
        public int IdVeiculo { get; set; }
        public override string ToString()
        {
            if (IdVeiculo == 0)
                return $"{Id} - {ModeloC} - {Preco}";
            else
                return $"{Id} - {ModeloC} - {Preco} - Veiculo: {IdVeiculo}";
        }
    }
}
