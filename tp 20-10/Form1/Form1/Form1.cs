using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form1 : Form
    {
        Data data = new Data();
        Contato contato = new Contato();
        Contatos contatos = new Contatos();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            textBoxEmail.Clear();
            textBoxNome.Clear();
            textBoxFone.Clear();
            textBoxDia.Clear();
            textBoxMes.Clear();
            textBoxAno.Clear();
            listBox1.Items.Clear();
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int diaTextBox = int.Parse(textBoxDia.Text);
            int mesTextBox = int.Parse(textBoxMes.Text);
            int anoTextBox = int.Parse(textBoxAno.Text);
            string emailTextBox = textBoxEmail.Text;
            string nomeTextBox = textBoxNome.Text;
            string foneTextBox = textBoxFone.Text;
            data = new Data(diaTextBox, mesTextBox, anoTextBox);
            contato = new Contato(emailTextBox, nomeTextBox, foneTextBox, data);
            listBox1.Items.Add(contatos.adicionar(contato));
        }

        private void button2Excluir_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            contato = new Contato(textBoxEmail.Text, "", "", data);
            listBox1.Items.Add(contatos.remover(contato));
        }

        private void buttonPesquisa_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            contato = new Contato(textBoxEmail.Text, "", "", data);
            listBox1.Items.Add(contatos.pesquisar(contato).ToString());
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Contato ctt in contatos.agenda)
            {
                listBox1.Items.Add(ctt.ToString());
            }
        }
    }
}
