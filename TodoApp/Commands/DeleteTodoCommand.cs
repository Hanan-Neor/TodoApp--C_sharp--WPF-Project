using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using TodoApp.Commands;
using TodoApp.Model;

namespace TodoApp.ViewModel
{
    internal class DeleteTodoCommand : CommandBase
    {
        TodoCollectionViewModel _todoCollectionViewModel;
        public DeleteTodoCommand(TodoCollectionViewModel todoCollectionViewModel)
        {
            _todoCollectionViewModel = todoCollectionViewModel;
            //_todoViewModel.PropertyChanged += OnViewModelProperyChanged;
        }
        public override void Execute(object? parameter)
        {
            DeleteTodo();
        }
        private void DeleteTodo()
        {
            foreach (var todoToRemove in _todoCollectionViewModel.Todos.Where(todo => todo.Selected).ToList())
            {
                _todoCollectionViewModel.Todos.Remove(todoToRemove);
            }
            int i = 0;
            foreach (var todo in _todoCollectionViewModel.Todos)
            {
                todo.Id = i+1;
                i++;
            }
        }
    }
}