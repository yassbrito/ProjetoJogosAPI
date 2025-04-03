//namespace = caminho em que a classe jogo esta
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ProjetosJogosAPI.Domains

{
    [Table("Jogo")]
    [Index(nameof(NomeDoJogo), IsUnique = true)]
    //Public Class = criar uma classe publica
    public class Jogo
    {
        //Preencher os atributos
        [Key]
        public Guid jogoID { get; set; }

        [Column(TypeName ="VARCHAR(50)")]
        //o REquired faz com que seja obrigatorio preencher o campo Nome do Jogo
        [Required(ErrorMessage = "o nome do jogo eh obrigatorio")]
        public string? NomeDoJogo { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        public string? Plataforma { get; set; }


    }
}
