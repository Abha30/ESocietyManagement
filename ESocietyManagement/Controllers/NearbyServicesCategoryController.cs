using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EntityLayer;
using DALEF;
using System.Web.Http.Cors;

namespace ESocietyWebAPI.Controllers
{
    [EnableCors(origins: "*", methods: "*", headers: "*")]

    public class NearbyServicesCategoryController : ApiController
    {
        NearbyServicesCategoryDALEF nsc = new NearbyServicesCategoryDALEF();

        public IEnumerable<NearbyServicesCategory> Get()
        {
            return nsc.GetServiceCategory();
        }

        public NearbyServicesCategory Get(int id)
        {
            return nsc.GetByServiceCategoryId(id);
        }

        public bool Post([FromBody] NearbyServicesCategory n)
        {
            return nsc.PostNearByServiceCategory(n);
        }

        public string Put([FromBody] NearbyServicesCategory n, int id)
        {
            return nsc.PutNearByServiceCategory(id, n);
        }
    }
}
