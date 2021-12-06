using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.ViewModel;

namespace TodoApp.Commands
{
    internal class ToggleTodoComposerCommand : CommandBase
    {
        StateViewModel _stateViewModel;
        public ToggleTodoComposerCommand(StateViewModel stateViewModel)
        {
            _stateViewModel = stateViewModel;
            //_todoViewModel.PropertyChanged += OnViewModelProperyChanged;
        }
        public override void Execute(object? parameter)
        {
                ToggleComposer();
        }
        private void ToggleComposer()
        {
            _stateViewModel.ShowComposer = !_stateViewModel.ShowComposer;
        }
    }
}
