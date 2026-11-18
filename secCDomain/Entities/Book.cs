using System;
using System.Collections.Generic;
using System.Text;

namespace secCDomain.Entities
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string BookNumber { get; set; }
        public int PublishedYear { get; set; }

        public List<Author> Authors { get; set; } = new();
    }
}
