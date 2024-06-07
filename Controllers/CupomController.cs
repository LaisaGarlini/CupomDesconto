using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CupomDesconto.Data;
using CupomDesconto.Models;

namespace CupomDesconto.Controllers
{
    public class CupomController : Controller
    {
        private readonly CupomDescontoContext _context;

        public CupomController(CupomDescontoContext context)
        {
            _context = context;
        }

        // GET: Cupom
        public async Task<IActionResult> Index()
        {
            var cupomDescontoContext = _context.Cupom.Include(c => c.Loja).Include(c => c.Produto).Include(c => c.Usuario);
            return View(await cupomDescontoContext.ToListAsync());
        }

        // GET: Cupom/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cupom = await _context.Cupom
                .Include(c => c.Loja)
                .Include(c => c.Produto)
                .Include(c => c.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cupom == null)
            {
                return NotFound();
            }

            return View(cupom);
        }

        // GET: Cupom/Create
        public IActionResult Create()
        {
            ViewData["LojaID"] = new SelectList(_context.Loja, "Id", "Nome");
            ViewData["ProdutoID"] = new SelectList(_context.Produto, "Id", "Nome");
            ViewData["UsuarioID"] = new SelectList(_context.Usuario, "Id", "Email");
            return View();
        }

        // POST: Cupom/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Codigo,Valor_Desconto,Percentual_Desconto,DataValidade,UsuarioID,LojaID,ProdutoID")] Cupom cupom)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cupom);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LojaID"] = new SelectList(_context.Loja, "Id", "Nome", cupom.LojaID);
            ViewData["ProdutoID"] = new SelectList(_context.Produto, "Id", "Nome", cupom.ProdutoID);
            ViewData["UsuarioID"] = new SelectList(_context.Usuario, "Id", "Email", cupom.UsuarioID);
            return View(cupom);
        }

        // GET: Cupom/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cupom = await _context.Cupom.FindAsync(id);
            if (cupom == null)
            {
                return NotFound();
            }
            ViewData["LojaID"] = new SelectList(_context.Loja, "Id", "Nome", cupom.LojaID);
            ViewData["ProdutoID"] = new SelectList(_context.Produto, "Id", "Nome", cupom.ProdutoID);
            ViewData["UsuarioID"] = new SelectList(_context.Usuario, "Id", "Email", cupom.UsuarioID);
            return View(cupom);
        }

        // POST: Cupom/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Codigo,Valor_Desconto,Percentual_Desconto,DataValidade,UsuarioID,LojaID,ProdutoID")] Cupom cupom)
        {
            if (id != cupom.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cupom);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CupomExists(cupom.Id))
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
            ViewData["LojaID"] = new SelectList(_context.Loja, "Id", "Nome", cupom.LojaID);
            ViewData["ProdutoID"] = new SelectList(_context.Produto, "Id", "Nome", cupom.ProdutoID);
            ViewData["UsuarioID"] = new SelectList(_context.Usuario, "Id", "Email", cupom.UsuarioID);
            return View(cupom);
        }

        // GET: Cupom/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cupom = await _context.Cupom
                .Include(c => c.Loja)
                .Include(c => c.Produto)
                .Include(c => c.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cupom == null)
            {
                return NotFound();
            }

            return View(cupom);
        }

        // POST: Cupom/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cupom = await _context.Cupom.FindAsync(id);
            if (cupom != null)
            {
                _context.Cupom.Remove(cupom);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CupomExists(int id)
        {
            return _context.Cupom.Any(e => e.Id == id);
        }
    }
}
