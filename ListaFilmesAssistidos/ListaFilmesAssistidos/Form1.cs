using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListaFilmesAssistidos
{
    public partial class Form1 : Form
    {
        Dictionary<string, List<Filme>> dicionario = new Dictionary<string, List<Filme>>();
        
        public void Cadastrar()
        {
            if (nometxt.Text != "" & generocbox.Text != "" & localtxt.Text != "")
            {
                //Converte a data para uma data menor.
                string dataconvertidada = dateTimePicker1.Value.ToShortDateString();

                // A variável agarra pega todos o textos editados no visual e armzena na classe.
                Filme agarra = new Filme(nometxt.Text, generocbox.Text, dataconvertidada, localtxt.Text);

                ListViewItem Itens = new ListViewItem();
                Itens.Text = nometxt.Text;
                Itens.Group = listView1.Groups[generocbox.Text];
                listView1.Items.Add(Itens);
                Itens.SubItems.Add(generocbox.Text);
                Itens.SubItems.Add(dataconvertidada);
                Itens.SubItems.Add(localtxt.Text);

                //Verifica se a chave já existe
                if (dicionario.ContainsKey(generocbox.Text))
                {
                    List<Filme> pegarpassar = dicionario[generocbox.Text];
                    pegarpassar.Add(agarra);
                    Limpar();
                }
                else
                {
                    List<Filme> pegarpassar = new List<Filme>();
                    pegarpassar.Add(agarra);
                    dicionario.Add(generocbox.Text, pegarpassar);
                    Limpar();
                }
            }

            else
            {
                MessageBox.Show("Erro!! Digite corretamente os campos", "Informação", MessageBoxButtons.OK);
            }
        }

        public void Limpar()
        {
            nometxt.Text = "";
            localtxt.Text = "";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastrar();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Remove(listBox1.Text);
            //ListView1.ListItems.Remove(ListView1.SelectedItem);
        }
    }
}
