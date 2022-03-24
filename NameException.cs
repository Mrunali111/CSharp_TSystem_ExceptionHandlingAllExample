using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_Day4
{
    public class NameException : Exception
    {
        public NameException(string msg) : base(msg) { }
    }
    public class User
    {
        public string AcceptName(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new NameException("Name is required ");
            }
            return name;
        }
    }
}
