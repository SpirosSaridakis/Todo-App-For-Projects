using Project_Todo.Data;
using Project_Todo.Models;
using Project_Todo.Windows;

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
            window.FormClosed += new FormClosedEventHandler(RestoreButton);
            window.Show();
            AddProj.Enabled = false;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ToTaskViewWindow_Click(object sender, EventArgs e)
        {
            ViewCurrentTaskWindow window = new ViewCurrentTaskWindow();
            window.FormClosed += new FormClosedEventHandler(RestoreButton);
            window.Show();
            ToTaskViewWindow.Enabled = false;
            
        }
        private void RestoreButton(object sender, FormClosedEventArgs e)
        {
            Form closedForm = sender as Form;
            if (closedForm is AddProjectWindow) 
            {
                AddProj.Enabled = true;
            }else if (closedForm is ViewCurrentTaskWindow)
            {
                ToTaskViewWindow.Enabled = true;
            }
        }
    }
}