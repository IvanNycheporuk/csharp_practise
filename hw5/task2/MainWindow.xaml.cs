using System.Linq;
using System.Windows;

namespace task2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnShowData_Click(object sender, RoutedEventArgs e)
        {
            var dbContext = new Model1Container();

            CustomGrid.ItemsSource = dbContext.task2Model.ToList();
        }
    }
}
