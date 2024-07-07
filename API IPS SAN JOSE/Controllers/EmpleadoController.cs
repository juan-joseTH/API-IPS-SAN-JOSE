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
    public class EmpleadoController : ApiController
    {
        // GET api/<controller>
        public List<Empleado> Get()
        {
            return EmpleadoData.Listar();
        }
        // GET api/<controller>/5
        public List<Empleado> Get(string id)
        {
            return EmpleadoData.Consultar(id);
        }
        // POST api/<controller>
        public bool Post([FromBody] Empleado oEmpleado)
        {
            return EmpleadoData.InsertarEmpleado(oEmpleado);
        }
        // PUT api/<controller>/5
        public bool Put([FromBody] Empleado oEmpleado)
        {
            return EmpleadoData.ActualizarEmpleado(oEmpleado);
        }
        // DELETE api/<controller>/5
        public bool Delete(string id)
        {
            return EmpleadoData.EliminarEmpleado(id);
        }
    }
}