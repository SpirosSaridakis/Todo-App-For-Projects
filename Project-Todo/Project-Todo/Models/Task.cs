using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Todo.Models
{
    public class Task
    {
        [Key]
        public int TaskId { get; set; }

        public string Description { get; set; }

        public int Progress { get; set; }

        [ForeignKey("Project")]
        public int Id { get; set; }

        public Project Project { get; set; }

        public int ProjectTaskIndex { get; set; }

        public Task()
        {

        }
        public Task(string Adescription, int Aprogress, int Pid, int AprojectTaskIndex)
        {
            Description = Adescription;
            Progress = Aprogress;
            Id = Pid;
            ProjectTaskIndex = AprojectTaskIndex;
        }
    }

    


}
