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
        string EditarFilme;
        int EditarGenero;
        //DateTime EditarData;
        string EditarLocal;

        public void Cadastrar()
        {
            if (nometxt.Text != "" & generocbox.Text != "" & localtxt.Text != "")
            {
                //Converte a data para uma data menor.
                string dataconvertidada = dateTimePicker1.Value.ToShortDateString();
                
                // O objeto agarra pega todos o textos editados no visual e armzena na classe.
                Filme agarra = new Filme(nometxt.Text, generocbox.Text, dateTimePicker1.Text , localtxt.Text);
                
                
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

        

        private void btDeletar_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem PegaItem in listView1.SelectedItems)
            {
                //List<Filme> lis = dicionario[PegaItem.SubItems[1].Text];
                
                string Genero1 = PegaItem.SubItems[1].Text;// Group.Header;
                List<Filme> LiFilme = dicionario[Genero1];
                
                string Nome = PegaItem.Text;
                //List<Filme> Nome1 = PegaItem.Text;

                for (int I = 0; I < LiFilme.Count; I++ )
                {
                    if(LiFilme[I].Nome == PegaItem.Text)
                    {
                        MessageBox.Show("Excluído","");
                        LiFilme.RemoveAt(I);
                        dicionario.Remove(Genero1);
                        I--;
                        //List<Filme> ListVal = dicionario[Nome];
                        //for()
                        //{

                        //}
                    }
                }
                listView1.Items.Remove(PegaItem);

            }
            
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            foreach(List<Filme> PegaValor in dicionario.Values)
            {
                foreach(Filme DicionarioValores in PegaValor)
                {
                    if(DicionarioValores.Nome == EditarFilme)
                    {
                        //listView1.SelectedItems


                        DicionarioValores.Nome = nometxt.Text;
                        DicionarioValores.Genero = generocbox.Text;
                        DicionarioValores.Data = dateTimePicker1.Text;
                        DicionarioValores.Local = localtxt.Text;
                    }
                }
            }
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
                generocbox.Text = FilmeSelecionado.Group.Header;
                //dateTimePicker1.Value = Convert.ToDateTime(FilmeSelecionado.SubItems[1].Text);
                localtxt.Text = FilmeSelecionado.SubItems[3].Text;

                EditarFilme = FilmeSelecionado.Text;
                //EditarData = Convert.ToDateTime(FilmeSelecionado.SubItems[1].Text);
                EditarLocal = FilmeSelecionado.SubItems[3].Text;
                EditarGenero = listView1.Groups.IndexOf(FilmeSelecionado.Group);
            }
        }
    }
}