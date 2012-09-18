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
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nometxt.Text != "" & generocbox.Text != "" & datamask.Text != "" & localtxt.Text != "")
            {
                MessageBox.Show("Salvo com sucesso !!", "Informação", MessageBoxButtons.OK);
            }

            else
            {
                MessageBox.Show("Erro!! Digite corretamente os campos", "Informação", MessageBoxButtons.OK);
            }
        }
    }
}
