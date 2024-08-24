using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace WebApiJwt.Models
{
    public class CreateToken
    {
        public string TokenCreate()
        {
            var bytes = Encoding.UTF8.GetBytes("aspnetcorewebapiconsume_longer_key_12345");  // 1. Token için kullanılacak anahtarın byte dizisi oluşturuluyor. aspnetcorewebapiconsume => token key

            SymmetricSecurityKey key = new SymmetricSecurityKey(bytes);   // 2. SymmetricSecurityKey sınıfı ile anahtar oluşturuluyor.

            SigningCredentials credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);    // 3. Oluşturulan anahtar ile SigningCredentials (imza bilgileri) oluşturuluyor.




            JwtSecurityToken token = new JwtSecurityToken(issuer: "http://localhost", audience: "http://localhost", notBefore: DateTime.Now, expires: DateTime.Now.AddSeconds(30), signingCredentials: credentials);  // expires: DateTime.Now.AddSeconds(30) ile tokenın geçerlilik süresi 30 dk olarak ayarlandı

            // 4. JwtSecurityToken sınıfı ile JWT token oluşturuluyor.
            //    - issuer: Kimlik doğrulama sunucusunun (authentication server) adresi
            //    - audience: Token'ı kullanacak olan istemcinin (client) adresi
            //    - notBefore: Token'ın hangi tarihten önce geçerli olmayacağı
            //    - expires: Token'ın ne zaman geçerliliğini yitireceği
            //    - signingCredentials: Token'ı imzalayan imza bilgileri



            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler(); // 5. JwtSecurityTokenHandler sınıfı ile token yazdırılıyor (string olarak).

            return handler.WriteToken(token);

        }

        public string TokenCreateAdmin()
        {
            var bytes = Encoding.UTF8.GetBytes("aspnetcorewebapiconsume_longer_key_12345");
            SymmetricSecurityKey key = new SymmetricSecurityKey(bytes);
            SigningCredentials credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            List<Claim> claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier,Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.Role,"Admin"),
                new Claim(ClaimTypes.Role,"Visitor")
            };

            JwtSecurityToken jwtSecurityToken = new JwtSecurityToken(issuer: "http://localhost", audience: "http://localhost", notBefore: DateTime.Now, expires: DateTime.Now.AddSeconds(30), signingCredentials: credentials, claims: claims);

            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            return handler.WriteToken(jwtSecurityToken);
        }
    }
}
