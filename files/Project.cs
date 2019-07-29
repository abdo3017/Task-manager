using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace files
{
    [Serializable]
    public class Project
    {
        public string Name, Status;
        public Project()
        {

        }

        public Project(string Name)
        {
            this.Name = Name;
            Status = "unfinished";
        }

        public void changeStatus(string Status)
        {
            this.Status = Status;
        }
    }
}
