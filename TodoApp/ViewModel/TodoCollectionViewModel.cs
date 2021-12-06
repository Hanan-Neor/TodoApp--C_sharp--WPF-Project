using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TodoApp.Commands;
using TodoApp.Model;

namespace TodoApp.ViewModel
{
    internal class TodoCollectionViewModel : ViewModelBase
    {
        private ObservableCollection<TodoViewModel> _todos = new ObservableCollection<TodoViewModel>();
        public ObservableCollection<TodoViewModel> Todos
        {
            get { return _todos; }
            set
            {
                _todos = value;
                OnPropertyChanged(nameof(Todos));
            }
        } 
        
        private TodoViewModel? _currTodo;
        public TodoViewModel CurrTodo
        {
            get { return _currTodo; }
            set
            {
                _currTodo = value;
                OnPropertyChanged(nameof(CurrTodo));
            }
        }

        private string? _title;
        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged(nameof(Title));
            }
        }

        private string? _description;
        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }

        public ICommand AddCommand
        {
            get { return new AddTodoCommand(this); }
        }
        public ICommand DeleteCommand
        {
            get { return new DeleteTodoCommand(this); }
        }
       
        public ICommand SetCurrTodoCommand
        {
            get { return new SetCurrTodoCommand(this); }
        }

        public ICommand CancelCommand
        {
            get { return new CancelAddTodoCommand(this); }
        }
       
    }
}
