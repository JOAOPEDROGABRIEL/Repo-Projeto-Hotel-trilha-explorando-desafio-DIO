using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

    Pessoa p1 = new()
    {
        Nome = "Hospede",
        Sobrenome = 1.ToString(),
    };
    hospedes.Add(p1);
    Pessoa p2 = new()
    {
        Nome = "Hospede",
        Sobrenome = 2.ToString(),
    };
    hospedes.Add(p2);
// Cria a suíte
Suite premium = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);
Suite comum = new Suite(tipoSuite: "Comum", capacidade: 2, valorDiaria: 20);
Suite economica = new Suite(tipoSuite: "Economica", capacidade: 2, valorDiaria: 7);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reservaPremium = new Reserva(diasReservados: 30);
reservaPremium.CadastrarSuite(premium);
reservaPremium.CadastrarHospedes(hospedes);

Reserva reservaComum = new Reserva(diasReservados: 14);
reservaComum.CadastrarSuite(comum);
reservaComum.CadastrarHospedes(hospedes);

Reserva reservaEconomica = new Reserva(diasReservados: 5);
reservaEconomica.CadastrarSuite(economica);
reservaEconomica.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Suíte: {premium.TipoSuite}");
Console.WriteLine($"Hóspedes: {reservaPremium.ObterQuantidadeHospedes()}");
Console.WriteLine($"Dias Reservados: {reservaPremium.GetDiasReservados()}");
Console.WriteLine($"Valor diária: {reservaPremium.CalcularValorDiaria()}");
Console.WriteLine("");
Console.WriteLine($"Suíte: {comum.TipoSuite}");
Console.WriteLine($"Hóspedes: {reservaComum.ObterQuantidadeHospedes()}");
Console.WriteLine($"Dias Reservados: {reservaComum.GetDiasReservados()}");
Console.WriteLine($"Valor diária: {reservaComum.CalcularValorDiaria()}");
Console.WriteLine("");
Console.WriteLine($"Suíte: {economica.TipoSuite}");
Console.WriteLine($"Hóspedes: {reservaEconomica.ObterQuantidadeHospedes()}");
Console.WriteLine($"Dias Reservados: {reservaEconomica.GetDiasReservados()}");
Console.WriteLine($"Valor diária: {reservaEconomica.CalcularValorDiaria()}");