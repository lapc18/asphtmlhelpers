using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using HTMLHelpers.Models;

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
        [Range(16,99, ErrorMessage = "Su edad debe ser mayor que 15 y menor que 99.")]
        public int Edad { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Telefono { get; set; }

        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Este campo es obligario.")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "Este campo es obligario.")]
        public string EstadoCivil { get; set; }

        [Required(ErrorMessage = "Este campo es obligario.")]
        public List<string> Hobbys { get; set; } = new List<string>();

    }
}

class HList
{
    public List<HobbysModel> Hobbys = new List<HobbysModel>
    {
        new HobbysModel{ ID = 1, Hobby = "WatchSeries", IsChecked = false },
        new HobbysModel{ ID = 2, Hobby = "ListenMusic", IsChecked = false },
        new HobbysModel{ ID = 3, Hobby = "ToDance", IsChecked = false },
        new HobbysModel{ ID = 4, Hobby = "PlayVideos", IsChecked = false },
    };
}