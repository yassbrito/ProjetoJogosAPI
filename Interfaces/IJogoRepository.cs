using ProjetosJogosAPI.Domains;

namespace ProjetosJogosAPI.Interfaces
{
    public interface IJogoRepository
    {
        void Cadastrar(Jogo jogoNovo);
        List<Jogo> Listar();
        void Deletar(Guid id);
        void Atualizar(Guid id, Jogo jogoAtualizado);
    }
}
