using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Todo.Models
{
    public class Task
    {
        public int TaskId { get; set; }

        public string Description { get; set; }

        public int Progress { get; set; }
        public Task()
        {

        }
        public Task(int AtaskId, string Adescription, int Aprogress)
        {
            TaskId = AtaskId;
            Description = Adescription;
            Progress = Aprogress;
        }
    }

    


}
