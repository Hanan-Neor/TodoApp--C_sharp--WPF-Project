using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using TodoApp2.Commands;
using TodoApp2.Model;

namespace TodoApp2.ViewModel
{
    internal class CancelAddTodoCommand : CommandBase
    {
        TodoViewModel _todoViewModel;

        public CancelAddTodoCommand(TodoViewModel todoViewModel)
        {
            _todoViewModel = todoViewModel;
            //_todoViewModel.PropertyChanged += OnViewModelProperyChanged;
        }

        public override void Execute(object? parameter)
        {
            //MessageBox.Show("hi");
            _todoViewModel.CurrTodo = null;
            _todoViewModel.Title = "";
            _todoViewModel.Description = "";
            //throw new System.NotImplementedException();
           
        }
     
     
    }
}