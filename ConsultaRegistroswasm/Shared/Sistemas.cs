﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaRegistroswasm.Shared
{
    public class Sistemas
    {
        [Key]
        public int SistemaId { get; set; }

        [Required(ErrorMessage = "El nombre del sistema es obligatorio")]
        public String Nombre { get; set; }
    }
}
