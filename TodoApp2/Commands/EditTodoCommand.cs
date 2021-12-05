using System.Collections.Generic;
using System.Windows.Input;
using TodoApp2.Commands;
using TodoApp2.Model;

namespace TodoApp2.ViewModel
{
    internal class EditTodoCommand : CommandBase
    {
        TodoViewModel _todoViewModel;

        public EditTodoCommand(TodoViewModel todoViewModel)
        {
            _todoViewModel = todoViewModel;
            //_todoViewModel.PropertyChanged += OnViewModelProperyChanged;
        }

        public override void Execute(object? parameter)
        {
            //throw new System.NotImplementedException();
            int CurrTodoId = (int)parameter;
            EditTodo(CurrTodoId);
        }

        private void EditTodo(int CurrTodoId)
        {
            
            Todo todo = _todoViewModel.Todos.Find(Todo => Todo.Id == CurrTodoId);
            _todoViewModel.CurrTodo = todo;
            _todoViewModel.Title = todo.Title;
            _todoViewModel.Description = todo.Description;
            
          
        }
    }
}