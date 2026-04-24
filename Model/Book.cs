using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01.Model
{
    public class Book
    {
        [Key]
        public int ISPN { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int NumbefOfPages { get; set; }
        public DateOnly PublishedYear { get; set; }
        public bool IsStock { get; set; }
    }
}
