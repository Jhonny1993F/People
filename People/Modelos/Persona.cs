using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace People.Modelos
{
    [Table("people")]
    public class Persona
    {
        //public int Id { get; set; }
        //public string Name { get; set; }
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(250), Unique]
        public string Name { get; set; }
    }
}
