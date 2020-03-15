using AdviserDashboardService.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdviserDashboardService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class AdviserDashboardControllerBase<TEntity, TRepository> : ControllerBase
        where TEntity : class, IAuditable
        where TRepository : IRepository<TEntity>
    {
        private readonly TRepository repository;

        public AdviserDashboardControllerBase(TRepository repository)
        {
            this.repository = repository;
        }

        // GET: api/[controller]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TEntity>>> Get()
        {
            return await repository.GetAll();
        }

        // GET: api/[controller]/A57592E3-D03B-4F73-A6F3-FB9BC3CC5CD8       
        [HttpGet("{id}")]
        public async Task<ActionResult<TEntity>> Get(Guid id)
        {
            var entity = await repository.Get(id);
            if (entity == null)
            {
                return NotFound();
            }
            return entity;
        }

        // PUT: api/[controller]/A57592E3-D03B-4F73-A6F3-FB9BC3CC5CD8
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, TEntity entity)
        {
            if (id != entity.Id)
            {
                return BadRequest();
            }
            await repository.Update(entity);
            return NoContent();
        }

        // POST: api/[controller]
        [HttpPost]
        public async Task<ActionResult<TEntity>> Post(TEntity entity)
        {
            await repository.Add(entity);
            return CreatedAtAction("Get", new { id = entity.Id }, entity);
        }

        // DELETE: api/[controller]/A57592E3-D03B-4F73-A6F3-FB9BC3CC5CD8       
        [HttpDelete("{id}")]
        public async Task<ActionResult<TEntity>> Delete(Guid id)
        {
            var entity = await repository.Delete(id);
            if (entity == null)
            {
                return NotFound();
            }
            return entity;
        }

    }
}
