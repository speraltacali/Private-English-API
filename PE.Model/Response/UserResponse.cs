﻿using PE.Domain.Base.Tipo;
using System;
using System.Collections.Generic;
using System.Text;

namespace PE.Model.Response
{
    public class UserResponse
    {
        public string Usuario { get; set; }

        public string Token { get; set; }

        public Cargo Cargo { get; set; }
    }
}
