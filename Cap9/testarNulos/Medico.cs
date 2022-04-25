using System.Collections.Generic;

namespace testarNulos
{
    public class Medico
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public List<Paciente> Pacientes { get; set; }
    }
}