using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DanielaMora_Examen.Models;

namespace DanielaMora_Examen.Controllers
{
    public class DM_tabla1Controller : Controller
    {
        private readonly DanielaMoraDB_Context _context;

        public DM_tabla1Controller(DanielaMoraDB_Context context)
        {
            _context = context;
        }

        // GET: DM_tabla1
        public async Task<IActionResult> Index()
        {
            return View(await _context.DM_tabla1.ToListAsync());
        }

        // GET: DM_tabla1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dM_tabla1 = await _context.DM_tabla1
                .FirstOrDefaultAsync(m => m.IdDm == id);
            if (dM_tabla1 == null)
            {
                return NotFound();
            }

            return View(dM_tabla1);
        }

        // GET: DM_tabla1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DM_tabla1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdDm,Nombres,Apellidos,CuentaAhorro,CuentaCorriente,CitaConsulta,DineroDisponible")] DM_tabla1 dM_tabla1)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dM_tabla1);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dM_tabla1);
        }

        // GET: DM_tabla1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dM_tabla1 = await _context.DM_tabla1.FindAsync(id);
            if (dM_tabla1 == null)
            {
                return NotFound();
            }
            return View(dM_tabla1);
        }

        // POST: DM_tabla1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdDm,Nombres,Apellidos,CuentaAhorro,CuentaCorriente,CitaConsulta,DineroDisponible")] DM_tabla1 dM_tabla1)
        {
            if (id != dM_tabla1.IdDm)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dM_tabla1);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DM_tabla1Exists(dM_tabla1.IdDm))
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
            return View(dM_tabla1);
        }

        // GET: DM_tabla1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dM_tabla1 = await _context.DM_tabla1
                .FirstOrDefaultAsync(m => m.IdDm == id);
            if (dM_tabla1 == null)
            {
                return NotFound();
            }

            return View(dM_tabla1);
        }

        // POST: DM_tabla1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dM_tabla1 = await _context.DM_tabla1.FindAsync(id);
            if (dM_tabla1 != null)
            {
                _context.DM_tabla1.Remove(dM_tabla1);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DM_tabla1Exists(int id)
        {
            return _context.DM_tabla1.Any(e => e.IdDm == id);
        }
    }
}
