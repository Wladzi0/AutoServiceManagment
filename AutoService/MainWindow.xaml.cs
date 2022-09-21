using ApiLibrary;
using System.Threading.Tasks;
using System.Windows;

namespace AutoService
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ApiHelper.InitializeClient();
        }
        public void LoadVhicleApi_ClickAsync(object sender, RoutedEventArgs e)
        {
           ApiProcessor.LoadBasicCarContent();
        }
    }
}
