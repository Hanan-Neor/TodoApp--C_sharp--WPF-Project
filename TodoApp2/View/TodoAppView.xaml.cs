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
using System.Windows.Shapes;
using TodoApp2.ViewModel;

namespace TodoApp2.View
{
    /// <summary>
    /// Interaction logic for TodoAppView.xaml
    /// </summary>
    public partial class TodoAppView : Window
    {
       
        public TodoAppView()

        {
            InitializeComponent();
            //if (Todos.ElementAt(0) == null)
            //{
            //    init.Visibility = Visibility.Collapsed;
            //}
            
        }
        public void OnShowModalClick(object sender, RoutedEventArgs e)
        {
            TodoComposeView.Visibility = Visibility.Visible;
            //TodoComposeView.Box.Focusable = true;
            //Keyboard.Focus(Box);


           
         
        }

        internal static void OnShowModalClick()
        {
            throw new NotImplementedException();
        }

        void Find(object sender, RoutedEventArgs e)
        {
            object wantedNode = MainGrid.FindName("Box");
            if (wantedNode is TextBox)
            {
                // Following executed if Text element was found.
                TextBox wantedChild = wantedNode as TextBox;
            //wantedChild.Foreground = Brushes.Blue;
            wantedChild.Focusable = true;
            //Keyboard.Focus(wantedChild);
            wantedChild.Focus();

                //wantedChild.Focus(Box);
            }
        }

        private void TodoComposeView_Loaded(object sender, RoutedEventArgs e)
        {

        }

      
    }
}
