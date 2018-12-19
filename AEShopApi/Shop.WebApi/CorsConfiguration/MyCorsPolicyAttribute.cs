using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = false)]
public class MyCorsPolicyAttribute : Attribute, ICorsPolicyProvider
{
    private CorsPolicy _policy;

    public MyCorsPolicyAttribute()
    {
        // Create a CORS policy.
        _policy = new CorsPolicy();

        // Add allowed origins.
        _policy.Origins.Add("http://localhost:3000/");
    }

    public Task<CorsPolicy> GetPolicyAsync(HttpContext context, string policyName)
    {
        return Task.FromResult(_policy);
    }

}