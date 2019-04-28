using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BioskopApp.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BioskopApp.Controllers
{
    [Authorize]
    public class ReservationController : Controller
    {
        private readonly ApplicationDbContext _context;
        private UserManager<IdentityUser> _userManager;

        public ReservationController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: ProgramOfEvents
        public async Task<IActionResult> Index()
        {
            var program = await _context.ProgramOfEvents.Include(p => p.Movie).ToListAsync();
            foreach (var pr in program)
            {
                pr.Tickets = pr.Tickets - _context.Reservations
                                 .Where(r => r.ProgramOfEvents.ID == pr.ID)
                                 .Select(r => r.NumberOfTickets).Sum();
            }

            var program1 = program.Where(p => p.Tickets > 0 && (p.Date > DateTime.Now|| 
                              p.Date== DateTime.Now && p.Time.Hour > DateTime.Now.Hour));
            return View(program1);
        }

        public IActionResult Reserve(int? id)
        {
            Reservation reservation = new Reservation
            {
                ProgramOfEvents =
                    _context.ProgramOfEvents.Include(pr => pr.Movie).FirstOrDefault(pr => pr.ID == id),
                ProgramOfEventsId = id ?? 0
            };

            reservation.ProgramOfEvents.Tickets  = reservation.ProgramOfEvents.Tickets - _context.Reservations
                                     .Where(r => r.ProgramOfEvents.ID == reservation.ProgramOfEvents.ID)
                                     .Select(r => r.NumberOfTickets).Sum();
            return View(reservation);


        }

        public async Task<IActionResult> Reserve2([Bind("ProgramOfEventsId,NumberOfTickets")] Reservation reservation)
        {
            var pr = _context.ProgramOfEvents
                    .Include(pro => pro.Movie)
                    .FirstOrDefault(pro => pro.ID == reservation.ProgramOfEventsId);

            var numberOfTickets = pr.Tickets - _context.Reservations
                                      .Where(r => r.ProgramOfEvents.ID == pr.ID)
                                      .Select(r => r.NumberOfTickets).Sum();
            if (_userManager != null)
            {
                reservation.User = await _userManager.GetUserAsync(HttpContext.User);
            }

            if (numberOfTickets < reservation.NumberOfTickets || reservation.NumberOfTickets <=0)
            {
                return RedirectToAction(nameof(Index));
            }

            _context.Reservations.Add(reservation);
            _context.SaveChanges();
            

            return RedirectToAction(nameof(MyTickets));
        }

        public async Task<IActionResult> MyTickets()
        {
         
            var user = await _userManager.GetUserAsync(HttpContext.User);
           
            var reserved =_context.Reservations.Include(r => r.ProgramOfEvents)
                .Include(r=> r.User)
                .Include(r=>r.ProgramOfEvents.Movie)
                .Where(_res => _res.User.Id == user.Id 
                      && (_res.ProgramOfEvents.Date > DateTime.Now 
                          || _res.ProgramOfEvents.Date == DateTime.Now && _res.ProgramOfEvents.Time.Hour > DateTime.Now.Hour) ).ToList();
            return View(reserved.OrderBy(r => r.ProgramOfEvents.Date).ToList());
        }

        public IActionResult Delete(int id)
        {
            var forDelete =_context.Reservations.Include(r => r.ProgramOfEvents).FirstOrDefault(r => r.ID == id);
            if (forDelete == null)
            {
                return RedirectToAction(nameof(MyTickets));
            }

            if (forDelete.ProgramOfEvents.Date > DateTime.Now)
            {
                _context.Reservations.Remove(forDelete);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(MyTickets));

        }


        public async Task<IActionResult> ReservedTickets()
        { 

            var reserved = _context.Reservations.Include(r => r.ProgramOfEvents)
                .Include(r => r.User)
                .Include(r => r.ProgramOfEvents.Movie)
                .Where(_res =>_res.ProgramOfEvents.Date > DateTime.Now
                                   || _res.ProgramOfEvents.Date == DateTime.Now && _res.ProgramOfEvents.Time.Hour > DateTime.Now.Hour).ToList()
                .GroupBy(r => r.ProgramOfEvents);
            return View(reserved.OrderBy(r =>r.Key.Date));
        }
    }
}