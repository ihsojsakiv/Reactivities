using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

using Domain;
using Persistence;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Reactivities.Controllers
{
    public class ActivitiesController : BaseApiController
    {
        private readonly DataContext _context;
        public ActivitiesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActivity()
        {
            return await _context.Activities.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> GetActivity(Guid id)
        {
            return await _context.Activities.FindAsync(id);
        }
    }
}
