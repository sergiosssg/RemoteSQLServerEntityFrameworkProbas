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

            dataModel.pO_TEL_VID_CONNECTs.Load();

            var colOfPO = dataModel.pO_TEL_VID_CONNECTs.ToList<PO_TEL_VID_CONNECT>();

            Console.WriteLine(" collection is read");

            foreach (var elOfPO in colOfPO)
            {
                Console.WriteLine(String.Format("{0}, {1}, {2}", elOfPO.IDConnect, elOfPO.KodOfConnect, elOfPO.NameOfConnect));

            }
            Console.WriteLine(" collection is printed");
        }

    }
}
