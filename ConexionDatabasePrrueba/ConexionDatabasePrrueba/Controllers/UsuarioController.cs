using ConexionDatabasePrrueba.Interfaces;
using ConexionDatabasePrrueba.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConexionDatabasePrrueba.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        Iusuario usuario;

        public UsuarioController(Iusuario usuario)
        {
            this.usuario = usuario;

        }

        [HttpGet("GET-USUARIOS")]
        public IActionResult getUsuario()
        {
            return Ok(usuario.GetUsuarios());
        }


        [HttpPut("UPDATE-USUARIO/{id}")]
        public IActionResult updateUsuario(int id, [FromBody] Usuario usuarioActualizado)
        {
            var usuarioExistente = usuario.GetUsuarioPorId(id);

            if (usuarioExistente == null)
            {
                return NotFound();
            }


            usuarioExistente.Nombre = usuarioActualizado.Nombre;
            usuarioExistente.Matricula = usuarioActualizado.Matricula;


            p2Context.SaveChanges();

            return Ok(usuarioExistente);

        }



 
}
