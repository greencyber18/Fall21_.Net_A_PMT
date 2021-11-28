using AutoMapper;
using BEL;

using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProjectService
    {
        public static List<ProjectModel> Get()
        {
            var config = new MapperConfiguration(c => {
               
                c.CreateMap<Common, CommonModel>();
                c.CreateMap<Project, ProjectModel>();


            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<ProjectModel>>(DataAccessFactory.ProjectDataAccess().Get());
            return data;
        }

        public static List<string> GetTitles()
        {

            var data = DataAccessFactory.ProjectDataAccess().Get().Select(e => e.Title).ToList();
            return data;
        }

        public static void Add(ProjectModel p)
        {
            var config = new MapperConfiguration(c => {
                c.CreateMap<Project, ProjectModel>();



            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Project>(p);
            DataAccessFactory.ProjectDataAccess().Add(data);
        }

    }
}
