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

        // Atualizar
        public void Atualizar(Guid id, Jogo jogoAtualizado)
        {
            try
            {
                Jogo jogoBuscado = _context.Jogo.Find(id)!;

                if (jogoAtualizado != null)
                {
                    jogoAtualizado.NomeDoJogo = jogoAtualizado.NomeDoJogo;
                    jogoAtualizado.Plataforma = jogoAtualizado.Plataforma;
                }

                _context.Jogo.Update(jogoAtualizado!);

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Cadastrar
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
            try
            {
                Jogo jogoBuscado = _context.Jogo.Find(id)!;

                if (jogoBuscado != null)
                {
                    _context.Jogo.Remove(jogoBuscado);
                }

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Jogo> Listar()
        {
            try
            {
                return _context.Jogo.Select(e => new Jogo
                {
                    jogoID = e.jogoID,
                    NomeDoJogo = e.NomeDoJogo,
                    Plataforma = e.Plataforma
                }).ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }
    }
}
