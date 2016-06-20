using Abp.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany.Portal.EntityFramework.Repositories
{
    public class TaskRepository : PortalRepositoryBase<Task, long>, ITaskRepository
    {
        public List<Task> GetAllWithPeople(int? assignedPersonId, TaskStatus? state)
        {
            var query = GetAll();

            if (assignedPersonId.HasValue) {
                query = query.Where(task => task.AssignedPersonId == assignedPersonId.Value);
            }

            if (state.HasValue) {
                query = query.Where(task => task.State == state);
            }

            return query
                    .OrderByDescending(task => task.CreationTime)
                    .ToList();
        }

        public TaskRepository(IDbContextProvider<PortalDbContext> dbContextProvider) : base(dbContextProvider)
        {

        }
    }
}
