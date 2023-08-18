using InyeccionDeIndepenciaPatternAPI.Clases;
using InyeccionDeIndepenciaPatternAPI.Interfaces;

namespace InyeccionDeIndepenciaPatternAPI.Servicios
{
    public class AlimentosServices : IAlimentos
    {
        public List<Alimentos> GetAlimentos()
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

            return alimentos;


        }
    }
}
