using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WindTurbineAPI.Data;
using WindTurbineAPI.Models;

namespace WindTurbineAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // Route: /api/windturbine


    public class WindTurbineController(AppDbContext context) : ControllerBase
    {
        private readonly AppDbContext _context = context;

        // GET: api/windturbine
        [HttpGet]
        public async Task <IActionResult> GetALL()
        {
            var turbines = await _context.WindTurbines.ToListAsync();
            return Ok(turbines);
        }
    }


}
