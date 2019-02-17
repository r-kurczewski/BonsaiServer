using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BonsaiServer.Database;

namespace BonsaiServer.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class MutationsController : Controller
    {
        private readonly AppDbContext _context;

        public MutationsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Manage/Mutations
        public async Task<IActionResult> Index()
        {
            return View(await _context.Mutations.ToListAsync());
        }

        // GET: Manage/Mutations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mutation = await _context.Mutations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mutation == null)
            {
                return NotFound();
            }

            return View(mutation);
        }

        // GET: Manage/Mutations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Manage/Mutations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Start,End")] Mutation mutation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mutation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mutation);
        }

        // GET: Manage/Mutations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mutation = await _context.Mutations.FindAsync(id);
            if (mutation == null)
            {
                return NotFound();
            }
            return View(mutation);
        }

        // POST: Manage/Mutations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Start,End")] Mutation mutation)
        {
            if (id != mutation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mutation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MutationExists(mutation.Id))
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
            return View(mutation);
        }

        // GET: Manage/Mutations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mutation = await _context.Mutations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mutation == null)
            {
                return NotFound();
            }

            return View(mutation);
        }

        // POST: Manage/Mutations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mutation = await _context.Mutations.FindAsync(id);
            _context.Mutations.Remove(mutation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MutationExists(int id)
        {
            return _context.Mutations.Any(e => e.Id == id);
        }
    }
}
