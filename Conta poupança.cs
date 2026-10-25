using System;

namespace MiniBancoConsoleApp
{
    public class ContaPoupanca
    {
        public string Titular { get; set; }
        public int Numero { get; set; }
        public decimal Saldo { get; set; }
        public decimal RendimentoPercentual { get; set; }
        public int DiaAniversario { get; set; }
    }
}
