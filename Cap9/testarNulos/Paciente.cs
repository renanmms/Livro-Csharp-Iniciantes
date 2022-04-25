using System;

namespace testarNulos
{
    public class Paciente
    {
        public int ID { get; set; }
        public string NomePaciente { get; set; }
        public string Historico { get; set; } = "nada relatado";
        public string Remedios { get; set; }
        public decimal ValorConsulta { get; set; } = 0;
        public bool Internado { get; set; }
    }
}