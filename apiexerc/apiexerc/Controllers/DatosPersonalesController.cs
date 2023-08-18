using apiexerc.Models;
using Microsoft.AspNetCore.Mvc;

namespace apiexerc.Controllers
{
    [ApiController]
    [Route("Estudiante")]
    public class DatosPersonalesController : ControllerBase
    {
        [HttpGet]
        [Route("Datos")] 
        
        public dynamic getDatosestudiante()
        {
            List<Estudiante> estudiante = new List<Estudiante>
            {
                new Estudiante
                {
                nombre = "Manuel Torres",
                matricula = "2022-0173",
                carrera = "Software development"
                }
            };

            return estudiante;
            

            
        }

    }
}
