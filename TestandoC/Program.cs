﻿using TestandoC.Entidades;

Banco banco = new Banco("Banco do Brasil", 50000.00);

Console.WriteLine($"---------- BEM-VINDO(A) AO {banco.Nome} ----------\n");

banco.CriarConta("Sther");
banco.CriarConta("Morales", 200.00);
banco.CriarConta("Jurema", 3122.00);

banco.Transferir(banco.Clientes[1], banco.Clientes[2], 300);


Console.WriteLine($"{banco.Nome} {banco.SaldoTotal}");
banco.MostrarClientes();


banco.Clientes[1].Depositar();
banco.Clientes[1].Sacar();