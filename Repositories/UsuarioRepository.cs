using Microsoft.EntityFrameworkCore;
using ProjetosJogosAPI.Context;
using ProjetosJogosAPI.Domains;
using ProjetosJogosAPI.Interfaces;

namespace ProjetosJogosAPI.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ProjetoJogosContext _context;
        public UsuarioRepository()
        {
            _context = new ProjetoJogosContext();
        }

        public void Atualizar(Guid id, Usuario usuarioAtualizado)
        {
            try
            {
                Usuario usuarioBuscado = _context.Usuario.Find(id)!;

                if (usuarioBuscado != null)
                {
                    usuarioBuscado.Nome = usuarioAtualizado.Nome;
                    usuarioBuscado.NickName = usuarioAtualizado.NickName;
                }

                _context.Usuario.Update(usuarioBuscado!);

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Cadastrar(Usuario usuarioNovo)
        {
            try
            {
                usuarioNovo.UsuarioID = Guid.NewGuid();
                _context.Usuario.Add(usuarioNovo);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Deletar(Guid id)
        {
            try
            {
                Usuario usuarioBuscado = _context.Usuario.Find(id)!;

                if (usuarioBuscado != null)
                {
                    _context.Usuario.Remove(usuarioBuscado);
                }

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Usuario> Listar()
        {
            try
            {
                return _context.Usuario.ToList();
            }
            catch (Exception)
            {
                return new List<Usuario>();

            }
        }
    }
}
