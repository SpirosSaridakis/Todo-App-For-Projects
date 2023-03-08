using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Todo.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string ClassName { get; set; }

        public DateTime Deadline { get; set; }

        public List<Task> TaskList { get; set; }

        public int Priority { get; set; }
        public Project() 
        {
            
        }

        public Project(string AprojectName, string AclassName, DateTime Adeadline, List<Task> AtaskList, int Apriorityname)        {
            ProjectName = AprojectName;
            ClassName = AclassName;
            Deadline = Adeadline;
            TaskList = AtaskList;
            Priority = Apriorityname;
        }

    }
}
