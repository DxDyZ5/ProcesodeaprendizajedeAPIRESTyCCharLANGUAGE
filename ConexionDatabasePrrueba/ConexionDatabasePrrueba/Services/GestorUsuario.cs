using ConexionDatabasePrrueba.Interfaces;
using ConexionDatabasePrrueba.Models;

namespace ConexionDatabasePrrueba.Services
{

    public class GestorUsuario : Iusuario
    {
       private readonly P2Context p2Context; 

        public GestorUsuario(P2Context p2Context)
        {
            this.p2Context = p2Context;
        }
        public List<Usuario> GetUsuarios()
        {
            return p2Context.Usuarios.ToList();
        }

        public Usuario GetUsuarioPorId(int id)
        {
            return p2Context.Usuarios.FirstOrDefault(u => u.Id == id);
        }
    }
}
