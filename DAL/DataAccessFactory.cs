using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class DataAccessFactory
    {
        static PMSEntities db;
        static DataAccessFactory()
        {
            db = new PMSEntities();
        }

        public static IRepository<Project, int> ProjectDataAccess()
        {
            return new ProjectRepo(db);

        }

        public static CRepository<Common,int>  CommonDataAccess()
        {
            return new CommonRepo(db);

        }
    }
}
