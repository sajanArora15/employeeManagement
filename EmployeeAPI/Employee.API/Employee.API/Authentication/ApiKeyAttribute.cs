using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Employee.API.Authentication
{
    public class ApiKeyAttribute : Attribute, IAuthorizationFilter
    {
        //private readonly IConfiguration _configuration;
        //public ApiKeyAuthenticationFilter(IConfiguration configuration)
        //{
        //    _configuration = configuration;
        //}
        private const string ApiKeyHeaderName = "X-Api-Key";
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (!IsApiKeyValid(context.HttpContext))
            {
                context.Result = new UnauthorizedResult();
            }
        }
        private bool IsApiKeyValid(HttpContext context)
        {
            string apiKey = context.Request.Headers[ApiKeyHeaderName];

            string actualKey = context.RequestServices.GetRequiredService<IConfiguration>().GetValue<string>("ApiKey");

            return apiKey == actualKey;
        }
    }
}
