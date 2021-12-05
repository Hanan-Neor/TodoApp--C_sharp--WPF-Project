
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TodoApp2.Model;
using TodoApp2.ViewModel;

namespace TodoApp2.Commands
{
    internal class RelayCommand : CommandBase
    {
        TodoViewModel _todoViewModel;



        public RelayCommand(TodoViewModel todoViewModel)
        {
            _todoViewModel = todoViewModel;
            //_todoViewModel.PropertyChanged += OnViewModelProperyChanged;
        }

        //public override bool CanExecute(object? parameter)
        //{
        //    return !string.IsNullOrEmpty(_todoViewModel.Title) && base.CanExecute(parameter);
        //}


        public override void Execute(object? parameter)
        {
            //MessageBox.Show("hi");
            //throw new NotImplementedException();
            if (parameter == null) return;


            if(_todoViewModel.CurrTodo!= null)
            {
                //MessageBox.Show("editing todo");
                EditTodo();
            }
            else
            {
                //MessageBox.Show("adding new todo");
                AddTodos();

            }

            //string action = parameter.ToString();
            //switch (action)
            //{
            //    case "AddTodo":
            //        AddTodos();
            //        break;
            //  
            //}

           
        }

        private void AddTodos()
        {
            if (_todoViewModel.Title == null || _todoViewModel.Title == "")
            {
                _todoViewModel.Title = "";
                _todoViewModel.Description = "";
                return;
            }
            //MessageBox.Show("hi");
            if (_todoViewModel.Todos == null)
            {
                _todoViewModel.Todos = new List<Todo>();
            }
            var temp = _todoViewModel.Todos;
            _todoViewModel.Todos = new List<Todo>();


            //temp.Add(new Todo { Id = temp.Count() + 1, Title = _todoViewModel.Title, Description = _todoViewModel.Description, IsChecked = false, Selected = false });
            temp.Insert(0, (new Todo {  Title = _todoViewModel.Title, Description = _todoViewModel.Description, IsChecked = false, Selected = false }));

            //temp.ForEach(todo => todo.Id = temp.FindIndex(todo2 => todo2.Id == todo.Id) + 1);
            
            for (int i = 0 ; i < temp.Count(); ++i)
            {
                temp.ElementAt(i).Id = i + 1;
            }
            _todoViewModel.Title = "";
            _todoViewModel.Description = "";
            _todoViewModel.Todos = temp;
        }

        private void EditTodo()
        {
            if (_todoViewModel.Title == null || _todoViewModel.Title == "")
            {
                _todoViewModel.Title = "";
                _todoViewModel.Description = "";
                return;
            }
            var temp = _todoViewModel.Todos;
            _todoViewModel.Todos = new List<Todo>();

            Todo todo = temp.Find(todo2 =>todo2.Id ==_todoViewModel.CurrTodo.Id);
            int idx = temp.FindIndex(todo3 => todo3.Id == _todoViewModel.CurrTodo.Id);
            temp.Remove(todo);
            temp.Insert(idx, (new Todo {Id= _todoViewModel.CurrTodo.Id,
                Title = _todoViewModel.Title, Description = _todoViewModel.Description,
                IsChecked = _todoViewModel.CurrTodo.IsChecked, Selected = _todoViewModel.CurrTodo.Selected
            }));


            _todoViewModel.Title = "";
            _todoViewModel.Description = "";
            _todoViewModel.Todos = temp;
            _todoViewModel.CurrTodo = null;

        }
    }
}
