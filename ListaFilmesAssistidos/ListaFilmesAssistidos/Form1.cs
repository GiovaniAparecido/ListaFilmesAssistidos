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
    static public class Filmes
    {
        public string[] Nomes = new string[50];
        public string[] Generos =new string[50];
        public string[] Datas = new string[50];
        public string[] Locais = new string[50];
    }

    public partial class Form1 : Form
    {
        public void Cadastrar()
        {
            
            

            if (nometxt.Text != "" & generocbox.Text != "" & datamask.Text != "" & localtxt.Text != "")
            {
                Dictionary<string, List<string>> dicionario = new Dictionary<string, List<string>>();
                List<string> dados = new List<string>();

            }

            else
            {
                MessageBox.Show("Erro!! Digite corretamente os campos", "Informação", MessageBoxButtons.OK);
            }
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
    }
}
