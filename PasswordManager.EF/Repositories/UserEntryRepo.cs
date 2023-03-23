using Microsoft.EntityFrameworkCore;
using PasswordManager.EF.Context;
using PasswordManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.EF.Repositories {
    public class UserEntryRepo : IEntityRepo<UserEntry> {
        public void Add(UserEntry entity)
        {
            using var context = new ApplicationContext();
            context.Add(entity);
            context.SaveChanges();
        }

       

        public IList<UserEntry> GetAll()
        {
            using var context = new ApplicationContext();
            return context.UserEntries.Include(userEntry=>userEntry.StoredPasswords).ToList();

        }

        public UserEntry? GetById(Guid ID)
        {
            using var context = new ApplicationContext();
            return context.UserEntries.Where(userEntry=>userEntry.ID==ID)
            .Include(userEntry=>userEntry.StoredPasswords)
            .SingleOrDefault();
        }

        public void Update(Guid ID, UserEntry entity)
        {
            using var context = new ApplicationContext();
            var UserEntryDb = context.UserEntries
               .Where(userEntry => userEntry.ID == ID)
               .Include(userEntry => userEntry.StoredPasswords)
               .SingleOrDefault();
            if (UserEntryDb is null) throw new KeyNotFoundException($"Given id '{ID}' was not found");
            UserEntryDb.MasterUserName = entity.MasterUserName;
            UserEntryDb.MasterPassword = entity.MasterPassword;
            UserEntryDb.DateCreated = entity.DateCreated;
            UserEntryDb.FirstName = entity.FirstName;
            UserEntryDb.LastName = entity.LastName;
            UserEntryDb.Phone = entity.Phone;
            UserEntryDb.Active = entity.Active;

            context.SaveChanges();

        }
        public void Delete(Guid ID)
        {
            using var context = new ApplicationContext();
            var UserEntryDb = context.UserEntries
                .Where(userEntry=> userEntry.ID == ID)
                .Include(userEntry => userEntry.StoredPasswords)
                .SingleOrDefault();
            if (UserEntryDb is null)
                throw new KeyNotFoundException($"Given id '{ID}' was not found");
            context.Remove(UserEntryDb);
            context.SaveChanges();

        }
    }
}
