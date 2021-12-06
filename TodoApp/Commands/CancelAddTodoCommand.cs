
using TodoApp.Commands;

namespace TodoApp.ViewModel
{
    internal class CancelAddTodoCommand : CommandBase
    {
        TodoCollectionViewModel _todoViewModel;

        public CancelAddTodoCommand(TodoCollectionViewModel todoViewModel)
        {
            _todoViewModel = todoViewModel;
        }

        public override void Execute(object? parameter)
        {
            _todoViewModel.CurrTodo = null;
            _todoViewModel.Title = "";
            _todoViewModel.Description = "";
        }
    }
}