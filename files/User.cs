using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace files
{
    [Serializable]
    public class User
    {
        public string userName, password, Name;
        public User()
        {

        }

        public User(string userName, string password, string Name)
        {
            this.userName = userName;
            this.password = password;
            this.Name = Name;
        }
    }
}
