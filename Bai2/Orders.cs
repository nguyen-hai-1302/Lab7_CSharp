﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class Orders
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Orders(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
