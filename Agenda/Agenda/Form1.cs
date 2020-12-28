using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace Agenda
{
    public partial class Form1 : Form
    {
        private ContatoDAO dao = new ContatoDAO();
        public Form1()
        {
            InitializeComponent();
        }
     

        private void adicionarButton(object sender, EventArgs e)
        {
            long numero =000000000;
            Match m = Regex.Match(textBox2.Text, "^[0-9]{9}$");


            if (m.Success)
            {
                numero = long.Parse(textBox2.Text);
                
                Contato contato = new Contato(textBox1.Text, numero);

                if (dao.adicionarContato(contato))
                {
                    MessageBox.Show("Seu contato foi adicionado com sucesso.", "Contato salvo.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Nome não foi preenchido.", "Falha ao adicionar contato.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                 MessageBox.Show("É necessário que você coloque 9 números e não é permito letras(a,b,c,d...) ou caracteres(-,!,@...)", "Falha ao adicionar contato.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
        }

        private void alterarNomeButton(object sender, EventArgs e)
        {

        }

        private void alterarNumeroButton(object sender, EventArgs e)
        {

        }

        private void excluiButton(object sender, EventArgs e)
        {

        }

        private void fecharButton(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
    }
}
