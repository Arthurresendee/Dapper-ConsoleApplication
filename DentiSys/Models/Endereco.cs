﻿using System.ComponentModel.DataAnnotations.Schema;

namespace DentiSys.Models
{
    [Table("[Endereco]")]
    public class Endereco
    {

        public int Id { get; set; }
        public string? CEP {get;set;}
        public string? Pais { get; set; }
        public string? Estado { get; set; }
        public string? Cidade { get; set; }
        public string? Rua { get; set; }
        public string? Numero { get; set; }
    }
    
}
