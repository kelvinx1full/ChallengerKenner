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
    public class LogAuditoriaProdutosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LogAuditoriaProdutosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: LogAuditoriaProdutos
        public async Task<IActionResult> Index()
        {
            return View(await _context.LogAuditoriaProdutosModel.ToListAsync());
        }

        // GET: LogAuditoriaProdutos/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var logAuditoriaProdutosModel = await _context.LogAuditoriaProdutosModel
                .FirstOrDefaultAsync(m => m.LogProdutosId == id);
            if (logAuditoriaProdutosModel == null)
            {
                return NotFound();
            }

            return View(logAuditoriaProdutosModel);
        }

        // GET: LogAuditoriaProdutos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LogAuditoriaProdutos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LogProdutosId,DetalhesAuditoriaProdutos,EmailUsuario")] LogAuditoriaProdutosModel logAuditoriaProdutosModel)
        {
            if (ModelState.IsValid)
            {
                logAuditoriaProdutosModel.LogProdutosId = Guid.NewGuid();
                _context.Add(logAuditoriaProdutosModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(logAuditoriaProdutosModel);
        }

        // GET: LogAuditoriaProdutos/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var logAuditoriaProdutosModel = await _context.LogAuditoriaProdutosModel.FindAsync(id);
            if (logAuditoriaProdutosModel == null)
            {
                return NotFound();
            }
            return View(logAuditoriaProdutosModel);
        }

        // POST: LogAuditoriaProdutos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("LogProdutosId,DetalhesAuditoriaProdutos,EmailUsuario")] LogAuditoriaProdutosModel logAuditoriaProdutosModel)
        {
            if (id != logAuditoriaProdutosModel.LogProdutosId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(logAuditoriaProdutosModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LogAuditoriaProdutosModelExists(logAuditoriaProdutosModel.LogProdutosId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(logAuditoriaProdutosModel);
        }

        // GET: LogAuditoriaProdutos/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var logAuditoriaProdutosModel = await _context.LogAuditoriaProdutosModel
                .FirstOrDefaultAsync(m => m.LogProdutosId == id);
            if (logAuditoriaProdutosModel == null)
            {
                return NotFound();
            }

            return View(logAuditoriaProdutosModel);
        }

        // POST: LogAuditoriaProdutos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var logAuditoriaProdutosModel = await _context.LogAuditoriaProdutosModel.FindAsync(id);
            _context.LogAuditoriaProdutosModel.Remove(logAuditoriaProdutosModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LogAuditoriaProdutosModelExists(Guid id)
        {
            return _context.LogAuditoriaProdutosModel.Any(e => e.LogProdutosId == id);
        }
    }
}
