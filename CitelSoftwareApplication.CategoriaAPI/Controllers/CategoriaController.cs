using CitelSoftwareApplication.CategoriaAPI.Model.Domain;
using CitelSoftwareApplication.CategoriaAPI.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CitelSoftwareApplication.CategoriaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaService _service;

        public CategoriaController(ICategoriaService service)
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

                return BadRequest("Não foi possível deletar categoria");
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(Categoria categoria)
        {
            try
            {
                var resposta = await _service.Create(categoria);

                return Ok(resposta);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update(Categoria categoria)
        {
            try
            {
                var resposta = await _service.Update(categoria);

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
