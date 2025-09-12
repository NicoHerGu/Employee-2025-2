using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Share.Entities
{
    public class Employee
    {
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(30, ErrorMessage = "El campo {0} no puede tener mas de {1} caractéres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string FirstName { get; set; } = null;

        [Display(Name = "Apellido")]
        [MaxLength(30, ErrorMessage = "El campo {0} no puede tener mas de {1} caractéres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string LastName { get; set; } = null;

        [Display(Name = "Activo")]
        public bool IsActive { get; set; } = true;

        [Display(Name = "Fecha de contratación")]
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; } = DateTime.UtcNow;

        [Display(Name = "Salario")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Range(1000000, double.MaxValue, ErrorMessage = "El campo {0} debe ser mínimo {1:C0}")]
        public decimal Salary { get; set; }
    }
}