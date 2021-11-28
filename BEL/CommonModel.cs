using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class CommonModel
    {
        public int ID { get; set; }
        public int ProjectID { get; set; }
        public int MemberID { get; set; }
        public int SupID { get; set; }

        public virtual MemberModel Member { get; set; }
        public virtual ProjectModel Project { get; set; }
        public virtual SupervisorModel Supervisor { get; set; }
    }
}
