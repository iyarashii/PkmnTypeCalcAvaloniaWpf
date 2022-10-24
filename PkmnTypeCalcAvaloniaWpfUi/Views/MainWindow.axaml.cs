using Avalonia;
using Avalonia.Controls;

namespace PkmnTypeCalcAvaloniaWpfUi.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
#if DEBUG
                this.AttachDevTools();
#endif
            InitializeComponent();
        }
    }
}