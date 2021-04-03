using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace Extensions.ClaimsPrincipalHelper
{
    public static class ClaimsPrincipalHelper
    {
        /// <summary>
        /// Get Claims information by claim type
        /// </summary>
        /// <typeparam name="T">Return Type</typeparam>
        /// <param name="principal">Claims Principal</param>
        /// <param name="type">Claim Type</param>
        /// <returns>claims value</returns>
        public static T GetClaims<T>(this ClaimsPrincipal principal, string type)
        {
            var value = principal?.Claims?.FirstOrDefault(x => x.Type == type)?.Value;
            return (T)Convert.ChangeType(value, typeof(T));
        }
    }
}
