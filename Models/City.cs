using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Tour.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Required, StringLength(10000), Display(Name = "Product Description"), DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public string Image{ get; set; }
        public DateTime EventDate { get; set; }
        [NotMapped]
        public int[] Ratings { get; set; }
        public int? LocationId  { get; set; }
        public virtual Location Location { get; set; }
    }
}
