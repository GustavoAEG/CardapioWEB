﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CardapioWEB_Demo.Context;
using CardapioWEB_Demo.Models;
using Microsoft.AspNetCore.Authorization;
using ReflectionIT.Mvc.Paging;

namespace CardapioWEB_Demo.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminLanchesController : Controller
    {
        private readonly AppDbContext _context;

        public AdminLanchesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Admin/AdminLanches
        public async Task<IActionResult> Index(string filter, int pageindex = 1, string sort = "Nome")
        {
            var resultado = _context.lanches.Include(l => l.Categoria).AsQueryable();

            if (!string.IsNullOrWhiteSpace(filter))
            {
                resultado = resultado.Where(p => p.Nome.Contains(filter));
            }

            var model = await PagingList.CreateAsync(resultado, 5, pageindex, sort, "Nome");
            model.RouteValue = new RouteValueDictionary { { "filter", filter } };
            return View(model);

        }

        // GET: Admin/AdminLanches/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.lanches == null)
            {
                return NotFound();
            }

            var lanche = await _context.lanches
                .Include(l => l.Categoria)
                .FirstOrDefaultAsync(m => m.lancheID == id);
            if (lanche == null)
            {
                return NotFound();
            }

            return View(lanche);
        }

        // GET: Admin/AdminLanches/Create
        public IActionResult Create()
        {
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "Id", "Descricao");
            return View();
        }

        // POST: Admin/AdminLanches/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("lancheID,Nome,DescricaoCurta,DescricaoDetalhada,Preco,ImageUrl,ImagemThumbnailUrl,IsLanchePreferido,EmEstoque,CategoriaId")] Lanche lanche)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lanche);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "Id", "Descricao", lanche.CategoriaId);
            return View(lanche);
        }

        // GET: Admin/AdminLanches/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.lanches == null)
            {
                return NotFound();
            }

            var lanche = await _context.lanches.FindAsync(id);
            if (lanche == null)
            {
                return NotFound();
            }
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "Id", "Descricao", lanche.CategoriaId);
            return View(lanche);
        }

        // POST: Admin/AdminLanches/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("lancheID,Nome,DescricaoCurta,DescricaoDetalhada,Preco,ImageUrl,ImagemThumbnailUrl,IsLanchePreferido,EmEstoque,CategoriaId")] Lanche lanche)
        {
            if (id != lanche.lancheID)
            {
                return NotFound();
            }

       
                    try
                {
                    _context.Update(lanche);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LancheExists(lanche.lancheID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "Id", "Descricao", lanche.CategoriaId);
            return View(lanche);
        }

        // GET: Admin/AdminLanches/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.lanches == null)
            {
                return NotFound();
            }

            var lanche = await _context.lanches
                .Include(l => l.Categoria)
                .FirstOrDefaultAsync(m => m.lancheID == id);
            if (lanche == null)
            {
                return NotFound();
            }

            return View(lanche);
        }

        // POST: Admin/AdminLanches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.lanches == null)
            {
                return Problem("Entity set 'AppDbContext.lanches'  is null.");
            }
            var lanche = await _context.lanches.FindAsync(id);
            if (lanche != null)
            {
                _context.lanches.Remove(lanche);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LancheExists(int id)
        {
          return (_context.lanches?.Any(e => e.lancheID == id)).GetValueOrDefault();
        }
    }
}
