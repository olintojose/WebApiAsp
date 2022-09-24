using System.ComponentModel.DataAnnotations;
using WebApiAutores.validaciones;

namespace WebApiAutores.Controllers.Entidades
{
    public class Libro
    {
        public int Id { get; set; }
        [PrimeraLetraMayuscula]
        [StringLength(maximumLength: 250)]
        public string  Titulo { get; set; }
      
    }
}
