using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DiarsT1.Models
{
    public class Ciudad
    {
        [Required(ErrorMessage = "El campo id es obligatorio")]
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo nombre es obligatorio")]
        public string Nombre { get; set; }
    }
}
