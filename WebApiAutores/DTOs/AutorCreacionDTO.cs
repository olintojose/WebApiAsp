using System.ComponentModel.DataAnnotations;
using WebApiAutores.validaciones;

namespace WebApiAutores.DTOs
{
    public class AutorCreacionDTO
    {
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(maximumLength: 120, ErrorMessage = "El campo {0} no debe tener mas de {1} caraceteres")]  //el 40 equivale a {1}
        [PrimeraLetraMayuscula]
        public String Nombre { get; set; }
    }
}
