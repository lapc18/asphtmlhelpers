using System;
using System.ComponentModel.DataAnnotations;

namespace HTMLHelpers.Models
{
    public class FormularioModel
    {
        [Required(ErrorMessage = "Este campo es oblogario.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Este campo es oblogario.")]

        public string Apellido { get; set; }

        [Required(ErrorMessage = "Este campo es oblogario.")]
        public string Cedula { get; set; }

        [Required]
        [Range(18,99, ErrorMessage = "Debe ingresar una edad verdadera.")]
        public int Edad { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Telefono { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Este campo es obligario.")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "Este campo es obligario.")]
        public string EstadoCivil { get; set; }

        [Required(ErrorMessage = "Este campo es obligario.")]
        public string Hobbys { get; set; }

    }
}
