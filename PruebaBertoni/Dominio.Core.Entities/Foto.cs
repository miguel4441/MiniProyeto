﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Core.Entities
{
    public class Foto
    {
        public int albumId { get;set; }
        public int id { get;set; }
        public string title { get;set; }

        public string url { get; set; } 
        public string thumbnailUrl { get; set; }


    }
}
