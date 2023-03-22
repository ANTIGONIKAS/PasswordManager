using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Model
{
    public class Entry
    {
        public Guid Id { get; set; }

        public Entry()
        {
            Id= Guid.NewGuid();
        }
    }
}
