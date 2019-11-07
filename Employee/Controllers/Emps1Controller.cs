using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Employee.Model;
using Employee.Models;
using Employee.Data;

namespace Employee.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]

    public abstract class Emps1Controller<TEntity, TRepository> : ControllerBase

        where TEntity : class, IEntity
        where TRepository : IRepository<TEntity>
    {
        private readonly TRepository repository;

        public Emps1Controller(TRepository repository)
        {
            this.repository = repository;
        }

        // GET: api/Emps
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TEntity>>> Get()
        {
            return await repository.GetAll();
        }

        // GET: api/Emps/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TEntity>> Get(int id)
        {
            var emp = await repository.Get(id);
            if (emp == null)
            {
                return NotFound();
            }
            return emp;
        }

        // PUT: api/Emps/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, TEntity emp)
        {
            if (id != emp.Id)
            {
                return BadRequest();
            }
            await repository.Update(emp);
            return NoContent();
        }

        // POST: api/Emps
        [HttpPost]
        public async Task<ActionResult<TEntity>> Post(TEntity emp)
        {
            await repository.Add(emp);
            return CreatedAtAction("Get", new { id = emp.Id }, emp);
        }

        // DELETE: api/Emps/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TEntity>> Delete(int id)
        {
            var emp = await repository.Delete(id);
            if (emp == null)
            {
                return NotFound();
            }
            return emp;
        }

    }

}