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
        ListViewItem PegaItem2 = new ListViewItem();
        string EditarFilme;
        int EditarGenero;
        //DateTime EditarData;
        string EditarLocal;

        // Salva no dlistview
        public void salvar()
        {
            Filme agarra = new Filme(nometxt.Text, generocbox.Text, dateTimePicker1.Text, localtxt.Text);
            //Condição para executar cadastro
            if (nometxt.Text != "" & generocbox.Text != "" & localtxt.Text != "")
            {
                string dataconvertidada = dateTimePicker1.Value.ToShortDateString();
                ListViewItem Itens = new ListViewItem();
                Itens.Group = listView1.Groups[generocbox.Text];
                Itens.Text = nometxt.Text;
                Itens.SubItems.Add(generocbox.Text);
                Itens.SubItems.Add(dateTimePicker1.Text);
                Itens.SubItems.Add(localtxt.Text);
                listView1.Items.Add(Itens);

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

                apagar();
            }
            else
            {
                MessageBox.Show("Erro!! Digite corretamente os campos", "Informação", MessageBoxButtons.OK);
                btDeletar.Enabled = true;
                bteditar.Enabled = true;
                btsalvar.Enabled = false;
            }
        }

        public void Cadastrar()
        {
            if (nometxt.Text != "" & generocbox.Text != "" & localtxt.Text != "")
            {
                // O objeto agarra pega todos o textos editados no visual e armzena na classe.
                Filme agarra = new Filme(nometxt.Text, generocbox.Text, dateTimePicker1.Text, localtxt.Text);

                salvar();

                //Verifica se a chave já existe
                if (dicionario.ContainsKey(generocbox.Text))
                {
                    List<Filme> pegarpassar = new List<Filme>(dicionario[generocbox.Text]);
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

        
        public void voltainicialenableds()
        {
            btsalvar.Enabled = true;
            bteditar.Enabled = false;
            btDeletar.Enabled = false;
        }

        public void Limpar()
        {
            nometxt.Text = "";
            localtxt.Text = "";
            generocbox.Text = "";
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void apagar()
        {
            foreach (ListViewItem PegaItem in listView1.SelectedItems)
            {
                List<Filme> lis = dicionario[listView1.SelectedItems[0].Group.Header];
                
                //Exclui da Lista Filme.
                for (int I = 0; I < lis.Count; I++)
                {
                    Filme pegaapaga = lis[I];
                    if (pegaapaga.Nome == listView1.SelectedItems[0].Text)
                    {
                        lis.Remove(pegaapaga);
                        listView1.Items.Remove(PegaItem);
                        voltainicialenableds();
                        Limpar();
                        voltainicialenableds();
                    }
                }
            }
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Excluído", "");
            //apagar();
            foreach (ListViewItem PegaItem in listView1.SelectedItems)
            {
                List<Filme> lis = dicionario[listView1.SelectedItems[0].Group.Header];
                //Exclui da Lista Filme.
                for (int I = 0; I < lis.Count; I++)
                {
                    Filme pegaapaga = lis[I];
                    if (pegaapaga.Nome == listView1.SelectedItems[0].Text)
                    {
                        lis.Remove(pegaapaga);
                        listView1.Items.Remove(PegaItem);
                        voltainicialenableds();
                        Limpar();
                    }
                }
                
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            salvar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, List<Filme>> pesquisa in dicionario)
            {
                ListViewItem RecebePesq = new ListViewItem();

                listView2.Items.Add(pesquisa.Key);

                RecebePesq.SubItems.Add(pesquisa.Key);
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            foreach (ListViewItem FilmeSelecionado in listView1.SelectedItems)
            {
                nometxt.Text = FilmeSelecionado.Text;
                generocbox.Text = FilmeSelecionado.SubItems[0].Text;
                //dateTimePicker1.Value = Convert.ToDateTime(FilmeSelecionado.SubItems[1].Text);
                localtxt.Text = FilmeSelecionado.SubItems[3].Text;

                EditarFilme = FilmeSelecionado.Text;
                //EditarData = Convert.ToDateTime(FilmeSelecionado.SubItems[1].Text);
                EditarLocal = FilmeSelecionado.SubItems[3].Text;
                EditarGenero = listView1.Groups.IndexOf(FilmeSelecionado.Group);

                btDeletar.Enabled = true;
                bteditar.Enabled = true;
                btsalvar.Enabled = false;
            }
        }

        private void btpesquisa_Click(object sender, EventArgs e)
        {

        }

        private void Pesquisagenerocbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Pesquisagenerocbx.Text != "")
            {
                listView2.Visible = true;
                btpesquisa.Visible = true;
            }
        }
    }
}