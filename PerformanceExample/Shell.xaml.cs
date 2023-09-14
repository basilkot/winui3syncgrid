using Microsoft.UI.Xaml;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace PerformanceExample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Shell : Window
    {
        public Shell()
        {
            this.InitializeComponent();
            ContentFrame.Navigate(typeof(MainPage));
        }
    }
}
