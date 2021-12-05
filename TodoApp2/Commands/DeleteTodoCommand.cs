using System.Collections.Generic;
using System.Windows.Input;
using TodoApp2.Commands;
using TodoApp2.Model;

namespace TodoApp2.ViewModel
{
    internal class DeleteTodoCommand : CommandBase
    {
        TodoViewModel _todoViewModel;

        public DeleteTodoCommand(TodoViewModel todoViewModel)
        {
            _todoViewModel = todoViewModel;
            //_todoViewModel.PropertyChanged += OnViewModelProperyChanged;
        }

        public override void Execute(object? parameter)
        {
            //throw new System.NotImplementedException();
            DeleteTodo();
        }

        private void DeleteTodo()
        {
            var temp = _todoViewModel.Todos;
            _todoViewModel.Todos = new List<Todo>();

            _todoViewModel.Todos = temp.FindAll(Todo => Todo.Selected == false);
            _todoViewModel.Todos.ForEach(todo => todo.Id = _todoViewModel.Todos.FindIndex(todo2=>todo2.Id == todo.Id)+1);

            //Todo todo = temp.Find(Todo => Todo.Id == CurrTodoId);
            //todo.Selected = !todo.Selected;
            //temp.Remove(todo);
            //MessageBox.Show(todo.Title);

            //_todoViewModel.Todos = temp;
        }
    }
}