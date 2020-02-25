using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiArduino.Controllers
{
    public class ValuesController : ApiController
    {
        System.IO.Ports.SerialPort Arduino;

        public ValuesController()
        {
            Arduino = new System.IO.Ports.SerialPort();
            Arduino.PortName = "COM4";
            Arduino.BaudRate = 9600;
            Arduino.Open();
        }

        // GET api/values
        public IEnumerable<string> Get()
        {

            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            if (Arduino.IsOpen)
            {
Arduino.Write("E");
            }
            else
            {
                Arduino.Open();
                Arduino.Write("E");
            }
            Arduino.Close();
            
            
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
