
namespace DentiSys.Models
{
    public class Clinica
    {
        public Clinica()
        {
            Pacientes = new List<Paciente>();
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public IList<Paciente>? Pacientes { get; set; }
    }

    //public class Clinica
    //{
    //    public Clinica()
    //    {
    //        Pacientes = new List<Paciente>();
    //        Dentistas = new List<Dentista>();
    //    }

    //    public Guid Id { get; set; }
    //    public string Nome { get; set; }
    //    public Guid IdEndereco { get; set; }
    //    public Endereco Endereco { get; set; }
    //    public IList<Dentista>? Dentistas { get; set; }
    //    public IList<Paciente>? Pacientes { get; set; }
    //}
}
