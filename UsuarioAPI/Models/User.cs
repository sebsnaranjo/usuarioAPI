using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UsuarioAPI.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Debe ingresar el primer nombre")]
        public required string primer_nombre { get; set; }

        [StringLength(50)]
        public string segundo_nombre { get; set; } = string.Empty;

        [StringLength(50)]
        [Required(ErrorMessage = "Debe ingresar el primer apellido")]
        public required string primer_apellido { get; set; }

        [StringLength(50)]
        public string segundo_apellido { get; set; } = string.Empty;

        [Required(ErrorMessage = "Debe ingresar la fecha de nacimiento")]
        public required DateTime fecha_nacimiento { get; set; }

        [Required(ErrorMessage = "El sueldo es obligatorio")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El sueldo debe ser mayor que 0")]
        public required decimal sueldo { get; set; }

        public DateTime fecha_creacion { get; set; }

        public DateTime fecha_modificacion { get; set; }

    }
}
