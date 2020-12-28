using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public class Contato
    {
    
        private string nome;
        private long numero;

        public Contato(string nome, long numero)
        {
                this.nome = nome;
                this.numero = numero;
               
        }


        //Get e Sets
        public void setNome(string nome)
        {
            this.nome = nome;
        }
       
        public string getNome()
        {
            return this.nome;
        }

        public void setNumero(long numero)
        {
            this.numero = numero;
        }

        public long getNumero()
        {
            return this.numero;
        }

    }
}
