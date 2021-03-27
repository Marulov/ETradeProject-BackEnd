using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Encryption
{
    public class SigningCredentialsHelper
    {
        public static SigningCredentials CreateSigningCredentials(SecurityKey securiyKey)
        {
            // hangi anahtarı ve algoritmayı kullanacağımızı belirledik web api için
            return new SigningCredentials(securiyKey, SecurityAlgorithms.HmacSha512Signature);
        }
            
    }
}
