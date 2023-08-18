using InyeccionDeIndepenciaPatternAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace InyeccionDeIndepenciaPatternAPI.Controllers
{
    [ApiController]
    [Route("AlimentosObtenerController")]
    public class AlimentosController : ControllerBase
    {
        IAlimentos alimentos;
        IAlimentoespecifico alimentoespecifico;

        public AlimentosController(IAlimentos alimentos, IAlimentoespecifico alimentoespecifico)
        {
            this.alimentos = alimentos;
            this.alimentoespecifico = alimentoespecifico;
        }

        [HttpGet]
        [Route("ObtenerAlimentosLisa")]
        public IActionResult GetLista() 
        {
            return Ok(alimentos.GetAlimentos());
        }

        [HttpGet]
        [Route("ObteneralimentoEspecifico")]
        public IActionResult getAlimentoEspecifico(string nombre)
        {
            return Ok(alimentoespecifico.GetAlimento(nombre));
        }

    }
}
