using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BCM.DAL.Migrations
{
    using BCM.Model;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    public static class RoleActions
    {
        public static void createAdmin(BCM.DAL.ApplicationDbContext context)
        {           
            IdentityResult IdRoleResult;
            IdentityResult IdUserResult;

            // Create a RoleStore object by using the ApplicationDbContext object. 
            // The RoleStore is only allowed to contain IdentityRole objects.
            var roleStore = new RoleStore<IdentityRole>(context);

            // Create a RoleManager object that is only allowed to contain IdentityRole objects.
            // When creating the RoleManager object, you pass in (as a parameter) a new RoleStore object. 
            var roleMgr = new RoleManager<IdentityRole>(roleStore);

            // Then, you create the "Administrator" role if it doesn't already exist.
            if (!roleMgr.RoleExists("Administrator"))
            {
                IdRoleResult = roleMgr.Create(new IdentityRole("Administrator"));
                if (!IdRoleResult.Succeeded)
                {
                    // Handle the error condition if there's a problem creating the RoleManager object.
                }
            }

            // Create a UserManager object based on the UserStore object and the ApplicationDbContext  
            // object. Note that you can create new objects and use them as parameters in
            // a single line of code, rather than using multiple lines of code, as you did
            // for the RoleManager object.
            
            //var userMgr = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var userMgr = new ApplicationUserManager();
            var appUser = new ApplicationUser()
            {
                UserName = "Admin",
            };
            IdUserResult = userMgr.Create(appUser, "Passw0rd1");

            // If the new "Admin" user was successfully created, 
            // add the "Admin" user to the "Administrator" role. 
            if (IdUserResult.Succeeded)
            {
                IdUserResult = userMgr.AddToRole(appUser.Id, "Administrator");
                if (!IdUserResult.Succeeded)
                {
                    // Handle the error condition if there's a problem adding the user to the role.
                }
            }
            else
            {
                // Handle the error condition if there's a problem creating the new user. 
            }
        }

        public static bool createUserAndRole(BCM.DAL.ApplicationDbContext context)
        {
            var rm = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            IdentityResult ir = rm.Create(new IdentityRole("canEdit"));
            //var um = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var um = new ApplicationUserManager();
            var user = new ApplicationUser()
            {
                UserName = "user1",
            };
            ir = um.Create(user, "Passw0rd1");
            if (ir.Succeeded == false)
                return ir.Succeeded;

            ir = um.AddToRole(user.Id, "canEdit");

            return ir.Succeeded;
        }
    }
}
