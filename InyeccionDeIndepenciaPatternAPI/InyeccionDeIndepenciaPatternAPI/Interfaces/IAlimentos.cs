using InyeccionDeIndepenciaPatternAPI.Clases;

namespace InyeccionDeIndepenciaPatternAPI.Interfaces
{
    public interface IAlimentos
    {
        List<Alimentos> GetAlimentos();
       
    }
    public interface IAlimentoespecifico
    {
        List<Alimentos> GetAlimento(string nombre);
    }
}
