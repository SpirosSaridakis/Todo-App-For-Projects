using Project_Todo.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Todo.Windows
{
    public partial class ViewCurrentTaskWindow : Form
    {
        private readonly ApplicationDbContext _context;
        int projectid;
        Models.Task currentTask = null;
        List<Models.Task> selectedProjectTaskList = null;
        int taskCounter = 0;
        public ViewCurrentTaskWindow(int projectId, ApplicationDbContext context)
        {
            projectid = projectId;
            InitializeComponent();
            _context = context;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Completed_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you have completed the selected task", "Message",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                taskCounter++;
                currentTask = selectedProjectTaskList[taskCounter];
                loadNewTask(currentTask);
                MessageBox.Show("Task completed", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.None);
                
                
                //Delete the current text of the textbox
                //Delete the task from the database
                //Load the new task percentage and description on the textboxes
            }
            
        }

        private void ViewCurrentTaskWindow_Load(object sender, EventArgs e)
        {
            var tasks = _context.Tasks.Where(Task => Task.Id == projectid).ToList();
            if (tasks==null)
            {
                MessageBox.Show("The selected project does not have any tasks", "Task Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tasks.Sort((p1, p2) => p1.ProjectTaskIndex.CompareTo(p2.ProjectTaskIndex));
            selectedProjectTaskList = tasks;
            if (tasks[0].Description == null)
            {
                textBox1.Text = "null";
            }
            textBox1.Text = tasks[0].Description;
            currentTask = tasks[0];
        }

        public void loadNewTask(Models.Task newCurrentTask)
        {
            currentTask= newCurrentTask;
            if (newCurrentTask.Description==null)
            {
                textBox1.Text = "null";
            }
            textBox1.Text = newCurrentTask.Description;
        }
    }
}
