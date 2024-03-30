using DentiSys.Models.Enums;

namespace DentiSys.Models
{
    public class Procedimento
    {
        public Procedimento(){}

        public int Id { get; set; }
        public string Titulo { get; set; }

        public TipoDeProcedimento TipoDeProcedimento { get; set; }
        public string Descricao { get; set; }
        //public IList<DateTime> DataProcedimentos { get; set; } //data em que um determinado procedimento foi realizado ou agendado para ser realizado
    }
}
