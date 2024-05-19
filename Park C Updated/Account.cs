using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Park_C_Updated
{
    public abstract class Account
    {
        public string username { get; set; }
        public string password { get; set; }
        public string email {  get; set; }
        public string phoneNumber { get; set; }

        public abstract void Save();
        public abstract bool Validate(string username, string password);
    }
}
