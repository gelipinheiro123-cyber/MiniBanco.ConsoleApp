namespace MiniBancoConsoleApp
{
    public class ContaSalario
    {
        public string Titular { get; set; }
        public int Numero { get; set; }
        public decimal Saldo { get; set; }
        public string Empresa { get; set; }
        public decimal Salario { get; set; } // Atributo específico para o valor do salário
    }
}