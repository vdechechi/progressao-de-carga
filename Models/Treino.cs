using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace ProgessaoDeCarga.Models
{
    public class Treino
    {

        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }

        public ICollection<Serie> Series { get; set; }

        public ICollection<SessaoTreinoExercicio> Sessao_Treino_Exercicios { get; set; }


    }
}
