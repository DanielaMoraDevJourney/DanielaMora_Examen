using System.ComponentModel.DataAnnotations;

namespace DanielaMora_Examen.Models
{
    public class DM_tabla1
    {
        public int IdDm { get; set; }

        [StringLength(10, MinimumLength = 5)]
        [Required(AllowEmptyStrings = true)]

        public String? Nombres { get; set; }
        public  String? Apellidos { get; set; }

        [Required]
        public bool CuentaAhorro { get; set; }
        public bool CuentaCorriente { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CitaConsulta { get; set; }

        [Range(0.01, 9999.99)]
        public decimal DineroDisponible { get; set; }

     





    }
}
