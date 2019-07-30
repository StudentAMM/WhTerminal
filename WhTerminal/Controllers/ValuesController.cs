using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WhTerminal.Data.DataAccess;
using WhTerminal.Data.Models;

namespace WhTerminal.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : ApiController
    {
        private UnitOfWork unitOfWork = new UnitOfWork();

        // GET api/values
        public IHttpActionResult Get()
        {
            // SHOWSTATUS 
            List<int> wh = new List<int>();
            foreach (Warehouse i in unitOfWork.WarehouseRepository.GetAll())
                wh.Add(i.Id);
            return Ok(wh);
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
