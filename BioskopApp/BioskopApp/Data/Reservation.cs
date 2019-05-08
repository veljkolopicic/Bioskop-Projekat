using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace BioskopApp.Data
{
    public class Reservation
    {
        public int ID { get; set; }
        public int ProgramOfEventsId { get; set; }
        public ProgramOfEvents ProgramOfEvents { get; set; }
        

        [Range(1, maximum: 20, ErrorMessage = "Dozvoljeni su samo pozitivni brojevi!")]//ne radi range, niti required
        [Required(ErrorMessage = "Polje mora biti popunjeno!")]
        public int NumberOfTickets { get; set; }

        public IdentityUser User { get; set; }
    }
}
