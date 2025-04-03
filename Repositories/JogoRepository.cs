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
            try
            {
                Jogo jogoBuscado = _context.Jogo.Find(id)!;

                if (jogoBuscado != null)
                {
                    jogoBuscado.NomeDoJogo = jogo.NomeJogo;
                }

                _context.Jogo.Update(jogoBuscado!);

                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
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
