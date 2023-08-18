using apiexerc.Models;
using Microsoft.AspNetCore.Mvc;

namespace apiexerc.Controllers
{
    [ApiController]
    [Route("Mascotas")]
    public class MascotasController : ControllerBase
    {
        [HttpGet]
        [Route("Datos")]

            public dynamic getDatosMascota()
        {
            List<Mascotas> mascotas = new List<Mascotas>
            {
                new Mascotas
            {
                nombre = "Luna",
                edad = 3,
                raza = "Labrador Retriever"
            },
            new Mascotas
            {
                nombre = "Simba",
                edad = 2,
                raza = "Maine Coon (gato)"
            },
            new Mascotas
            {
                nombre = "Rocky",
                edad = 5,
                raza = "Pastor Alemán"
            },
            new Mascotas
            {
                nombre = "Bella",
                edad = 1,
                raza = "Bulldog Francés"
            },
            new Mascotas
            {
                nombre = "Max",
                edad = 4,
                raza = "Golden Retriever"
            }

            };

            return mascotas;



        }
    }
}
