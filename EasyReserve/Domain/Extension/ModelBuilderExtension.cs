using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Extension
{
    public static class ModelBuilderExtension
    {
        public static void AddAllEntities<TBaseType>(this ModelBuilder modelBuilder, params Assembly[] assemblies)
        {
            var entityTypes = assemblies
                .SelectMany(x => x.GetExportedTypes())
             //condition p is public...
                .Where(p => p is { IsPublic: true, IsAbstract: false } && typeof(TBaseType)
                                .IsAssignableFrom(p) &&
                            p.IsSubclassOf(typeof(TBaseType)));
            foreach (var type in entityTypes)
            {
                modelBuilder.Entity(type);
            }
        }
    }
}
