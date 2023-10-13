namespace TestandoC.Entidades
{
    internal class Banco 
    {
        public string Nome { get; set; }
        public double SaldoTotal { get; set;}
       
        public List<Cliente> Clientes { get; set; } = new List<Cliente>();

        public Banco(string nome, double saldoTotal)
        {
            this.SaldoTotal = saldoTotal;
            this.Nome = nome;
        }

        public void CriarConta(string nome, double saldoInicial = 0) 
        {
           
            if (saldoInicial >= 0)
            {
                Cliente cliente = new Cliente(nome, saldoInicial, this);
                Clientes.Add(cliente);
                SaldoTotal += saldoInicial;
            }
            else
            {
                Console.WriteLine($"{nome}, tá pobre po? ");
            }


        }

        public void MostrarClientes()
        {
            for (int i = 0; i < Clientes.Count; i++)
            {
                Console.WriteLine($"Nome: {Clientes[i].Nome}, Saldo: {Clientes[i].Saldo}");
            }

        }

        public void Transferir(Cliente origem, Cliente destino,  double valor) {

            if (origem.Saldo >= valor)
            {
                origem.Saldo -= valor;
                destino.Saldo += valor;
            }
            else
            {
                Console.WriteLine($"{origem.Nome} tá querendo me passar a perna?");
            }
        }
    }
}
