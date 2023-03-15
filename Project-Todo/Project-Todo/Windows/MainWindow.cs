using Project_Todo.Windows;

namespace Project_Todo
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddProj_Click(object sender, EventArgs e)
        {
            AddProjectWindow window = new AddProjectWindow();
            window.Show();
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
            window.Show();
        }
    }
}