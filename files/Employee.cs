using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace files
{
    [Serializable]
    public class Employee : User
    {
        public string Address, Email, Phone,projectName;
        public Employee()
        {

        }

        public Employee(string Address, string Email, string Phone, string projectName, string userName, string Name, string password) : base(userName, Name,password)
        {
            this.Address = Address;
            this.Email = Email;
            this.Phone = Phone;
            this.projectName = projectName;
        }
    }
}
