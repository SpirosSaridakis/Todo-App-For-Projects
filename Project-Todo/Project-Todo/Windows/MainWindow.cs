using Project_Todo.Data;
using Project_Todo.Models;
using Project_Todo.Windows;
using System.Data;

namespace Project_Todo
{
    public partial class MainWindow : Form
    {
        private readonly ApplicationDbContext _context;
        public MainWindow(ApplicationDbContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void AddProj_Click(object sender, EventArgs e)
        {
            AddProjectWindow window = new AddProjectWindow(_context); 
            window.Show();
            this.Hide();
            window.FormClosed += new FormClosedEventHandler(RestoreWindow);
            //AddProj.Enabled = false;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            LoadProjectsFromDB();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ToTaskViewWindow_Click(object sender, EventArgs e)
        {
           DataGridViewRow selectedRow = null;
            if (dataGridView1.SelectedRows.Count == 1)
            {
                selectedRow = dataGridView1.SelectedRows[0];
                string name = selectedRow.Cells["ProjectName"].Value.ToString();
                string classname = selectedRow.Cells["ClassName"].Value.ToString();
                Project selected = _context.Projects.FirstOrDefault(Project => Project.ProjectName == name && Project.ClassName == classname);
                ViewCurrentTaskWindow window = new ViewCurrentTaskWindow(selected.Id, _context);
                if (window.selectedProjectTaskList.Count == 0)
                {
                    MessageBox.Show("The selected project does not have any tasks.", "Task count error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    window.Close();

                }
                else
                {
                    window.Show();
                    this.Hide();
                    window.FormClosed += new FormClosedEventHandler(RestoreWindow);
                }

            }
            else
            {
                MessageBox.Show("please select only one project by clicking on a row", "Selection Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void RestoreWindow(object sender, FormClosedEventArgs e)
        {
            Form closedForm = sender as Form;
            if (closedForm is AddProjectWindow)
            {
                LoadProjectsFromDB();
                this.Show();
            }
            else if (closedForm is ViewCurrentTaskWindow)
            {
                LoadProjectsFromDB();
                this.Show();
            }
        }

        public void LoadProjectsFromDB()
        {
            var list = _context.Projects.Select(Project => new { Project.ClassName, Project.ProjectName, Project.Deadline, Project.Priority })
                .ToList();
            dataGridView1.DataSource = list;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}