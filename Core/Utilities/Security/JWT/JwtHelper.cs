using Core.Entities.Concrete;
using Core.Extensions;
using Core.Utilities.Security.Encryption;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.JWT
{
    public class JwtHelper : ITokenHelper
    {
        public IConfiguration Configuration { get; }//benim API'm de ki appsettings in içini okumama yarıyor.(Konfigürasyon dosyasını okumama yarıyor). IConfiguration=> Microsoft extensions kısmından çekildi.
        private TokenOptions _tokenOptions;//app settingste okuduğum değerleri bir nesneye atacağım. yukarıda ki congiguration' sınıfıyla okuduğum değerleri atacağım nesne
        private DateTime _accessTokenExpiration;//access token ne zaman geçerliğini yitirecek. tarih
        public JwtHelper(IConfiguration configuration)
        {
            Configuration = configuration;
            _tokenOptions = Configuration.GetSection("TokenOptions").Get<TokenOptions>();//app settingssin içinde ki "TokenOptions" bölümünü al ve onu <TokenOptions> bu sınıfın değerlerini kullanarak maple, yani sıra sıra audince falan atadı içerisine

        }
        public AccessToken CreateToken(User user, List<OperationClaim> operationClaims)
        {
            _accessTokenExpiration = DateTime.Now.AddMinutes(_tokenOptions.AccessTokenExpiration);
            var securityKey = SecurityKeyHelper.CreateSecurityKey(_tokenOptions.SecurityKey);//Bir algoritmayı kullanarak şifreli bir token oluşturucaz, o tone'ı encrpt ederken kendi bildiğimiz özel bir anahtara ihtiyacımız var.
            var signingCredentials = SigningCredentialsHelper.CreateSigningCredentials(securityKey);
            var jwt = CreateJwtSecurityToken(_tokenOptions, user, signingCredentials, operationClaims);
            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            var token = jwtSecurityTokenHandler.WriteToken(jwt);//Token'ı yazdırmış oldum WriteToken(jwt)=> string e çevirdik
            
            return new AccessToken
            {
                Token = token,
                Expiration = _accessTokenExpiration
            };

        }

        public JwtSecurityToken CreateJwtSecurityToken(TokenOptions tokenOptions, User user,
            SigningCredentials signingCredentials, List<OperationClaim> operationClaims)
        {
            var jwt = new JwtSecurityToken( //Token oluştururken benden istediği bilgileri veriyorum ona
                issuer: tokenOptions.Issuer,
                audience: tokenOptions.Audience,
                expires: _accessTokenExpiration,
                notBefore: DateTime.Now,//Token'ın geçerlik süresi şuandan önceyse geçerli değil
                claims: SetClaims(user, operationClaims),
                signingCredentials: signingCredentials
            );
            return jwt;
        }

        private IEnumerable<Claim> SetClaims(User user, List<OperationClaim> operationClaims)
        {
            var claims = new List<Claim>();
            claims.AddNameIdentifier(user.UserId.ToString());
            claims.AddEmail(user.Email);
            claims.AddName($"{user.FirstName} {user.LastName}");
            claims.AddRoles(operationClaims.Select(c => c.Name).ToArray());

            return claims;
        }
    }
}




