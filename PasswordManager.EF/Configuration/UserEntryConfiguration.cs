using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PasswordManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.EF.Configuration {
    public class UserEntryConfiguration : IEntityTypeConfiguration<UserEntry> {

        public void Configure(EntityTypeBuilder<UserEntry> builder)
        {
            //table UserEntries
            builder.ToTable("UserEntries");

            //primary key
            builder.HasKey(userEntry=>userEntry.ID);

            builder.Property(userEntry=>userEntry.MasterUserName).HasMaxLength(100).IsRequired();
            builder.Property(userEntry=>userEntry.MasterPassword).HasMaxLength(128).IsRequired();
            builder.Property(userEntry=>userEntry.FirstName).HasMaxLength(20).IsRequired();
            builder.Property(userEntry=>userEntry.LastName).HasMaxLength(20).IsRequired();
            builder.Property(userEntry=>userEntry.Phone).HasMaxLength(20).IsRequired();
            builder.Property(userEntry=>userEntry.DateCreated).IsRequired();
            builder.Property(userEntry=>userEntry.Active).IsRequired();
            builder.Property(userEntry=>userEntry.Email).HasMaxLength(50).IsRequired();
           

            
        }
    }
}       
