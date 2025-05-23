using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entity.PruebaMP.Entities
{
    public class Cliente
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string RazonSocial { get; set; }
        [ForeignKey("IdTipoCliente")]
        public int IdTipoCliente { get; set; }
        [Required]
        public DateTime FechaCreacion {  get; set; }
        [Required]
        public string RFC {  get; set; }
    }
}
