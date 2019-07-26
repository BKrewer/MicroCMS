using MicroCMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MicroCMS.Infra.Data
{
    public class DbInitializer
    {
        private APIContext _context;

        public DbInitializer(APIContext context)
        {
            _context = context;
        }

        public void Initialize()
        {
            if (_context.Users.Any())
            {
                return;
            }

            User u1 = new User("Bruno 1", "12345678901", "brnkrewer@gmail.com", "M", new DateTime(1998, 12, 12));
            User u2 = new User("Bruno 2", "12354345901", "teste@gmail.com", "M", new DateTime(1998, 12, 12));
            User u3 = new User("Bruno 3", "54321678901", "teste1@gmail.com", "M", new DateTime(1998, 12, 12));
            User u4 = new User("Bruno 4", "52346678901", "teste13r@gmail.com", "M", new DateTime(1998, 12, 12));

            _context.Users.AddRange(u1, u2, u3, u4);
            _context.SaveChanges();
        }
    }
}