using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TodoApp2.ViewModel;

namespace TodoApp2.View
{
    /// <summary>
    /// Interaction logic for TodoComposeView.xaml
    /// </summary>
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


        private void OnCloseModalClick(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
        }

        //public void OnShowModalClick(object sender, RoutedEventArgs e)
        //{
        //    TodoComposeView.Visibility = Visibility.Visible;
        //    //TodoComposeView.Box.Focusable = true;
        //    //Keyboard.Focus(Box);




        //}
    }
}
