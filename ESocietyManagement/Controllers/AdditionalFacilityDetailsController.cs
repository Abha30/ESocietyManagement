using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using EntityLayer;
using DALEF;


namespace ESocietyManagement.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class AdditionalFacilityDetailsController : ApiController
    {
    
            AdditionalFacilityDetailsDALEF ad = new AdditionalFacilityDetailsDALEF();
            [HttpGet]
            public IEnumerable<AdditionalFacilityDetails> Get()
            {
                return ad.GetAdditionalFacilityDetails();
            }
        [HttpGet]

        public AdditionalFacilityDetails Get(int id)
        {
            return ad.GetByAdditionalFacilityDetails(id);
        }

        [HttpPost]
        public bool post([FromBody] AdditionalFacilityDetails fd)
        {
            return ad.PostAdditionalFacilityDetails(fd);
        }
        [HttpPut]
        public string put([FromBody] AdditionalFacilityDetails fd,  int id)
        {
            return ad.PutAdditionalFacilityDetails(fd, id);
        }
    }
    }