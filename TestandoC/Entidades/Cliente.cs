namespace TestandoC.Entidades
{
    internal class Cliente
    {
        public string Nome { get; set; }
        public double Saldo { get; set; }

        public Banco Banco { get; set; } 

        public Cliente(string nome, double saldo, Banco banco)
        {
            this.Banco = banco;
            this.Nome = nome;
            this.Saldo = saldo;
        }
    
        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                Banco.SaldoTotal += Saldo;
                Console.WriteLine(Banco.SaldoTotal);
            }
            else
            {
                Console.WriteLine($"{Nome} tá querendo me passar a perna?");
            }
        }
        public void Sacar(double valor) 
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
                Banco.SaldoTotal -= valor;
                Console.WriteLine(Banco.SaldoTotal);
            }
            else
            {
                Console.WriteLine($"{Nome} tá querendo me passar a perna?");
            }
        }
    }
}
