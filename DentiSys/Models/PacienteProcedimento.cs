

namespace DentiSys.Models
{
    public class PacienteProcedimento
    {
        public Guid Id { get; set; }
        public Guid IdPaciente { get; set; }
        public Paciente Paciente { get; set; }
        public Guid IdProcedimento { get; set; }
        public Procedimento Procedimento { get; set; }
        public DateTime DataProcedimento { get; set; }
        public bool ProcedimentoRealizado { get; set; }
    }
}
