using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonADICIONAR_Click(object sender, EventArgs e)
        {
            if (TextBoxID.Text == "")
            {
                MessageBox.Show("ID Não pode ser vazio, por favor preencha o ID");
                TextBoxID.Focus();
                return;
            }
            if (TextBoxPRODUTO.Text == "")
            {
                MessageBox.Show("PRODUTO Não pode ser vazio, por favor preencha o PRODUTO");
                TextBoxPRODUTO.Focus();
                return;
            }
            if (TextBoxQUANTIDADE.Text == "")
            {
                MessageBox.Show("QUANTIDADE Não pode ser vazio, por favor preecnha o QUANTIDADE");
                TextBoxQUANTIDADE.Focus();
                return;
            }
            if (TextBoxPREÇO.Text == "")
            {
                MessageBox.Show("PREÇO Não pode ser vazio, por favor preecha o PREÇO");
                TextBoxPREÇO.Focus();
                return;
            }

            String[] produtos = new string[4];
            produtos[0] = TextBoxID.Text;
            produtos[1] = TextBoxPRODUTO.Text;
            produtos[2] = TextBoxQUANTIDADE.Text;
            produtos[3] = TextBoxPREÇO.Text;

            ListViewItem L = new ListViewItem(produtos);
            ListViewProdutos.Items.Add(L);
            limpar();

            
        }

        private void limpar()
        {
            TextBoxID.Clear();
            TextBoxPRODUTO.Clear();
            TextBoxQUANTIDADE.Clear();
            TextBoxPREÇO.Clear();
            TextBoxID.Focus();
        }

        private void ButtonREMOVER_Click(object sender, EventArgs e)
        {
            ListViewProdutos.Items.RemoveAt(ListViewProdutos.SelectedIndices[0]);
        }
    }
}
