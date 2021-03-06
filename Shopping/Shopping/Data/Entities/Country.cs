using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Data.Entities
{
    public class Country
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "El campo {0} debe tener maximo {1} caracteres")]
        [Required(ErrorMessage = "El campo pais es obligatorio")]
        [Display(Name = "Pais")]
        public string Name { get; set; }

        public ICollection<State> States { get; set; }

        [Display(Name = "Departamentos / Estados")]
        public int StatesNumber => States == null ? 0 : States.Count;
    }
}
