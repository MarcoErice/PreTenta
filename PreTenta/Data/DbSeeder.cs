using Microsoft.AspNetCore.Identity;
using PreTenta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PreTenta.Data
{
    public class DbSeeder
    {
        public static void Seed(ApplicationDbContext context, UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            if (!context.Roles.Any())
            {
                var admin = new IdentityRole { Name = "Admin" };
                var result = roleManager.CreateAsync(admin);
            }

            if (!context.Users.Any())
            {
                var aUser = new ApplicationUser { UserName = "admin@test.com", Email = "admin@test.com" };
                var aResult = userManager.CreateAsync(aUser, "Pa$$w0rd").Result;
                var roleResult = userManager.AddToRoleAsync(aUser, "Admin").Result;

                var sUser = new ApplicationUser { UserName = "student@test.com", Email = "student@test.com" };
                var sResult = userManager.CreateAsync(sUser, "Pa$$w0rd").Result;
                
            }
            // Look for any Products.
            if (context.Product.Any())
            {
                return;   // DB has been seeded
            }

            var aProduct = new Product
            {
                Name = "Surface Pro 4",
                UnitPrice = 17499,
                ReleaseDate = new DateTime (2016,02,17),
                IsDeleted = true
            };
            var bProduct = new Product
            {
                Name = "Surface book 2",
                UnitPrice = 38499,
                ReleaseDate = new DateTime(2018,02,19),
                IsDeleted = true
            };
            var cProduct = new Product
            {
                Name = "Surface laptop",
                UnitPrice = 19499,
                ReleaseDate = new DateTime(2017,02,15),
                IsDeleted = true
            };
            context.Product.AddRange(aProduct);
            context.Product.AddRange(bProduct);
            context.Product.AddRange(cProduct);

            context.SaveChanges();
        }
    }
}
