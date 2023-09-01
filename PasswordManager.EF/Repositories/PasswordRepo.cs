using PasswordManager.EF.Context;
using PasswordManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.EF.Repositories {
    public class PasswordRepo : IEntityRepo<Password> {
        public void Add(Password entity)
        {
            using var context = new ApplicationContext();
            context.Add(entity);
            context.SaveChanges();
        }

        
        public IList<Password> GetAll()
        {
            using var context = new ApplicationContext();
            return context.Passwords.ToList();
        }

        public Password? GetById(Guid ID)
        {
            using var context = new ApplicationContext();
            return context.Passwords
                .Where(password => password.Id == ID)
                .SingleOrDefault();
        }

        public void Update(Guid ID, Password entity)
        {
            using var context = new ApplicationContext();
            var PasswordDb = context.Passwords
                .Where(password => password.Id == ID)
                .SingleOrDefault();
            if (PasswordDb is null) throw new KeyNotFoundException($"Given id '{ID}' was not found");
            PasswordDb.Username = entity.Username;
            PasswordDb.Passcode = entity.Passcode;
            PasswordDb.Site = entity.Site;
            PasswordDb.UserId = entity.UserId;
            PasswordDb.User = entity.User;
            context.SaveChanges();
        }
        public void Delete(Guid ID)
        {
            using var context = new ApplicationContext();
            var PasswordDb = context.Passwords.Where(password => password.Id == ID).SingleOrDefault();
            if (PasswordDb is null)
                return;
            context.Remove(PasswordDb);
            context.SaveChanges();
        }

    }
}
