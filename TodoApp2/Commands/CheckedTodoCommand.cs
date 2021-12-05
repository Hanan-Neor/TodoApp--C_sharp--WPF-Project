using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using TodoApp2.Commands;
using TodoApp2.Model;

namespace TodoApp2.ViewModel
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

            //    private Todo _todo;
            //public Todo Todo
            //{
            //    get
            //    {
            //        return _todo;
            //    }
            //    set
            //    {
            //        _todo = parameter;
            //    }
            //}

            int CurrTodoId = (int)parameter;

            //MessageBox.Show(CurrTodoId);
            CheckedTodo(CurrTodoId);

        }

        private void CheckedTodo(int CurrTodoId)
        {
            //MessageBox.Show(CurrTodoId.ToString());

            var temp = _todoViewModel.Todos;
            _todoViewModel.Todos = new List<Todo>();

            Todo todo = temp.Find(Todo => Todo.Id == CurrTodoId);
            todo.IsChecked = !todo.IsChecked;
            //temp.Remove(todo);
            //MessageBox.Show(todo.Title);

            _todoViewModel.Todos = temp;

            //_todoViewModel.Selected = !_todoViewModel.Selected;


        }
    }
}