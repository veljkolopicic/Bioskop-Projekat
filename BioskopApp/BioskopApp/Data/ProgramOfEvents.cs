using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BioskopApp.Data
{
    public class ProgramOfEvents
    {
        public int ID { get; set; }
        
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        [Required(ErrorMessage = "Polje mora biti popunjeno!")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Polje mora biti popunjeno!")]
        public DateTime Time { get; set; }

        [Range(1, 300, ErrorMessage = "Dozvoljeni su samo pozitivni brojevi i maksimalan broj karata je 300!")]
        [Required(ErrorMessage = "Polje mora biti popunjeno!")]
        public int Tickets { get; set; }

        [Range(1, maximum: 2000, ErrorMessage = "Dozvoljeni su samo pozitivni brojevi!")]
        [Required(ErrorMessage = "Polje mora biti popunjeno!")]
        public Decimal Price { get; set; }
    }
}
