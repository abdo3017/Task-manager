using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace files
{
    [Serializable]
    class Task
    {
        public string taskName, employeeUserName, projectName, Description, Comment, Status, achievedFile, History;
        public Task()
        {

        }
        public Task(string taskName, string employeeUserName, string projectName, string Description, string Comment, string achievedFile, string History)
        {
            this.taskName = taskName;
            this.employeeUserName = employeeUserName;
            this.projectName = projectName;
            this.Description = Description;
            this.Comment = Comment;
            Status = "unfinished";
            this.achievedFile = achievedFile;
            this.History = History;
        }

        public void changeStatus(string Status)
        {
            this.Status = Status;
        }
    }
}
