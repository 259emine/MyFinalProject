﻿using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Encryption
{
    public class SecurityKeyHelper
    {
        public static SecurityKey CreatSecurityKey(string securityKey)
        {
            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));
        }

        internal static object CreateSecurityKey(string securityKey)
        {
            throw new NotImplementedException();
        }

        public static SecurityKey CreateSecurityKey(string securityKey)
        {
            throw new NotImplementedException();
        }
    }
}
