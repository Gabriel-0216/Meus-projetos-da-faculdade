using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bancodescente
{
    class Cliente
    {
        private String nome;
        private int numConta;
        private double saldo;

        public Cliente()
        {

        }

        public int getNumeroConta()
        {
            return numConta;
        }

        public void setNumeroConta(int numConta)
        {
            this.numConta = numConta;

        }
        public String getNome()
        {
            return nome;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public void setSaldo(double saldo)
        {
            this.saldo = saldo;
        }

        public double getSaldo()
        {
            return saldo;
        }

        
        public override string ToString()
        {
            return "\nNOME DO TITULAR DA CONTA: " + getNome() +
                   "\nNÚMERO DA CONTA.......: " + getNumeroConta() +
                   "\nSALDO ATUAL....... - R$ " + getSaldo() + " ";
         }
     

    }
}
