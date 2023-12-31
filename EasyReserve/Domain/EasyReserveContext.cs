using Domain.Entities;
using Domain.Entities.Identities;
using Domain.Extension;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class EasyReserveContext : IdentityDbContext<User, Role, long>
    {
        public EasyReserveContext(DbContextOptions<EasyReserveContext> options): base(options) { }


        //Extension Method
        // Crud : create - read - update - delete 
        // DTO : Data Transfer Object ---> X real Data
        // Automapper : Dto --> entity and BelAx
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var assemblies = typeof(IBaseEntity).Assembly;
            modelBuilder.AddAllEntities<IBaseEntity>(assemblies);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(IBaseEntity).Assembly); // (for Applying fluent API)
        }
    }
}
