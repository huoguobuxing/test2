using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany.Portal
{
    public class GetTasksInput
    {
        public int? AssignedPersonId { get; set; }
        public TaskStatus? State { get; set; }
    }
}
