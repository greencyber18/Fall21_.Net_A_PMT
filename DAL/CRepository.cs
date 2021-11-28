using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public interface CRepository<T,ID>
    {
        List<T> GetEvery();
        T GetEvery(ID id);
    }
}
