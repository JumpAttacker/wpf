using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace DocGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public string TextInfo { get; set; } = "WTF";
        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
        }

        private async void ToggleSwitch_OnClick(object sender, RoutedEventArgs e)
        {
            var controller = await this.ShowProgressAsync("Please wait...", "Progress message");
            controller.SetProgress(0.50);
            controller.SetIndeterminate();
            await Task.Delay(5000);
            await controller.CloseAsync();
        }
    }
}
