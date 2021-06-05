﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProsperiDevLab.Controllers.Contracts.Response
{
    public class ServiceOrderResponse
    {
        public long Id { get; set; }
        public string Number { get; set; }
        public DateTime ExecutionDate { get; set; }
        public PriceResponse Price { get; set; }
        public long PriceId { get; set; }
        public EmployeeResponse Employee { get; set; }
        public long EmployeeId { get; set; }
        public CustomerResponse Customer { get; set; }
        public long CustomerId { get; set; }
    }
}
