using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PasswordManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.EF.Configuration {
    public class PasswordEntryConfiguration : IEntityTypeConfiguration<PasswordEntry> {
        public void Configure(EntityTypeBuilder<PasswordEntry> builder)
        {
            //table
            builder.ToTable("PasswordEntries");

            //primary key
            builder.HasKey(passwordEntry => passwordEntry.ID);

            builder.Property(passwordEntry=>passwordEntry.Password).HasMaxLength(20).IsRequired();
            builder.Property(passwordEntry=>passwordEntry.UserName).HasMaxLength(20).IsRequired();
            builder.Property(passwordEntry=>passwordEntry.DateModified).IsRequired();
            builder.Property(passwordEntry=>passwordEntry.Site).HasMaxLength(20).IsRequired();

            //relation userEntry - passwordEntry

            builder.HasOne(passwordEntry=>passwordEntry.UserEntry)
            .WithMany(userEntry=>userEntry.StoredPasswords)
            .HasForeignKey(passwordEntry=>passwordEntry.ID).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
