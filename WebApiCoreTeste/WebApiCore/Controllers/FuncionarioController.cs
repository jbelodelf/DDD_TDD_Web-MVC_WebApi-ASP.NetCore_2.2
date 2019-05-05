using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiCore.Controllers
{
    [Route("api/[controller]")]
    [Controller]
    public class FuncionarioController : ControllerBase
    {
        private IFuncionarioApp _funcRep;

        public FuncionarioController(IFuncionarioApp funcRep)
        {
            _funcRep = funcRep;
        }

        // GET: api/<controller>
        [HttpGet("Listar")]
        //[Route("api/funcionario")]
        public async Task<ActionResult<IEnumerable<Funcionario>>> Get()
        {
            try
            {
                var data = await _funcRep.Get();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
