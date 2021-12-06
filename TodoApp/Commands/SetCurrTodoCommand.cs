using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using TodoApp.Commands;
using TodoApp.Model;

namespace TodoApp.ViewModel
{
    //internal class EditTodoCommand : CommandBase
    internal class SetCurrTodoCommand : CommandBase
    {
        TodoCollectionViewModel _todoCollectionViewModel;
        public SetCurrTodoCommand(TodoCollectionViewModel todoCollectionViewModel)
        {
            _todoCollectionViewModel = todoCollectionViewModel;
            //_todoViewModel.PropertyChanged += OnViewModelProperyChanged;
        }

        public override void Execute(object? parameter)
        {
            int CurrTodoId = (int)parameter;
            EditTodo(CurrTodoId);
        }

        private void EditTodo(int CurrTodoId)
        {
            TodoViewModel x = _todoCollectionViewModel.Todos.Where(todo => todo.Id == CurrTodoId).FirstOrDefault();
            _todoCollectionViewModel.CurrTodo = x;
            _todoCollectionViewModel.Title = x.Title;
            _todoCollectionViewModel.Description = x.Description;
        }
    }
}