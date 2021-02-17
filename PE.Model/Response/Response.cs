using System;
using System.Collections.Generic;
using System.Text;

namespace PE.Model.Response
{
    public class Response
    {
        public int Exito { get; set; }

        public string Mensaje { get; set; }

        public object Data { get; set; }

        public Response()
        {
            this.Exito = 0;
        }
    }
}
