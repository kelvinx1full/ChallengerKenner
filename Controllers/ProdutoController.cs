using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ChallengerKenner1._0.Data;
using ChallengerKenner1._0.Models;
using Microsoft.AspNetCore.Authorization;

namespace ChallengerKenner1._0.Controllers
{
    [Authorize]
    public class ProdutoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProdutoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Produto
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProdutoModel.ToListAsync());
        }

        // GET: Produto/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            _context.LogAuditoriaModel.Add(
                new LogAuditoriaModel
                {
                    EmailUsuario = User.Identity.Name,
                    DetalhesAuditoria = "Entrou na tela de Detalhes"
                });

            _context.SaveChanges();

            if (id == null)
            {
                return NotFound();
            }

            var produtoModel = await _context.ProdutoModel
                .FirstOrDefaultAsync(m => m.ProdutoId == id);
            if (produtoModel == null)
            {
                return NotFound();
            }

            return View(produtoModel);
        }

        // GET: Produto/Create
        public IActionResult Create()
        {
            _context.LogAuditoriaModel.Add(
                new LogAuditoriaModel
                {
                    EmailUsuario = User.Identity.Name, 
                    DetalhesAuditoria = "Entrou na tela de Cadastro"
                });

            _context.SaveChanges();

            return View();
        }

        // POST: Produto/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProdutoId,Nome,Descricao,Custo,Valor,Quantidade")] ProdutoModel produtoModel)
        {
            if (ModelState.IsValid)
            {
                produtoModel.ProdutoId = Guid.NewGuid();
                _context.Add(produtoModel);
                await _context.SaveChangesAsync();

                _context.LogAuditoriaModel.Add(
                new LogAuditoriaModel
                {
                    EmailUsuario = User.Identity.Name,
                    DetalhesAuditoria = string.Concat("Cadastrou o Produto: ", 
                    produtoModel.Nome," | ", " Data de cadastro: ", DateTime.Now.ToLongDateString())
                });
                _context.SaveChanges();

                _context.LogAuditoriaProdutosModel.Add(
                new LogAuditoriaProdutosModel
                {
                    EmailUsuario = User.Identity.Name,
                    DetalhesAuditoriaProdutos = string.Concat("Entrada do produto: ",
                    produtoModel.Nome," | ", " Data de entrada: ", DateTime.Now.ToLongDateString())
                });
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            return View(produtoModel);
        }

        // GET: Produto/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            _context.LogAuditoriaModel.Add(
                new LogAuditoriaModel
                {
                    EmailUsuario = User.Identity.Name,
                    DetalhesAuditoria = "Entrou na tela de Edição"
                });

            _context.SaveChanges();

            if (id == null)
            {
                return NotFound();
            }

            var produtoModel = await _context.ProdutoModel.FindAsync(id);
            if (produtoModel == null)
            {
                return NotFound();
            }
            return View(produtoModel);
        }

        // POST: Produto/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ProdutoId,Nome,Descricao,Custo,Valor,Quantidade")] ProdutoModel produtoModel)
        {
            if (id != produtoModel.ProdutoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(produtoModel);
                    await _context.SaveChangesAsync();

                    _context.LogAuditoriaModel.Add(
                    new LogAuditoriaModel
                {
                    EmailUsuario = User.Identity.Name,
                    DetalhesAuditoria = string.Concat("Atualizou o Produto: ",
                    produtoModel.Nome," | ", "Data de atualização: ", DateTime.Now.ToLongDateString())
                });
                    _context.SaveChanges();

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProdutoModelExists(produtoModel.ProdutoId))
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
            return View(produtoModel);
        }

        // GET: Produto/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            _context.LogAuditoriaModel.Add(
                new LogAuditoriaModel
                {
                    EmailUsuario = User.Identity.Name,
                    DetalhesAuditoria = "Entrou na tela de Exclusão"
                });

            _context.SaveChanges();

            if (id == null)
            {
                return NotFound();
            }

            var produtoModel = await _context.ProdutoModel
                .FirstOrDefaultAsync(m => m.ProdutoId == id);
            if (produtoModel == null)
            {
                return NotFound();
            }

            return View(produtoModel);
        }

        // POST: Produto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var produtoModel = await _context.ProdutoModel.FindAsync(id);
            _context.ProdutoModel.Remove(produtoModel);
            await _context.SaveChangesAsync();

            _context.LogAuditoriaModel.Add(
                new LogAuditoriaModel
                {
                    EmailUsuario = User.Identity.Name,
                    DetalhesAuditoria = string.Concat("Deletou o Produto: ",
                    produtoModel.Nome, " | ", "Data de exclusão: ", DateTime.Now.ToLongDateString())
                });
            _context.SaveChanges();

            _context.LogAuditoriaProdutosModel.Add(
               new LogAuditoriaProdutosModel
               {
                   EmailUsuario = User.Identity.Name,
                   DetalhesAuditoriaProdutos = string.Concat("Saída do produto: ",
                   produtoModel.Nome, " | ", "Data de saída: ", DateTime.Now.ToLongDateString())
               });
            _context.SaveChanges();


            return RedirectToAction(nameof(Index));
        }

        private bool ProdutoModelExists(Guid id)
        {
            return _context.ProdutoModel.Any(e => e.ProdutoId == id);
        }
    }
}
