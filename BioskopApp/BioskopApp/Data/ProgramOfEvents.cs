using System;
using System.Collections.Generic;
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
        public DateTime Date { get; set; }

        public DateTime Time { get; set; }
        public int Tickets { get; set; }

        public Decimal Price { get; set; }
    }
}
