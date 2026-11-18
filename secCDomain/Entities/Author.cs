using System;
using System.Collections.Generic;
using System.Text;

namespace secCDomain.Entities
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

        public List<Book> Books { get; set; } = new();

    }
}
