﻿using System.ComponentModel.DataAnnotations;
using WebApiAutores.validaciones;

namespace WebApiAutores.Entidades
{
    public class Libro
    {
        public int Id { get; set; }
        [Required]
        [PrimeraLetraMayuscula]
        [StringLength(maximumLength: 250)]
        public string  Titulo { get; set; }
        public List<Comentario> Comentarios { get; set; }
      
    }
}
