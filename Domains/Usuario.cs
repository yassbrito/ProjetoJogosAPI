//namespace = caminho em que a classe usuario esta
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ProjetosJogosAPI.Domains
{
    [Table("Usuario")]
    [Index(nameof(NickName), IsUnique = true)]
    public class Usuario
    {
        [Key]
        public Guid UsuarioID { get; set; }

        [Column(TypeName = "VARCHAR(80)")]
        [Required(ErrorMessage = "o nome eh obrigatorio")]
        public string? Nome { get; set; }

        [Column(TypeName = "VARCHAR(30)")]
        [Required(ErrorMessage = "o NickName eh obrigatorio")]
        public string? NickName { get; set; }
        
        public Guid JogoID { get; set; }
        [ForeignKey("JogoID")]

        public Jogo? Jogo { get; set; }

    }
}
