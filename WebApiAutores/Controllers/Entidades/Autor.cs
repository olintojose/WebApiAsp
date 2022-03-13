using System.ComponentModel.DataAnnotations;
using WebApiAutores.validaciones;

namespace WebApiAutores.Controllers.Entidades
{
    public class Autor
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="El {0} es requerido")]
        [StringLength(maximumLength: 40, ErrorMessage ="El campo {0} no debe tener mas de {1} caraceteres")]  //el 40 equivale a {1}
        [PrimeraLetraMayuscula]
        public string Nombre { get; set; }
        public List<Libro> Libros { get; set; }
    }
}
