using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteMSSQLServerEntityFrameworkProba
{
    public partial  class SimpleDataModel : DbContext
    {

        public SimpleDataModel( DbContextOptions options) : base(options)
        {

        }


        public DbSet<PO_TEL_VID_CONNECT>? pO_TEL_VID_CONNECTs { get; set; } = null;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("pnone");
            base.OnModelCreating(modelBuilder);
        }
    }
}
