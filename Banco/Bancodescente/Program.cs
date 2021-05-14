using System;

namespace Bancodescente
{
    class Program
    {
        static void Main(string[] args)
        {
            bool parar = false;
            Banco banco = new Banco();
            int opc = 0;
            int numConta = 0;
     
            while (parar != true)
            {

              
                Console.WriteLine("BEM VINDO AO BANCO");
            Console.WriteLine("DIGITE 1 PARA CADASTRAR UM NOVO CLIENTE");
            Console.WriteLine("DIGITE 2 PARA EXTRATO BANCÁRIO DE UM CLIENTE");
            Console.WriteLine("DIGITE 3 PARA DEPÓSITO BANCÁRIO");
            Console.WriteLine("DIGITE 4 PARA SAQUE BANCÁRIO");
            Console.WriteLine("DIGITE 5 PARA TRANSFERÊNCIA BANCÁRIA!");
            bool sucesso = false;
            while (sucesso != true)
            {
                try
                {
                    opc = int.Parse(Console.ReadLine());
                    sucesso = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                    Console.WriteLine("O cáracter digitado não é um número!");
                }
            }

                switch (opc)
                {
                    case 1:
                        Console.WriteLine("Digite o nome do titular da conta");
                        string nome = Console.ReadLine();

                        Console.WriteLine("Digite o saldo do titular da conta:");
                        double saldo = double.Parse(Console.ReadLine());

                        banco.adicionaClientes(nome, saldo);

                        Console.ReadLine();
                        Console.Clear();
                        break;

                   

                    case 2:

                        Console.WriteLine("DIgite o número da conta do extrato:");
                        numConta = int.Parse(Console.ReadLine());
                        banco.extratoBancario(numConta);
                        break;
                    case 3:
                        sucesso = false;
                        while (sucesso != true)
                        {
                            try
                            {
                                Console.WriteLine("Digite o número da conta de destino:");
                                int numContaDestino = int.Parse(Console.ReadLine());
                                if (banco.verificarExistenciaCliente(numContaDestino) == true)
                                {
                                    Console.WriteLine("Digite o valor a ser depositado: R$");
                                    double valorDeposito = double.Parse(Console.ReadLine());

                                    banco.depositoBancario(numContaDestino, valorDeposito);
                                    sucesso = true;

                                }
                                else
                                {
                                    Console.WriteLine("Essa conta não existe!");
                                }
                            }catch(Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }

                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;


                    case 4:

                        sucesso = false;
                        while (sucesso != true)
                        {

                            Console.WriteLine("Digite o número da conta");
                            numConta = int.Parse(Console.ReadLine());

                            if (banco.verificarExistenciaCliente(numConta) == true)
                            {
                                Console.WriteLine("Digite o valor do saque em reais, R$:");
                                double saque = double.Parse(Console.ReadLine());
                                banco.saque(numConta, saque);
                                sucesso = true;

                            }
                            else
                            {
                                Console.WriteLine("Essa conta não existe!");
                            }

                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;


                    case 5:
                        try
                        {
                            sucesso = false;
                            while (sucesso != true)
                            {
                                Console.WriteLine("Digite o número da sua conta:");
                                numConta = int.Parse(Console.ReadLine());
                                if (banco.verificarExistenciaCliente(numConta) == true)
                                {
                                    sucesso = true;
                                }
                                else {
                                    Console.WriteLine("CONTA NÃO EXISTE");
                                }
                            }
                            sucesso = false;
                            while (sucesso != true)
                            {
                                Console.WriteLine("Digite o número da conta do destino:");
                                int numContaDestino = int.Parse(Console.ReadLine());
                                if (banco.verificarExistenciaCliente(numContaDestino) == true)
                                {
                                    sucesso = true;
                                    Console.WriteLine("Digite o valor a ser transferido em reais. R$:");
                                    double valor = double.Parse(Console.ReadLine());

                                    banco.transferenciaBancaria(numContaDestino, numConta, valor);
                                   
                                }
                                else
                                {
                                    Console.WriteLine("CONTA NÃO EXISTE");
                                }
                            }


                        }
                        catch(Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    default:
                        parar = true;
                        break;

                }




            }
        }
    }
}
