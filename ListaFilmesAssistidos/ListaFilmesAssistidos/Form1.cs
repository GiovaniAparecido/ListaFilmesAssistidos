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
        public Dictionary<string, List<Filme>> dicionario = new Dictionary<string, List<Filme>>();
        
        public void Cadastrar()
        {
            string datinha = dateTimePicker1.Value.ToShortDateString();
            Filme agarra = new Filme(nometxt.Text, generocbox.Text, datinha, localtxt.Text);
            if (nometxt.Text != "" & generocbox.Text != "" & localtxt.Text != "")
            {

            }

            else
            {
                MessageBox.Show("Erro!! Digite corretamente os campos", "Informação", MessageBoxButtons.OK);
            }
        }





        //Dictionary<string, List<string>> dicionario = new Dictionary<string, List<string>>();
        //        //List<string> dados = new List<string>();
        //public void Cadastrar()
        //{
        //    if (nometxt.Text != "" & generocbox.Text != "" & datamask.Text != "" & localtxt.Text != "")
        //    {
        //        //Dictionary<string, List<string>> dicionario = new Dictionary<string, List<string>>();
        //        //List<string> dados = new List<string>();

        //    }

        //    else
        //    {
        //        MessageBox.Show("Erro!! Digite corretamente os campos", "Informação", MessageBoxButtons.OK);
        //    }
        //}

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
    }
}
