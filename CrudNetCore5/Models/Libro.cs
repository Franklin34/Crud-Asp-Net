using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudNetCore5.Models
{
    public class Libro
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "El titulo es obligatorio")]
        [StringLength(50, ErrorMessage = "El {0} debe ser almenos {2} y maximo {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Título")]
        public string titulo { get; set; }

        [Required(ErrorMessage = "La descripcion es obligatoria")]
        [StringLength(50, ErrorMessage = "El {0} debe ser almenos {2} y maximo {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Descripción")]
        public string description { get; set; }

        [Required(ErrorMessage = "La fecha es obligatoria")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha lanzamiento")]
        public DateTime fechaLanzamiento { get; set; }

        [Required(ErrorMessage = "El autor es obligatorio")]
        public string autor { get; set; }

        [Required(ErrorMessage = "El precio es obligatorio")]
        public int precio { get; set; }
    }
}
