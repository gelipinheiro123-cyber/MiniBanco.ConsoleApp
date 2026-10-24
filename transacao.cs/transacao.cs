namespace MiniBanco.ConsoleApp
{
    // Modelo da Transação (RF01)
    public class Transacao
    {
        public string Tipo { get; set; }   // "Deposito", "Saque" ou "Tarifa"
        public decimal Valor { get; set; }  // Valor da operação

        public Transacao(string tipo, decimal valor)
        {
            Tipo = tipo;
            Valor = valor;
        }
    }
}