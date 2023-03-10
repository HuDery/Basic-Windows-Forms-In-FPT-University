using System;
using System.Collections.Generic;

#nullable disable

namespace PE_PRN211_LeHaDuy_RePo.Models
{
    public partial class Publisher
    {
        public Publisher()
        {
            Books = new HashSet<Book>();
        }

        public string PublisherId { get; set; }
        public string PublisherName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
