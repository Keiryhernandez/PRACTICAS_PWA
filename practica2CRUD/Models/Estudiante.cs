using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace practica2CRUD.Models
{
    public class Estudiante
    {
        [key]
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string Nombre { get; set; } = string.Empty;
        [Required]
        [StringLength(200)]
        public string Apellido { get; set; } = string.Empty;
        [Required]
        [StringLength(10)]
        public string Genero { get; set; } = string.Empty;
        [Required]
        [StringLength(20)]
        public string Carnet { get; set; } = string.Empty;

        [DisplayName("Asignatura")]
        public int IdAsignatura { get; set; }//Clave foranea
        [ForeignKey("IdAsignatura")]
        public Asignaturas? Asignatura { get; set; } //Relacion de asignatura



    }
}
