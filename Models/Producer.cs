﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineClothingStore.Models
{
    public class Producer
    {
        public int ProducerId { get; set; }
        public string Name { get; set; }
    }
}
