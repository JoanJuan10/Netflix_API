using System;
using System.Collections.Generic;

namespace API_C06_ER_SQL.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Videos = new HashSet<Videos>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public int? Dni { get; set; }
        public DateTime? Fecha { get; set; }

        public virtual ICollection<Videos> Videos { get; set; }

    }
}
