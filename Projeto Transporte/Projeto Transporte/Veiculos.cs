using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_Transporte
{
    class Veiculos
    {
        public List<Veiculo> veiculos { get; set; }
        public void incluir(Veiculo veiculo)
        {
            veiculos.Add(veiculo);
        }
    }
}
