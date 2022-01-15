using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_Transporte
{
    class Veiculo
    {
        public int id { get; set; }
        public string placa { get; set; }
        public int lotacao { get; set; }
        public Veiculo() { }
        public Veiculo(int id, string placa, int lotacao)
        {
            this.id = id;
            this.placa = placa;
            this.lotacao = lotacao;
        }
        public string ToString()
        {
            return "ID: "+ this.id + "\nPlaca: " + this.placa + "\nLotacao: "+ this.lotacao;
        }
    }
}
