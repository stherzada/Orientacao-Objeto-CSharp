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
    
        public void Depositar()
        {
            Console.Write("\nDigite o quanto você quer depositar: R$ ");
            double valor = Convert.ToDouble(Console.ReadLine());

            if (valor > 0)
            {
                Saldo += valor;
                Banco.SaldoTotal += Saldo;
                Console.WriteLine($"Deposito -> {Banco.Nome}: {String.Format("{0:C}", Banco.SaldoTotal)}");
            }
            else
            {
                Console.WriteLine($"{Nome} tá querendo me passar a perna?");
            }
        }
        public void Sacar()
        {
            Console.Write("Digite o quanto você quer sacar: ");
            double valor = Convert.ToDouble(Console.ReadLine());

            if (Saldo >= valor)
            {
                Saldo -= valor;
                Banco.SaldoTotal -= valor;
                Console.WriteLine($"Saque -> {Banco.Nome}: {String.Format("{0:C}", Banco.SaldoTotal)}");
            }
            else
            {
                Console.WriteLine($"{Nome} tá querendo me passar a perna?");
            }
        }
    }
}
