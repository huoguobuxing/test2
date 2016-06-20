﻿using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany.Portal
{
    public interface ITaskRepository:IRepository<Task,long>
    {
        List<Task> GetAllWithPeople(int? assignedPersonId, TaskStatus? state);
    }
}
