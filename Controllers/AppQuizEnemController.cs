using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QuizUpEnem.Data;
using QuizUpEnem.Models;

namespace MyQuizUpEnem.Controllers
{
    public class AppQuizEnemController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AppQuizEnemController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AppQuizEnem
        public async Task<IActionResult> Index()
        {
            return View(await _context.AppQuizEnems.ToListAsync());
        }

        // GET: AppQuizEnem/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appQuizEnem = await _context.AppQuizEnems
                .FirstOrDefaultAsync(m => m.Id == id);
            if (appQuizEnem == null)
            {
                return NotFound();
            }

            return View(appQuizEnem);
        }

        // GET: AppQuizEnem/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AppQuizEnem/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Materia,CreatedAt,LastUpdateFinished,User")] AppQuizEnem appQuizEnem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(appQuizEnem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(appQuizEnem);
        }

        // GET: AppQuizEnem/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appQuizEnem = await _context.AppQuizEnems.FindAsync(id);
            if (appQuizEnem == null)
            {
                return NotFound();
            }
            return View(appQuizEnem);
        }

        // POST: AppQuizEnem/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Materia,CreatedAt,LastUpdateFinished,User")] AppQuizEnem appQuizEnem)
        {
            if (id != appQuizEnem.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(appQuizEnem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AppQuizEnemExists(appQuizEnem.Id))
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
            return View(appQuizEnem);
        }

        // GET: AppQuizEnem/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appQuizEnem = await _context.AppQuizEnems
                .FirstOrDefaultAsync(m => m.Id == id);
            if (appQuizEnem == null)
            {
                return NotFound();
            }

            return View(appQuizEnem);
        }

        // POST: AppQuizEnem/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var appQuizEnem = await _context.AppQuizEnems.FindAsync(id);
            if (appQuizEnem != null)
            {
                _context.AppQuizEnems.Remove(appQuizEnem);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AppQuizEnemExists(int id)
        {
            return _context.AppQuizEnems.Any(e => e.Id == id);
        }
    }
}
