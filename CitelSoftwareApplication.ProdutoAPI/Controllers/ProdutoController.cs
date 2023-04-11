using CitelSoftwareApplication.ProdutoAPI.Data;
using CitelSoftwareApplication.ProdutoAPI.Model.Domain;
using CitelSoftwareApplication.ProdutoAPI.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CitelSoftwareApplication.ProdutoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _service;

        public ProdutoController(IProdutoService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(long id)
        {
            try
            {
                var resposta = await _service.GetByIdAsync(id);

                return Ok(resposta);
            }
            catch (NotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var resposta = await _service.GetAllAsync();

                return Ok(resposta);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet("contagem")]
        public async Task<IActionResult> GetContagem()
        {
            try
            {
                var resposta = await _service.GetContagemAsync();

                return Ok(resposta);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            try
            {
                var resposta = await _service.DeleteByIdAsync(id);
                if (resposta)
                {
                    return Ok();
                }

                return BadRequest("Não foi possível deletar o produto");
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProdutoDTO produtoDto)
        {
            try
            {
                var resposta = await _service.Create(produtoDto);

                return Ok(resposta);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update(ProdutoDTO produtoDto)
        {
            try
            {
                var resposta = await _service.Update(produtoDto);

                return Ok(resposta);
            }
            catch (NotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
