using BEL;
using BLL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace PMS.Controllers


{
    [EnableCors("http://127.0.0.1:5500", "*","*")]
    public class ProjectController : ApiController
    {
        [Route("api/Project/Title")]
        [HttpGet]

        public List<string> GetTitles()
        {
            return ProjectService.GetTitles();
        }

        [Route("api/Project/All")]
        [HttpGet]

        public List<ProjectModel> GetAll()
        {
            return ProjectService.Get();
        }


        [Route("api/Project/Create")]
        [HttpPost]

        public void Add(ProjectModel p)
        {
            ProjectService.Add(p);
        }

        [Route("api/Common/All")]
        [HttpGet]

        public List<CommonModel> GetEvery()
        {
            return CommonService.GetEvery();
        }
        
    }
}
