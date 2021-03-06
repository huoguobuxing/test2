﻿using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany.Portal
{
    public class CreateTaskInput : IInputDto
    {
        public int? AssignedPersonId { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
