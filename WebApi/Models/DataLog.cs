﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class DataLog
    {
        public int id { get; set; }
        public string aplicacion { get; set; }
        public string mensaje { get; set; }
        public System.DateTime fecha { get; set; }
    }
}