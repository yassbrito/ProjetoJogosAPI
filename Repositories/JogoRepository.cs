using ProjetosJogosAPI.Context;
using ProjetosJogosAPI.Domains;
using ProjetosJogosAPI.Interfaces;

namespace ProjetosJogosAPI.Repositories
{
    public class JogoRepository : IJogoRepository
    {
        private readonly ProjetoJogosContext _context;
        public JogoRepository()
        {
            _context = new ProjetoJogosContext();
        }

        //
        public void Atualizar(Guid id, Jogo jogoAtualizado)
        {
            
        }

        public void Cadastrar(Jogo jogoNovo)
        {
            try
            {
                jogoNovo.jogoID = Guid.NewGuid();

                _context.Jogo.Add(jogoNovo);

                _context.SaveChanges();

            }
            catch (Exception)
            {

               
            }
        }

        public void Deletar(Guid id)
        {
           
        }

        public List<Jogo> Listar()
        {
            
        }
    }
}
