using System;

namespace MiniBancoConsoleApp
{
    public class ContaCorrente
    {
        public static void Main()
        {
            // Inicialização dos dados das contas
            string[] nomes = { "Maria", "João", "Julia" };
            decimal[] saldos = { 150.75m, -85.50m, 300.25m };

            int escolhaConta = 0;

            while (escolhaConta != 4)
            {
                Console.Clear();
                Console.WriteLine("--- MINIBANCO .NET - MOTOR DE GESTAO DE CONTAS ---");
                
                // Exibe as contas disponíveis
                for (int i = 0; i < nomes.Length; i++)
                {
                    Console.WriteLine($"[{i}] Conta de: {nomes[i]} | Saldo: R$ {saldos[i]}");
                }
                
                Console.WriteLine("\n[4] Sair do Sistema");
                Console.Write("\nEscolha uma opção/conta: ");
                
                if (!int.TryParse(Console.ReadLine(), out escolhaConta))
                {
                    continue;
                }

                if (escolhaConta >= 0 && escolhaConta < nomes.Length)
                {
                    Console.Clear();
                    Console.WriteLine($"\nGerenciando conta de: {nomes[escolhaConta]}");
                    Console.WriteLine("[1] Sacar / Depositar");
                    Console.Write("Escolha a ação: ");
                    string acao = Console.ReadLine();

                    if (acao == "1")
                    {
                        Console.Write("Digite o valor da operação: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal valor))
                        {
                            // Altera o saldo da conta selecionada dinamicamente
                            saldos[escolhaConta] += valor;
                            Console.WriteLine($"Operação realizada! Novo saldo: R$ {saldos[escolhaConta]}");
                        }
                    }
                    
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
            }
            
            Console.WriteLine("Sistema encerrado.");
        }
    }
}