using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BioskopApp.Data
{
    public class Movie
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string Image { get; set; }

        public bool Highlighted { get; set; }

        public string Description { get; set; }

        public string Trailer { get; set; }

        public string LongDescription { get; set; }

        public string ImageRepertoar { get; set; }
    }
}
