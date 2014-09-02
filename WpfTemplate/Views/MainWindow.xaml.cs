using System.Windows;
using WpfTemplate.Models;
using WpfTemplate.ModelViews;

namespace WpfTemplate.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainViewModel(new Person());
        }
    }
}
