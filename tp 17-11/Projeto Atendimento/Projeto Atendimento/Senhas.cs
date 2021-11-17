﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Atendimento
{
    class Senhas
    {
        public int proximoAtendimento{ get; set; }
        public Queue<Senha> filaSenhas { get; set; }
        public Senhas()
        {
            this.filaSenhas = new Queue<Senha>();
            proximoAtendimento = 1;
        }
        public void gerar()
        {
            filaSenhas.Enqueue(new Senha(proximoAtendimento));
            proximoAtendimento++;
        }
    }
}
