using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using booking_backend.Model;

namespace booking_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResourcesController : ControllerBase
    {
        private readonly ResourceContext _context;

        public ResourcesController(ResourceContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Resource>>> GetResource()
        {
          if (_context.Resource == null)
          {
              return NotFound();
          }
            return await _context.Resource.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Resource>> GetResource(int id)
        {
          if (_context.Resource == null)
          {
              return NotFound();
          }
            var resource = await _context.Resource.FindAsync(id);

            if (resource == null)
            {
                return NotFound();
            }

            return resource;
        }

        [HttpPost]
        public async Task<ActionResult<Resource>> PostResource(Resource resource)
        {
            _context.Resource.Add(resource);
            await _context.SaveChangesAsync();


            return CreatedAtAction(nameof(GetResource), new { id = resource.Id }, resource);
        }

      
    }
}
