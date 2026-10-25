using System;

namespace MiniBancoConsoleApp;

class Program
{
    static void Main()
    {
        // Os nomes e os saldos (o João já começa com -85.50)
        string[] nomes = { "Maria", "João", "Júlia" };
        decimal[] saldos = { 150.75m, -85.50m, 300.25m };
        
        int escolhaConta = 0;

        while (escolhaConta != 4)
        {
            Console.Clear();
            Console.WriteLine("=== MINIBANCO .NET - MOTOR DE GESTAO DE CONTAS ===");
            Console.WriteLine("==================================================");
            Console.WriteLine("PROCESSANDO CONTA");
            Console.WriteLine("=============================================");
            Console.WriteLine(">DADOS DA CONTA :");
            Console.WriteLine("1 - " + nomes[0] + " (R$ " + saldos[0] + ")");
            Console.WriteLine("2 - " + nomes[1] + " (R$ " + saldos[1] + ")");
            Console.WriteLine("3 - " + nomes[2] + " (R$ " + saldos[2] + ")");
            Console.WriteLine("4 - Sair");
            Console.Write("Digite o numero: ");

            try
            {
                escolhaConta = int.Parse(Console.ReadLine());

                if (escolhaConta >= 1 && escolhaConta <= 3)
                {
                    int i = escolhaConta - 1; // Pega a posição certa (0, 1 ou 2)
                    int acao = 0;

                    while (acao != 4)
                    {
                        Console.Clear();
                        Console.WriteLine("CONTA DE " + nomes[i] + " | Saldo: R$ " + saldos[i]);
                        Console.WriteLine("1 - Depositar");
                        Console.WriteLine("2 - Sacar");
                       Console.WriteLine("3 - Cobrar Tarifa");
                        Console.WriteLine("4 - FINALIZAR");
                        Console.Write("Escolha a acao: ");

                  acao =int.Parse(Console.ReadLine());

                  if(acao ==1)
                        {
                            Console.WriteLine("valor do deposito");
                            decimal valor = decimal.Parse(Console.ReadLine());
                            saldos[1] = saldos [1]+valor;
                            Console.WriteLine("Deposito Realizado");
                        }
                        else if (acao ==2 || acao == 3)
                        {
                            Console.WriteLine("valor");
                            decimal valor= decimal.Parse(Console.ReadLine());
                        
                            if(saldos[i] - valor<0)
                            {
                                Console.WriteLine ("erro:saldo insuficiente");
                            }
                            else
                            {
                                saldos[i] =saldos[i] -valor;
                                Console.WriteLine("operacao realizada com sucesso");
                            }
                        }

                        if (acao == 4)
                        {
                            Console.WriteLine("Pressione Enter para continiuar");
                            Console.ReadLine();
                }
                    }
                }
            }

                
            catch(Exception)
            {
                    Console.WriteLine(" erro:digite apenas o numero valido");
                    Console.WriteLine("Pressione Enter para continuar");
                    Console.ReadLine();
            }
            }
        }
    }