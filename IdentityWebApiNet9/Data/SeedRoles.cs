using Microsoft.AspNetCore.Identity;

namespace IdentityWebApiNet9.Data
{
    public class SeedRoles
    {

        public static async Task CreateRolesAsync(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            string[] roleName = { "Admin", "User" };

            foreach (var role in roleName)
            {
                if (!await roleManager.RoleExistsAsync(role))
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
            }
        }
    }
}
