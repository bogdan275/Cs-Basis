using Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Main
{
    public class UserRepository : Repository<User>
    {
        public UserRepository(MonitoringContext context) : base(context) { }

        public override IEnumerable<User> GetAll()
        {
            return _context.Users
                .OrderBy(u => u.Login)
                .ToList();
        }

        public override User GetById(int id)
        {
            return _context.Users
                .FirstOrDefault(u => u.UserId == id);
        }

        public User GetByLogin(string login)
        {
            return _context.Users
                .FirstOrDefault(u => u.Login == login);
        }

        public User Authenticate(string login, string password)
        {
            return _context.Users.FirstOrDefault(u => u.Login == login && u.Password == password && u.IsActive);
        }

        public bool LoginExists(string login)
        {
            return _context.Users.Any(u => u.Login == login);
        }
    }
}
