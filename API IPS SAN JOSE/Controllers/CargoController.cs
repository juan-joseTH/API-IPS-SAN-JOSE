using API_IPS_SAN_JOSE.Data;
using API_IPS_SAN_JOSE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_IPS_SAN_JOSE.Controllers
{
    public class CargoController : ApiController
    {
        // GET api/<controller>
        public List<Cargo> Get()
        {
            return CargoData.Listar();
        }
        // GET api/<controller>/5
        public List<Cargo> Get(string id)
        {
            return CargoData.Consultar(id);
        }
        // POST api/<controller>
        public bool Post([FromBody] Cargo oCargo)
        {
            return CargoData.InsertarCargo(oCargo);
        }
        // PUT api/<controller>/5
        public bool Put([FromBody] Cargo oCargo)
        {
            return CargoData.ActualizarCargo(oCargo);
        }
        // DELETE api/<controller>/5
        public bool Delete(string id)
        {
            return CargoData.EliminarCargo(id);
        }
    }
}