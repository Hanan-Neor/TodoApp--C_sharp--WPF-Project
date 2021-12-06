
using System.Collections.ObjectModel;
using System.Linq;
using TodoApp.ViewModel;

namespace TodoApp.Commands
{
    internal class AddTodoCommand : CommandBase
    {
        TodoCollectionViewModel _todoCollectionViewModel;
        public AddTodoCommand(TodoCollectionViewModel todoCollectionViewModel)
        {
            _todoCollectionViewModel = todoCollectionViewModel;
        }
        public override void Execute(object? parameter)
        {
            if (_todoCollectionViewModel.Title == null || _todoCollectionViewModel.Title == "")
            {
                return;
            }
            if (_todoCollectionViewModel.CurrTodo != null)
            {
                EditTodo();
            }
            else
            {
                AddTodos();
            }
            _todoCollectionViewModel.Title = "";
            _todoCollectionViewModel.Description = "";
        }

        private void AddTodos()
        {
            if (_todoCollectionViewModel.Todos == null)
            {
                _todoCollectionViewModel.Todos = new ObservableCollection<TodoViewModel>();
            }
            _todoCollectionViewModel.Todos.Insert(0, (new TodoViewModel {  Title = _todoCollectionViewModel.Title, Description = _todoCollectionViewModel.Description, IsChecked = false, Selected = false }));
            int i = 0;
            foreach (var todo in _todoCollectionViewModel.Todos)
            {
                todo.Id = i + 1;
                i++;
            }
        }

        private void EditTodo()
        {
            TodoViewModel currTodo = _todoCollectionViewModel.Todos.Where(todo => todo.Id == _todoCollectionViewModel.CurrTodo.Id).FirstOrDefault();
            currTodo.Title = _todoCollectionViewModel.Title;
            currTodo.Description = _todoCollectionViewModel.Description; ;
            _todoCollectionViewModel.CurrTodo = null;
        }
    }
}
