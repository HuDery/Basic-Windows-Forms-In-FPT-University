using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace PE_PRN211_LeHaDuy_RePo.Models
{
    public partial class BookPubLisherContext : DbContext
    {
        public BookPubLisherContext(string conn)
        {
            this.Database.SetConnectionString(conn);
        }
    }
}
