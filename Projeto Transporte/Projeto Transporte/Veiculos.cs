using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_Transporte
{
    class Veiculos
    {
        public List<Veiculo> veiculos { get; set; }
        public Veiculos()
        {
            this.veiculos = new List<Veiculo>();
        }
        public void incluir(Veiculo veiculo)
        {
            if (veiculos.Count < 8)
                veiculos.Add(veiculo);
            else
                Console.WriteLine("Numero de veiculos excedido");
        }
    }
}
