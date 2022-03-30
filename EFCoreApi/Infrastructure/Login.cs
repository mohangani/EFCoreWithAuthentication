using EFCoreApi.Models.InputModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreApi.Infrastructure
{
    public class Login : ILogin
    {
        private readonly IToken token;

        public Login(IToken token)
        {
            this.token = token;
        }
        public string Authenticate(LoginDto input)
        {
            if (input.UserName.Equals("Admin", StringComparison.OrdinalIgnoreCase)
                && input.Password.Equals("admin"))
            {

                return token.Create(input.UserName);
            }
            return null;
        }
    }
}
