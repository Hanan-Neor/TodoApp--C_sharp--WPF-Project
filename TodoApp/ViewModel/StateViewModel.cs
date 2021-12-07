//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Input;
//using TodoApp.Commands;

//namespace TodoApp.ViewModel
//{
//    internal class StateViewModel : ViewModelBase
//    {
//        private bool _showComposer = false;
//        public bool ShowComposer
//        {
//            get { return _showComposer; }
//            set
//            {
//                _showComposer = value;
//                OnPropertyChanged(nameof(ShowComposer));
//            }
//        }

//        public ICommand ToggleTodoComposerCommand
//        {
//            get { return new ToggleTodoComposerCommand(this); }
//        }
//    }
//}
