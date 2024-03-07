using DesafioConstruindoUmSistemaDeHotel.Models;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa("Hóspede 1");
Pessoa p2 = new Pessoa("Hóspede 2");
Pessoa p3 = new Pessoa("Hóspede 2");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);

Suite suite = new Suite("Premium", 3, 30);

Reserva reserva = new Reserva(10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

System.Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeDeHospedes()}");
System.Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");