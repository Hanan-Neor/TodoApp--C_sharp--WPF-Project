using System.Windows;

namespace TodoApp.View
{
    public partial class TodoAppView : Window
    {
        public TodoAppView()
        {
            InitializeComponent();
        }
        public void OnShowModalClick(object sender, RoutedEventArgs e)
        {
            TodoComposeView.Visibility = Visibility.Visible;
        }
    }
}
