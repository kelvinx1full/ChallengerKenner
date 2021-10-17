using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ChallengerKenner1._0.Data;
using ChallengerKenner1._0.Models;

namespace ChallengerKenner1._0.Controllers
{
    public class LogAuditoriaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LogAuditoriaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: LogAuditoria
        public async Task<IActionResult> Index()
        {
            return View(await _context.LogAuditoriaModel.ToListAsync());
        }

    }
}
