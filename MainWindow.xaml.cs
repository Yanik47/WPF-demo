using System.Windows;

namespace GraficInterfacePresentation
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

        private void ToggleFlowDirection_Click(object sender, RoutedEventArgs e)
        {
            // Переключение FlowDirection между RightToLeft и LeftToRight
            this.FlowDirection = this.FlowDirection == FlowDirection.LeftToRight
                ? FlowDirection.RightToLeft
                : FlowDirection.LeftToRight;
        }
    }
}
