using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Todo.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string ClassName { get; set; }

        public DateTime Deadline { get; set; }

        public int CurrentTask { get; set; }

        public int Priority { get; set; }
        public Project() 
        {
            
        }

        public Project(string AprojectName, string AclassName, DateTime Adeadline, int Apriority)
        {
            ProjectName = AprojectName;
            ClassName = AclassName;
            Deadline = Adeadline;
            CurrentTask = 1;
            Priority = Apriority;
        }

    }
}
