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
    public class UserServiceDetailsController : ApiController
    {
        UserServiceDetailsDALEF ud = new UserServiceDetailsDALEF();
        [HttpGet]

        public IEnumerable<UserServiceDetails> Get()
        {
            return ud.GetUserService();
        }
        [HttpGet]

        public UserServiceDetails Get(int id)
        {
            return ud.GetByIdUserService(id);
        }

        [HttpPost]
        public bool post([FromBody] UserServiceDetails u)
        {
            return ud.PostUserService(u);
        }
        [HttpPut]
        public string put( int id, [FromBody] UserServiceDetails u)
        {
            return ud.PutUserService(id,u);
        }
    }
}
