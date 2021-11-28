using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class CommonRepo: CRepository<Common,int>
    {
        PMSEntities db;
        public CommonRepo(PMSEntities db)
        {
            this.db = db;
        }

        public List<Common> GetEvery()
        {
            return db.Commons.ToList();
        }

        public Common GetEvery(int id)
        {
            return db.Commons.FirstOrDefault(e => e.ID == id);
        }



        /*  static CommonRepo()
          {
              db = new PMSEntities();
          }
          public static List<Common> GetEvery()
          {
              return db.Commons.ToList();
          }

          public static Common GetEvery(int Id)
          {
              return db.Commons.FirstOrDefault(e => e.ID == Id);
          } */
    }
}
