using Business.Constants;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Microsoft.AspNetCore.Http;
using Core.Utilities.IoC;
using Core.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace Business.BusinessAspects.Autofac
{
    public class SecuredOperation : MethodInterception
    {
        private string[] _roles;
        private IHttpContextAccessor _httpContextAccessor;

        public SecuredOperation(string roles)
        {
            _roles = roles.Split(',');
            _httpContextAccessor = ServiceTool.ServiceProvider.GetService<IHttpContextAccessor>();

        }

        protected override void OnBefore(IInvocation invocation)
        {
            var user = _httpContextAccessor.HttpContext.User;
            if (user == null)
            {
                Console.WriteLine("User is null.");
                throw new Exception("User is null");
            }

            Console.WriteLine("Listing all claims from User:");
            foreach (var claim in user.Claims)
            {
                Console.WriteLine($"Type: {claim.Type}, Value: {claim.Value}");
            }

            var roleClaims = user.ClaimRoles(); // This is the extension method
            foreach (var role in _roles)
            {
                if (roleClaims.Contains(role))
                {
                    return;
                }
            }

            throw new Exception(Messages.AuthorizationDenied);
        }
    }
}