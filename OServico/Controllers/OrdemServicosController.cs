using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OServico.Data;
using OServico.Models;

namespace OServico.Controllers
{
    public class OrdemServicosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OrdemServicosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: OrdemServicos
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.OrdemServico.ToListAsync());
        }

        // GET: OrdemServicos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordemServico = await _context.OrdemServico
                .FirstOrDefaultAsync(m => m.OrdemServicoId == id);
            if (ordemServico == null)
            {
                return NotFound();
            }

            return View(ordemServico);
        }

        // GET: OrdemServicos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OrdemServicos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrdemServicoId,Cliente,Tecnico,status,DataInicial,DataFinal,Garantia,DescriçãoServico,Defeito,Observacoes,LaudoTecnico")] OrdemServico ordemServico)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ordemServico);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ordemServico);
        }

        // GET: OrdemServicos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordemServico = await _context.OrdemServico.FindAsync(id);
            if (ordemServico == null)
            {
                return NotFound();
            }
            return View(ordemServico);
        }

        // POST: OrdemServicos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrdemServicoId,Cliente,Tecnico,status,DataInicial,DataFinal,Garantia,DescriçãoServico,Defeito,Observacoes,LaudoTecnico")] OrdemServico ordemServico)
        {
            if (id != ordemServico.OrdemServicoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ordemServico);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrdemServicoExists(ordemServico.OrdemServicoId))
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
            return View(ordemServico);
        }

        // GET: OrdemServicos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordemServico = await _context.OrdemServico
                .FirstOrDefaultAsync(m => m.OrdemServicoId == id);
            if (ordemServico == null)
            {
                return NotFound();
            }

            return View(ordemServico);
        }

        // POST: OrdemServicos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ordemServico = await _context.OrdemServico.FindAsync(id);
            _context.OrdemServico.Remove(ordemServico);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrdemServicoExists(int id)
        {
            return _context.OrdemServico.Any(e => e.OrdemServicoId == id);
        }
    }
}
