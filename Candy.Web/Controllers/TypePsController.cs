using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Candy.Web.Data;
using Candy.Web.Data.Entities;

namespace Candy.Web.Controllers
{
    public class TypePsController : Controller
    {
        private readonly DataContext _context;

        public TypePsController(DataContext context)
        {
            _context = context;
        }

        // GET: TypePs
        public async Task<IActionResult> Index()
        {
            return View(await _context.TypePs.ToListAsync());
        }

        // GET: TypePs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeP = await _context.TypePs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (typeP == null)
            {
                return NotFound();
            }

            return View(typeP);
        }

        // GET: TypePs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TypePs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] TypeP typeP)
        {
            if (ModelState.IsValid)
            {
                _context.Add(typeP);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(typeP);
        }

        // GET: TypePs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeP = await _context.TypePs.FindAsync(id);
            if (typeP == null)
            {
                return NotFound();
            }
            return View(typeP);
        }

        // POST: TypePs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] TypeP typeP)
        {
            if (id != typeP.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(typeP);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TypePExists(typeP.Id))
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
            return View(typeP);
        }

        // GET: TypePs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeP = await _context.TypePs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (typeP == null)
            {
                return NotFound();
            }

            return View(typeP);
        }

        // POST: TypePs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var typeP = await _context.TypePs.FindAsync(id);
            _context.TypePs.Remove(typeP);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TypePExists(int id)
        {
            return _context.TypePs.Any(e => e.Id == id);
        }
    }
}
