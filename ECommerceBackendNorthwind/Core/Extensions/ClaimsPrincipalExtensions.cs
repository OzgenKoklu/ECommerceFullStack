using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace Core.Extensions
{
    public static class ClaimsPrincipalExtensions
    {
        /*
        public static List<string> Claims(this ClaimsPrincipal claimsPrincipal, string claimType)
        {
            var result = claimsPrincipal?.FindAll(claimType)?.Select(x => x.Value).ToList();
            return result;
        }

        public static List<string> ClaimRoles(this ClaimsPrincipal claimsPrincipal)
        {
            return claimsPrincipal?.Claims(ClaimTypes.Role);
        }*/

        public static List<string> Claims(this ClaimsPrincipal claimsPrincipal, string claimType)
        {
            if (claimsPrincipal == null)
            {
                Console.WriteLine("ClaimsPrincipal is null.");
                return new List<string>();
            }

            var claims = claimsPrincipal.FindAll(claimType)?.Select(x => x.Value).ToList();
            Console.WriteLine($"Claims of type {claimType}: {string.Join(", ", claims)}");
            return claims;
        }

        public static List<string> ClaimRoles(this ClaimsPrincipal claimsPrincipal)
        {
            if (claimsPrincipal == null)
            {
                Console.WriteLine("ClaimsPrincipal is null.");
                return new List<string>();
            }

            foreach (var claim in claimsPrincipal.Claims)
            {
                Console.WriteLine($"Type: {claim.Type}, Value: {claim.Value}");
            }

            var roles = claimsPrincipal.Claims(ClaimTypes.Role);
            Console.WriteLine("Roles: " + (roles != null ? string.Join(", ", roles) : "No roles found"));
            return roles;
        }
    }
}