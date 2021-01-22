using System;
using System.IdentityModel.Tokens.Jwt;

namespace wt_jwt
{
    public class wtJWT
    {
        static public string GetLogin(string token)
        {
            var handler = new JwtSecurityTokenHandler();
            var tokenS = handler.ReadToken(token) as JwtSecurityToken;
            return tokenS.Payload.ToString();
        }
    }
}
