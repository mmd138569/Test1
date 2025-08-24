using System.Windows;
using Telerik.Windows.Controls;

namespace Test1.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            StyleManager.ApplicationTheme = new Windows11Theme();
            InitializeComponent();
        }
    }
}
