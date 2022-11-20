using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiAutores.DTOs;
using WebApiAutores.Entidades;

namespace WebApiAutores.Controllers
{
    [ApiController]
    [Route("api/libros/{libroId:int/comentarios")]
    public class ComentariosController: ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public ComentariosController(ApplicationDbContext context,
            IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult>Post (int libroId, ComentarioCreacionDTO comentarioCreacionDTO)
        {
            var existeLibro = await context.Libros.AnyAsync(libroDB => libroDB.Id == libroId);

            if (!existeLibro)
            {
                return NotFound();
            }
            var comentario = mapper.Map<Comentario>(comentarioCreacionDTO);
            comentario.LibroId= libroId;
            context.Add(comentario);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
    
    
}
