﻿using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany.Portal
{
    public class Person:Entity
    {
        public virtual string Name { get; set; }
    }
}