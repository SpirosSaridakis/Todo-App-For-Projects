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
            var list = _context.Projects.Select(Project => new { Project.ClassName, Project.ProjectName, Project.Deadline, Project.Priority })
                .ToList();
            dataGridView1.DataSource= list;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ToTaskViewWindow_Click(object sender, EventArgs e)
        {
            ViewCurrentTaskWindow window = new ViewCurrentTaskWindow();
            window.Show(); 
            this.Hide();
            window.FormClosed += new FormClosedEventHandler(RestoreWindow);
        }
        private void RestoreWindow(object sender, FormClosedEventArgs e)
        {
            Form closedForm = sender as Form;
            if (closedForm is AddProjectWindow)
            {
                this.Show();
            }
            else if (closedForm is ViewCurrentTaskWindow)
            {
                this.Show();
            }
        }
    }
}