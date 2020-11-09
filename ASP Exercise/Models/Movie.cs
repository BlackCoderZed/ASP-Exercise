using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_Exercise.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime ReleasedDate { get; set; }
        public string Description { get; set; }

        public GenreType GenreType { get; set; }
        public int GenreTypeId { get; set; }
    }
}