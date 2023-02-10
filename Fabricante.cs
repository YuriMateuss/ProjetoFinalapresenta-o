using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProejtoFinalPEOOFabricantedeVeiculos
{ 
        public class Fabricante
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public override string ToString()
        {
            return $"{Id} - {Nome} - {Sigla}";
        }
    }

}
