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
        ListViewItem Itens = new ListViewItem();

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
            foreach (ListViewItem PegaItem in listView1.SelectedItems)
            {
                List<Filme> lis = dicionario[PegaItem.SubItems[1].Text];
                List<Filme> lis2 = dicionario[PegaItem.Text];

                if(dicionario.ContainsKey(lis.ToString()))
                {
                    if(dicionario.ContainsValue(lis2))
                    {
                        dicionario.Remove(PegaItem.Text);
                    }
                }
                //while (dicionario.ContainsKey(lis.ToString()))
                //{

                //}

                listView1.Items.Remove(PegaItem);
            }
            
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, List<Filme>> pesquisa in dicionario)
            {
                //listView2.Items.AddRange
                //ListViewItem RecebePesq = new ListViewItem(pesquisa.Value[0].ToString());
                //ListViewItem RecebePesq = new ListViewItem();

                ListViewItem RecebePesq = new ListViewItem();
                //////////////////RecebePesq = pesquisa.Value
                //RecebePesq.Group = listView1.Groups[RecebePesq.Text];
                listView2.Items.Add(pesquisa.Key);
                //RecebePesq.SubItems.Add(generocbox.Text);
                //RecebePesq.SubItems.Add(dataconvertidada);
                //RecebePesq.SubItems.Add(localtxt.Text);
            }
        }
    }
}