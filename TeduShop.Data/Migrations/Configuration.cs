﻿namespace TeduShop.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TeduShop.Model.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TeduShop.Data.TeduShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TeduShop.Data.TeduShopDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new TeduShopDbContext()));
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new TeduShopDbContext()));

            var user = new ApplicationUser()
            {
                UserName = "TrungTT",
                Email = "tranthanhtrung.fithou@gmail.com",
                EmailConfirmed = true,
                BirthDate = DateTime.Now,
                FullName = "Trần Thành Trung"
            };

            manager.Create(user, "123456aA@");

            if (!roleManager.Roles.Any())
            {
                roleManager.Create(new IdentityRole { Name="Admin"});
                roleManager.Create(new IdentityRole { Name = "User" });
            }

            var adminUser = manager.FindByEmail("tranthanhtrung.fithou@gmail.com");

            manager.AddToRoles(adminUser.Id,new string[] { "Admin", "User"}); 

        }
    }
}
