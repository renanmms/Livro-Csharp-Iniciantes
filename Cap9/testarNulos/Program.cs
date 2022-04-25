// See https://aka.ms/new-console-template for more information
using testarNulos;
using static System.Console;

Medico med = new Medico(){ID = 1, Nome = "Rodrigo"};
WriteLine($"Dr(a) {med.Nome} tem {med.Pacientes?.Count() ?? 0} pacientes"); // A interrogação pergunta se o objeto é nulo

Medico objM = new Medico()
{
    ID = 1,
    Nome = "Alisson",
    Pacientes = new List<Paciente> 
    {
        new Paciente 
        {
            ID = 1,
            NomePaciente = "Jeu",
            ValorConsulta = 150
        },
        new Paciente 
        {
            ID = 2,
            NomePaciente = "Lucimara",
            ValorConsulta = 180,
            Remedios = "simeco plus"
        },
        new Paciente 
        {
            ID = 3,
            NomePaciente = "Marcos",
            ValorConsulta = 180, 
            Remedios = "neosaldina"
        },
        new Paciente 
        {
            ID = 4,
            NomePaciente = "Rodrigo",
            ValorConsulta = 320, 
            Internado = true,
            Historico = "pé chato"
        },
        new Paciente
        {
            ID = 5,
            NomePaciente = "Lucas",
            ValorConsulta = 100,
            Internado = true,
            Historico = "camisa de força"
        }
    }
};

WriteLine($"historico dos pacientes ---- Dr(a) {objM.Nome}");
objM.Pacientes?.ForEach(p => WriteLine($"--- {p.NomePaciente} - remédios: {p.Remedios ?? "sem remédios"} - histórico: {p.Historico} - consulta: R$ {p.ValorConsulta:n2}"));


WriteLine();
WriteLine("--- Faturamento da clínica ---");
decimal faturamento = 0;

objM.Pacientes?.ForEach(p => faturamento += p.ValorConsulta);
WriteLine($"R$ {faturamento:n2}");

WriteLine();
WriteLine($"--- Quantidade de pacientes ---");
WriteLine($"Há um total de {objM?.Pacientes.Count()} pacientes");
WriteLine($"Há {objM?.Pacientes.Count(p => p.Internado == true)} pacientes internados");
WriteLine($"Há {objM.Pacientes?.Count(r => !String.IsNullOrEmpty(r.Remedios))} pacientes que estão tomando remédios.");
