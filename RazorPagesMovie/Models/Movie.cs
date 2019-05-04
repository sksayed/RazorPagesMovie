using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        //this is ID which will be primary key 
        public string Title { get; set; }
        //this is another property
        [DataType(DataType.Date)] //this is an attribute 
        public DateTime ReleaseTime { get; set; }
        public string Genere { get; set; }
        public decimal Price { get; set; }
    }
}
