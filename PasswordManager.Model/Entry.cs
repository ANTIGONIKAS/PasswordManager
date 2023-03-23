using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Model
{
    public class Entry
    {
        public Guid ID { get; set; }

        public Entry()
        {
            ID= Guid.NewGuid();
        }
    }
}
