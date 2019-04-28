using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BioskopApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<ProgramOfEvents> ProgramOfEvents { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

           
        }
    }
}
