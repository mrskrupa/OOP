using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace FirstProgram
{
    class ApContext : DbContext
    {
        public DbSet <User> Users { get; set; }
        public ApContext() : base("DefaultConnection") { }
    }
}
