using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteMSSQLServerEntityFrameworkProba
{
    public partial class WorkingWithEntitiesFromMSSQLThroughEF
    {

        static public void AccomplishSelectTo_TEL_VID_CONNECT()
        {
            DbContextOptions<SimpleDataModel> OptionsOFContext = new DbContextOptionsBuilder<SimpleDataModel>().UseSqlServer(  DBFacilities.GetConnectionString()).Options;       /// DataBaseFacilities.OptionsOfDbContext();
            SimpleDataModel dataModel = new SimpleDataModel(OptionsOFContext);

        }

    }
}
