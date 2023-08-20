using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using webappmssql.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace webappmssql.Data
{
    public class MyWorldDBContext: DbContext //เอา class DbContext จาก EntityFrameworkCore มาใช้
    {
        public MyWorldDBContext(DbContextOptions<MyWorldDBContext> options) : base (options){

        }

        public DbSet<Gadgets> Gadgets {get; set;} // DbSet คือ method มาจาก class ใน EntityFrameworkCore
    }
}