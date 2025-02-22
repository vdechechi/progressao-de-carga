using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System.ComponentModel.DataAnnotations;

namespace ProgessaoDeCarga.Models
{
    public class Treino
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Nome { get; set; }

        [Required]
        public string? Descricao { get; set; }

        [Required]

        public ICollection<Serie>? Series { get; set; }

        public ICollection<SessaoTreinoExercicio> Sessao_Treino_Exercicios { get; set; }


    }
}
