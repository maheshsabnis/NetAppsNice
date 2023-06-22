﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADOConnected.Models
{
    internal class Department: EntityBase
    {
        public int DeptNo { get; set; }
        public string? DeptName { get; set; }
        public int Capacity { get; set; }
        public string? Location { get; set; }
    }
}
