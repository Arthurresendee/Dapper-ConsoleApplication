
namespace DentiSys.Models
{
    public class PacientePlano
    {
        public Guid Id { get; set; }
        public Guid IdPlano { get; set; }
        public Plano Plano { get; set; }
        public Guid IdPaciente { get; set; }
        public Paciente Paciente { get; set; }
        public bool PlanoAtivo { get; set; }

    }
}
