using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BioskopApp.Data;
using Microsoft.AspNetCore.Authorization;


namespace BioskopApp.Controllers
{
    //[Authorize(Roles = "admin")]
    public class ProgramOfEventsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProgramOfEventsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ProgramOfEvents
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProgramOfEvents.Include(p => p.Movie).ToListAsync());
        }

        // GET: ProgramOfEvents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programOfEvents = await _context.ProgramOfEvents.Include(p => p.Movie)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (programOfEvents == null)
            {
                return NotFound();
            }

            return View(programOfEvents);
        }

        // GET: ProgramOfEvents/Create
        public IActionResult Create()
        {
            ViewData["Movies"] = _context.Movies.ToList();
            return View();
        }

        // POST: ProgramOfEvents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,MovieId,Date,Time,Tickets,Price")] ProgramOfEvents programOfEvents)
        {
            if (ModelState.IsValid)
            {
                _context.Add(programOfEvents);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(programOfEvents);
        }

        // GET: ProgramOfEvents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            ViewData["Movies"] = _context.Movies.ToList();
            if (id == null)
            {
                return NotFound();
            }

            var programOfEvents = await _context.ProgramOfEvents.FindAsync(id);
            if (programOfEvents == null)
            {
                return NotFound();
            }
            return View(programOfEvents);
        }

        // POST: ProgramOfEvents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,MovieId,Date,Time,Tickets,Price")] ProgramOfEvents programOfEvents)
        {
            if (id != programOfEvents.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(programOfEvents);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProgramOfEventsExists(programOfEvents.ID))
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
            return View(programOfEvents);
        }

        // GET: ProgramOfEvents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programOfEvents = await _context.ProgramOfEvents
                .FirstOrDefaultAsync(m => m.ID == id);
            if (programOfEvents == null)
            {
                return NotFound();
            }

            return View(programOfEvents);
        }

        // POST: ProgramOfEvents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var programOfEvents = await _context.ProgramOfEvents.FindAsync(id);
            _context.ProgramOfEvents.Remove(programOfEvents);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProgramOfEventsExists(int id)
        {
            return _context.ProgramOfEvents.Any(e => e.ID == id);
        }
    }
}
