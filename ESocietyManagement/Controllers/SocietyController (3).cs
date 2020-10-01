﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EntityLayer;
using DALEF;
using System.Web.Http.Cors;


namespace ESocietyProject.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class SocietyController : ApiController
    {
        SocietyDALEF ef = new SocietyDALEF();
        [HttpGet]
        public IEnumerable<Society> Get()
        {
            return (IEnumerable<Society>)ef.GetAllSociety();
        }

        [HttpGet]
        public Society Get(string id)
        {
            return ef.GetByIdSociety(id);
        }
        [HttpPost]
        public bool Post([FromBody] Society sd)
        {
            return ef.PostSociety(sd);
        }
        [HttpPut]
        public string Put( string id, [FromBody] Society sd)
        {
            return ef.PutSociety(id, sd);
        }
    }
}
