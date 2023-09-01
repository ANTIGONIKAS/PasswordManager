using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PasswordManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.EF.Configuration {
    public class PasswordConfiguration : IEntityTypeConfiguration<Password> {
        public void Configure(EntityTypeBuilder<Password> builder)
        {
            builder.ToTable("Passwords");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Site).HasMaxLength(128).IsRequired();

            builder.Property(x => x.Username).HasMaxLength(128).IsRequired();

            builder.Property(x => x.Passcode).HasMaxLength(128).IsRequired();


            builder.HasOne(password=>password.User).WithMany(user=>user.Passwords).
            HasForeignKey(password=>password.UserId).OnDelete(DeleteBehavior.Restrict); 



        }
    }
}