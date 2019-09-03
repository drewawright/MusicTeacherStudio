using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using MusicTeacherStudio.Data;
using Owin;

[assembly: OwinStartup(typeof(MusicTeacherStudio.WebAPI.Startup))]

namespace MusicTeacherStudio.WebAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateRolesAndUsers();
        }

        public void CreateRolesAndUsers()
        {
            ApplicationDbContext ctx = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(ctx));
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(ctx));

            if (!roleManager.RoleExists("Admin"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Admin";
                roleManager.Create(role);

                var user = new ApplicationUser();
                user.UserName = "Admin";
                user.Email = "admin@admin.admin";

                string userPWD = "B*8v0dly";

                var chkUser = userManager.Create(user, userPWD);

                if (chkUser.Succeeded)
                {
                    var resultOne = userManager.AddToRole(user.Id, userPWD);
                }
            }

            if (!roleManager.RoleExists("Teacher"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Teacher";
                roleManager.Create(role);
            }

            if (!roleManager.RoleExists("Student"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Student";
                roleManager.Create(role);
            }
        }
    }
}
