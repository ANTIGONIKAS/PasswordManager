using Microsoft.EntityFrameworkCore;
using PasswordManager.EF.Context;
using PasswordManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.EF.Repositories {
    public class PasswordEntryRepo : IEntityRepo<PasswordEntry> {
        public void Add(PasswordEntry entity)
        {
            using var context = new ApplicationContext();
            context.Add(entity);
            context.SaveChanges();

        }

        public void Delete(Guid ID)
        {
            using var context = new ApplicationContext();
            var PasswordEntryDb = context.PasswordEntries.Where(passwordEntry => passwordEntry.ID == ID).SingleOrDefault();
            if (PasswordEntryDb is null)
                return;
            context.Remove(PasswordEntryDb);
            context.SaveChanges();
        }

        public IList<PasswordEntry> GetAll()
        {
            using var context = new ApplicationContext();

            return context.PasswordEntries.ToList();
        }

        public PasswordEntry? GetById(Guid ID)
        {
            using var context = new ApplicationContext();
            return context.PasswordEntries
                .Where(passwordEntry => passwordEntry.ID == ID)
               
                .SingleOrDefault();
        }

        public void Update(Guid ID, PasswordEntry entity)
        {
            using var context = new ApplicationContext();
            var PasswordEntryDb = context.PasswordEntries
                .Where(passwordEntry=> passwordEntry.ID == ID)
                
                .SingleOrDefault();
            if (PasswordEntryDb is null) throw new KeyNotFoundException($"Given id '{ID}' was not found");
            PasswordEntryDb.UserName = entity.UserName;
            PasswordEntryDb.Password = entity.Password;
            PasswordEntryDb.DateModified = entity.DateModified;
            PasswordEntryDb.Site = entity.Site;
            PasswordEntryDb.Active = entity.Active;
            context.SaveChanges();
        }
    }
}
