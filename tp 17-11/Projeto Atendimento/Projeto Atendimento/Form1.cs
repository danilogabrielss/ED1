using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Atendimento
{
    public partial class Form1 : Form
    {
        Senha senha = new Senha();
        Senhas senhas = new Senhas();
        Guiche guiche = new Guiche();
        Guiches guiches = new Guiches();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonListarSenhas_Click(object sender, EventArgs e)
        {
            listBoxSenhas.Items.Clear();
            foreach (Senha sn in senhas.filaSenhas)
            {
                listBoxSenhas.Items.Add(sn.dadosParciais());
            }
        }
        private void buttonGerarSenha_Click(object sender, EventArgs e)
        {
            senhas.gerar();
        }

        private void buttonAddGuiche_Click(object sender, EventArgs e)
        {
            guiches.adicionar(guiche);
            labelQtdGuiches.Text = Convert.ToString(guiches.listaGuiches.Count);
        }

        private void buttonListarAtdm_Click(object sender, EventArgs e)
        {
            listBoxAtendimentos.Items.Clear();
            foreach (Senha sen in guiche.atendimentos)
            {
                listBoxAtendimentos.Items.Add(sen.dadosCompletos());
            }
        }

        private void buttonChamar_Click(object sender, EventArgs e)
        {
            int guich = Convert.ToInt32(textBoxGuiche.Text);
            if (guiches.listaGuiches.Count != 0)
            {
                guiche.chamar(senhas.filaSenhas);
            }
        }
    }
}
