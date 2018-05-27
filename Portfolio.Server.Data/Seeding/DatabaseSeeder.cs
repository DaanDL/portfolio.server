using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Portfolio.Server.Data.Context;
using Portfolio.Server.Data.Model;

namespace Portfolio.Server.Data.Seeding
{
    public static class DatabaseSeeder
    {
        public static void Initialize(IServiceProvider service)
        {
            using (var serviceScope = service.CreateScope())
            {
                var scopeServiceProvider = serviceScope.ServiceProvider;
                var db = scopeServiceProvider.GetService<BlogPostContext>();
                db.Database.Migrate();
                InsertTestData(db);
            }
        }

        private static void InsertTestData(BlogPostContext context)
        {
            if (context.Authors.Any())
            {
                return;
            }

            context.Authors.Add(new Author
            {
                Id = Guid.NewGuid(),
                Name = "Daan"
            });

            context.SaveChanges();
        }
    }


}
