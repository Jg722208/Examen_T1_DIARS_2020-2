using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DiarsT1.Models
{
    public class Persona
    {

        [Required(ErrorMessage = "El campo id es obligatorio")]
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo Nombre es obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo Apellido es obligatorio")]
        public int Apellido { get; set; }
        [Required(ErrorMessage = "La fecha de nacimiento es obligatorio")]
        public DateTime FechaNacimiento { get; set; }
        [Required(ErrorMessage = "El campo Dni es obligatorio")]
        public string Dni { get; set; }
        [Required(ErrorMessage = "El campo genero es obligatorio")]
        public string Genero { get; set; }
        [Required(ErrorMessage = "El campo idCiudad es obligatorio")]
        public int IdCiudad { get; set; }
        [Required(ErrorMessage = "El campo Directorio es obligatorio")]
        public string Directorio { get; set; }
        [Required(ErrorMessage = "El campo Correo es obligatorio")]
        public string Correo { get; set; }
        [Required(ErrorMessage = "El Usuario es obligatorio")]
        public string Username { get; set; }
        [Required(ErrorMessage = "El campo Password es obligatorio")]
        public string Password { get; set; }
    }
}
