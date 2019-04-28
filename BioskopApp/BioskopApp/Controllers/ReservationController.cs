﻿using System;
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
            return View(program);
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

            if (numberOfTickets < reservation.NumberOfTickets)
            {
                return RedirectToAction(nameof(Index));
            }

            _context.Reservations.Add(reservation);
            _context.SaveChanges();
            

            return RedirectToAction(nameof(Index));
        }
    }
}