using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
namespace IDatabase
{
   public interface INearServiceCategory
    {
        IEnumerable<NearbyServicesCategory> GetServiceCategory();

        NearbyServicesCategory GetByServiceCategoryId(int id);
        bool PostNearByServiceCategory(NearbyServicesCategory s);

        string PutNearByServiceCategory(NearbyServicesCategory s, int id);
    }
}
