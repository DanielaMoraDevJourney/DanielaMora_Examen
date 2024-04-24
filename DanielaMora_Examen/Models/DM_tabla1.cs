using System.ComponentModel.DataAnnotations;

namespace DanielaMora_Examen.Models
{
    public class DM_tabla1
    {

        [Key]
        public int IdDm { get; set; }

        [StringLength(10, MinimumLength = 5)]
        [Required(AllowEmptyStrings = true)]

        public String? DM_Nombres { get; set; }
        public  String? DM_Apellidos { get; set; }

        [Required]
        public bool DM_CuentaAhorro { get; set; }
        public bool DM_CuentaCorriente { get; set; }

        [Required(ErrorMessage = "La fecha de la Cita Consulta es requerida.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DM_CitaConsulta { get; set; }

        [Range(0.01, 9999.99)]
        public decimal DM_DineroDisponible { get; set; }

     





    }
}
