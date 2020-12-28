using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class ContatoDAO
    {
        private Conexao cnn = new Conexao();
        public Boolean adicionarContato(Contato contato)
        {
            if (contato.getNome() == "" || contato.getNome() == null)
            {

                try
                {
              
                    MySqlCommand cmd = new MySqlCommand("INSERT TO contato (nome, numero)" +
                    "VALUES ('" + contato.getNome() + ", " + contato.getNumero() + "')", cnn.getCnn());


                    cmd.ExecuteNonQuery();
                    
                }
                catch (Exception falhaSalvar)
                {
                    Console.WriteLine(falhaSalvar.ToString());
                }

                


                Console.WriteLine("Contato está errado, por isso não foi adicionado.");
                return false;
            }
            else
            {
                Console.WriteLine("Contato adicionado com sucesso!");
                return true;

            }
        }
    }
}
