﻿using System;
using System.Collections.Generic;
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
        public IdentityUser User { get; set; }

        public int NumberOfTickets { get; set; }
    }
}