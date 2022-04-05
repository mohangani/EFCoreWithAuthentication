using EFCoreApi.Models.DbModels;
using EFCoreApi.Models.InputModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreApi.Infrastructure
{
    public class Login : ILogin
    {
        private readonly IToken token;
        private readonly ShopperStopDbContext dbcontext;

        public Login(IToken token, ShopperStopDbContext dbcontext)
        {
            this.token = token;
            this.dbcontext = dbcontext;
        }
        public string Authenticate(LoginDto input)
        {
            var user = dbcontext.Users.Include(x => x.Role).Where(x => x.UserName.Equals(input.UserName) && x.Password == input.Password)
                .Select(x => new User { Password = x.Password, Id = x.Id, UserName = x.UserName, Role = x.Role })
                .FirstOrDefault();

            if (user != default && user.Password == input.Password)
                return token.Create(user);

            return null;
        }
    }
}
