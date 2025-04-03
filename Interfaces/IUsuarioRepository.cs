using ProjetosJogosAPI.Domains;

namespace ProjetosJogosAPI.Interfaces
{
    public interface IUsuarioRepository
    {
        void Cadastrar(Usuario usuarioNovo);
        void Deletar(Guid id);
        List<Usuario> Listar();
        void Atualizar(Guid id, Usuario usuarioAtualizado);
    }
}
