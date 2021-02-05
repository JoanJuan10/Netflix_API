using System;
using System.Collections.Generic;

namespace API_C06_ER_SQL.Models
{
    public partial class Videos
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public int? CliId { get; set; }

        public virtual Cliente Cli { get; set; }
    }
}
