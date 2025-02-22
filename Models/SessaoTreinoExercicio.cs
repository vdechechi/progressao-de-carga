using System.ComponentModel.DataAnnotations;

namespace ProgessaoDeCarga.Models
{
    public class SessaoTreinoExercicio
    {
        [Key]
        public int Id { get; set; }
        public int SessaoTreinoId { get; set; }  // Relacionamento com Sessao_Treino
        public int ExercicioId { get; set; }     // Relacionamento com Exercicio
        public SessaoTreino? SessaoTreino { get; set; }
        public Exercicio? Exercicio { get; set; }

    }
}
