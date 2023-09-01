using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PasswordManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.EF.Configuration {
    public class UserConfiguration : IEntityTypeConfiguration<User> {


        public void Configure(EntityTypeBuilder<User> builder)
        {

            builder.ToTable("Users");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.FName).HasMaxLength(128).IsRequired();
            builder.Property(x => x.LName).HasMaxLength(128).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(128).IsRequired();
            builder.Property(x => x.MasterUsername).HasMaxLength(128).IsRequired();
            builder.Property(x => x.MasterPassword).HasMaxLength(128).IsRequired();
        }
    }
}
