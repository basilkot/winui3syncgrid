using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace PerformanceExample
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            App.Window.ContentFrame.Navigate(typeof(ReportPage));
        }
    }
}
