using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProjectRepo : IRepository<Project, int>
    {
        PMSEntities db;
        public ProjectRepo(PMSEntities db)
        {
            this.db = db;
        }

            /* public static PMSEntities db;

            static ProjectRepo()
             {
                 db = new PMSEntities();
             }

             public static List<Project> Get()
             {
                 return db.Projects.ToList();
             }

             public static Project Get(int Id)
             {
                 return db.Projects.FirstOrDefault(e => e.ID == Id);
             }

             public void Edit(Project p)
             {
                 var ds = db.Projects.FirstOrDefault(e => e.ID == p.ID);
                 db.Entry(ds).CurrentValues.SetValues(p);
                 db.SaveChanges();
             }

             public void Delete(int Id)
             {
                 var ds = db.Projects.FirstOrDefault(e => e.ID == Id);
                 db.Projects.Remove(ds);
             }

             public static void Add(Project p)
             {
                 db.Projects.Add(p);
                 db.SaveChanges();

             }
            */
            public void Add(Project p)
        {
            db.Projects.Add(p);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var pr = db.Projects.FirstOrDefault(p => p.ID == id);
            db.Projects.Remove(pr);
            db.SaveChanges();
        }


        public List<Project> Get()
        {
            return db.Projects.ToList();
        }

        public Project Get(int id)
        {
            return db.Projects.FirstOrDefault(p => p.ID == id);
        }

      
    }
}
