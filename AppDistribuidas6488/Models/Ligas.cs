using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppDistribuidas6488.Models
{
    [Table("Ligas")]
    public class Ligas
    {
        [Key]
        public int IdLiga { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
    }
}
