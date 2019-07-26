using MicroCMS.Domain.Entities;
using MicroCMS.Domain.Interfaces.Repository;
using MicroCMS.Infra.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroCMS.Infra.Repository
{
    public class UserRepository : APIRepository<User>, IUserRepository
    {
        public UserRepository(APIContext context) : base(context)
        { }

    }
}
