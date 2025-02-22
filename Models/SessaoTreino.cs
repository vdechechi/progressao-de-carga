using System.ComponentModel.DataAnnotations;

namespace ProgessaoDeCarga.Models
{
    public class SessaoTreino
{
    [Key]
    public int Id { get; set; }
    public DateTime Data { get; set; } = DateTime.Now;
    
    public ICollection<SessaoTreinoExercicio> Sessao_Treino_Exercicios { get; set; }
    public int TreinoId { get; set; }  // Relacionamento com Treino
    }

}
