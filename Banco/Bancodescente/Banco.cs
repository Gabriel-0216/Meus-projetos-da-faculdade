using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bancodescente
{
    class Banco
    {
        private int tamanho;
        private Cliente[] clientes;
        
        public Banco()
        {
            clientes = new Cliente[5];
            tamanho = 0;
        }
        public void adicionaClientes(String nome, double saldo)
        { 
            try
            {
                Cliente cliente = new();
                cliente.setNome(nome);
                cliente.setNumeroConta(tamanho);
                cliente.setSaldo(saldo);
                clientes[tamanho] = cliente;
                tamanho++;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void extratoBancario(int numConta)
        {

            if (verificarExistenciaCliente(numConta) == true)
            {
                try
                {
                    Console.WriteLine(clientes[numConta].ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else {
                Console.WriteLine("Essa conta não existe!");
            }

        }
 
        public bool verificarExistenciaCliente(int numConta)
        {
            bool existe = false;
            for(int i=0; i<tamanho; i++)
            {
                if (clientes[i].getNumeroConta().Equals(numConta))
                {
                    existe = true;
                    break;
                }
                else {
                    existe = false;

                }
            }
            return existe;
        }
        public void depositoBancario(int numConta, double saldo)
        {
            if (verificarExistenciaCliente(numConta).Equals(true))
            {
              double saldoAtual= clientes[numConta].getSaldo();
                saldoAtual += saldo;
                clientes[numConta].setSaldo(saldoAtual);
                Console.WriteLine("TRANSAÇÃO REALIZADA COM SUCESSO!");
            }
            else {
                Console.WriteLine("Conta não existe");
            }
        }

        public void saque(int numConta, double saque)
        {
            if (verificarExistenciaCliente(numConta).Equals(true))
            {
                if (clientes[numConta].getSaldo() < saque)
                {
                    Console.WriteLine("Seu saldo é insuficiente para realizar essa transação");
                }
                else {
                    double saldoAtual = clientes[numConta].getSaldo();
                    saldoAtual -= saque;
                    clientes[numConta].setSaldo(saldoAtual);
                    Console.WriteLine("TRANSAÇÃO REALIZADA COM SUCESSO!");
                }
            }
            else
            {
                Console.WriteLine("Conta não existe");
            }
        }

        public void transferenciaBancaria(int numContaDestino, int numContaSaida, double valor) {
            if (verificarExistenciaCliente(numContaSaida).Equals(true) && verificarExistenciaCliente(numContaDestino).Equals(true))
            {
                try
                {
                    if (clientes[numContaSaida].getSaldo() > valor)
                    {
                        double valorAtualDestino = clientes[numContaDestino].getSaldo();
                        clientes[numContaDestino].setSaldo(valorAtualDestino += valor);

                        double valorAtualSaida = clientes[numContaSaida].getSaldo();
                        clientes[numContaSaida].setSaldo(valorAtualSaida -= valor);
                        Console.WriteLine("TRANSAÇÃO REALIZADA COM SUCESSO!");
                    }
                    else {
                        Console.WriteLine("SEU SALDO É INSUFICIENTE PARA REALIZAR ESSA TRANSAÇÃO!");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else {
                Console.WriteLine("Ocorreu algum erro!");
            }
        }
    }
}
