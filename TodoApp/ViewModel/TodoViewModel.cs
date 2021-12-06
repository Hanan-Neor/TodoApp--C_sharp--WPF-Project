using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TodoApp.Model;

namespace TodoApp.ViewModel
{
    public class TodoViewModel : ViewModelBase
    {
        private Todo _todo = new Todo();
        public Todo Todo { get => _todo; set { _todo = value; OnPropertyChanged(nameof(Todo)); } }

        public int Id
        {
            get => this.Todo.Id;
            set
            {
               Todo.Id = value;
                OnPropertyChanged(nameof(Id));
            }
        }
        public string Title
        {
            get => Todo.Title;
            set
            {
                Todo.Title = value;
                OnPropertyChanged(nameof(Title));
            }
        }
        public string Description
        {
            get => Todo.Description;
            set
            {
                Todo.Description = value;
                OnPropertyChanged(nameof(Description));
            }
        }
        public bool Selected
        {
            get => Todo.Selected;
            set
            {
                Todo.Selected = value;
                OnPropertyChanged(nameof(Todo.Selected));
            }
        }
        public bool IsChecked
        {
            get => Todo.IsChecked;
            set
            {
                Todo.IsChecked = value;
                OnPropertyChanged(nameof(Todo.IsChecked));
            }
        }
        public ICommand CheckedCommand
        {
            get { return new CheckedTodoCommand(this); }
        }
    }
}
