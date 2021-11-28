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
   public class CommonService
    {
        public static List<CommonModel> GetEvery()
        {
            var config = new MapperConfiguration(c => {

                c.CreateMap<Common, CommonModel>();
                c.CreateMap<Project, ProjectModel>();
                c.CreateMap<Supervisor, SupervisorModel>();
                c.CreateMap<Member, MemberModel>();



            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<CommonModel>>(DataAccessFactory.CommonDataAccess().GetEvery());
            return data;
        }
    }
}
