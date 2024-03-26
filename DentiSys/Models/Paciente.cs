﻿
namespace DentiSys.Models
{
    public class Paciente
    {
        public Paciente()
        {
            PacienteProcedimentos = new List<PacienteProcedimento>();
        }
        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public string? SobreNome { get; set; }
        public int? Idade { get; set; }
        public string? CPF { get; set; }
        public DateTime? DataDeAniversario { get; set; }
        public string? Email { get; set; }   
        public string? NumeroDeTelefone { get; set; }
        public Guid IdEndereco { get; set; }
        public Endereco? Endereco { get; set; }
        public IList<PacienteProcedimento> PacienteProcedimentos{ get; set;}
    }
}
