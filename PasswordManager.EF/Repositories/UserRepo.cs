using Microsoft.EntityFrameworkCore;
using PasswordManager.EF.Context;
using PasswordManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.EF.Repositories {
    public class UserRepo : IEntityRepo<User> {
        public void Add(User entity)
        {
            using var context = new ApplicationContext();
            context.Add(entity);
            context.SaveChanges();
        }



        public IList<User> GetAll()
        {
            using var context = new ApplicationContext();
            return context.Users
                .Include(user => user.Passwords)
                .ToList();
        }

        public User? GetById(Guid ID)
        {
            using var context = new ApplicationContext();
            var result = context.Users.Where(user => user.Id == ID)
            .Include(user => user.Passwords)
            .SingleOrDefault();
            return result;
        }

        public void Update(Guid ID, User entity)
        {
            using var context = new ApplicationContext();
            var UserDb = GetById(ID);
            if (UserDb is null) throw new KeyNotFoundException($"Given id '{ID}' was not found");
            UserDb.MasterUsername = entity.MasterUsername;
            UserDb.MasterPassword = entity.MasterPassword;
            UserDb.FName = entity.FName;
            UserDb.LName = entity.LName;
            UserDb.Email = entity.Email;
            context.SaveChanges();
        }
        public void Delete(Guid ID)
        {
            using var context = new ApplicationContext();
            var UserDb = context.Users
                .Where(user => user.Id == ID)
                .Include(user => user.Passwords)
                .SingleOrDefault();
            if (UserDb is null)
                throw new KeyNotFoundException($"Given id '{ID}' was not found");
            context.Remove(UserDb);
            context.SaveChanges();
        }
    }
}