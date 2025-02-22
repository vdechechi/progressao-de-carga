using System.ComponentModel.DataAnnotations;

namespace ProgessaoDeCarga.Models
{
    public class Serie
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Repeticoes { get; set; }

        [Required]
        public double Carga { get; set; }

        public int ExercicioId { get; set; }
    }

}
