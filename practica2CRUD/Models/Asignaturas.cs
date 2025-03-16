using System.ComponentModel.DataAnnotations;

namespace practica2CRUD.Models
{
    public class Asignaturas
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(80)]
        public string Nombre { get; set; } = string.Empty;
        [StringLength(200)]
        public string? Descripcion { get; set; }
    }
}
