using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace Core.Extensions
{
    public static class ClaimsPrincipalExtensions
    {
        public static List<string> Claims(this ClaimsPrincipal claimsPrincipal, string claimType)
        {
            var result = claimsPrincipal?.FindAll(claimType)?.Select(x => x.Value).ToList();//ClaimsPrincipal ile ise istekte bulunan kullanıcı eğer bir token göndermişse bu wepapimiz tarafından decrypt ediliyor yani çözülüyor, claimsprincipal.findall() ile de çözülmüş token içerisindeki claimleri okuyoruz
            return result;
        }

        public static List<string> ClaimRoles(this ClaimsPrincipal claimsPrincipal)
        {
            return claimsPrincipal?.Claims(ClaimTypes.Role);
        }
    }
}
