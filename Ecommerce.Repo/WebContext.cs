using Ecommerce.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Repo
{
    public class WebContext : DbContext
    {
        public WebContext()
            : base("DefaultConnection")
        {
        }
        public DbSet<TemporyTest> TemporyTests { get; set; }
    }
}
