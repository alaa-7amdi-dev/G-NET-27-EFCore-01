using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01.Model
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string FisrtName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string?  Email { get; set; }
        public string Biography { get; set; } = "";
        public DateOnly DateOfBirth { get; set; }


    }
}
