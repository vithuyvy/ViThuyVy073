using System;
using System.ComponentModel.DataAnnotations;

namespace ViThuyVy073.Models
{
    public class VTV
    {
        [Key]
        public int VTVId { get; set; }
        public string VTVName { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}