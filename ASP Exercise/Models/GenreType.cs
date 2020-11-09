using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ASP_Exercise.Models
{
    public class GenreType
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Genre { get; set; }
    }
}