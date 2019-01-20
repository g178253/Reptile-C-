using System.Windows;
using Reptile.Core;
using Reptile.Douban;

namespace Reptile.UI
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly UserInterface userInterface;
        public MainWindow()
        {
            InitializeComponent();
            var ds = new DoubanDataSource(new Http());
            userInterface = new DoubanUI(ds, new DoubanDataProcessor());
        }

        private async void Start_Click(object sender, RoutedEventArgs e)
        {
            Message.Text = await userInterface.GetAsync();
        }
    }
}
