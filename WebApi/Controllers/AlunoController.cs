using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {

        private readonly IRepository _repo;

        public AlunoController(IRepository repo)
        {
            this._repo = repo;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Aluno aluno)
        {
            try
            {
                _repo.Add(aluno);
                if (await _repo.SaveChangesAsync())
                {
                    return Ok(aluno);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return BadRequest("Ocorreu um Erro não esperado!");
        }

        [HttpPut]
        public async Task<IActionResult> Put(Aluno resource)
        {
            try
            {
                var aluno = await _repo.GetAlunoAsyncById(resource.Id);
                if (aluno == null)
                {
                    return NotFound("Recurso não encontrado");
                }
                else
                {
                    _repo.Update(resource);
                    if (await _repo.SaveChangesAsync())
                    {
                        return Ok(resource);
                    }
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return BadRequest("Ocorreu um Erro não esperado!");
        }

        [HttpDelete("{AlunoId}")]
        public async Task<IActionResult> Delete(int alunoId)
        {
            try
            {
                var aluno = await _repo.GetAlunoAsyncById(alunoId);
                if (aluno == null)
                {
                    return NotFound("Recurso não encontrado");
                }
                else
                {
                    _repo.Delete(aluno);
                    if (await _repo.SaveChangesAsync())
                    {
                        return Ok(aluno);
                    }
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return BadRequest("Ocorreu um Erro não esperado!");
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await _repo.GetAllAlunosAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }

        [HttpGet("{AlunoId}")]
        public async Task<IActionResult> Get(int AlunoId)
        {
            try
            {
                var result = await _repo.GetAlunoAsyncById(AlunoId);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }
    }
}
