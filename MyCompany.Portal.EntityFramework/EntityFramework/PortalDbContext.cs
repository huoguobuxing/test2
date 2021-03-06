﻿using Abp.EntityFramework;
using System.Data.Entity;

namespace MyCompany.Portal.EntityFramework
{
    public class PortalDbContext : AbpDbContext
    {
        //TODO: Define an IDbSet for each Entity...

        public virtual IDbSet<Task> Tasks { get; set; }
        public virtual IDbSet<Person> People { get; set; }
        //Example:
        //public virtual IDbSet<User> Users { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public PortalDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in PortalDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of PortalDbContext since ABP automatically handles it.
         */
        public PortalDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }
    }
}
