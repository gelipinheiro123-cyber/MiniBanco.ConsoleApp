using System;

namespace MiniBancoConsoleApp
{
    // Exceção personalizada para tratar tentativas de levantamento/transferência sem saldo bastante
    public class SaldoInsuficienteException : Exception
    {
        public decimal SaldoAtual { get; }
        public decimal ValorTentado { get; }

        public SaldoInsuficienteException() 
            : base("Saldo insuficiente para realizar a operação.") { }

        public SaldoInsuficienteException(string mensagem) 
            : base(mensagem) { }

        public SaldoInsuficienteException(decimal saldoAtual, decimal valorTentado)
            : base($"Saldo insuficiente! Saldo atual: R$ {saldoAtual:F2} | Valor tentado: R$ {valorTentado:F2}")
        {
            SaldoAtual = saldoAtual;
            ValorTentado = valorTentado;
        }
    }
}