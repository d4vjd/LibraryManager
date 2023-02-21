using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.DataModels
{
    public class Book
    {
        [Key]
        [Required]
        [StringLength(50)]
        public string ISBN { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        [StringLength(50)]
        public string Author { get; set; }

        [Required]
        public DateTime PublicationDate { get; set; }

        [Required]
        [StringLength(50)]
        public string Publisher { get; set; }

        [Required]
        [StringLength(50)]
        public string Genre { get; set; }

        [Required]
        [StringLength(500)]
        public string Summary { get; set; }

        [StringLength(200)]
        public string CoverImage { get; set; }

        [Required]
        public double Rating { get; set; }
    }
}