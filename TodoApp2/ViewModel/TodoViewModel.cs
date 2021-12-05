using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TodoApp2.Commands;
using TodoApp2.Model;

namespace TodoApp2.ViewModel
{
    internal class TodoViewModel : ViewModelBase
    {
        private List<Todo> _todos;
        public List<Todo> Todos
        {
            get { return _todos; }
            set
            {
                _todos = value;
                OnPropertyChanged(nameof(Todos));
            }
        } 
        
        private Todo? _currTodo;
        public Todo CurrTodo
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

        private bool _selected;
        public bool Selected
        {
            get => _selected;
            set
            {
                _selected = value;
                OnPropertyChanged(nameof(Selected));
            }
        }

        private ICommand command;
        public ICommand ActionCommand
        {
            get { return command ?? new RelayCommand(this); }
        }
        public ICommand DeleteCommand
        {
            get { return new DeleteTodoCommand(this); }
        }
        public ICommand SelectCommand
        {
            get { return new SelectTodoCommand(this); }
        }
        public ICommand EditCommand
        {
            get { return new EditTodoCommand(this); }
        }

        public ICommand CancelCommand
        {
            get { return new CancelAddTodoCommand(this); }
        }
        public ICommand CheckedCommand
        {
            get { return new CheckedTodoCommand(this); }
        }



        //public ICommand CancelCommand
        //{
        //    get { return new CancelViewModelCommand()}
        //}
        //public ICommand SubmitCommand
        //{
        //    get { return  new RelayCommand(this); }
        //}
    }
}
