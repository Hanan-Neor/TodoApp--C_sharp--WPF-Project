
using TodoApp.Commands;

namespace TodoApp.ViewModel
{
    internal class CheckedTodoCommand : CommandBase
    {
        TodoViewModel _todoViewModel;
        public CheckedTodoCommand(TodoViewModel todoViewModel)
        {
            _todoViewModel = todoViewModel;
            //_todoViewModel.PropertyChanged += OnViewModelProperyChanged;
        }
        public override void Execute(object? parameter)
        {
            CheckedTodo();
        }

        private void CheckedTodo()
        {
            _todoViewModel.IsChecked = !_todoViewModel.IsChecked;
        }
    }
}