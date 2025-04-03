using Microsoft.EntityFrameworkCore;
using ProjetosJogosAPI.Domains;
using ProjetosJogosAPI.Interfaces;

namespace ProjetosJogosAPI.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public void Atualizar(Guid id, Usuario usuarioAtualizado)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Usuario usuarioNovo)
        {
            usuarioNovo.UsuarioID = Guid.NewGuid();

            

        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
