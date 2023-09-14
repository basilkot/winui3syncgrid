using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace PerformanceExample
{
    public sealed partial class ReportPage : Page
    {
        public ReportPage()
        {
            InitializeComponent();
            Loader.Visibility = Visibility.Collapsed;
        }

        public Item[] Items =
        {
            new() { Name = "Item 1", Count = 10, Percent = "10%", Avg = 10, Min = 10 },
            new() { Name = "Item 2", Count = 20, Percent = "20%", Avg = 20, Min = 20 },
            new() { Name = "Item 3", Count = 30, Percent = "30%", Avg = 30, Min = 30 },
            new() { Name = "Item 4", Count = 40, Percent = "40%", Avg = 40, Min = 40 },
        };

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            App.Window.ContentFrame.GoBack();
        }
    }
}
