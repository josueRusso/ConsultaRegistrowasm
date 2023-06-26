using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaRegistroswasm.Shared
{
    public class Prioridades
    {
        [Key]
        public int PrioridadId { get; set; }

        public string? Descripcion { get; set; }

        public DateTime DiasCompromiso { get; set; } = DateTime.Now;
    }
}
