using InyeccionDeIndepenciaPatternAPI.Clases;
using InyeccionDeIndepenciaPatternAPI.Interfaces;
using System.Collections.Generic;

namespace InyeccionDeIndepenciaPatternAPI.Servicios
{
    public class AlimentoEspecificoServicio : IAlimentoespecifico
    {
        public List<Alimentos> GetAlimento(string nombre)
        {
            List<Alimentos> alimentos = new List<Alimentos>
            {
                new Alimentos
                {
                    Nombre = "SALMON"
                },
                new Alimentos
                {
                    Nombre = "JITOMATE"
                },
                new Alimentos
                {
                    Nombre = "HUEVO"
                },new Alimentos
                {
                    Nombre = "LECHE"
                },
                new Alimentos
                {
                    Nombre = "MANZANA"
                }

            };

             List<Alimentos> resultado = alimentos.Where(a => a.Nombre == nombre).ToList();
                return resultado;
            

        }
    }
}
