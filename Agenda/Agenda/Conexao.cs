using MySql.Data.MySqlClient;
using System;


namespace Agenda
{
    public class Conexao
    {
        private MySqlConnection cnn;

        public Conexao()
        {

            cnn = new MySqlConnection();
            try
            {

                cnn.ConnectionString = "server=localhost;database=agenda;username=root;password=";
                cnn.Open();
                Console.WriteLine("Conectado");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


        }

        public MySqlConnection getCnn()
        {
            return this.cnn;
        }


    }
}
