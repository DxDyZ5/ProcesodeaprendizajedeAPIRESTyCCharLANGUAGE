using System;
using System.Collections.Generic;

namespace ConexionDatabasePrrueba.Models
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Matricula { get; set; }
    }
}
