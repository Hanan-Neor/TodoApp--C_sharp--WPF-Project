
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace TodoApp.View
{
    public partial class TodoComposeView : UserControl
    {
        public TodoComposeView()
        {
            InitializeComponent();
        }
        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                AddTodo.Command.Execute(AddTodo.CommandParameter);
                AddTodo.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
            }
        }
        private void OnSaveTodoClick(object sender, RoutedEventArgs e)
        {
            if(TitleTextBox.Text == "")
            {
                return;
            }
            OnCloseModalClick(sender,e);
        }
        private void OnCloseModalClick(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
        }
    }
}
