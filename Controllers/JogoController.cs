using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetosJogosAPI.Domains;
using ProjetosJogosAPI.Interfaces;

namespace ProjetosJogosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JogoController : ControllerBase
    {
        private readonly IJogoRepository _JogoRepository;

        public JogoController(IJogoRepository JogoRepository)
        {
            _JogoRepository = JogoRepository;
        }


        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                List<Jogo> listaDeJogo =

                  _JogoRepository.Listar();

                return Ok(listaDeJogo);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        
        [HttpPost]
        public IActionResult Post(Jogo novoJogo)
        {
            try
            {
                _JogoRepository.Cadastrar(novoJogo);

                return Created();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, Jogo jogo)
        {
            try
            {
                _JogoRepository.Atualizar(id, jogo);

                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

       
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _JogoRepository.Deletar(id);

                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
