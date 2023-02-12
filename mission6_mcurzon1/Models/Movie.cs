using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mission6_mcurzon1.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieID { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public ushort Year { get; set; }
        public string Director { get; set; }
        public string Rating { get; set; }
    }
}
