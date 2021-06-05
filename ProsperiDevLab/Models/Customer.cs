﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProsperiDevLab.Models
{
    public class Customer
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string CNPJ { get; set; }

        /* EF Associations */
        public ICollection<ServiceOrder> ServiceOrders { get; set; }
    }
}
