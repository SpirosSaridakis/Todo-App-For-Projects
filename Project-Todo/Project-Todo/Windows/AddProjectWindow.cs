using Project_Todo.Data;
using Project_Todo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Todo.Windows
{
    public partial class AddProjectWindow : Form
    {
        public enum Priority
        {
            High=1, Medium=2 , Low=3
        }

        ApplicationDbContext _context;
        public AddProjectWindow(ApplicationDbContext context)
        {
            InitializeComponent();
            _context= context;
        }

        private void AddProjectWindow_Load(object sender, EventArgs e)
        {
            var datasource = new List<int>();
            for(int i = 0; i < 11; i++)
            {
                datasource.Add(i);
            }
            NumberOfTasksBox.DataSource= datasource;

            var datasource2 = new List<Priority>();
            datasource2.Add(Priority.High);
            datasource2.Add(Priority.Medium);
            datasource2.Add(Priority.Low);
            PriorityBox.DataSource = datasource2;
        }

        private void DeadlineCal_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void ClassBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProjectBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumberOfTasksBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PriorityBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private async void ToAddTasks_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ToAddTasks", "Called",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            string className = ClassBox.Text;
            string projectName = ProjectBox.Text;
            var selectedRange = DeadlineCal.SelectionRange;
            DateTime deadline = selectedRange.Start;
            int priority = PriorityBox.SelectedIndex;
            int numberoftasks = NumberOfTasksBox.SelectedIndex;

            int result = ArgumentValidation(className, projectName, priority, numberoftasks);
            switch (result)
            {
                case 0:
                    Project project = new Project(projectName, className, deadline, priority);
                    var task = System.Threading.Tasks.Task.Run(() => AddProjectToDatabase(project));
                    var dbresult = await task;
                    if (dbresult == false)
                    {
                        MessageBox.Show("Project could not be saved", "Please try again",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }else
                    {
                        AddTasksWindow window = new AddTasksWindow(numberoftasks);
                        window.Show();
                    }
                    break;

                case 1:
                    MessageBox.Show("Please Enter a Class", "Try again",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                    
                case 2:
                    MessageBox.Show("Please Enter a Project Name", "Try again",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case 3:
                    MessageBox.Show("Please Select a Priority", "Try again",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case 4:
                    MessageBox.Show("Please select a number of tasks", "Error, you forgot to select the number of tasks",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            
        }

        public async Task<bool> AddProjectToDatabase(Project project)
        {
            _context.Projects.Add(project);
            if(await _context.SaveChangesAsync()!=1)
            {
                return false;
            }
            return true;
            
        }

        public int ArgumentValidation(string ClassName, string ProjectName, int Priority, int NumberOfTasks)
        {
            if (ClassName == "")
            {
                return 1;
            }
            if(ProjectName == "")
            {
                return 2;
            }
            if(Priority == 0)
            {
                return 3;
            }
            if (NumberOfTasks == 0) 
            {
                return 4;
            }
            return 0;
        }
    }
}
